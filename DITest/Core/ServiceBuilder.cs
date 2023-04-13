using DITest.Core.Interfaces;
using DITest.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DITest.Core
{
	public class ServiceBuilder : IServiceBuilder
	{
		Dictionary<Type, IServiceContainer> _services; 
		public ServiceBuilder()
		{
			_services = new Dictionary<Type, IServiceContainer>();
		}
		public ServiceBuilder AddService<T, I>()  where I : class, IServiceContainer, new()
		{
			I service = new();
			_services.Add(typeof(T), service);
			return this;
		}

		public List<Type> GetAllServices()
		{
			return _services.Keys.ToList();
		}

		public IServiceContainer GetService<T>() where T : IServiceContainer
		{
			return _services[typeof(T)];
		}

		public IServiceContainer GetService(Type type)
		{
			return _services[type];
		}
	}
}
