using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using DTO;

namespace DAO
{
    public class NhanVienDAO : ConnectDB
    {
        public DataTable ListNhanVienDAO() {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM NhanVien", _conn);
                SqlDataReader rdr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(rdr);
                return dt;
            }
            finally
            {
                _conn.Close();
            }
        }
    }
}