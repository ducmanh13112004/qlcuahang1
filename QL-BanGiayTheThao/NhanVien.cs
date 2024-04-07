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
    public partial class NhanVien : Form
    {
        public NhanVien()
        {
            InitializeComponent();
        }
        nhan
        NhanVienBUS nhanvienbus;//lỗi 
       
        private void NhanVien_Load(object sender, EventArgs e)
        {
            nhanvienbus = new NhanVienBUS();
            try
            {
                dtgrvHienThiListNV.DataSource = nhanvienbus.getAllnhanvien();//lỗi getall
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi :  " + ex.Message, "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
        }
    }
}
