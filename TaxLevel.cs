using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TaxCalc
{
	public class TaxLevel
	{
		public TaxLevel()
		{
		}

		public decimal Amount
		{
			get;
			set;
		}

		public decimal Percentage
		{
			get;
			set;
		}

		public decimal GetTaxPerLevel(decimal fromAmount)
		{
			return (Amount - fromAmount) * Percentage;
		}
	}
}
