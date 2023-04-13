using DITest.App.Interfaces;
using DITest.App.Services;
using DITest.Core;
using DITest.Interfaces;
using DITest.Services;

AppProvider app = new AppProvider();

app.Services
	.AddService<ITestService, TestService>()
	.AddService<IWorkService, WorkService>();

app.Run();