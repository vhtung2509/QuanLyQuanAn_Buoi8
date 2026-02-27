using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanAn.Data
{
    internal class MonAn
    {
        public int ID { get; set; }
        public int LoaiMonAnID { get; set; }
        public int TenMon { get; set; }
        public int DonGia { get; set; }
        public string? MoTa { get; set; }
        public string? HinhAnh { get; set; }
        public virtual LoaiMonAn LoaiMonAn { get; set; } = null;
    }
}
