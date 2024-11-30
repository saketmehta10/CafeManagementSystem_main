namespace WindowsFormsApp1
{
    partial class AdminAddUsers
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.adminAddUser_importbtn = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.adminAddUser_imageView = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.adminAddUser_clearbtn = new System.Windows.Forms.Button();
            this.adminAddUser_deletebtn = new System.Windows.Forms.Button();
            this.adminAddUser_update_btn = new System.Windows.Forms.Button();
            this.adminAddUser_addbtn = new System.Windows.Forms.Button();
            this.adminAddUser_status = new System.Windows.Forms.ComboBox();
            this.adminAddUser_role = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.adminAddUser_password = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.adminAddUser_username = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adminAddUser_imageView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.adminAddUser_importbtn);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.adminAddUser_clearbtn);
            this.panel1.Controls.Add(this.adminAddUser_deletebtn);
            this.panel1.Controls.Add(this.adminAddUser_update_btn);
            this.panel1.Controls.Add(this.adminAddUser_addbtn);
            this.panel1.Controls.Add(this.adminAddUser_status);
            this.panel1.Controls.Add(this.adminAddUser_role);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.adminAddUser_password);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.adminAddUser_username);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(22, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(252, 544);
            this.panel1.TabIndex = 0;
            // 
            // adminAddUser_importbtn
            // 
            this.adminAddUser_importbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            this.adminAddUser_importbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adminAddUser_importbtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminAddUser_importbtn.ForeColor = System.Drawing.Color.White;
            this.adminAddUser_importbtn.Location = new System.Drawing.Point(74, 131);
            this.adminAddUser_importbtn.Name = "adminAddUser_importbtn";
            this.adminAddUser_importbtn.Size = new System.Drawing.Size(93, 35);
            this.adminAddUser_importbtn.TabIndex = 15;
            this.adminAddUser_importbtn.Text = "Import";
            this.adminAddUser_importbtn.UseVisualStyleBackColor = false;
            this.adminAddUser_importbtn.Click += new System.EventHandler(this.adminAddUser_importbtn_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Silver;
            this.panel4.Controls.Add(this.adminAddUser_imageView);
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Location = new System.Drawing.Point(74, 17);
            this.panel4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(93, 108);
            this.panel4.TabIndex = 0;
            // 
            // adminAddUser_imageView
            // 
            this.adminAddUser_imageView.Location = new System.Drawing.Point(2, 2);
            this.adminAddUser_imageView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.adminAddUser_imageView.Name = "adminAddUser_imageView";
            this.adminAddUser_imageView.Size = new System.Drawing.Size(91, 103);
            this.adminAddUser_imageView.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.adminAddUser_imageView.TabIndex = 1;
            this.adminAddUser_imageView.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 41);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // adminAddUser_clearbtn
            // 
            this.adminAddUser_clearbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            this.adminAddUser_clearbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adminAddUser_clearbtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminAddUser_clearbtn.ForeColor = System.Drawing.Color.White;
            this.adminAddUser_clearbtn.Location = new System.Drawing.Point(142, 467);
            this.adminAddUser_clearbtn.Name = "adminAddUser_clearbtn";
            this.adminAddUser_clearbtn.Size = new System.Drawing.Size(93, 35);
            this.adminAddUser_clearbtn.TabIndex = 13;
            this.adminAddUser_clearbtn.Text = "Clear";
            this.adminAddUser_clearbtn.UseVisualStyleBackColor = false;
            this.adminAddUser_clearbtn.Click += new System.EventHandler(this.adminAddUser_clearbtn_Click);
            // 
            // adminAddUser_deletebtn
            // 
            this.adminAddUser_deletebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            this.adminAddUser_deletebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adminAddUser_deletebtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminAddUser_deletebtn.ForeColor = System.Drawing.Color.White;
            this.adminAddUser_deletebtn.Location = new System.Drawing.Point(22, 467);
            this.adminAddUser_deletebtn.Name = "adminAddUser_deletebtn";
            this.adminAddUser_deletebtn.Size = new System.Drawing.Size(93, 35);
            this.adminAddUser_deletebtn.TabIndex = 12;
            this.adminAddUser_deletebtn.Text = "Delete";
            this.adminAddUser_deletebtn.UseVisualStyleBackColor = false;
            this.adminAddUser_deletebtn.Click += new System.EventHandler(this.adminAddUser_deletebtn_Click);
            // 
            // adminAddUser_update_btn
            // 
            this.adminAddUser_update_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            this.adminAddUser_update_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adminAddUser_update_btn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminAddUser_update_btn.ForeColor = System.Drawing.Color.White;
            this.adminAddUser_update_btn.Location = new System.Drawing.Point(142, 408);
            this.adminAddUser_update_btn.Name = "adminAddUser_update_btn";
            this.adminAddUser_update_btn.Size = new System.Drawing.Size(93, 35);
            this.adminAddUser_update_btn.TabIndex = 11;
            this.adminAddUser_update_btn.Text = "Update";
            this.adminAddUser_update_btn.UseVisualStyleBackColor = false;
            this.adminAddUser_update_btn.Click += new System.EventHandler(this.addUserdata_updatebtn_Click);
            // 
            // adminAddUser_addbtn
            // 
            this.adminAddUser_addbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            this.adminAddUser_addbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adminAddUser_addbtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminAddUser_addbtn.ForeColor = System.Drawing.Color.White;
            this.adminAddUser_addbtn.Location = new System.Drawing.Point(22, 408);
            this.adminAddUser_addbtn.Name = "adminAddUser_addbtn";
            this.adminAddUser_addbtn.Size = new System.Drawing.Size(93, 35);
            this.adminAddUser_addbtn.TabIndex = 2;
            this.adminAddUser_addbtn.Text = "Add";
            this.adminAddUser_addbtn.UseVisualStyleBackColor = false;
            this.adminAddUser_addbtn.Click += new System.EventHandler(this.adminAddUser_addbtn_Click);
            // 
            // adminAddUser_status
            // 
            this.adminAddUser_status.FormattingEnabled = true;
            this.adminAddUser_status.Items.AddRange(new object[] {
            "Active",
            "Inactive",
            "Apprival"});
            this.adminAddUser_status.Location = new System.Drawing.Point(97, 360);
            this.adminAddUser_status.Name = "adminAddUser_status";
            this.adminAddUser_status.Size = new System.Drawing.Size(139, 21);
            this.adminAddUser_status.TabIndex = 10;
            // 
            // adminAddUser_role
            // 
            this.adminAddUser_role.FormattingEnabled = true;
            this.adminAddUser_role.Items.AddRange(new object[] {
            "Admin",
            "Cashier"});
            this.adminAddUser_role.Location = new System.Drawing.Point(97, 311);
            this.adminAddUser_role.Name = "adminAddUser_role";
            this.adminAddUser_role.Size = new System.Drawing.Size(139, 21);
            this.adminAddUser_role.TabIndex = 2;
            this.adminAddUser_role.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(32, 366);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Status :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(45, 317);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "Role :";
            // 
            // adminAddUser_password
            // 
            this.adminAddUser_password.Location = new System.Drawing.Point(97, 266);
            this.adminAddUser_password.Name = "adminAddUser_password";
            this.adminAddUser_password.Size = new System.Drawing.Size(139, 20);
            this.adminAddUser_password.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 271);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Password :";
            // 
            // adminAddUser_username
            // 
            this.adminAddUser_username.Location = new System.Drawing.Point(97, 223);
            this.adminAddUser_username.Name = "adminAddUser_username";
            this.adminAddUser_username.Size = new System.Drawing.Size(139, 20);
            this.adminAddUser_username.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Username :";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(280, 14);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(722, 544);
            this.panel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(25, 53);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(674, 477);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Data of Users";
            // 
            // AdminAddUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "AdminAddUsers";
            this.Size = new System.Drawing.Size(1015, 572);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.adminAddUser_imageView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox adminAddUser_password;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox adminAddUser_username;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox adminAddUser_status;
        private System.Windows.Forms.ComboBox adminAddUser_role;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button adminAddUser_addbtn;
        private System.Windows.Forms.Button adminAddUser_clearbtn;
        private System.Windows.Forms.Button adminAddUser_deletebtn;
        private System.Windows.Forms.Button adminAddUser_update_btn;
        private System.Windows.Forms.Button adminAddUser_importbtn;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox adminAddUser_imageView;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
