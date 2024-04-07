using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class NhanVienDTO
    {
        private string maNV;
        private string tenNV;
        private string sDT;
        private string queQuan;
        private string email;
        private string tentk;
        public NhanVienDTO()
        {

        }
        public NhanVienDTO(string maNV, string tenNV, string sDT, string queQuan, string email, string tentk)
        {
            this.maNV = maNV;
            this.tenNV = tenNV;
            this.sDT = sDT;
            this.queQuan = queQuan;
            this.email = email;
            this.tentk = tentk;
        }

        public string MaNV { get => maNV; set => maNV = value; }
        public string TenNV { get => tenNV; set => tenNV = value; }
        public string SDT { get => sDT; set => sDT = value; }
        public string QueQuan { get => queQuan; set => queQuan = value; }
        public string Email { get => email; set => email = value; }
        public string Tentk { get => tentk; set => tentk = value; }
    }
    

}
