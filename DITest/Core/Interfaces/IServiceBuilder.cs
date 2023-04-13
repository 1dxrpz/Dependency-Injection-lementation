using DITest.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DITest.Core.Interfaces
{
	public interface IServiceBuilder
	{
		public ServiceBuilder AddService<T, I>() where I : class, IServiceContainer, new();
		public IServiceContainer GetService<T>() where T : IServiceContainer;
		public IServiceContainer GetService(Type type);
		public List<Type> GetAllServices();
	}
}
