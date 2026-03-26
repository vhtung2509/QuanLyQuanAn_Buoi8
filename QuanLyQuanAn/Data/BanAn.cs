using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanAn.Data
{
    internal class BanAn
    {
        public int ID { get; set; }
        public string TenBan { get; set; } = null!;
        public string TrangThai { get; set; } = null!;

        // Một bàn ăn có thể có nhiều hóa đơn
        public virtual ICollection<HoaDon> HoaDon { get; set; } = new List<HoaDon>();
    }
}