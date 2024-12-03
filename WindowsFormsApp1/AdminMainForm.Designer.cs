namespace WindowsFormsApp1
{
    partial class AdminMainForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.close_btn = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.close = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.addCustomer_btn = new System.Windows.Forms.Button();
            this.LogOut_button = new System.Windows.Forms.Button();
            this.addProduct_btn = new System.Windows.Forms.Button();
            this.addCashierButton = new System.Windows.Forms.Button();
            this.DashbordButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cashierOrderForm1 = new WindowsFormsApp1.CashierOrderForm();
            this.adminDashboardForm1 = new WindowsFormsApp1.AdminDashboardForm();
            this.adminAddProducts1 = new WindowsFormsApp1.AdminAddProducts();
            this.adminAddUsers1 = new WindowsFormsApp1.AdminAddUsers();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.close_btn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.close);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1297, 609);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // close_btn
            // 
            this.close_btn.AutoSize = true;
            this.close_btn.BackColor = System.Drawing.Color.Gray;
            this.close_btn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close_btn.Location = new System.Drawing.Point(1210, 12);
            this.close_btn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.close_btn.Name = "close_btn";
            this.close_btn.Size = new System.Drawing.Size(18, 18);
            this.close_btn.TabIndex = 15;
            this.close_btn.Text = "X";
            this.close_btn.Click += new System.EventHandler(this.close_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Cafe Shop Management System";
            // 
            // close
            // 
            this.close.AutoSize = true;
            this.close.BackColor = System.Drawing.Color.Transparent;
            this.close.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.Location = new System.Drawing.Point(1232, 9);
            this.close.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(21, 22);
            this.close.TabIndex = 13;
            this.close.Text = "X";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            this.panel2.Controls.Add(this.addCustomer_btn);
            this.panel2.Controls.Add(this.LogOut_button);
            this.panel2.Controls.Add(this.addProduct_btn);
            this.panel2.Controls.Add(this.addCashierButton);
            this.panel2.Controls.Add(this.DashbordButton);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(258, 609);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // addCustomer_btn
            // 
            this.addCustomer_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addCustomer_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCustomer_btn.ForeColor = System.Drawing.Color.White;
            this.addCustomer_btn.Location = new System.Drawing.Point(14, 382);
            this.addCustomer_btn.Name = "addCustomer_btn";
            this.addCustomer_btn.Size = new System.Drawing.Size(234, 33);
            this.addCustomer_btn.TabIndex = 22;
            this.addCustomer_btn.Text = "Add Customer";
            this.addCustomer_btn.UseVisualStyleBackColor = true;
            this.addCustomer_btn.Click += new System.EventHandler(this.addMain_customerBtn_Click);
            // 
            // LogOut_button
            // 
            this.LogOut_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogOut_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogOut_button.ForeColor = System.Drawing.Color.White;
            this.LogOut_button.Location = new System.Drawing.Point(10, 518);
            this.LogOut_button.Name = "LogOut_button";
            this.LogOut_button.Size = new System.Drawing.Size(234, 33);
            this.LogOut_button.TabIndex = 21;
            this.LogOut_button.Text = "Log Out";
            this.LogOut_button.UseVisualStyleBackColor = true;
            this.LogOut_button.Click += new System.EventHandler(this.button5_Click);
            // 
            // addProduct_btn
            // 
            this.addProduct_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addProduct_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProduct_btn.ForeColor = System.Drawing.Color.White;
            this.addProduct_btn.Location = new System.Drawing.Point(14, 335);
            this.addProduct_btn.Name = "addProduct_btn";
            this.addProduct_btn.Size = new System.Drawing.Size(234, 33);
            this.addProduct_btn.TabIndex = 19;
            this.addProduct_btn.Text = "Add Products";
            this.addProduct_btn.UseVisualStyleBackColor = true;
            this.addProduct_btn.Click += new System.EventHandler(this.button4_Click);
            // 
            // addCashierButton
            // 
            this.addCashierButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addCashierButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCashierButton.ForeColor = System.Drawing.Color.White;
            this.addCashierButton.Location = new System.Drawing.Point(14, 283);
            this.addCashierButton.Name = "addCashierButton";
            this.addCashierButton.Size = new System.Drawing.Size(234, 33);
            this.addCashierButton.TabIndex = 18;
            this.addCashierButton.Text = "Add Cashier";
            this.addCashierButton.UseVisualStyleBackColor = true;
            this.addCashierButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // DashbordButton
            // 
            this.DashbordButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DashbordButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DashbordButton.ForeColor = System.Drawing.Color.White;
            this.DashbordButton.Location = new System.Drawing.Point(14, 228);
            this.DashbordButton.Name = "DashbordButton";
            this.DashbordButton.Size = new System.Drawing.Size(234, 33);
            this.DashbordButton.TabIndex = 2;
            this.DashbordButton.Text = "Dashboard";
            this.DashbordButton.UseVisualStyleBackColor = true;
            this.DashbordButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(146, 194);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 15);
            this.label4.TabIndex = 17;
            this.label4.Text = "Admin";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(45, 194);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 15);
            this.label3.TabIndex = 16;
            this.label3.Text = "Username :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(50, 153);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 22);
            this.label2.TabIndex = 15;
            this.label2.Text = "Admin\'s Portal";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(64, 48);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(114, 103);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cashierOrderForm1);
            this.panel3.Controls.Add(this.adminDashboardForm1);
            this.panel3.Controls.Add(this.adminAddProducts1);
            this.panel3.Controls.Add(this.adminAddUsers1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(258, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1039, 609);
            this.panel3.TabIndex = 2;
            // 
            // cashierOrderForm1
            // 
            this.cashierOrderForm1.Location = new System.Drawing.Point(-1, 3);
            this.cashierOrderForm1.Name = "cashierOrderForm1";
            this.cashierOrderForm1.Size = new System.Drawing.Size(1015, 572);
            this.cashierOrderForm1.TabIndex = 3;
            this.cashierOrderForm1.Load += new System.EventHandler(this.cashierOrderForm1_Load);
            // 
            // adminDashboardForm1
            // 
            this.adminDashboardForm1.Location = new System.Drawing.Point(0, 0);
            this.adminDashboardForm1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.adminDashboardForm1.Name = "adminDashboardForm1";
            this.adminDashboardForm1.Size = new System.Drawing.Size(1014, 609);
            this.adminDashboardForm1.TabIndex = 2;
            this.adminDashboardForm1.Load += new System.EventHandler(this.adminDashboardForm1_Load);
            // 
            // adminAddProducts1
            // 
            this.adminAddProducts1.Location = new System.Drawing.Point(0, 0);
            this.adminAddProducts1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.adminAddProducts1.Name = "adminAddProducts1";
            this.adminAddProducts1.Size = new System.Drawing.Size(1015, 609);
            this.adminAddProducts1.TabIndex = 1;
            this.adminAddProducts1.Load += new System.EventHandler(this.adminAddProducts1_Load);
            // 
            // adminAddUsers1
            // 
            this.adminAddUsers1.Location = new System.Drawing.Point(-2, 0);
            this.adminAddUsers1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.adminAddUsers1.Name = "adminAddUsers1";
            this.adminAddUsers1.Size = new System.Drawing.Size(1013, 609);
            this.adminAddUsers1.TabIndex = 0;
            this.adminAddUsers1.Load += new System.EventHandler(this.adminAddUsers1_Load);
            // 
            // AdminMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1297, 609);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "AdminMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminMainForm";
            this.Load += new System.EventHandler(this.AdminMainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label close;
        private System.Windows.Forms.Button DashbordButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button LogOut_button;
        private System.Windows.Forms.Button addProduct_btn;
        private System.Windows.Forms.Button addCashierButton;
        private System.Windows.Forms.Panel panel3;
        private AdminAddUsers adminAddUsers1;
        private System.Windows.Forms.Label close_btn;
        private AdminAddProducts adminAddProducts1;
        private AdminDashboardForm adminDashboardForm1;
        private System.Windows.Forms.Button addCustomer_btn;
        private CashierOrderForm cashierOrderForm1;
    }
}