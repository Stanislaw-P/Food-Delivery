using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Food_Delivery
{
	public partial class FormCatalog : Form
	{
		UsersRepository users;
		public FormCatalog()
		{
			InitializeComponent();
			users = UsersRepository.DeSerialize();
		}
		private void FormShop_Load(object sender, EventArgs e)
		{
			labelUserName.Text = users.CurrentUser.Name; // Отображение имени текущего пользователя
			if (Catalog.CountItems == 0)
				Catalog.LoadFromFile();
			listViewCatalog.Items.AddRange(Catalog.GetProductsToListViewItem());


		}

		private void FormShop_FormClosing(object sender, FormClosingEventArgs e)
		{
			users.Serialize();
			Application.Exit();
		}

		private void buttonLogOut_Click(object sender, EventArgs e)
		{
			FormLogin formLogin = new FormLogin();
			formLogin.Show();

			this.Hide();
		}

		private void buttonCart_Click(object sender, EventArgs e)
		{
			users.Serialize(); // Мне не нравится такое решение, где нужно каждый раз делать серелизацию
			FormCart formCart = new FormCart();
			formCart.Show();

			this.Hide();
		}

		private void buttonAddToCart_Click(object sender, EventArgs e)
		{
			try
			{
				int selectedProductId = int.Parse(listViewCatalog.SelectedItems[0].SubItems[3].Text);
				Product selecterProduct = Catalog.GetProductById(selectedProductId);
				if (!users.CurrentUser.Cart.Contains(selecterProduct))
					users.CurrentUser.Cart.Add(selecterProduct);
				else
					users.CurrentUser.Cart.Increase(selecterProduct);
			}
			catch
			{
				MessageBox.Show("Выберите продукт!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void buttonOrders_Click(object sender, EventArgs e)
		{
			FormOrders formOrders = new FormOrders();
			formOrders.Show();

			this.Hide();
		}
	}
}
