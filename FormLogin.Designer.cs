namespace Food_Delivery
{
	partial class FormLogin
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
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label4 = new System.Windows.Forms.Label();
			this.buttonRegisterForm = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.textBoxPassword = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.checkBoxShowPassword = new System.Windows.Forms.CheckBox();
			this.buttonLogin = new System.Windows.Forms.Button();
			this.maskedTextBoxPhoneNumber = new System.Windows.Forms.MaskedTextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.SkyBlue;
			this.panel1.Controls.Add(this.label6);
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.buttonRegisterForm);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(395, 513);
			this.panel1.TabIndex = 0;
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
			this.label4.Location = new System.Drawing.Point(122, 390);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(132, 20);
			this.label4.TabIndex = 7;
			this.label4.Text = "Нет аккаунта?";
			// 
			// buttonRegisterForm
			// 
			this.buttonRegisterForm.BackColor = System.Drawing.Color.SkyBlue;
			this.buttonRegisterForm.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.buttonRegisterForm.FlatAppearance.BorderSize = 2;
			this.buttonRegisterForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonRegisterForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonRegisterForm.ForeColor = System.Drawing.Color.Black;
			this.buttonRegisterForm.Location = new System.Drawing.Point(57, 420);
			this.buttonRegisterForm.Name = "buttonRegisterForm";
			this.buttonRegisterForm.Size = new System.Drawing.Size(262, 45);
			this.buttonRegisterForm.TabIndex = 4;
			this.buttonRegisterForm.Text = "Регистрация";
			this.buttonRegisterForm.UseVisualStyleBackColor = false;
			this.buttonRegisterForm.Click += new System.EventHandler(this.buttonRegisterForm_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(430, 157);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(91, 22);
			this.label2.TabIndex = 2;
			this.label2.Text = "Телефон:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(541, 58);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(92, 36);
			this.label1.TabIndex = 3;
			this.label1.Text = "Вход";
			// 
			// textBoxPassword
			// 
			this.textBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBoxPassword.Location = new System.Drawing.Point(434, 259);
			this.textBoxPassword.Name = "textBoxPassword";
			this.textBoxPassword.PasswordChar = '*';
			this.textBoxPassword.Size = new System.Drawing.Size(301, 34);
			this.textBoxPassword.TabIndex = 1;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.Location = new System.Drawing.Point(430, 234);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(77, 22);
			this.label3.TabIndex = 6;
			this.label3.Text = "Пароль:";
			// 
			// checkBoxShowPassword
			// 
			this.checkBoxShowPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.checkBoxShowPassword.Location = new System.Drawing.Point(434, 299);
			this.checkBoxShowPassword.Name = "checkBoxShowPassword";
			this.checkBoxShowPassword.Size = new System.Drawing.Size(199, 29);
			this.checkBoxShowPassword.TabIndex = 2;
			this.checkBoxShowPassword.Text = "Показать пароль";
			this.checkBoxShowPassword.UseVisualStyleBackColor = true;
			this.checkBoxShowPassword.CheckedChanged += new System.EventHandler(this.checkBoxShowPassword_CheckedChanged);
			// 
			// buttonLogin
			// 
			this.buttonLogin.BackColor = System.Drawing.Color.SkyBlue;
			this.buttonLogin.FlatAppearance.BorderColor = System.Drawing.Color.LightSkyBlue;
			this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonLogin.ForeColor = System.Drawing.Color.Black;
			this.buttonLogin.Location = new System.Drawing.Point(434, 375);
			this.buttonLogin.Name = "buttonLogin";
			this.buttonLogin.Size = new System.Drawing.Size(153, 45);
			this.buttonLogin.TabIndex = 3;
			this.buttonLogin.Text = "Войти";
			this.buttonLogin.UseVisualStyleBackColor = false;
			this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
			// 
			// maskedTextBoxPhoneNumber
			// 
			this.maskedTextBoxPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.maskedTextBoxPhoneNumber.Location = new System.Drawing.Point(434, 182);
			this.maskedTextBoxPhoneNumber.Mask = "+7 (000) 000-00-00";
			this.maskedTextBoxPhoneNumber.Name = "maskedTextBoxPhoneNumber";
			this.maskedTextBoxPhoneNumber.Size = new System.Drawing.Size(297, 34);
			this.maskedTextBoxPhoneNumber.TabIndex = 12;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(105, 171);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(185, 32);
			this.label6.TabIndex = 10;
			this.label6.Text = "FoodWoman";
			// 
			// FormLogin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(772, 513);
			this.Controls.Add(this.maskedTextBoxPhoneNumber);
			this.Controls.Add(this.buttonLogin);
			this.Controls.Add(this.checkBoxShowPassword);
			this.Controls.Add(this.textBoxPassword);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "FormLogin";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Вход в аккаунт";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormLogin_FormClosing);
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
		private System.Windows.Forms.TextBox textBoxPassword;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.CheckBox checkBoxShowPassword;
		private System.Windows.Forms.Button buttonLogin;
		private System.Windows.Forms.Button buttonRegisterForm;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.MaskedTextBox maskedTextBoxPhoneNumber;
		private System.Windows.Forms.Label label6;
	}
}

