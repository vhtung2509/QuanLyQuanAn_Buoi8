using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace QuanLyQuanAn.Data
{
    internal class QLQADbcontext : DbContext
    {
        public DbSet<LoaiMonAn> LoaiMonAn { get; set; }
        public DbSet<MonAn> MonAn { get; set; }
        public DbSet<NhanVien> NhanVien { get; set; }
        public DbSet<NguyenLieu> NguyenLieu { get; set; }
        public DbSet<KhachHang> KhachHang { get; set; }
        public virtual DbSet<HoaDon> HoaDon { get; set; }
        public virtual DbSet<HoaDon_ChiTiet> HoaDon_ChiTiet { get; set; }
        public virtual DbSet<BanAn> BanAn { get; set; }
        public DbSet<NhaCungCap> NhaCungCap { get; set; }
        public DbSet<PhieuNhap> PhieuNhap { get; set; }
        public DbSet<ChiTiet_PhieuNhap> ChiTiet_PhieuNhap { get; set; }
        public DbSet<CongThuc> CongThuc { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["QLQAConnection"].ConnectionString);
        }
    }
}