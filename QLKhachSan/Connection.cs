using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace QLKhachSan
{
    class Connection
    {
        private static string stringConnection = @"Data Source=THUYTIEN\SQLEXPRESS;Initial Catalog=khachsan;User ID=sa;Password=123";
        public static SqlConnection getConnection()
        {
            return new SqlConnection(stringConnection);

        }
    }
}
