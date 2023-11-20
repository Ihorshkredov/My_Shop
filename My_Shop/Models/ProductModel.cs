using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Shop.Models
{
	public class ProductModel
	{
		public string Code { get; set; } = null!;

		public string Name { get; set; } = null!;

		public decimal Price { get; set; }

		public int? Quantity { get; set; }
	}
}
