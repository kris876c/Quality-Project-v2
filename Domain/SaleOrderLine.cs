using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class SaleOrderLine
    {
		public Product Product { get; set; }
		public int Quantity { get; set; }
		public int Price { get; set; }

		public SaleOrderLine(Product product, int quantity, int price)
		{
			Product = product;
			Quantity = quantity;
			Price = price; 
		}
	}
}
