namespace Food_Delivery
{
	partial class FormRegister
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.panel1 = new System.Windows.Forms.Panel();
			this.label5 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label4 = new System.Windows.Forms.Label();
			this.buttonLoginForm = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.textBoxUsername = new System.Windows.Forms.TextBox();
			this.textBoxPasswordC = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.checkBoxShowPassword = new System.Windows.Forms.CheckBox();
			this.buttonRegister = new System.Windows.Forms.Button();
			this.textBoxPassword = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.maskedTextBoxPhoneNumber = new System.Windows.Forms.MaskedTextBox();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.SkyBlue;
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.buttonLoginForm);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(395, 513);
			this.panel1.TabIndex = 0;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(105, 171);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(185, 32);
			this.label5.TabIndex = 9;
			this.label5.Text = "FoodWoman";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::Food_Delivery.Properties.Resources.logo;
			this.pictureBox1.Location = new System.Drawing.Point(134, 40);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(128, 128);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 8;
			this.pictureBox1.TabStop = false;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label4.Location = new System.Drawing.Point(112, 386);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(165, 20);
			this.label4.TabIndex = 7;
			this.label4.Text = "Аккаунт уже есть?";
			// 
			// buttonLoginForm
			// 
			this.buttonLoginForm.BackColor = System.Drawing.Color.SkyBlue;
			this.buttonLoginForm.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.buttonLoginForm.FlatAppearance.BorderSize = 2;
			this.buttonLoginForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonLoginForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonLoginForm.ForeColor = System.Drawing.Color.Black;
			this.buttonLoginForm.Location = new System.Drawing.Point(57, 420);
			this.buttonLoginForm.Name = "buttonLoginForm";
			this.buttonLoginForm.Size = new System.Drawing.Size(262, 45);
			this.buttonLoginForm.TabIndex = 5;
			this.buttonLoginForm.Text = "Войти в аккаунт";
			this.buttonLoginForm.UseVisualStyleBackColor = false;
			this.buttonLoginForm.Click += new System.EventHandler(this.buttonLoginForm_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(434, 93);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(172, 22);
			this.label2.TabIndex = 2;
			this.label2.Text = "Имя пользователя:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(468, 19);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(214, 36);
			this.label1.TabIndex = 3;
			this.label1.Text = "Регистрация";
			// 
			// textBoxUsername
			// 
			this.textBoxUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBoxUsername.Location = new System.Drawing.Point(434, 118);
			this.textBoxUsername.Name = "textBoxUsername";
			this.textBoxUsername.Size = new System.Drawing.Size(301, 34);
			this.textBoxUsername.TabIndex = 0;
			// 
			// textBoxPasswordC
			// 
			this.textBoxPasswordC.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBoxPasswordC.Location = new System.Drawing.Point(434, 322);
			this.textBoxPasswordC.Name = "textBoxPasswordC";
			this.textBoxPasswordC.PasswordChar = '*';
			this.textBoxPasswordC.Size = new System.Drawing.Size(301, 34);
			this.textBoxPasswordC.TabIndex = 2;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.Location = new System.Drawing.Point(434, 297);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(190, 22);
			this.label3.TabIndex = 6;
			this.label3.Text = "Подтвердите пароль:";
			// 
			// checkBoxShowPassword
			// 
			this.checkBoxShowPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.checkBoxShowPassword.Location = new System.Drawing.Point(434, 362);
			this.checkBoxShowPassword.Name = "checkBoxShowPassword";
			this.checkBoxShowPassword.Size = new System.Drawing.Size(301, 34);
			this.checkBoxShowPassword.TabIndex = 3;
			this.checkBoxShowPassword.Text = "Показать пароль";
			this.checkBoxShowPassword.UseVisualStyleBackColor = true;
			this.checkBoxShowPassword.CheckedChanged += new System.EventHandler(this.checkBoxShowPassword_CheckedChanged);
			// 
			// buttonRegister
			// 
			this.buttonRegister.BackColor = System.Drawing.Color.SkyBlue;
			this.buttonRegister.FlatAppearance.BorderColor = System.Drawing.Color.LightSkyBlue;
			this.buttonRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonRegister.ForeColor = System.Drawing.Color.Black;
			this.buttonRegister.Location = new System.Drawing.Point(434, 420);
			this.buttonRegister.Name = "buttonRegister";
			this.buttonRegister.Size = new System.Drawing.Size(326, 45);
			this.buttonRegister.TabIndex = 4;
			this.buttonRegister.Text = "Зарегестрироваться\r\n";
			this.buttonRegister.UseVisualStyleBackColor = false;
			this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_Click);
			// 
			// textBoxPassword
			// 
			this.textBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBoxPassword.Location = new System.Drawing.Point(434, 254);
			this.textBoxPassword.Name = "textBoxPassword";
			this.textBoxPassword.PasswordChar = '*';
			this.textBoxPassword.Size = new System.Drawing.Size(301, 34);
			this.textBoxPassword.TabIndex = 1;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label6.Location = new System.Drawing.Point(434, 229);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(77, 22);
			this.label6.TabIndex = 8;
			this.label6.Text = "Пароль:";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label7.Location = new System.Drawing.Point(434, 164);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(91, 22);
			this.label7.TabIndex = 10;
			this.label7.Text = "Телефон:";
			// 
			// maskedTextBoxPhoneNumber
			// 
			this.maskedTextBoxPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.maskedTextBoxPhoneNumber.Location = new System.Drawing.Point(434, 189);
			this.maskedTextBoxPhoneNumber.Mask = "+7 (000) 000-00-00";
			this.maskedTextBoxPhoneNumber.Name = "maskedTextBoxPhoneNumber";
			this.maskedTextBoxPhoneNumber.Size = new System.Drawing.Size(297, 34);
			this.maskedTextBoxPhoneNumber.TabIndex = 11;
			// 
			// FormRegister
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(772, 513);
			this.Controls.Add(this.maskedTextBoxPhoneNumber);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.textBoxPassword);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.buttonRegister);
			this.Controls.Add(this.checkBoxShowPassword);
			this.Controls.Add(this.textBoxPasswordC);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.textBoxUsername);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "FormRegister";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Регистрация аккаунта";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormRegister_FormClosing);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBoxUsername;
		private System.Windows.Forms.TextBox textBoxPasswordC;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.CheckBox checkBoxShowPassword;
		private System.Windows.Forms.Button buttonRegister;
		private System.Windows.Forms.Button buttonLoginForm;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.TextBox textBoxPassword;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.MaskedTextBox maskedTextBoxPhoneNumber;
	}
}

