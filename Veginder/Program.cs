using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace Veginder
{
	//Делегат №1 без параметрів та повертаємого значення
	public delegate void FirstDelegate();

	//Делегат №2 з повертаємим значенням
	public delegate string SecondDelegate();

	//Делегат №3 з параметром
	public delegate void ThirdDelegate(string msg);

	//Делегат, що представляє подію
	public delegate void EventDelegate(string msg);

	public class Test
	{
		//Об'являємо подію
		public event EventDelegate Notify;
		
		public void TestMethod()
		{
			//Викликаємо подію
			Notify?.Invoke("This is message for the event from test method");
		}
	}

	public class Program
	{
		public static void Main(string[] args)
		{
			//Створюємо екземпляри делегатів та сповіщуємо їх з методами
			FirstDelegate firstDelegate = Msg1;
			SecondDelegate secondDelegate = Msg2;
			ThirdDelegate thirdDelegate = Msg3;
			//Анонімний метод
			FirstDelegate firstDelegateWithAnonymousMethod = delegate () {
				System.Diagnostics.Debug.WriteLine("This is message for delegate 1 with anonymous method");
			};
			//Лямбда-оператор та лямбда-вираз
			ThirdDelegate thirdDelegateWithLambdaOperatorAndExpression = (x) => 
				System.Diagnostics.Debug.WriteLine("This is message for delegate 3 with parameter: " + x);


			//Викликаємо методи, сповіщені з делегатами
			firstDelegate();
			System.Diagnostics.Debug.WriteLine("This is message for delegate 2 with return value: " + secondDelegate());
			thirdDelegate("Test parameter");
			firstDelegateWithAnonymousMethod();

			string msg = "Parameter for Lambda expression";
			thirdDelegateWithLambdaOperatorAndExpression(msg);

			//Створюємо екземпляр класу, що викликає подію
			Test test = new Test();
			//Додаємо обробник подій EventMsg
			test.Notify += EventMsg;
			//Викликаємо метод, що викликає подію
			test.TestMethod();

			CreateHostBuilder(args).Build().Run();
		}
		private static void EventMsg(string msg)
		{
			System.Diagnostics.Debug.WriteLine(msg);
		}

		private static void Msg1()
		{
			System.Diagnostics.Debug.WriteLine("This is message for delegate 1");
		}

		private static string Msg2()
		{
			return "Return value for delegate 2";
		}

		private static void Msg3(string msg)
		{
			System.Diagnostics.Debug.WriteLine("This is message for delegate 3 with parameter: " + msg);
		}



		public static IHostBuilder CreateHostBuilder(string[] args) =>
			Host.CreateDefaultBuilder(args)
				.ConfigureWebHostDefaults(webBuilder =>
				{
					webBuilder.UseStartup<Startup>();
				});
	}
}
