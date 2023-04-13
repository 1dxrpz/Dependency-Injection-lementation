using DITest.App.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DITest.App.Services
{
	public class WorkService : IWorkService
	{
		public void Work()
		{
			Console.WriteLine("Doing work");
		}
	}
}
