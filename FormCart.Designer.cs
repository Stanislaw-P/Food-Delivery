namespace Food_Delivery
{
	partial class FormCart
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			this.panel2 = new System.Windows.Forms.Panel();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.labelUserName = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.buttonLogOut = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.dataGridViewCart = new System.Windows.Forms.DataGridView();
			this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Product = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.sum = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.add = new System.Windows.Forms.DataGridViewButtonColumn();
			this.amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.decrease = new System.Windows.Forms.DataGridViewButtonColumn();
			this.labelTotalCostCart = new System.Windows.Forms.Label();
			this.buttonMakeOrder = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.textBoxDeliveryAddress = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.buttonClearCart = new System.Windows.Forms.Button();
			this.buttonOrders = new System.Windows.Forms.Button();
			this.buttonCatalog = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pictureBox4 = new System.Windows.Forms.PictureBox();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.panel2.SuspendLayout();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewCart)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.SuspendLayout();
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.White;
			this.panel2.Controls.Add(this.label5);
			this.panel2.Controls.Add(this.pictureBox4);
			this.panel2.Controls.Add(this.label4);
			this.panel2.Controls.Add(this.pictureBox3);
			this.panel2.Controls.Add(this.label3);
			this.panel2.Controls.Add(this.labelUserName);
			this.panel2.Controls.Add(this.pictureBox2);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(1262, 49);
			this.panel2.TabIndex = 1;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(48, 10);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(185, 32);
			this.label5.TabIndex = 14;
			this.label5.Text = "FoodWoman";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label4.Location = new System.Drawing.Point(599, 10);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(243, 25);
			this.label4.TabIndex = 14;
			this.label4.Text = "ул. Хаджи Мамсурова 77";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.Location = new System.Drawing.Point(344, 10);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(173, 25);
			this.label3.TabIndex = 14;
			this.label3.Text = "+7(928)999-99-99";
			// 
			// labelUserName
			// 
			this.labelUserName.AutoSize = true;
			this.labelUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelUserName.Location = new System.Drawing.Point(1076, 10);
			this.labelUserName.Name = "labelUserName";
			this.labelUserName.Size = new System.Drawing.Size(78, 29);
			this.labelUserName.TabIndex = 12;
			this.labelUserName.Text = "Name";
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.SkyBlue;
			this.panel1.Controls.Add(this.buttonOrders);
			this.panel1.Controls.Add(this.buttonCatalog);
			this.panel1.Controls.Add(this.buttonLogOut);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel1.Location = new System.Drawing.Point(0, 49);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(266, 694);
			this.panel1.TabIndex = 2;
			// 
			// buttonLogOut
			// 
			this.buttonLogOut.BackColor = System.Drawing.Color.SkyBlue;
			this.buttonLogOut.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.buttonLogOut.FlatAppearance.BorderSize = 2;
			this.buttonLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonLogOut.ForeColor = System.Drawing.Color.Black;
			this.buttonLogOut.Image = global::Food_Delivery.Properties.Resources.logout_icon;
			this.buttonLogOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.buttonLogOut.Location = new System.Drawing.Point(12, 571);
			this.buttonLogOut.Name = "buttonLogOut";
			this.buttonLogOut.Size = new System.Drawing.Size(239, 76);
			this.buttonLogOut.TabIndex = 6;
			this.buttonLogOut.Text = "Выйти";
			this.buttonLogOut.UseVisualStyleBackColor = false;
			this.buttonLogOut.Click += new System.EventHandler(this.buttonLogOut_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(84, 168);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(109, 29);
			this.label1.TabIndex = 11;
			this.label1.Text = "Корзина";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(663, 86);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(120, 32);
			this.label2.TabIndex = 12;
			this.label2.Text = "Товары";
			// 
			// dataGridViewCart
			// 
			this.dataGridViewCart.AllowUserToAddRows = false;
			this.dataGridViewCart.AllowUserToDeleteRows = false;
			this.dataGridViewCart.AllowUserToResizeRows = false;
			this.dataGridViewCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewCart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Product,
            this.sum,
            this.add,
            this.amount,
            this.decrease});
			this.dataGridViewCart.Location = new System.Drawing.Point(306, 121);
			this.dataGridViewCart.Margin = new System.Windows.Forms.Padding(4);
			this.dataGridViewCart.Name = "dataGridViewCart";
			this.dataGridViewCart.ReadOnly = true;
			this.dataGridViewCart.RowHeadersVisible = false;
			this.dataGridViewCart.RowHeadersWidth = 51;
			this.dataGridViewCart.Size = new System.Drawing.Size(631, 424);
			this.dataGridViewCart.TabIndex = 15;
			this.dataGridViewCart.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCart_CellContentClick);
			// 
			// Id
			// 
			this.Id.HeaderText = "ID";
			this.Id.MinimumWidth = 6;
			this.Id.Name = "Id";
			this.Id.ReadOnly = true;
			this.Id.Width = 50;
			// 
			// Product
			// 
			this.Product.HeaderText = "Товар";
			this.Product.MinimumWidth = 6;
			this.Product.Name = "Product";
			this.Product.ReadOnly = true;
			this.Product.Width = 150;
			// 
			// sum
			// 
			this.sum.HeaderText = "Цена";
			this.sum.MinimumWidth = 6;
			this.sum.Name = "sum";
			this.sum.ReadOnly = true;
			this.sum.Width = 70;
			// 
			// add
			// 
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.add.DefaultCellStyle = dataGridViewCellStyle1;
			this.add.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.add.HeaderText = "Добавить";
			this.add.MinimumWidth = 6;
			this.add.Name = "add";
			this.add.ReadOnly = true;
			this.add.Text = "+";
			this.add.Width = 45;
			// 
			// amount
			// 
			this.amount.HeaderText = "Количество";
			this.amount.MinimumWidth = 6;
			this.amount.Name = "amount";
			this.amount.ReadOnly = true;
			this.amount.Width = 55;
			// 
			// decrease
			// 
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Red;
			this.decrease.DefaultCellStyle = dataGridViewCellStyle2;
			this.decrease.FillWeight = 20F;
			this.decrease.HeaderText = "Убавить";
			this.decrease.MinimumWidth = 6;
			this.decrease.Name = "decrease";
			this.decrease.ReadOnly = true;
			this.decrease.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.decrease.Text = "-";
			this.decrease.Width = 45;
			// 
			// labelTotalCostCart
			// 
			this.labelTotalCostCart.AutoSize = true;
			this.labelTotalCostCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelTotalCostCart.Location = new System.Drawing.Point(301, 560);
			this.labelTotalCostCart.Name = "labelTotalCostCart";
			this.labelTotalCostCart.Size = new System.Drawing.Size(181, 29);
			this.labelTotalCostCart.TabIndex = 16;
			this.labelTotalCostCart.Text = "Сумма заказа:";
			// 
			// buttonMakeOrder
			// 
			this.buttonMakeOrder.BackColor = System.Drawing.Color.SkyBlue;
			this.buttonMakeOrder.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.buttonMakeOrder.FlatAppearance.BorderSize = 2;
			this.buttonMakeOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonMakeOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonMakeOrder.ForeColor = System.Drawing.Color.Black;
			this.buttonMakeOrder.Location = new System.Drawing.Point(972, 255);
			this.buttonMakeOrder.Name = "buttonMakeOrder";
			this.buttonMakeOrder.Size = new System.Drawing.Size(246, 52);
			this.buttonMakeOrder.TabIndex = 17;
			this.buttonMakeOrder.Text = "Оформить заказ";
			this.buttonMakeOrder.UseVisualStyleBackColor = false;
			this.buttonMakeOrder.Click += new System.EventHandler(this.buttonMakeOrder_Click);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label6.Location = new System.Drawing.Point(967, 174);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(141, 29);
			this.label6.TabIndex = 18;
			this.label6.Text = "Ваш адрес:";
			// 
			// textBoxDeliveryAddress
			// 
			this.textBoxDeliveryAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBoxDeliveryAddress.Location = new System.Drawing.Point(972, 206);
			this.textBoxDeliveryAddress.Name = "textBoxDeliveryAddress";
			this.textBoxDeliveryAddress.Size = new System.Drawing.Size(246, 34);
			this.textBoxDeliveryAddress.TabIndex = 19;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label7.Location = new System.Drawing.Point(967, 324);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(270, 25);
			this.label7.TabIndex = 20;
			this.label7.Text = "Стоимость доставки: 150р.";
			// 
			// buttonClearCart
			// 
			this.buttonClearCart.BackColor = System.Drawing.Color.LightCyan;
			this.buttonClearCart.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.buttonClearCart.FlatAppearance.BorderSize = 2;
			this.buttonClearCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonClearCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonClearCart.ForeColor = System.Drawing.Color.Black;
			this.buttonClearCart.Location = new System.Drawing.Point(972, 493);
			this.buttonClearCart.Name = "buttonClearCart";
			this.buttonClearCart.Size = new System.Drawing.Size(246, 52);
			this.buttonClearCart.TabIndex = 21;
			this.buttonClearCart.Text = "Очистить корзину";
			this.buttonClearCart.UseVisualStyleBackColor = false;
			this.buttonClearCart.Click += new System.EventHandler(this.buttonClearCart_Click);
			// 
			// buttonOrders
			// 
			this.buttonOrders.BackColor = System.Drawing.Color.SkyBlue;
			this.buttonOrders.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.buttonOrders.FlatAppearance.BorderSize = 2;
			this.buttonOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonOrders.ForeColor = System.Drawing.Color.Black;
			this.buttonOrders.Image = global::Food_Delivery.Properties.Resources.order_history_icon;
			this.buttonOrders.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.buttonOrders.Location = new System.Drawing.Point(12, 372);
			this.buttonOrders.Name = "buttonOrders";
			this.buttonOrders.Size = new System.Drawing.Size(239, 52);
			this.buttonOrders.TabIndex = 13;
			this.buttonOrders.Text = "Мои заказы";
			this.buttonOrders.UseVisualStyleBackColor = false;
			this.buttonOrders.Click += new System.EventHandler(this.buttonOrders_Click);
			// 
			// buttonCatalog
			// 
			this.buttonCatalog.BackColor = System.Drawing.Color.SkyBlue;
			this.buttonCatalog.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.buttonCatalog.FlatAppearance.BorderSize = 2;
			this.buttonCatalog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonCatalog.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonCatalog.ForeColor = System.Drawing.Color.Black;
			this.buttonCatalog.Image = global::Food_Delivery.Properties.Resources.catalog_icon;
			this.buttonCatalog.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.buttonCatalog.Location = new System.Drawing.Point(12, 314);
			this.buttonCatalog.Name = "buttonCatalog";
			this.buttonCatalog.Size = new System.Drawing.Size(239, 52);
			this.buttonCatalog.TabIndex = 12;
			this.buttonCatalog.Text = "Каталог";
			this.buttonCatalog.UseVisualStyleBackColor = false;
			this.buttonCatalog.Click += new System.EventHandler(this.buttonCatalog_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::Food_Delivery.Properties.Resources.logo;
			this.pictureBox1.Location = new System.Drawing.Point(76, 37);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(128, 128);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 10;
			this.pictureBox1.TabStop = false;
			// 
			// pictureBox4
			// 
			this.pictureBox4.Image = global::Food_Delivery.Properties.Resources.location_icon;
			this.pictureBox4.Location = new System.Drawing.Point(551, 9);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new System.Drawing.Size(35, 35);
			this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox4.TabIndex = 15;
			this.pictureBox4.TabStop = false;
			// 
			// pictureBox3
			// 
			this.pictureBox3.Image = global::Food_Delivery.Properties.Resources.phone_call_icon;
			this.pictureBox3.Location = new System.Drawing.Point(306, 9);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(32, 32);
			this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox3.TabIndex = 14;
			this.pictureBox3.TabStop = false;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = global::Food_Delivery.Properties.Resources.user_icon;
			this.pictureBox2.Location = new System.Drawing.Point(1038, 9);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(32, 32);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox2.TabIndex = 13;
			this.pictureBox2.TabStop = false;
			// 
			// FormCart
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1262, 743);
			this.Controls.Add(this.buttonClearCart);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.textBoxDeliveryAddress);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.buttonMakeOrder);
			this.Controls.Add(this.labelTotalCostCart);
			this.Controls.Add(this.dataGridViewCart);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.panel2);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "FormCart";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Доставка до калитки";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormCart_FormClosed);
			this.Load += new System.EventHandler(this.FormCart_Load);
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewCart)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button buttonLogOut;
		private System.Windows.Forms.Label labelUserName;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Button buttonCatalog;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.PictureBox pictureBox4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.DataGridView dataGridViewCart;
		private System.Windows.Forms.Label labelTotalCostCart;
		private System.Windows.Forms.Button buttonMakeOrder;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox textBoxDeliveryAddress;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Button buttonOrders;
		private System.Windows.Forms.DataGridViewTextBoxColumn Id;
		private System.Windows.Forms.DataGridViewTextBoxColumn Product;
		private System.Windows.Forms.DataGridViewTextBoxColumn sum;
		private System.Windows.Forms.DataGridViewButtonColumn add;
		private System.Windows.Forms.DataGridViewTextBoxColumn amount;
		private System.Windows.Forms.DataGridViewButtonColumn decrease;
		private System.Windows.Forms.Button buttonClearCart;
	}
}