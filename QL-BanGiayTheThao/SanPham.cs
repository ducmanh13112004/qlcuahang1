using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DAO;
using DTO;
namespace QL_BanGiayTheThao
{
    public partial class SanPham : Form
    {
        SanPhamBUS sanphambus =new SanPhamBUS();
       
        public SanPham()
        {
            InitializeComponent();
        }
        
        private void SanPham_Load(object sender, EventArgs e)
        {
            try
            {
                dtgrvHienThiListSP.DataSource = sanphambus.listofsanpham();

            }catch (Exception ex)
            {
                MessageBox.Show("Lỗi :  " + ex.Message, "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.None);

            }
        }

        private void dtgrvHienThiListSP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtgrvHienThiListSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                txtMaSP.Text = dtgrvHienThiListSP.Rows[e.RowIndex].Cells[0].Value.ToString();
                cbbNCC.Text = dtgrvHienThiListSP.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtTenSP.Text = dtgrvHienThiListSP.Rows[e.RowIndex].Cells[2].Value.ToString();
                cbbHangSP.Text = dtgrvHienThiListSP.Rows[e.RowIndex].Cells[3].Value.ToString();
                cbbXuatxu.Text = dtgrvHienThiListSP.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtGiaBan.Text = dtgrvHienThiListSP.Rows[e.RowIndex].Cells[5].Value.ToString();
                cbbTheloai.Text = dtgrvHienThiListSP.Rows[e.RowIndex].Cells[6].Value.ToString();

            }
            catch
            {
                MessageBox.Show("Có lỗi khi thực hiện chức năng này !");
            }
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            txtMaSP.Text = "";
            cbbNCC.Text = "  Chọn nhà cung cấp";
            cbbHangSP.Text = "  Chọn hãng sản phẩm";
            cbbXuatxu.Text = "  Chọn xuất xứ";
            cbbTheloai.Text = "Chọn thể loại";
            txtGiaBan.Text = "";
            
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            SanPhamDTO sanPham = new SanPhamDTO();
            sanPham.MaSP = txtMaSP.Text;
            sanPham.MaNCC = cbbNCC.Text;
            sanPham.TenSP = txtTenSP.Text;
            sanPham.HangSP = cbbHangSP.Text;
            sanPham.XuatXu = cbbXuatxu.Text;
            sanPham.GiaBan = txtGiaBan.Text;
            sanPham.TheLoai = cbbTheloai.Text;

            // Kiểm tra xem giá bán nhập vào có đúng định dạng số không
            if (!decimal.TryParse(txtGiaBan.Text, out decimal giaBan))
            {
                MessageBox.Show("Giá bán không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra xem tất cả các trường thông tin đã được nhập đầy đủ
            if (string.IsNullOrWhiteSpace(txtMaSP.Text) || string.IsNullOrWhiteSpace(cbbNCC.Text) || string.IsNullOrWhiteSpace(txtTenSP.Text) || string.IsNullOrWhiteSpace(cbbHangSP.Text) || string.IsNullOrWhiteSpace(cbbXuatxu.Text) || string.IsNullOrWhiteSpace(txtGiaBan.Text) || string.IsNullOrWhiteSpace(cbbTheloai.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Tạo một đối tượng SanPhamDAO và gọi phương thức thêm sản phẩm từ lớp DAO
            SanPhamDAO daoSanPham = new SanPhamDAO();

            // Kiểm tra xem mã sản phẩm đã tồn tại hay chưa
            if (daoSanPham.kiemTraMaSP(sanPham.MaSP))
            {
                MessageBox.Show("Mã sản phẩm đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (daoSanPham.kiemtraMaNCC(sanPham.MaNCC))
            {
                MessageBox.Show("Mã nhà cung cấp không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Tạo một đối tượng SanPhamBUS và gọi phương thức thêm sản phẩm từ lớp BUS
            SanPhamBUS sanPhamBUS = new SanPhamBUS();
            sanPhamBUS.AddSanPham(sanPham);

            // Hiển thị thông báo thành công
            MessageBox.Show("Thêm sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Refresh lại danh sách sản phẩm
            SanPham_Load(sender, e);

        }

        private void btn_sua_Click(object sender, EventArgs e)
        {

        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            try
            {
                SanPhamDTO sanPham = new SanPhamDTO();
               
                SanPhamBUS busSanPham = new SanPhamBUS();
                busSanPham.DeleteSanPham(sanPham);

                // Hiển thị thông báo xóa thành công cho người dùng
                MessageBox.Show("Đã xóa sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Cập nhật giao diện người dùng nếu cần
                // Ví dụ: load lại danh sách sản phẩm sau khi xóa
                SanPham_Load(sender, e);
            }
            catch (Exception ex)
            {
                // Xử lý lỗi nếu có
                MessageBox.Show("Lỗi khi xóa sản phẩm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //hàm kiểm tra 

    }
}
