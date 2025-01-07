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
	public partial class FormLogin : Form
	{
		public FormLogin()
		{
			InitializeComponent();
		}

		private void FormLogin_FormClosing(object sender, FormClosingEventArgs e)
		{
			Application.Exit();
		}

		private void buttonRegisterForm_Click(object sender, EventArgs e)
		{
			FormRegister formRegister = new FormRegister();
			formRegister.Show();

			Hide();
		}

		private void checkBoxShowPassword_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBoxShowPassword.Checked)
				textBoxPassword.PasswordChar = (char)0;
			else
				textBoxPassword.PasswordChar = '*';
		}

		// TODO: Сделать похожее для корзины
		private void buttonLogin_Click(object sender, EventArgs e)
		{
			if (hasEmptyFields())
				MessageBox.Show("Все поля должны быть заполнены!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

			UsersRepository users = UsersRepository.DeSerialize();
			User selectedUser = users.FindByPhone(maskedTextBoxPhoneNumber.Text);

			//CartsRepository carts = CartsRepository.DeSerialize();
			if (isCorrectUser(selectedUser))
			{
				//carts.SetCurrentCartByPhoneNumber(maskedTextBoxPhoneNumber.Text);
				users.CurrentUser = selectedUser;
				users.Serialize();
				FormShop formShop = new FormShop();
				formShop.Show();
				Hide();
			}
			else
				MessageBox.Show("Неправильный номер телефона или пароль!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		private bool hasEmptyFields()
		{
			return string.IsNullOrEmpty(maskedTextBoxPhoneNumber.Text) || string.IsNullOrEmpty(textBoxPassword.Text);
		}

		private bool isCorrectUser(User user)
		{
			return (user != null) && user.PasswordsIsMatch(textBoxPassword.Text);
		}
	}
}
