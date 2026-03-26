using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanAn.Data
{
    internal class NhaCungCap
    {
        public int ID { get; set; }
        public string TenNCC { get; set; }
         public string SoDienThoai { get; set; }
        public string DiaChi { get; set; }
        public virtual ICollection<PhieuNhap> PhieuNhap { get; set; }
    }
}
