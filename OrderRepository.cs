using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Food_Delivery
{
	[Serializable]
	public class OrderRepository
	{
		public List<Order> orders = new List<Order>();

		public void Add(Order order)
		{
			orders.Add(order);
		}

		public void Serialize()
		{
			BinaryFormatter formatter = new BinaryFormatter();
			using (FileStream fs = new FileStream("data/orders.dat", FileMode.OpenOrCreate))
			{
				formatter.Serialize(fs, this);
			}
		}

		static public OrderRepository DeSerialize()
		{
			try
			{
				BinaryFormatter formatter = new BinaryFormatter();
				using (FileStream fs = new FileStream("data/orders.dat", FileMode.OpenOrCreate))
				{
					return (OrderRepository)formatter.Deserialize(fs);
				}
			}
			catch
			{
				return new OrderRepository();
			}
		}

		public void Show(DataGridView dataGrid)
		{
			dataGrid.Rows.Clear();
			foreach (var order in orders)
			{
				dataGrid.Rows.Add(new object[] { order.Address, order.Cost, order.ID });
			}
		}

		public void RemoveOrderById(int idOrder)
		{
			orders.RemoveAll(order => order.ID == idOrder);
		}
	}
}
