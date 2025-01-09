using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Food_Delivery
{
	public partial class FormCart : Form
	{
		UsersRepository users;
		public FormCart()
		{
			InitializeComponent();
			users = UsersRepository.DeSerialize();
		}

		private void FormCart_Load(object sender, EventArgs e)
		{
			labelUserName.Text = users.CurrentUser.Name; // Отображение имени текущего пользователя
			users.CurrentUser.Cart.ShowCart(dataGridViewCart);
			labelTotalCostCart.Text = $"Сумма заказа:{users.CurrentUser.Cart.TotalCost}";

			//CartsRepository carts = CartsRepository.DeSerialize();
			////Cart cartCurrentUser = CartsRepository.GetCartCurrentUser();
			//Cart cartCurrentUser = CartsRepository.CurrentCart;
			//cartCurrentUser.ShowCart(dataGridViewCart);
		}

		private void FormCart_FormClosed(object sender, FormClosedEventArgs e)
		{
			users.Serialize();
			Application.Exit();
		}

		private void buttonCatalog_Click(object sender, EventArgs e)
		{
			users.Serialize();
			FormShop formShop = new FormShop();
			formShop.Show();

			this.Hide();
		}


		//TODO: Сделать, а также сделать чтобы при добавлении продукта, который уже есть в корзине что нибудь происходило
		private void dataGridViewCart_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			switch (e.ColumnIndex)
			{
				case 3:
					int idProductForIncrease = Convert.ToInt32(dataGridViewCart.Rows[e.RowIndex].Cells[0].Value);
					users.CurrentUser.Cart.Increase(idProductForIncrease);
					users.CurrentUser.Cart.ShowCart(dataGridViewCart);
					labelTotalCostCart.Text = $"Сумма заказа:{users.CurrentUser.Cart.TotalCost}";
					break;
				case 5:
					int idProductForDecrease = Convert.ToInt32(dataGridViewCart.Rows[e.RowIndex].Cells[0].Value);
					users.CurrentUser.Cart.Decrease(idProductForDecrease);
					if (users.CurrentUser.Cart.GetAmountPorduct(idProductForDecrease) == 0)
						users.CurrentUser.Cart.RemoveProduct(idProductForDecrease);
					users.CurrentUser.Cart.ShowCart(dataGridViewCart);
					labelTotalCostCart.Text = $"Сумма заказа:{users.CurrentUser.Cart.TotalCost}";
					break;
			}
		}

		private void buttonLogOut_Click(object sender, EventArgs e)
		{
			FormLogin formLogin = new FormLogin();
			formLogin.Show();

			this.Hide();
		}



		private void FormCart_FormClosing(object sender, FormClosingEventArgs e)
		{
			Application.Exit();
		}

		private void buttonMakeOrder_Click(object sender, EventArgs e)
		{
			Order order = new Order(users.CurrentUser, users.CurrentUser.Cart.TotalCost, textBoxDeliveryAddress.Text);
			order.OrderHasOccurred += DisplayMessageBoxOrder;
			order.PlaceOrder();

			users.CurrentUser.Cart.Clear();
			users.CurrentUser.Cart.ShowCart(dataGridViewCart);

		}

		private void DisplayMessageBoxOrder(User sender, OrderEventArgs e)
		{
			string message = $"Адресс доставки:{e.DeliveryAddress}\nДата доставки: {e.DeliveryTime.ToString("dd/MM HH:mm")}\nК оплате: {e.TotalCostOrder}руб.";
			MessageBox.Show(message, e.Message, MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
	}
}
