using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Food_Delivery
{
	public class Order
	{
		public delegate void OrderHandler(User user, OrderEventArgs e);
		public event OrderHandler OrderHasOccurred;
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
		public void PlaceOrder()
		{
			OrderHasOccurred?.Invoke(UserOwner, new OrderEventArgs($"Заказ №{ID} оформлен.", Cost + 150, DateTime.Now.AddHours(1), Address));
		}
	}
}
