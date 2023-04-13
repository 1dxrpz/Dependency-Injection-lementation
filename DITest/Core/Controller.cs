using DITest.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DITest.Core
{
	public class Controller
	{
		public Controller()
		{

		}
		public Controller(params IServiceContainer[] services)
		{
			//_app = app;
			//services.ToList().ForEach(service =>
			//{
				
			//});
		}
	}
}
