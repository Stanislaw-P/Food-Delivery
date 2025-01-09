using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Food_Delivery
{
	public partial class FormRegister : Form
	{
		UsersRepository users;
		public FormRegister()
		{
			InitializeComponent();
		}

		private void FormRegister_FormClosing(object sender, FormClosingEventArgs e)
		{
			Application.Exit();
		}

		private void buttonLoginForm_Click(object sender, EventArgs e)
		{
			FormLogin formLogin = new FormLogin();
			formLogin.Show();

			Hide();
		}

		private void checkBoxShowPassword_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBoxShowPassword.Checked)
			{
				textBoxPassword.PasswordChar = (char)0;
				textBoxPasswordC.PasswordChar = (char)0;
			}
			else
			{
				textBoxPassword.PasswordChar = '*';
				textBoxPasswordC.PasswordChar = '*';
			}
		}

		private void checkPasswordMatches()
		{
			if (textBoxPassword.Text != textBoxPasswordC.Text)
				MessageBox.Show("Пароли не совпадают!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		private void buttonRegister_Click(object sender, EventArgs e)
		{
			checkPasswordMatches();

			if (hasEmptyFields())
				MessageBox.Show("Все поля должны быть заполнены!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
			users = UsersRepository.DeSerialize();
			if (userAlreadyExists(maskedTextBoxPhoneNumber.Text) == true)
				MessageBox.Show("Пользователь с таким номером уже существует!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			else
			{
				User newUser = new User(textBoxUsername.Text, maskedTextBoxPhoneNumber.Text, textBoxPassword.Text);
				users.Add(newUser);
				users.Serialize();

				FormLogin formLogin = new FormLogin();
				formLogin.Show();
				this.Hide();
			}
		}

		private bool hasEmptyFields()
		{
			return string.IsNullOrEmpty(textBoxUsername.Text) || string.IsNullOrEmpty(maskedTextBoxPhoneNumber.Text) || string.IsNullOrEmpty(textBoxPassword.Text) || string.IsNullOrEmpty(textBoxPasswordC.Text);
		}

		private bool? userAlreadyExists(string phoneNumber)
		{
			return users?.IsUserExistence(phoneNumber);
		}
	}
}
