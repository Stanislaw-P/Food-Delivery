using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Food_Delivery
{
	[Serializable]
	public class UsersRepository : IEnumerable<User>
	{
		public  List<User> Users = new List<User>();
		public User CurrentUser;

        public void Add(User newUser)
		{
			Users.Add(newUser);
		}

		public User FindByPhone(string phoneNumber)
		{
			return Users.FirstOrDefault(us => us.PhoneNumber == phoneNumber);
		}

		public void SetCurrentUserByPhoneNumber(string phoneNumber)
		{
			CurrentUser = FindByPhone(phoneNumber);
		}

		public void SetCurrentUser(User selectedUser)
		{
			CurrentUser = selectedUser;
		}

		public IEnumerator<User> GetEnumerator()
		{
			foreach (var user in Users)
			{
				yield return user;
			}
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Serialize()
		{
			BinaryFormatter formatter = new BinaryFormatter();
			using (FileStream fs = new FileStream("data/users.dat", FileMode.OpenOrCreate))
			{
				formatter.Serialize(fs, this);
			}
		}

		static public UsersRepository DeSerialize()
		{
			try
			{
				BinaryFormatter formatter = new BinaryFormatter();
				using (FileStream fs = new FileStream("data/users.dat", FileMode.OpenOrCreate))
				{
					return (UsersRepository)formatter.Deserialize(fs);
				}
			}
			catch
			{
				return new UsersRepository();
			}
		}
	}
}
