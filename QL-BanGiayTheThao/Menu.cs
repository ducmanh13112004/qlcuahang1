using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_BanGiayTheThao
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void lblDateTime_Click(object sender, EventArgs e)
        {

        }
        static string GetTimeNow()
        {
            DateTime date = DateTime.Now; // Lấy thời điểm hiện tại

            string dayOfWeek = date.ToString("dddd"); // Lấy thứ trong tuần
            string dayOfMonth = date.Day.ToString(); // Lấy ngày trong tháng
            string month = date.Month.ToString(); // Lấy tên của tháng
            string year = date.Year.ToString(); // Lấy năm

            return $"{dayOfWeek}, ngày {dayOfMonth}/{month}/{year}";
        }
    }
}
