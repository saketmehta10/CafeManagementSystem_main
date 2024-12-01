namespace WindowsFormsApp1
{
    partial class CashierOrderForm
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cashierOrderForm_menuTable = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cashierOrderForm_type = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cashierOrderForm_productID = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cashierOrderForm_quantity = new System.Windows.Forms.NumericUpDown();
            this.cashierOrderForm_prodName = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cashierOrderForm_price = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cashierOrderForm_addBtn = new System.Windows.Forms.Button();
            this.cashierOrderForm_removeBtn = new System.Windows.Forms.Button();
            this.cashierOrderForm_clearBtn = new System.Windows.Forms.Button();
            this.cashierOrderForm_orderTable = new System.Windows.Forms.DataGridView();
            this.cashierOrderForm_orderPrice = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cashierOrderForm_amount = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cashierOrderForm_change = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.cashierOrderForm_payBtn = new System.Windows.Forms.Button();
            this.cashierOrderForm_receipitBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cashierOrderForm_menuTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cashierOrderForm_quantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cashierOrderForm_orderTable)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cashierOrderForm_menuTable);
            this.panel1.Location = new System.Drawing.Point(31, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(650, 268);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cashierOrderForm_clearBtn);
            this.panel2.Controls.Add(this.cashierOrderForm_removeBtn);
            this.panel2.Controls.Add(this.cashierOrderForm_addBtn);
            this.panel2.Controls.Add(this.cashierOrderForm_price);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.cashierOrderForm_prodName);
            this.panel2.Controls.Add(this.cashierOrderForm_quantity);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.cashierOrderForm_productID);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.cashierOrderForm_type);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(31, 295);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(650, 268);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cashierOrderForm_receipitBtn);
            this.panel3.Controls.Add(this.cashierOrderForm_payBtn);
            this.panel3.Controls.Add(this.cashierOrderForm_change);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.cashierOrderForm_amount);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.cashierOrderForm_orderPrice);
            this.panel3.Controls.Add(this.cashierOrderForm_orderTable);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Location = new System.Drawing.Point(712, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(287, 551);
            this.panel3.TabIndex = 2;
            // 
            // cashierOrderForm_menuTable
            // 
            this.cashierOrderForm_menuTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cashierOrderForm_menuTable.Location = new System.Drawing.Point(15, 41);
            this.cashierOrderForm_menuTable.Name = "cashierOrderForm_menuTable";
            this.cashierOrderForm_menuTable.RowHeadersWidth = 51;
            this.cashierOrderForm_menuTable.Size = new System.Drawing.Size(615, 215);
            this.cashierOrderForm_menuTable.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Menu";
            // 
            // cashierOrderForm_type
            // 
            this.cashierOrderForm_type.FormattingEnabled = true;
            this.cashierOrderForm_type.Items.AddRange(new object[] {
            "Active",
            "Inactive",
            "Apprival"});
            this.cashierOrderForm_type.Location = new System.Drawing.Point(133, 26);
            this.cashierOrderForm_type.Name = "cashierOrderForm_type";
            this.cashierOrderForm_type.Size = new System.Drawing.Size(169, 21);
            this.cashierOrderForm_type.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(82, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "Type :";
            // 
            // cashierOrderForm_productID
            // 
            this.cashierOrderForm_productID.FormattingEnabled = true;
            this.cashierOrderForm_productID.Items.AddRange(new object[] {
            "Active",
            "Inactive",
            "Apprival"});
            this.cashierOrderForm_productID.Location = new System.Drawing.Point(438, 26);
            this.cashierOrderForm_productID.Name = "cashierOrderForm_productID";
            this.cashierOrderForm_productID.Size = new System.Drawing.Size(178, 21);
            this.cashierOrderForm_productID.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(352, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "Product ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 15);
            this.label3.TabIndex = 15;
            this.label3.Text = "Product Name:";
            // 
            // cashierOrderForm_quantity
            // 
            this.cashierOrderForm_quantity.Location = new System.Drawing.Point(438, 78);
            this.cashierOrderForm_quantity.Name = "cashierOrderForm_quantity";
            this.cashierOrderForm_quantity.Size = new System.Drawing.Size(178, 20);
            this.cashierOrderForm_quantity.TabIndex = 16;
            // 
            // cashierOrderForm_prodName
            // 
            this.cashierOrderForm_prodName.AutoSize = true;
            this.cashierOrderForm_prodName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashierOrderForm_prodName.Location = new System.Drawing.Point(130, 79);
            this.cashierOrderForm_prodName.Name = "cashierOrderForm_prodName";
            this.cashierOrderForm_prodName.Size = new System.Drawing.Size(97, 15);
            this.cashierOrderForm_prodName.TabIndex = 17;
            this.cashierOrderForm_prodName.Text = "Test Product :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(366, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 15);
            this.label6.TabIndex = 18;
            this.label6.Text = "Quantity:";
            // 
            // cashierOrderForm_price
            // 
            this.cashierOrderForm_price.AutoSize = true;
            this.cashierOrderForm_price.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashierOrderForm_price.Location = new System.Drawing.Point(130, 131);
            this.cashierOrderForm_price.Name = "cashierOrderForm_price";
            this.cashierOrderForm_price.Size = new System.Drawing.Size(31, 15);
            this.cashierOrderForm_price.TabIndex = 20;
            this.cashierOrderForm_price.Text = "100";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(57, 131);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 15);
            this.label8.TabIndex = 19;
            this.label8.Text = "Price($) :";
            // 
            // cashierOrderForm_addBtn
            // 
            this.cashierOrderForm_addBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            this.cashierOrderForm_addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cashierOrderForm_addBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashierOrderForm_addBtn.ForeColor = System.Drawing.Color.White;
            this.cashierOrderForm_addBtn.Location = new System.Drawing.Point(85, 194);
            this.cashierOrderForm_addBtn.Name = "cashierOrderForm_addBtn";
            this.cashierOrderForm_addBtn.Size = new System.Drawing.Size(128, 35);
            this.cashierOrderForm_addBtn.TabIndex = 21;
            this.cashierOrderForm_addBtn.Text = "Add";
            this.cashierOrderForm_addBtn.UseVisualStyleBackColor = false;
            // 
            // cashierOrderForm_removeBtn
            // 
            this.cashierOrderForm_removeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            this.cashierOrderForm_removeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cashierOrderForm_removeBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashierOrderForm_removeBtn.ForeColor = System.Drawing.Color.White;
            this.cashierOrderForm_removeBtn.Location = new System.Drawing.Point(291, 194);
            this.cashierOrderForm_removeBtn.Name = "cashierOrderForm_removeBtn";
            this.cashierOrderForm_removeBtn.Size = new System.Drawing.Size(129, 35);
            this.cashierOrderForm_removeBtn.TabIndex = 22;
            this.cashierOrderForm_removeBtn.Text = "Remove";
            this.cashierOrderForm_removeBtn.UseVisualStyleBackColor = false;
            // 
            // cashierOrderForm_clearBtn
            // 
            this.cashierOrderForm_clearBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            this.cashierOrderForm_clearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cashierOrderForm_clearBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashierOrderForm_clearBtn.ForeColor = System.Drawing.Color.White;
            this.cashierOrderForm_clearBtn.Location = new System.Drawing.Point(476, 194);
            this.cashierOrderForm_clearBtn.Name = "cashierOrderForm_clearBtn";
            this.cashierOrderForm_clearBtn.Size = new System.Drawing.Size(132, 35);
            this.cashierOrderForm_clearBtn.TabIndex = 23;
            this.cashierOrderForm_clearBtn.Text = "Clear";
            this.cashierOrderForm_clearBtn.UseVisualStyleBackColor = false;
            // 
            // cashierOrderForm_orderTable
            // 
            this.cashierOrderForm_orderTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cashierOrderForm_orderTable.Location = new System.Drawing.Point(17, 16);
            this.cashierOrderForm_orderTable.Name = "cashierOrderForm_orderTable";
            this.cashierOrderForm_orderTable.RowHeadersWidth = 51;
            this.cashierOrderForm_orderTable.Size = new System.Drawing.Size(253, 265);
            this.cashierOrderForm_orderTable.TabIndex = 3;
            // 
            // cashierOrderForm_orderPrice
            // 
            this.cashierOrderForm_orderPrice.AutoSize = true;
            this.cashierOrderForm_orderPrice.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashierOrderForm_orderPrice.Location = new System.Drawing.Point(163, 300);
            this.cashierOrderForm_orderPrice.Name = "cashierOrderForm_orderPrice";
            this.cashierOrderForm_orderPrice.Size = new System.Drawing.Size(31, 15);
            this.cashierOrderForm_orderPrice.TabIndex = 25;
            this.cashierOrderForm_orderPrice.Text = "100";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(90, 300);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 15);
            this.label10.TabIndex = 24;
            this.label10.Text = "Price($) :";
            // 
            // cashierOrderForm_amount
            // 
            this.cashierOrderForm_amount.Location = new System.Drawing.Point(121, 335);
            this.cashierOrderForm_amount.Name = "cashierOrderForm_amount";
            this.cashierOrderForm_amount.Size = new System.Drawing.Size(139, 20);
            this.cashierOrderForm_amount.TabIndex = 26;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(34, 337);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 15);
            this.label11.TabIndex = 27;
            this.label11.Text = "Amount($) :";
            // 
            // cashierOrderForm_change
            // 
            this.cashierOrderForm_change.AutoSize = true;
            this.cashierOrderForm_change.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashierOrderForm_change.Location = new System.Drawing.Point(122, 379);
            this.cashierOrderForm_change.Name = "cashierOrderForm_change";
            this.cashierOrderForm_change.Size = new System.Drawing.Size(15, 15);
            this.cashierOrderForm_change.TabIndex = 25;
            this.cashierOrderForm_change.Text = "0";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(34, 379);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(82, 15);
            this.label13.TabIndex = 24;
            this.label13.Text = "Change($) :";
            // 
            // cashierOrderForm_payBtn
            // 
            this.cashierOrderForm_payBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            this.cashierOrderForm_payBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cashierOrderForm_payBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashierOrderForm_payBtn.ForeColor = System.Drawing.Color.White;
            this.cashierOrderForm_payBtn.Location = new System.Drawing.Point(17, 423);
            this.cashierOrderForm_payBtn.Name = "cashierOrderForm_payBtn";
            this.cashierOrderForm_payBtn.Size = new System.Drawing.Size(253, 40);
            this.cashierOrderForm_payBtn.TabIndex = 24;
            this.cashierOrderForm_payBtn.Text = "PAY";
            this.cashierOrderForm_payBtn.UseVisualStyleBackColor = false;
            // 
            // cashierOrderForm_receipitBtn
            // 
            this.cashierOrderForm_receipitBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            this.cashierOrderForm_receipitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cashierOrderForm_receipitBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashierOrderForm_receipitBtn.ForeColor = System.Drawing.Color.White;
            this.cashierOrderForm_receipitBtn.Location = new System.Drawing.Point(17, 477);
            this.cashierOrderForm_receipitBtn.Name = "cashierOrderForm_receipitBtn";
            this.cashierOrderForm_receipitBtn.Size = new System.Drawing.Size(253, 40);
            this.cashierOrderForm_receipitBtn.TabIndex = 28;
            this.cashierOrderForm_receipitBtn.Text = "RECEIPIT";
            this.cashierOrderForm_receipitBtn.UseVisualStyleBackColor = false;
            // 
            // CashierOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "CashierOrderForm";
            this.Size = new System.Drawing.Size(1015, 572);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cashierOrderForm_menuTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cashierOrderForm_quantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cashierOrderForm_orderTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView cashierOrderForm_menuTable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cashierOrderForm_type;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label cashierOrderForm_prodName;
        private System.Windows.Forms.NumericUpDown cashierOrderForm_quantity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cashierOrderForm_productID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label cashierOrderForm_price;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button cashierOrderForm_clearBtn;
        private System.Windows.Forms.Button cashierOrderForm_removeBtn;
        private System.Windows.Forms.Button cashierOrderForm_addBtn;
        private System.Windows.Forms.Label cashierOrderForm_orderPrice;
        private System.Windows.Forms.DataGridView cashierOrderForm_orderTable;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label cashierOrderForm_change;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox cashierOrderForm_amount;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button cashierOrderForm_receipitBtn;
        private System.Windows.Forms.Button cashierOrderForm_payBtn;
    }
}
