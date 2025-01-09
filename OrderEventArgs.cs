using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Food_Delivery
{
	public class OrderEventArgs
	{
		public OrderEventArgs(string message, decimal totalCostOrder, DateTime deliveryTime, string deliveryAddress)
		{
			Message = message;
			TotalCostOrder = totalCostOrder;
			DeliveryTime = deliveryTime;
			DeliveryAddress = deliveryAddress;
		}

		public string Message { get; }
		public decimal TotalCostOrder { get; }
		public DateTime DeliveryTime { get; private set; }
		public string DeliveryAddress { get; private set; }
	}
}
