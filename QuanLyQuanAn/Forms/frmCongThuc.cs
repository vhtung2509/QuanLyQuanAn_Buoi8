using QuanLyQuanAn.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanAn.Forms
{
    public partial class frmCongThuc : Form
    {
        QLQADbcontext context = new QLQADbcontext();
        public frmCongThuc()
        {
            InitializeComponent();
        }

        private void HienThiCongThuc()
        {
            if (cboMonAn.SelectedValue == null || !(cboMonAn.SelectedValue is int)) return;

            int idMon = (int)cboMonAn.SelectedValue;

            // Xóa nội dung cũ trong TextBox
            txtChiTietCongThuc.Clear();

            // Lấy danh sách nguyên liệu của món ăn đang chọn
            var dsNguyenLieu = context.CongThuc
                .Where(ct => ct.MonAnID == idMon)
                .Select(ct => new
                {
                    TenNL = ct.NguyenLieu.TenNguyenLieu,
                    SoLuong = ct.HamLuong,
                    DonVi = ct.DonViTinh
                }).ToList();

            // Nếu món này chưa có công thức trong Database
            if (dsNguyenLieu.Count == 0)
            {
                txtChiTietCongThuc.Text = "🍕 Món này hiện tại chưa có công thức hướng dẫn.";
                return;
            }

            // Nếu có, ta bắt đầu ghép chuỗi văn bản cho đẹp
            string noiDung = "THÀNH PHẦN CHUẨN BỊ CHO 1 PHẦN ĂN:\r\n";
            noiDung += "--------------------------------------------------\r\n\r\n";

            foreach (var item in dsNguyenLieu)
            {
                // Ghép theo chuẩn: "- 300 g Thịt bằm"
                noiDung += $"- {item.SoLuong} {item.DonVi} {item.TenNL}\r\n";
            }

            noiDung += "\r\n--------------------------------------------------\r\n";

            // Đổ toàn bộ đoạn văn bản vừa ghép lên TextBox
            txtChiTietCongThuc.Text = noiDung;
        }

        private void frmCongThuc_Load(object sender, EventArgs e)
        {
            // Nạp danh sách món ăn vào ComboBox khi vừa mở Form
            try
            {
                var dsMon = context.MonAn.ToList();
                cboMonAn.DataSource = dsMon;
                cboMonAn.DisplayMember = "TenMon";
                cboMonAn.ValueMember = "ID";

                // Vừa mở lên thì hiển thị luôn công thức của món đầu tiên
                HienThiCongThuc();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void cboMonAn_SelectedIndexChanged(object sender, EventArgs e)
        {
            HienThiCongThuc();
        }
    }
}
