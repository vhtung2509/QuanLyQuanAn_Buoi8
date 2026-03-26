using QuanLyQuanAn.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace QuanLyQuanAn.Forms
{
    public partial class frmBanAn : Form
    {
        QLQADbcontext context = new QLQADbcontext();
        bool XuLyThem = false;
        int id;

        public frmBanAn()
        {
            InitializeComponent();
        }

        private void BatTatChucNang(bool giaTri)
        {
            btnLuu.Enabled = giaTri;
            btnHuyBo.Enabled = giaTri;

            txtSoBan.Enabled = giaTri;
            cboTrangThai.Enabled = giaTri;

            btnThem.Enabled = !giaTri;
            btnSua.Enabled = !giaTri;
            btnXoa.Enabled = !giaTri;
        }

        private void frmBanAn_Load(object sender, EventArgs e)
        {
            BatTatChucNang(false);
            dataGridView.AutoGenerateColumns = false;

            if (cboTrangThai.Items.Count == 0)
            {
                cboTrangThai.Items.Add("Trống");
                cboTrangThai.Items.Add("Có khách");
                cboTrangThai.Items.Add("Đã đặt");
            }
            LoadDanhSachBan();
        }

        // TỐI ƯU: GỘP CHUNG LOGIC LOAD DỮ LIỆU VÀ TÌM KIẾM VÀO 1 HÀM
        
        private void HienThiDuLieuLenLuoi(string tuKhoa = "")
        {
            try
            {
                context.ChangeTracker.Clear(); // Refresh data mới nhất
                var query = context.BanAn.ToList().Select(b =>
                {
                    var hdLatest = context.HoaDon.Where(h => h.BanAnID == b.ID).OrderByDescending(h => h.ID).FirstOrDefault();
                    var kh = hdLatest != null ? context.KhachHang.FirstOrDefault(k => k.ID == hdLatest.KhachHangID) : null;

                    return new
                    {
                        ID = b.ID,
                        MaSoBan = b.TenBan,
                        NgayDatBan = (b.TrangThai == "Đã đặt" && hdLatest != null) ? (DateTime?)hdLatest.NgayLap : null,
                        HoTenKhachHang = (b.TrangThai == "Đã đặt" && kh != null) ? kh.HoVaTen : "",
                        SoDienThoai = (b.TrangThai == "Đã đặt" && kh != null) ? kh.DienThoai : "",
                        TrangThai = b.TrangThai,
                        GhiChu = (b.TrangThai == "Đã đặt" && hdLatest != null) ? hdLatest.GhiChuHoaDon : ""
                    };
                });

                // Nếu có từ khóa thì lọc (Tìm kiếm)
                if (!string.IsNullOrEmpty(tuKhoa))
                {
                    query = query.Where(b =>
                        b.MaSoBan.ToLower().Contains(tuKhoa) ||
                        (b.HoTenKhachHang != null && b.HoTenKhachHang.ToLower().Contains(tuKhoa)) ||
                        (b.SoDienThoai != null && b.SoDienThoai.Contains(tuKhoa))
                    );
                }

                // Sắp xếp chuẩn theo số (Bàn 2 đứng trước Bàn 10)
                var dsBan = query.OrderBy(b =>
                {
                    string so = new String(b.MaSoBan.Where(Char.IsDigit).ToArray());
                    int.TryParse(so, out int ketQua);
                    return ketQua;
                }).ToList();

                // Báo lỗi nếu tìm không ra
                if (dsBan.Count == 0 && !string.IsNullOrEmpty(tuKhoa))
                {
                    MessageBox.Show("Không tìm thấy kết quả nào phù hợp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HienThiDuLieuLenLuoi(""); // Reset về không từ khóa
                    return;
                }

                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = dsBan;

                // --- DATA BINDING ---
                txtSoBan.DataBindings.Clear();
                txtSoBan.DataBindings.Add("Text", bindingSource, "MaSoBan", false, DataSourceUpdateMode.Never);

                cboTrangThai.DataBindings.Clear();
                cboTrangThai.DataBindings.Add("Text", bindingSource, "TrangThai", false, DataSourceUpdateMode.Never);

                txtHoTenKhachHang.DataBindings.Clear();
                txtHoTenKhachHang.DataBindings.Add("Text", bindingSource, "HoTenKhachHang", false, DataSourceUpdateMode.Never);

                txtSoDienThoai.DataBindings.Clear();
                txtSoDienThoai.DataBindings.Add("Text", bindingSource, "SoDienThoai", false, DataSourceUpdateMode.Never);

                txtGhiChu.DataBindings.Clear();
                txtGhiChu.DataBindings.Add("Text", bindingSource, "GhiChu", false, DataSourceUpdateMode.Never);

                dataGridView.DataSource = bindingSource;
                DinhDangLuoi();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi load dữ liệu: " + ex.Message);
            }
        }

        private void LoadDanhSachBan()
        {
            HienThiDuLieuLenLuoi(""); // Mặc định không có từ khóa
        }

        private void DinhDangLuoi()
        {
            if (dataGridView.Columns.Count >= 6)
            {
                dataGridView.Columns[0].DataPropertyName = "ID";
                dataGridView.Columns[1].DataPropertyName = "MaSoBan";
                dataGridView.Columns[2].DataPropertyName = "NgayDatBan";
                dataGridView.Columns[3].DataPropertyName = "HoTenKhachHang";
                dataGridView.Columns[4].DataPropertyName = "SoDienThoai";
                dataGridView.Columns[5].DataPropertyName = "TrangThai";

                dataGridView.Columns[0].Visible = false; // Ẩn ID
            }

            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Xóa event cũ trước khi gán để tránh lỗi chớp nháy lưới (Memory leak)
            dataGridView.CellFormatting -= DataGridView_CellFormatting;
            dataGridView.CellFormatting += DataGridView_CellFormatting;
        }

        private void DataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 5 && e.Value != null)
            {
                string tt = e.Value.ToString();
                if (tt == "Có khách") { e.CellStyle.ForeColor = Color.Red; e.CellStyle.Font = new Font(dataGridView.Font, FontStyle.Bold); }
                else if (tt == "Đã đặt") e.CellStyle.ForeColor = Color.Orange;
                else e.CellStyle.ForeColor = Color.Green;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            XuLyThem = true;
            BatTatChucNang(true);
            txtSoBan.Clear();
            cboTrangThai.SelectedIndex = 0; // Mặc định Trống
            txtSoBan.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow == null) return;
            XuLyThem = false;
            BatTatChucNang(true);
            id = Convert.ToInt32(dataGridView.CurrentRow.Cells[0].Value.ToString());
            txtSoBan.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow == null) return;
            string tenBan = txtSoBan.Text;

            if (MessageBox.Show("Xác nhận xóa " + tenBan + "?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    id = Convert.ToInt32(dataGridView.CurrentRow.Cells[0].Value.ToString());
                    BanAn ban = context.BanAn.Find(id);
                    if (ban != null)
                    {
                        if (ban.TrangThai != "Trống")
                        {
                            MessageBox.Show("Không thể xóa bàn đang có khách hoặc đã được đặt!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        context.BanAn.Remove(ban);
                        context.SaveChanges();
                    }
                    LoadDanhSachBan();
                }
                catch
                {
                    MessageBox.Show("Không thể xóa bàn này vì đã có dữ liệu hóa đơn liên quan!", "Lỗi");
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string tenBanMoi = txtSoBan.Text.Trim();
            if (string.IsNullOrWhiteSpace(tenBanMoi))
            {
                MessageBox.Show("Vui lòng nhập số bàn!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSoBan.Focus();
                return;
            }

            try
            {
                // TỐI ƯU: Kiểm tra trùng tên bàn
                bool trungTen = XuLyThem ? context.BanAn.Any(b => b.TenBan.ToLower() == tenBanMoi.ToLower())
                                         : context.BanAn.Any(b => b.TenBan.ToLower() == tenBanMoi.ToLower() && b.ID != id);

                if (trungTen)
                {
                    MessageBox.Show("Số bàn này đã tồn tại! Vui lòng nhập số khác.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtSoBan.Focus();
                    return;
                }

                if (XuLyThem)
                {
                    BanAn ban = new BanAn();
                    ban.TenBan = tenBanMoi;
                    ban.TrangThai = string.IsNullOrWhiteSpace(cboTrangThai.Text) ? "Trống" : cboTrangThai.Text;
                    context.BanAn.Add(ban);
                }
                else
                {
                    BanAn ban = context.BanAn.Find(id);
                    if (ban != null)
                    {
                        ban.TenBan = tenBanMoi;
                        ban.TrangThai = cboTrangThai.Text;
                    }
                }
                context.SaveChanges();
                MessageBox.Show("Lưu dữ liệu bàn thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BatTatChucNang(false);
                LoadDanhSachBan();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu: " + ex.Message);
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            BatTatChucNang(false);
            LoadDanhSachBan();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnDatBan_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn một bàn để đặt!", "Thông báo");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtHoTenKhachHang.Text))
            {
                MessageBox.Show("Vui lòng nhập Tên khách hàng để đặt bàn!", "Cảnh báo");
                txtHoTenKhachHang.Focus();
                return;
            }

            // TỐI ƯU: Ràng buộc số điện thoại hợp lệ (ít nhất 10 số)
            if (string.IsNullOrWhiteSpace(txtSoDienThoai.Text) || txtSoDienThoai.Text.Length < 10)
            {
                MessageBox.Show("Vui lòng nhập đúng Số điện thoại khách hàng (từ 10 số trở lên)!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoDienThoai.Focus();
                return;
            }

            string tenKhach = txtHoTenKhachHang.Text.Trim();
            string sdtKhach = txtSoDienThoai.Text.Trim();
            DateTime ngayDat = dtpNgayDatBan.Value;
            string ghiChu = txtGhiChu.Text.Trim();

            try
            {
                int idBan = Convert.ToInt32(dataGridView.CurrentRow.Cells[0].Value);
                var ban = context.BanAn.Find(idBan);

                if (ban != null)
                {
                    if (ban.TrangThai == "Có khách" || ban.TrangThai == "Đã đặt")
                    {
                        MessageBox.Show("Bàn này đã được đặt hoặc đang có khách ngồi!", "Cảnh báo");
                        return;
                    }

                    var kh = context.KhachHang.FirstOrDefault(k => k.DienThoai == sdtKhach);
                    if (kh == null)
                    {
                        kh = new KhachHang { HoVaTen = tenKhach, DienThoai = sdtKhach, DiaChi = "" };
                        context.KhachHang.Add(kh);
                        context.SaveChanges();
                    }

                    HoaDon hd = new HoaDon
                    {
                        BanAnID = ban.ID,
                        KhachHangID = kh.ID,
                        NhanVienID = 1, // Tạm gắn Admin
                        NgayLap = ngayDat,
                        GhiChuHoaDon = ghiChu
                    };
                    context.HoaDon.Add(hd);

                    ban.TrangThai = "Đã đặt";
                    context.SaveChanges();

                    MessageBox.Show($"Đã đặt chỗ thành công cho khách {tenKhach} tại {ban.TenBan}!", "Thành công");
                    LoadDanhSachBan();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi đặt bàn: " + ex.Message);
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string tuKhoa = txtSoBan.Text.Trim().ToLower();
            if (string.IsNullOrEmpty(tuKhoa))
            {
                tuKhoa = txtHoTenKhachHang.Text.Trim().ToLower();
            }
            HienThiDuLieuLenLuoi(tuKhoa);
        }

        private void txtSoBan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtSoDienThoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}