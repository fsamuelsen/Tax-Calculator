using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit;
using NUnit.Framework;

namespace TaxCalc
{
	[TestFixture]
	class TaxCalculator1Tests
	{
		TaxCalculator1 tc1 = null;

		[SetUp]
		public void Setup()
		{
			tc1 = new TaxCalculator1();
		}

		[TearDown]
		public void TearDown()
		{ 
			tc1 = null;
		}

		[Test]
		public void CalcTax1()
		{
			Assert.AreEqual(500.000m, tc1.CalulateTax(5000), "blah..");
		}

		[Test]
		public void CalcTax2()
		{
			Assert.AreEqual(609.200m, tc1.CalulateTax(5800), "blah..");
		}

		[Test]
		public void CalcTax3()
		{
			Assert.AreEqual(1087.800m, tc1.CalulateTax(9000), "blah..");
		}

		[Test]
		public void CalcTax4()
		{
			Assert.AreEqual(2532.900m, tc1.CalulateTax(15000), "blah..");
		}

		[Test]
		public void CalcTax5()
		{
			Assert.AreEqual(15068.100m, tc1.CalulateTax(50000), "blah..");
		}
	}
}
