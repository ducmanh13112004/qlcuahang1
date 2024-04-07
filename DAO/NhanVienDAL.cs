using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAO
{
    class NhanVienDAL
    {
        private static string stringConnection = "Data Source=.;Initial Catalog=QLCuaHangGiayTheThao;Integrated Security=True";
        public static SqlConnection getConnection()
        {
            return new SqlConnection(stringConnection);
        }
    }
}
