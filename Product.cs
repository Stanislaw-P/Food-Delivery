using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Food_Delivery
{
	[Serializable]
	public class Product
	{
		public Product(string name, string typeOfProduct, decimal cost)
		{
			ID = idCounter;
			idCounter++;
			Name = name;
			TypeOfProduct = typeOfProduct;
			Cost = cost;
		}

		public int ID { get;}
		private static int idCounter = 0;
        public string Name { get; set; }
        public string TypeOfProduct { get; set; }
        public decimal Cost { get; set; }
		public int Amount { get; set; } = 0;

        public string[] ConvertToArrayForListViewItem()
		{
			return new string[] { Name, Cost.ToString(), TypeOfProduct, ID.ToString() };
		}
    }
}
