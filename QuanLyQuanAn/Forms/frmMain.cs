using QuanLyQuanAn.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BC = BCrypt.Net.BCrypt;

namespace QuanLyQuanAn.Forms
{
    public partial class frmMain : Form
    {
        QLQADbcontext context = new QLQADbcontext();

        // 1. Khai báo các biến chứa Form con (Để tránh mở 1 form nhiều lần)
        frmLoaiMonAn loaiMonAn = null;
        frmMonAn monAn = null;
        frmKhachHang khachHang = null;
        frmNhanVien nhanVien = null;
        frmHoaDon hoaDon = null;
        frmDangNhap dangNhap = null;

        string hoVaTenNhanVien = "";
        public void ChuaDangNhap()
        {
            mnuDangNhap.Enabled = true;
            mnuDangXuat.Enabled = false;

            mnuLoaiMonAn.Enabled = false;
            mnuMonAn.Enabled = false;
            mnuKhachHang.Enabled = false;
            mnuNhanVien.Enabled = false;
            mnuHoaDon.Enabled = false;

            lblTrangThai.Text = "Chưa đăng nhập.";
        }

        public void QuyenQuanLy()
        {
            mnuDangNhap.Enabled = false;
            mnuDangXuat.Enabled = true;

            mnuLoaiMonAn.Enabled = true;
            mnuMonAn.Enabled = true;
            mnuKhachHang.Enabled = true;
            mnuNhanVien.Enabled = true;
            mnuHoaDon.Enabled = true;

            lblTrangThai.Text = "Quản lý: " + hoVaTenNhanVien;
        }

        public void QuyenNhanVien()
        {
            mnuDangNhap.Enabled = false;
            mnuDangXuat.Enabled = true;

            mnuLoaiMonAn.Enabled = false;
            mnuMonAn.Enabled = false;
            mnuNhanVien.Enabled = false;

            mnuKhachHang.Enabled = true;
            mnuHoaDon.Enabled = true;

            lblTrangThai.Text = "Nhân viên: " + hoVaTenNhanVien;
        }

        private void DangNhap()
        {
        LamLai:
            if (dangNhap == null || dangNhap.IsDisposed)
                dangNhap = new frmDangNhap();

            if (dangNhap.ShowDialog() == DialogResult.OK)
            {
                // Nhớ set Modifiers của 2 TextBox bên frmDangNhap thành Public nhé!
                string tenDangNhap = dangNhap.txtTenDangNhap.Text;
                string matKhau = dangNhap.txtMatKhau.Text;

                if (tenDangNhap.Trim() == "")
                {
                    MessageBox.Show("Tên đăng nhập không được bỏ trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dangNhap.txtTenDangNhap.Focus();
                    goto LamLai;
                }
                else if (matKhau.Trim() == "")
                {
                    MessageBox.Show("Mật khẩu không được bỏ trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dangNhap.txtMatKhau.Focus();
                    goto LamLai;
                }
                else
                {
                    // Tìm nhân viên trong CSDL
                    var nv = context.NhanVien.Where(r => r.TenDangNhap == tenDangNhap).SingleOrDefault();

                    if (nv == null)
                    {
                        MessageBox.Show("Tên đăng nhập không tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        dangNhap.txtTenDangNhap.Focus();
                        goto LamLai;
                    }
                    else
                    {
                        // Kiểm tra mật khẩu mã hóa BCrypt
                        if (BC.Verify(matKhau, nv.MatKhau))
                        {
                            hoVaTenNhanVien = nv.HoVaTen;

                            // Kiểm tra quyền (Quyen = true là Quản lý, false là Nhân viên)
                            if (nv.Quyen == true)
                            {
                                QuyenQuanLy();
                            }
                            else
                            {
                                QuyenNhanVien();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Mật khẩu không chính xác!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            dangNhap.txtMatKhau.Focus();
                            goto LamLai;
                        }
                    }
                }
            }
        }
        public frmMain()
        {
            InitializeComponent();
        }

        private void mnuLoaiMonAn_Click(object sender, EventArgs e)
        {
            if (loaiMonAn == null || loaiMonAn.IsDisposed)
            {
                loaiMonAn = new frmLoaiMonAn();
                loaiMonAn.MdiParent = this;
                loaiMonAn.Show();
            }
            else loaiMonAn.Activate();

        }

        private void mnuMonAn_Click(object sender, EventArgs e)
        {
            if (monAn == null || monAn.IsDisposed)
            {
                monAn = new frmMonAn();
                monAn.MdiParent = this;
                monAn.Show();
            }
            else monAn.Activate();
        }

        private void mnuNhanVien_Click(object sender, EventArgs e)
        {
            if (nhanVien == null || nhanVien.IsDisposed)
            {
                nhanVien = new frmNhanVien();
                nhanVien.MdiParent = this;
                nhanVien.Show();
            }
            else nhanVien.Activate();
        }

        private void mnuKhachHang_Click(object sender, EventArgs e)
        {
            if (khachHang == null || khachHang.IsDisposed)
            {
                khachHang = new frmKhachHang();
                khachHang.MdiParent = this;
                khachHang.Show();
            }
            else khachHang.Activate();
        }

        private void mnuHoaDon_Click(object sender, EventArgs e)
        {
            if (hoaDon == null || hoaDon.IsDisposed)
            {
                hoaDon = new frmHoaDon();
                hoaDon.MdiParent = this;
                hoaDon.Show();
            }
            else hoaDon.Activate();
        }

        private void lblLienKet_Click(object sender, EventArgs e)
        {
            ProcessStartInfo info = new ProcessStartInfo();
            info.FileName = "explorer.exe";
            info.Arguments = "https://fit.agu.edu.vn";
            Process.Start(info);
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            ChuaDangNhap();
            DangNhap();
        }

        private void mnuDangNhap_Click(object sender, EventArgs e)
        {
            DangNhap();
        }

        private void mnuDangXuat_Click(object sender, EventArgs e)
        {
            foreach (Form child in MdiChildren)
            {
                child.Close();
            }

            ChuaDangNhap();
        }

        private void mnuThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}