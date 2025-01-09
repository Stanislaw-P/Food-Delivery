using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Food_Delivery
{
	[Serializable]
	public class Order
	{
		public User UserOwner { get; }
		public decimal Cost { get; set; }
		public string Address { get; }
		public int ID { get; }

		public Order(User userOwner, decimal cost, string address)
		{
			UserOwner = userOwner;
			Cost = cost;
			Address = address;
			ID = idCounter;
			idCounter++;
		}

		private static int idCounter = 0;
	}
}
