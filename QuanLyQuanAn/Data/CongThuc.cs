using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanAn.Data
{
    internal class CongThuc
    {
        public int ID { get; set; }
        public int MonAnID { get; set; }
        public virtual MonAn MonAn { get; set; }
        public int NguyenLieuID { get; set; }
        public virtual NguyenLieu NguyenLieu { get; set; }
        public double HamLuong { get; set; }
        public string DonViTinh { get; set; }
    }
}
