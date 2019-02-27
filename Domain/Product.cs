using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Product
    {
		public int ProductID { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public int Price { get; set; }
		public int MinInStock { get; set; }

		public Product (int productID, string name, string description, int price, int minInStock)
		{
			ProductID = productID;
			Name = name;
			Description = description;
			Price = price;
			MinInStock = minInStock; 
		}
	}

}
