using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TaxCalc
{
	class Program
	{
		static void Main(string[] args)
		{
			TaxCalculator1 tc1 = new TaxCalculator1();
			TaxCalculator2 tc2 = new TaxCalculator2()
			{
				TaxLevels = new List<TaxLevel>() 
				{	new TaxLevel() { Amount = 5070.0m, Percentage = 0.10m },
					new TaxLevel() { Amount = 8660.0m, Percentage = 0.14m },
					new TaxLevel() { Amount = 14070.0m, Percentage = 0.23m },
					new TaxLevel() { Amount = 21240.0m, Percentage = 0.30m },
					new TaxLevel() { Amount = 40230.0m, Percentage = 0.33m },
					new TaxLevel() { Amount = -1, Percentage = 0.45m }
				}
			};

			Console.WriteLine(String.Format("Income: {0} Tax to pay {1} Expected {2}", "5000", tc1.CalulateTax(5000).ToString(), "500"));
			Console.WriteLine(String.Format("Income: {0} Tax to pay {1} Expected {2}", "5800", tc1.CalulateTax(5800).ToString(), "609,2"));
			Console.WriteLine(String.Format("Income: {0} Tax to pay {1} Expected {2}", "9000", tc1.CalulateTax(9000).ToString(), "1087,8"));
			Console.WriteLine(String.Format("Income: {0} Tax to pay {1} Expected {2}", "15000", tc1.CalulateTax(15000).ToString(), "2532,9"));
			Console.WriteLine(String.Format("Income: {0} Tax to pay {1} Expected {2}", "50000", tc1.CalulateTax(50000).ToString(), "15068,1"));
			Console.WriteLine("--------------------------------------------------------------------------------------------------------------");
			Console.WriteLine(String.Format("Income: {0} Tax to pay {1} Expected {2}", "5000", tc2.CalulateTax(5000).ToString(), "500"));
			Console.WriteLine(String.Format("Income: {0} Tax to pay {1} Expected {2}", "5800", tc2.CalulateTax(5800).ToString(), "609,2"));
			Console.WriteLine(String.Format("Income: {0} Tax to pay {1} Expected {2}", "9000", tc2.CalulateTax(9000).ToString(), "1087,8"));
			Console.WriteLine(String.Format("Income: {0} Tax to pay {1} Expected {2}", "15000", tc2.CalulateTax(15000).ToString(), "2532,9"));
			Console.WriteLine(String.Format("Income: {0} Tax to pay {1} Expected {2}", "50000", tc2.CalulateTax(50000).ToString(), "15068,1"));	
		}
	}
}
