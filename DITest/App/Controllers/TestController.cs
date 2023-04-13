using DITest.App.Interfaces;
using DITest.Core;
using DITest.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DITest.App.Controllers
{
	public class TestController : Controller
	{
		public TestController(ITestService test, IWorkService workService)
		{
			Console.WriteLine(test.Test("world"));
			workService.Work();
		}
	}
}
