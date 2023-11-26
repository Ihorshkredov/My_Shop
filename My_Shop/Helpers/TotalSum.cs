using My_Shop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Shop.Helpers
{
	public static class TotalSum
	{
		public static double GetSum( List<ProductModel> buyPacage)
		{
			double sum = 0;
			if (buyPacage.Any())
			{
				foreach (var item in buyPacage)
				{
					sum += (int)item.Quantity * (double)item.Price;
				}
			}
			return sum;
		}
	}
}
