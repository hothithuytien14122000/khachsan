using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace QLKhachSan
{
    public partial class login : Form
    {
        SqlDataAdapter dataAdapter; // truy xuất dữ liệu vào bảng
        SqlCommand sqlCommand; 
        public login()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = Connection.getConnection();
           /* SqlConnection con = new SqlConnection(@"Data Source=THUYTIEN\SQLEXPRESS;Initial Catalog=khachsan;User ID=sa");*/
            try
            {
                sqlConnection.Open();
                string tk = txt_tk.Text;
                string mk = txt_mk.Text;
                string sql = "select * from DangNhap where Taikhoan='" + tk + "' and Matkhau= '" + mk + "'";
                sqlCommand = new SqlCommand(sql, sqlConnection);
                SqlDataReader dta = sqlCommand.ExecuteReader();
                if (dta.Read() == true)
                {
                    menu ss = new menu();
                    ss.Show();
                }
                else
                {
                    MessageBox.Show("dang nhap that bai");
                }
            }
            catch( Exception ex)
            {
                MessageBox.Show("loi sql");
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
