using DITest.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DITest.App.Interfaces
{
	public interface IWorkService : IServiceContainer
	{
		public void Work();
	}
}
