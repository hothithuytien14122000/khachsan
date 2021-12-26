using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKhachSan
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        Modify modify;
        phong phong;

        private void menu_Load(object sender, EventArgs e)
        {
            modify = new Modify();
            try
            {
                data_gridview.DataSource = modify.getAllphong();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi:" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            string id = this.txt_ma.Text;
            string name = this.txt_ten.Text;
            string loai = this.cbx_loaip.Text;
            string mota = this.rtb_mota.Text;
            string songuoi = this.txt_song.Text;
            string trangthai = this.cbx_tt.Text;
            phong = new phong(id, name, loai, mota, songuoi, trangthai);
            if (modify.insert(phong))
            {
                data_gridview.DataSource = modify.getAllphong();
            }
            else
            {
                MessageBox.Show("Lỗi:" + "Không thể thêm vào được", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
           
            string id = this.txt_ma.Text;
            string name = this.txt_ten.Text;
            string loai = this.cbx_loaip.Text;
            string mota = this.rtb_mota.Text;
            string songuoi = this.txt_song.Text;
            string trangthai = this.cbx_tt.Text;
            phong = new phong(id, name, loai, mota, songuoi, trangthai);
            if (modify.update(phong))
            {
                data_gridview.DataSource = modify.getAllphong();
            }
            else
            {
                MessageBox.Show("Lỗi:" + "Không sửa được", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void data_gridview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if(index >= 0)
            {
                txt_ma.Text = data_gridview.Rows[index].Cells["MaPhong"].Value.ToString();
                txt_ten.Text = data_gridview.Rows[index].Cells["TenPhong"].Value.ToString();
               /* cbx_loaip.Text = data_gridview.Rows[index].Cells["loaiphong"].Value.ToString();*/
                rtb_mota.Text = data_gridview.Rows[index].Cells["Mota"].Value.ToString();
                txt_song.Text = data_gridview.Rows[index].Cells["songtoida"].Value.ToString();
               /* cbx_tt.Text = data_gridview.Rows[index].Cells["trangthai"].Value.ToString();*/
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            string id = data_gridview.SelectedRows[0].Cells[0].Value.ToString();
            if (modify.delete(id))
            {
                data_gridview.DataSource = modify.getAllphong();
            }
            else
            {
                MessageBox.Show("Lỗi:" + "Không xóa được", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
