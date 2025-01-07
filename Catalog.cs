using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Food_Delivery
{
	public class Catalog
	{
		private static List<Product> products = new List<Product>();
		public static int CountItems => products.Count;

        public static void LoadFromFile(string fileName = "data/catalog.txt")
		{
			using (StreamReader reader = new StreamReader(fileName))
			{
				string typeProduct = null;
				while (!reader.EndOfStream)
				{
					string line = reader.ReadLine();
					if (line.Contains('$'))
					{
						string[] temp = line.Split('$');
						Product product = new Product(temp[0], typeProduct, Convert.ToDecimal(temp[1]));
						products.Add(product);
					}
					else
						typeProduct = line;
				}
			}
		}

		public static ListViewItem[] GetProductsToListViewItem()
		{
			return products
				.Select(product => new ListViewItem(product.ConvertToArrayForListViewItem()))
				.ToArray();
		}

		public static Product GetProductById(int idProduct)
		{
			return products.FirstOrDefault(product => product.ID == idProduct);
		}
	}
}
