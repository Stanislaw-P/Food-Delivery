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
	public partial class FormOrders : Form
	{
		UsersRepository users;
		OrderRepository orders;
		public FormOrders()
		{
			InitializeComponent();
			users = UsersRepository.DeSerialize();
			orders = OrderRepository.DeSerialize();
		}

		private void FormOrders_Load(object sender, EventArgs e)
		{
			labelUserName.Text = users.CurrentUser.Name; // Отображение имени текущего пользователя
			orders.Show(dataGridViewOrders);
		}

		private void FormOrders_FormClosing(object sender, FormClosingEventArgs e)
		{
			users.Serialize();
			orders.Serialize();
			Application.Exit();
		}

		private void buttonCatalog_Click(object sender, EventArgs e)
		{
			users.Serialize();
			orders.Serialize();
			FormCatalog formCatalog = new FormCatalog();
			formCatalog.Show();

			this.Hide();
		}

		private void buttonCart_Click(object sender, EventArgs e)
		{
			users.Serialize();
			orders.Serialize();
			FormCart formCart = new FormCart();
			formCart.Show();

			this.Hide();
		}

		private void dataGridViewOrders_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			switch (e.ColumnIndex)
			{
				case 3:
					int idOrderForRemove = Convert.ToInt32(dataGridViewOrders.Rows[e.RowIndex].Cells[2].Value);
					orders.RemoveOrderById(idOrderForRemove);
					orders.Show(dataGridViewOrders);
					break;
			}
		}
	}
}
