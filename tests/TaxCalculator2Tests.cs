using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit;
using NUnit.Framework;

namespace TaxCalc
{
	[TestFixture]
	class TaxCalculator2Tests
	{
		TaxCalculator2 tc2 = null;

		[SetUp]
		public void Setup()
		{
			tc2 = new TaxCalculator2() {
				TaxLevels = new List<TaxLevel>() 
				{	new TaxLevel() { Amount = 5070.0m, Percentage = 0.10m },
					new TaxLevel() { Amount = 8660.0m, Percentage = 0.14m },
					new TaxLevel() { Amount = 14070.0m, Percentage = 0.23m },
					new TaxLevel() { Amount = 21240.0m, Percentage = 0.30m },
					new TaxLevel() { Amount = 40230.0m, Percentage = 0.33m },
					new TaxLevel() { Amount = -1, Percentage = 0.45m }
				}
			};
		}

		[TearDown]
		public void TearDown()
		{ 
			tc2 = null;
		}
		//-----------------------------Calc Tax 2

		[Test]
		public void CalcTax21()
		{
			Assert.AreEqual(500.000m, tc2.CalulateTax(5000), "blah..");
		}

		[Test]
		public void CalcTax22()
		{
			Assert.AreEqual(609.200m, tc2.CalulateTax(5800), "blah..");
		}

		[Test]
		public void CalcTax23()
		{
			Assert.AreEqual(1087.800m, tc2.CalulateTax(9000), "blah..");
		}

		[Test]
		public void CalcTax24()
		{
			Assert.AreEqual(2532.900m, tc2.CalulateTax(15000), "blah..");
		}

		[Test]
		public void CalcTax25()
		{
			Assert.AreEqual(15068.100m, tc2.CalulateTax(50000), "blah..");
		}
	}
}
