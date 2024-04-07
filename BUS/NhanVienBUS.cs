using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace BUS
{
    internal class NhanVienBUS
    {
        //lấy không đc nhân viên bus


        SqlDataAdapter dataAdapter;
        public NhanVienBUS()
        {

        }
        public DataTable getAllnhanvien()
        {
            DataTable dataTable = new DataTable();
            string query = "select * from nhanvien";
            using (SqlConnection sqlConnection = NhanVienBUS.getConnection())
            {
                sqlConnection.Open();
                dataAdapter = new SqlDataAdapter(query, sqlConnection);
                dataAdapter.Fill(dataTable);
                sqlConnection.Close();
            }
            return dataTable;
        }

        private static SqlConnection getConnection()
        {
            string connectionString = "Data Source=.;Initial Catalog=QLCuaHangGiayTheThao;Integrated Security=True"; // Thay thế bằng chuỗi kết nối thực tế của bạn
            return new SqlConnection(connectionString);
        }

    }
}
