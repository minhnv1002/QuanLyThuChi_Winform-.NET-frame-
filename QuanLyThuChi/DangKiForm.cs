using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyThuChi
{

    public partial class DangKiForm : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Chua co that khong\Documents\chiPhi.mdf"";Integrated Security=True;Connect Timeout=30");
        public DangKiForm()
        {
            InitializeComponent();
        }
        public bool checkConection()
        {
            return (conn.State != ConnectionState.Open) ? false:true ;  
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_DangNhap2_Click(object sender, EventArgs e)
        {
            Form1 loginForm = new Form1();
            loginForm.Show();

            this.Hide();
        }

        private void checkBox_showPass2_CheckedChanged(object sender, EventArgs e)
        {
            textBox33.PasswordChar = checkBox_showPass2.Checked ? '\0' : '*';
        }
    }
}
