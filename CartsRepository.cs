using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Food_Delivery
{
	// Данный класс не нужен
	[Serializable]
	public class CartsRepository
	{
		private List<Cart> carts = new List<Cart>();
		private static Cart currentCart;
		public static Cart CurrentCart => currentCart;

		public void SetCurrentCartByPhoneNumber(string phoneNumber)
		{
			currentCart = FindByPhone(phoneNumber);
		}

		public Cart FindByPhone(string phoneNumber)
		{
			return carts.FirstOrDefault(cart => cart.UserPhoneNumber == phoneNumber);
		}

		public void Add(Cart newCart)
		{
			carts.Add(newCart);
		}


		public void Serialize()
		{
			BinaryFormatter formatter = new BinaryFormatter();
			using (FileStream fs = new FileStream("data/carts.dat", FileMode.OpenOrCreate))
			{
				formatter.Serialize(fs, this);
			}
		}

		static public CartsRepository DeSerialize()
		{
			try
			{
				BinaryFormatter formatter = new BinaryFormatter();
				using (FileStream fs = new FileStream("data/carts.dat", FileMode.OpenOrCreate))
				{
					return (CartsRepository)formatter.Deserialize(fs);
				}
			}
			catch
			{
				return new CartsRepository();
			}
		}

		
	}
}
