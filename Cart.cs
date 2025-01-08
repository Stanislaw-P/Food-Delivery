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

		public void Increase(Product product)
		{
			foreach (var item in items.Where(it => it.Equals(product)))
			{
				item.Amount++;
			}
		}

		public void Decrease(int idCartItem)
		{
			foreach (var item in items.Where(it => it.ID == idCartItem))
			{
				if(item.Amount > 0)
					item.Amount--;
			}
		}

		public bool Contains(Product product)
		{
			return items.Contains(product);
		}

		public int GetAmountPorduct(int idProduct)
		{
			try
			{
				return items.FirstOrDefault(item => item.ID == idProduct).Amount;

			}
			catch
			{
				throw new InvalidOperationException($"Продукта с ID:{idProduct} нет в корзине!");
				throw;
			}
		}

		public void RemoveProduct(int idProduct)
		{
			items.RemoveAll(product => product.ID == idProduct);
		}
	}
}
