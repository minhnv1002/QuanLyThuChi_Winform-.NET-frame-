namespace QuanLyThuChi
{
    partial class DangKiForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DangKiForm));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_DangNhap2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.checkBox_showPass2 = new System.Windows.Forms.CheckBox();
            this.button_DangKi2 = new System.Windows.Forms.Button();
            this.textBox22 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox33 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Code", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(424, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 32);
            this.label1.TabIndex = 11;
            this.label1.Text = "Đăng Kí";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(51)))));
            this.panel1.Controls.Add(this.button_DangNhap2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(376, 450);
            this.panel1.TabIndex = 9;
            // 
            // button_DangNhap2
            // 
            this.button_DangNhap2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(51)))));
            this.button_DangNhap2.FlatAppearance.BorderSize = 0;
            this.button_DangNhap2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_DangNhap2.Font = new System.Drawing.Font("Cascadia Code", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_DangNhap2.ForeColor = System.Drawing.Color.White;
            this.button_DangNhap2.Location = new System.Drawing.Point(145, 376);
            this.button_DangNhap2.Name = "button_DangNhap2";
            this.button_DangNhap2.Size = new System.Drawing.Size(75, 23);
            this.button_DangNhap2.TabIndex = 8;
            this.button_DangNhap2.Text = "Đăng Nhập";
            this.button_DangNhap2.UseVisualStyleBackColor = false;
            this.button_DangNhap2.Click += new System.EventHandler(this.button_DangNhap2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cascadia Code", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(106, 343);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(177, 25);
            this.label5.TabIndex = 3;
            this.label5.Text = "Đăng Nhập Ở Đây";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(108, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "QUẢN LÝ THU CHI";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(120, 93);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 74);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // checkBox_showPass2
            // 
            this.checkBox_showPass2.AutoSize = true;
            this.checkBox_showPass2.Location = new System.Drawing.Point(652, 333);
            this.checkBox_showPass2.Name = "checkBox_showPass2";
            this.checkBox_showPass2.Size = new System.Drawing.Size(95, 17);
            this.checkBox_showPass2.TabIndex = 17;
            this.checkBox_showPass2.Text = "Hiện mật khẩu";
            this.checkBox_showPass2.UseVisualStyleBackColor = true;
            this.checkBox_showPass2.CheckedChanged += new System.EventHandler(this.checkBox_showPass2_CheckedChanged);
            // 
            // button_DangKi2
            // 
            this.button_DangKi2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(51)))));
            this.button_DangKi2.FlatAppearance.BorderSize = 0;
            this.button_DangKi2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_DangKi2.Font = new System.Drawing.Font("Cascadia Code", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_DangKi2.ForeColor = System.Drawing.Color.White;
            this.button_DangKi2.Location = new System.Drawing.Point(563, 376);
            this.button_DangKi2.Name = "button_DangKi2";
            this.button_DangKi2.Size = new System.Drawing.Size(75, 23);
            this.button_DangKi2.TabIndex = 16;
            this.button_DangKi2.Text = "Đăng Kí";
            this.button_DangKi2.UseVisualStyleBackColor = false;
            // 
            // textBox22
            // 
            this.textBox22.Location = new System.Drawing.Point(486, 239);
            this.textBox22.Name = "textBox22";
            this.textBox22.PasswordChar = '*';
            this.textBox22.Size = new System.Drawing.Size(152, 20);
            this.textBox22.TabIndex = 15;
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(486, 172);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(152, 20);
            this.textBox11.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(484, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Mật khẩu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(483, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Tên đăng nhập";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Info;
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(769, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 19);
            this.button1.TabIndex = 10;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox33
            // 
            this.textBox33.Location = new System.Drawing.Point(486, 305);
            this.textBox33.Name = "textBox33";
            this.textBox33.PasswordChar = '*';
            this.textBox33.Size = new System.Drawing.Size(152, 20);
            this.textBox33.TabIndex = 19;
            this.textBox33.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(483, 275);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Xác nhận mật khẩu";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // DangKiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox33);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.checkBox_showPass2);
            this.Controls.Add(this.button_DangKi2);
            this.Controls.Add(this.textBox22);
            this.Controls.Add(this.textBox11);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DangKiForm";
            this.Text = "DangKiForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_DangNhap2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox checkBox_showPass2;
        private System.Windows.Forms.Button button_DangKi2;
        private System.Windows.Forms.TextBox textBox22;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox33;
        private System.Windows.Forms.Label label6;
    }
}