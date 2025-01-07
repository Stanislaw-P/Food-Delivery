using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Food_Delivery
{
	[Serializable]
	public class Cart
	{
		public Cart(string userPhoneNumber)
		{
			UserPhoneNumber = userPhoneNumber;
			ID = Guid.NewGuid();
		}

		public Guid ID { get; }
		public string UserPhoneNumber { get; }
		private List<Product> items = new List<Product>();

		public void Add(Product product) 
		{
			product.Amount++;
			items.Add(product);
		}

		//public static void LoadFromFile(string fileName = "data/catalog.txt")
		//{
		//	using (StreamReader reader = new StreamReader(fileName))
		//	{
		//		string typeProduct = null;
		//		while (!reader.EndOfStream)
		//		{
		//			string line = reader.ReadLine();
		//			if (line.Contains('$'))
		//			{
		//				string[] temp = line.Split('$');
		//				Product product = new Product(temp[0], typeProduct, Convert.ToDecimal(temp[1]));
		//				items.Add(product);
		//			}
		//			else
		//				typeProduct = line;
		//		}
		//	}
		//}

		public void ShowCart(DataGridView dataGrid)
		{
			dataGrid.Rows.Clear();
			foreach (var item in items)
			{
				dataGrid.Rows.Add(new object[] { item.ID, item.Name, item.Cost, "+", item.Amount, "-" });
			}
		}

		public void Increase(int idCartItem)
		{
			foreach (var item in items.Where(it => it.ID == idCartItem))
			{
				item.Amount++;
			}
		}
	}
}
