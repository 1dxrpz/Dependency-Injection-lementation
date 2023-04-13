using DITest.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DITest.Services
{
	public class TestService : ITestService
	{
		public string Test(string message)
		{
			return "Hello, " + message + "!";
		}
	}
}
