using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanAn.Data
{
    internal class ChiTiet_PhieuNhap
    {
        public int ID { get; set; }
        public int PhieuNhapID { get; set; }
        public virtual PhieuNhap PhieuNhap { get; set; }
        public int NguyenLieuID { get; set; }
        public virtual NguyenLieu NguyenLieu { get; set; }
        public double SoLuong { get; set; }
        public decimal DonGia { get; set; }
    }
}
