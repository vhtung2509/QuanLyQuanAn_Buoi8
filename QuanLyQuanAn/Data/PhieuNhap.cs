using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanAn.Data
{
    internal class PhieuNhap
    {
        public int ID { get; set; }
        public DateTime NgayNhap { get; set; } = DateTime.Now;
        public decimal TongTien { get; set; }
        public int NhaCungCapID { get; set; }
        public virtual NhaCungCap NhaCungCap { get; set; }
        public int NhanVienID { get; set; }
        public virtual NhanVien NhanVien { get; set; }

        public virtual ICollection<ChiTiet_PhieuNhap> ChiTiet_PhieuNhap { get; set; }
    }
}
