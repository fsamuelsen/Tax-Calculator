using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TaxCalc
{
	public class TaxCalculator2
	{
		public TaxCalculator2()
		{
		}

		public List<TaxLevel> TaxLevels
		{
			get;
			set;
		}

		public decimal CalulateTax(decimal income)
		{
			decimal taxToPay = 0.0m;
			decimal amountDeducded = 0.0m;
			decimal amountLeftToTaxate = income;

			foreach (TaxLevel tl in TaxLevels)
			{
				// -1 means no limit is set for this percentage. Just go to the else and calc what is remaining with the highest Percentage.
				if (income >= tl.Amount && tl.Amount != -1) 
				{
					taxToPay += tl.GetTaxPerLevel(amountDeducded);
					amountDeducded = tl.Amount;
					amountLeftToTaxate = income - amountDeducded;
				}
				else
				{
					taxToPay += amountLeftToTaxate * tl.Percentage;
					break;
				}
			}
			return taxToPay;
		}
	}
}
