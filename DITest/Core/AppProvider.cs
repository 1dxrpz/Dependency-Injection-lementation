using DITest.Core.Interfaces;
using DITest.Interfaces;
using System.Reflection;

namespace DITest.Core
{

	public class AppProvider : IAppProvider
	{
		public IServiceBuilder Services { get; }
		List<Controller> _controllers;

		public AppProvider()
		{
			Services = new ServiceBuilder();
			_controllers = new List<Controller>();
		}
		public T CreateInstance<T>(params object[] paramArray)
		{
			return (T)Activator.CreateInstance(typeof(T), args: paramArray);
		}
		public void Run()
		{
			NamespaceHelper.FindTypesOfObject(new Controller()).ForEach(v =>
			{
				List<IServiceContainer> services = new List<IServiceContainer>();
				Type[] types = new Type[1];

				types = Services.GetAllServices().ToArray();
				ConstructorInfo[] cons = v.GetConstructors();
				List<Type> constructorTypes = new List<Type>();
				var param = cons[0].GetParameters();
				var servicesFound = true;

				param.ToList().ForEach(p =>
				{
					try
					{
						services.Add(Services.GetService(p.ParameterType));
					}
					catch (KeyNotFoundException)
					{
						Console.BackgroundColor = ConsoleColor.Red;
						Console.ForegroundColor = ConsoleColor.Black;
						Console.WriteLine($"Service not found: {p.ParameterType}");
						Console.ResetColor();
						servicesFound = false;
					}
				});

				if (servicesFound)
				{
					var _controller = CreateInstance<Controller>(services.ToArray());
					cons[0].Invoke(services.ToArray());
				}


				//_controllers.Add((Controller) _controller);
			});
		}
	}
}
