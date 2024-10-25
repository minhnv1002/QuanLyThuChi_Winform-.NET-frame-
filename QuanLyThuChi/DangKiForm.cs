using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;//use later
using System.Data.SqlClient;

namespace QuanLyThuChi
{

    public partial class DangKiForm : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Chua co that khong\Documents\thuChi.mdf"";Integrated Security=True;Connect Timeout=30");


        public DangKiForm()
        {
            InitializeComponent();
        }
        public bool checkConnection()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
                return true;
            }
            return false;
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
            registercPass.PasswordChar = registerShowPass.Checked ? '\0' : '*';
            registercPass.PasswordChar = registerShowPass.Checked ? '\0' : '*';
        }

        private void button_DangKi2_Click(object sender, EventArgs e)
        {
            if (register_username.Text == "" || registerPass.Text == "" || registercPass.Text == "")
            {
                MessageBox.Show("Hãy điền các trường còn trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    // Sử dụng `using` để đảm bảo kết nối được đóng đúng cách
                    using (SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Project\QuanLyThuChi\QuanLyThuChi\quanLiChiTieu.mdf;Integrated Security=True;Connect Timeout=30"))
                    {
                        conn.Open();

                        string selectUsername = "SELECT * FROM users WHERE username = @usern";
                        using (SqlCommand checkUser = new SqlCommand(selectUsername, conn))
                        {
                            checkUser.Parameters.AddWithValue("@usern", register_username.Text.Trim());
                            SqlDataAdapter adapter = new SqlDataAdapter(checkUser);
                            DataTable table = new DataTable();
                            adapter.Fill(table);

                            if (table.Rows.Count != 0)
                            {
                                string tempUsern = register_username.Text.Substring(0, 1).ToUpper() + register_username.Text.Substring(1);
                                MessageBox.Show(tempUsern + " đã tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else if (registerPass.Text.Length < 8)
                            {
                                MessageBox.Show("Độ dài tối thiểu của mật khẩu phải lớn hơn 8", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else if (registerPass.Text != registercPass.Text)
                            {
                                MessageBox.Show("Mật khẩu xác nhận không chính xác. Vui lòng nhập lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                string insertData = "INSERT INTO users (username, password, ngayKhoiTao) VALUES(@usern, @pass, @date)";
                                using (SqlCommand insertUser = new SqlCommand(insertData, conn))
                                {
                                    insertUser.Parameters.AddWithValue("@usern", register_username.Text.Trim());
                                    insertUser.Parameters.AddWithValue("@pass", registerPass.Text.Trim());
                                    DateTime today = DateTime.Today;
                                    insertUser.Parameters.AddWithValue("@date", today);

                                    insertUser.ExecuteNonQuery();

                                    MessageBox.Show("Đăng kí thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    Form1 loginForm = new Form1();
                                    loginForm.Show();
                                    this.Hide();
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message, "Lỗi kết nối", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }



    }
}
