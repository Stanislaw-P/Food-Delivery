using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Food_Delivery
{
	[Serializable]
	public class User
	{
		public int ID { get; }
		public string Name { get; }
		public string PhoneNumber { get; }
		public string Password { get; }
		private static int idCounter = 0;
		public Cart Cart { get; set; }
		

		public User(string name, string phoneNumber, string password)
		{
			Name = name;
			PhoneNumber = phoneNumber;
			Password = toMD5(password);
			ID = idCounter;
			idCounter++;
			Cart = new Cart(phoneNumber);
		}

		private string toMD5(string password)
		{
			MD5 md5 = MD5.Create();
			byte[] inputBytes = Encoding.UTF8.GetBytes(password);
			byte[] hashBytes = md5.ComputeHash(inputBytes);
			return Convert.ToBase64String(hashBytes);
		}

		public bool PasswordsIsMatch(string pass)
		{
			return toMD5(pass) == this.Password;
		}

		
	}
}
