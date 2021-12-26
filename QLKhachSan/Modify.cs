using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace QLKhachSan
{
    class Modify
    {
        SqlDataAdapter dataAdapter; // truy xuất dữ liệu vào bảng
        SqlCommand sqlCommand; // ung de truy van va cap nhat toi csql
        public Modify()
        {

        }
        public DataTable getAllphong()
        {
            DataTable dataTable = new DataTable();
            string query = "select * from Phong";
            using (SqlConnection sqlConnection = Connection.getConnection())
            {
                sqlConnection.Open();
                dataAdapter = new SqlDataAdapter(query, sqlConnection);
                dataAdapter.Fill(dataTable);


                sqlConnection.Close();
            }
            return dataTable;
        }
        public bool insert(phong lKhachSan)
        {
            SqlConnection sqlConnection = Connection.getConnection();
            string query = "insert into Phong values (@MaPhong, @TenPhong, @loaiphong, @Mota, @songtoida, @trangthai)";
            try
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.Add("@MaPhong", SqlDbType.NVarChar).Value = lKhachSan.Id;
                sqlCommand.Parameters.Add("@TenPhong", SqlDbType.NVarChar).Value = lKhachSan.Name;
                sqlCommand.Parameters.Add("@loaiphong", SqlDbType.NVarChar).Value = lKhachSan.Loai;
                sqlCommand.Parameters.Add("@Mota", SqlDbType.NVarChar).Value = lKhachSan.Mota;
                sqlCommand.Parameters.Add("@songtoida", SqlDbType.NVarChar).Value = lKhachSan.Songuoi;
                sqlCommand.Parameters.Add("@trangthai", SqlDbType.NVarChar).Value = lKhachSan.Trangthai;
                sqlCommand.ExecuteNonQuery(); // thuc thi cau lenh truy van

            }
            catch
            {
                return false;
            }
            finally
            {
                sqlConnection.Close();
            }
            return true;
        }
        public bool update(phong lKhachSan)
        {
            SqlConnection sqlConnection = Connection.getConnection();
            string query = "update  Phong set TenPhong =@TenPhong, loaiphong=@loaiphong, Mota=@Mota, songtoida=@songtoida,trangthai=@trangthai where MaPhong=@MaPhong";
            try
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.Add("@MaPhong", SqlDbType.NVarChar).Value = lKhachSan.Id;
                sqlCommand.Parameters.Add("@TenPhong", SqlDbType.NVarChar).Value = lKhachSan.Name;
                sqlCommand.Parameters.Add("@loaiphong", SqlDbType.NVarChar).Value = lKhachSan.Loai;
                sqlCommand.Parameters.Add("@Mota", SqlDbType.NVarChar).Value = lKhachSan.Mota;
                sqlCommand.Parameters.Add("@songtoida", SqlDbType.NVarChar).Value = lKhachSan.Songuoi;
                sqlCommand.Parameters.Add("@trangthai", SqlDbType.NVarChar).Value = lKhachSan.Trangthai;
                sqlCommand.ExecuteNonQuery(); // thuc thi cau lenh truy van

            }
            catch
            {
                return false;
            }
            finally
            {
                sqlConnection.Close();
            }
            return true;
        }
        public bool delete(string id)
        {
            SqlConnection sqlConnection = Connection.getConnection();
            string query = "delete  Phong where MaPhong = @MaPhong ";
            try
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.Add("@MaPhong", SqlDbType.NVarChar).Value =id;
                sqlCommand.ExecuteNonQuery(); // thuc thi cau lenh truy van

            }
            catch
            {
                return false;
            }
            finally
            {
                sqlConnection.Close();
            }
            return true;
        }
    }
}
