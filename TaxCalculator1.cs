using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TaxCalc
{
	public class TaxCalculator1
	{
		public TaxCalculator1()
		{
			//Tax Amount Level
			Tal = new decimal[] { 5070.0m, 8660.0m, 14070.0m, 21240.0m, 40230.0m };
			//Tax Percentage Level
			Tpl = new decimal[] { 0.10m, 0.14m, 0.23m, 0.30m, 0.33m, 0.45m };
		}

		public decimal CalulateTax(decimal income)
		{
			decimal result = 0.0m;
			//0-5070
			if (income <= Tal[0])
				result = income * Tpl[0];
			//5071 - 8660
			else if (income > Tal[0] && income <= Tal[1])
				result = GetTaxPrLevel(1) + ((income - Tal[0]) * Tpl[1]);
			//8660 - 14070
			else if (income > Tal[1] && income <= Tal[2])
				result = GetTaxPrLevel(2) + ((income - Tal[1]) * Tpl[2]);
			//14070 - 21240
			else if (income > Tal[2] && income <= Tal[3])
				result = GetTaxPrLevel(3) + ((income - Tal[2]) * Tpl[3]);
			//21240 - 40230
			else if (income > Tal[3] && income <= Tal[4])
				result = GetTaxPrLevel(4) + ((income - Tal[3]) * Tpl[4]);
			//40230 - 
			else if (income > Tal[4])
				result = GetTaxPrLevel(5) + ((income - Tal[4]) * Tpl[5]);

			return result;
		}

		//Tax amount levels
		private decimal[] Tal
		{
			get;
			set;
		}
		//Tax percentage levels
		private decimal[] Tpl
		{
			get;
			set;
		}

		private decimal GetTaxPrLevel(int level)
		{
			switch (level)
			{
				case 1:
					return TTL1();
				case 2:
					return TTL1() + TTL2();
				case 3:
					return TTL1() + TTL2() + TTL3();
				case 4:
					return TTL1() + TTL2() + TTL3() + TTL4();
				case 5:
					return TTL1() + TTL2() + TTL3() + TTL4() + TTL5();
			}
			throw new Exception("invalid tax level");
		}

		//TotalTaxLevel1
		private decimal TTL1()
		{
			return Tal[0] * Tpl[0];
		}

		private decimal TTL2()
		{
			return ((Tal[1] - Tal[0]) * Tpl[1]);
		}

		private decimal TTL3()
		{
			return ((Tal[2] - Tal[1]) * Tpl[2]);
		}

		private decimal TTL4()
		{
			return ((Tal[3] - Tal[2]) * Tpl[3]);
		}

		private decimal TTL5()
		{
			return ((Tal[4] - Tal[3]) * Tpl[4]);
		}
	}
}
