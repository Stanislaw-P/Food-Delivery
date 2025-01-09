using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Food_Delivery
{
	public partial class FormCart : Form
	{
		UsersRepository users;
		OrderRepository orders;
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
		}

		private void buttonCatalog_Click(object sender, EventArgs e)
		{
			users.Serialize();
			FormCatalog formShop = new FormCatalog();
			formShop.Show();

			this.Hide();
		}

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

		private void buttonMakeOrder_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(textBoxDeliveryAddress.Text))
				MessageBox.Show("Введите адрес доставки!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
			if(users.CurrentUser.Cart.IsEmty())
				MessageBox.Show("Вваша корзина пуста!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
			else
			{
				Order order = new Order(users.CurrentUser, users.CurrentUser.Cart.TotalCost, textBoxDeliveryAddress.Text);
				DisplayMessageBoxOrder(new OrderEventArgs($"Заказ №{order.ID} оформлен.", order.Cost + 150, DateTime.Now.AddHours(1), order.Address));

				// Сохранение заказа в файл
				orders = OrderRepository.DeSerialize();
				orders.Add(order);
				orders.Serialize();

				users.CurrentUser.Cart.Clear();
				users.CurrentUser.Cart.ShowCart(dataGridViewCart);
			}
		}

		private void DisplayMessageBoxOrder(OrderEventArgs e)
		{
			string message = $"Адресс доставки:{e.DeliveryAddress}\nДата доставки: {e.DeliveryTime.ToString("dd/MM HH:mm")}\nК оплате: {e.TotalCostOrder}руб.";
			MessageBox.Show(message, e.Message, MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void buttonClearCart_Click(object sender, EventArgs e)
		{
			users.CurrentUser.Cart.Clear();
			users.CurrentUser.Cart.ShowCart(dataGridViewCart);
		}

		private void buttonOrders_Click(object sender, EventArgs e)
		{
			users.Serialize();
			FormOrders formOrders = new FormOrders();
			formOrders.Show();

			this.Hide();
		}

		private void buttonLogOut_Click(object sender, EventArgs e)
		{
			FormLogin formLogin = new FormLogin();
			formLogin.Show();

			this.Hide();
		}

		private void FormCart_FormClosed(object sender, FormClosedEventArgs e)
		{
			users.Serialize();
			Application.Exit();
		}
	}
}
