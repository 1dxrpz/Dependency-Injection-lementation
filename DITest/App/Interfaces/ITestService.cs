using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DITest.Interfaces
{
	public interface ITestService : IServiceContainer
	{
		public string Test(string message);
	}
}
