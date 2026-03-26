namespace QuanLyQuanAn.Forms
{
    partial class frmBanAn
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            groupBox1 = new GroupBox();
            btnLuu = new Button();
            btnTimKiem = new Button();
            label6 = new Label();
            txtGhiChu = new TextBox();
            dtpNgayDatBan = new DateTimePicker();
            label5 = new Label();
            txtSoDienThoai = new TextBox();
            txtHoTenKhachHang = new TextBox();
            label4 = new Label();
            label3 = new Label();
            cboTrangThai = new ComboBox();
            btnDatBan = new Button();
            btnHuyBo = new Button();
            btnThoat = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            txtSoBan = new TextBox();
            groupBox2 = new GroupBox();
            dataGridView = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            MaSoBan = new DataGridViewTextBoxColumn();
            NgayDatBan = new DataGridViewTextBoxColumn();
            HoVaTenKhachHang = new DataGridViewTextBoxColumn();
            SoDienThoai = new DataGridViewTextBoxColumn();
            TrangThai = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 46);
            label1.Name = "label1";
            label1.Size = new Size(78, 20);
            label1.TabIndex = 0;
            label1.Text = "Số bàn (*):";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 107);
            label2.Name = "label2";
            label2.Size = new Size(98, 20);
            label2.TabIndex = 1;
            label2.Text = "Trạng thái (*):";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnLuu);
            groupBox1.Controls.Add(btnTimKiem);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtGhiChu);
            groupBox1.Controls.Add(dtpNgayDatBan);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtSoDienThoai);
            groupBox1.Controls.Add(txtHoTenKhachHang);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(cboTrangThai);
            groupBox1.Controls.Add(btnDatBan);
            groupBox1.Controls.Add(btnHuyBo);
            groupBox1.Controls.Add(btnThoat);
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(btnSua);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Controls.Add(txtSoBan);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1119, 197);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Danh sách bàn ăn";
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(1019, 103);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(94, 29);
            btnLuu.TabIndex = 20;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(819, 154);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(94, 29);
            btnTimKiem.TabIndex = 19;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(344, 163);
            label6.Name = "label6";
            label6.Size = new Size(81, 20);
            label6.TabIndex = 18;
            label6.Text = "Ghi chú (*):";
            // 
            // txtGhiChu
            // 
            txtGhiChu.Location = new Point(499, 156);
            txtGhiChu.Name = "txtGhiChu";
            txtGhiChu.Size = new Size(225, 27);
            txtGhiChu.TabIndex = 17;
            // 
            // dtpNgayDatBan
            // 
            dtpNgayDatBan.CustomFormat = "dd/MM/yy";
            dtpNgayDatBan.Format = DateTimePickerFormat.Custom;
            dtpNgayDatBan.Location = new Point(134, 158);
            dtpNgayDatBan.MaxDate = new DateTime(2100, 12, 31, 0, 0, 0, 0);
            dtpNgayDatBan.MinDate = new DateTime(2026, 1, 1, 0, 0, 0, 0);
            dtpNgayDatBan.Name = "dtpNgayDatBan";
            dtpNgayDatBan.Size = new Size(172, 27);
            dtpNgayDatBan.TabIndex = 16;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 163);
            label5.Name = "label5";
            label5.Size = new Size(122, 20);
            label5.TabIndex = 15;
            label5.Text = "Ngày đặt bàn (*):";
            // 
            // txtSoDienThoai
            // 
            txtSoDienThoai.Location = new Point(499, 99);
            txtSoDienThoai.Name = "txtSoDienThoai";
            txtSoDienThoai.Size = new Size(225, 27);
            txtSoDienThoai.TabIndex = 14;
            txtSoDienThoai.KeyPress += txtSoDienThoai_KeyPress;
            // 
            // txtHoTenKhachHang
            // 
            txtHoTenKhachHang.Location = new Point(499, 37);
            txtHoTenKhachHang.Name = "txtHoTenKhachHang";
            txtHoTenKhachHang.Size = new Size(225, 27);
            txtHoTenKhachHang.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(331, 107);
            label4.Name = "label4";
            label4.Size = new Size(162, 20);
            label4.TabIndex = 12;
            label4.Text = "Số điện thoại khách (*):";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(331, 46);
            label3.Name = "label3";
            label3.Size = new Size(156, 20);
            label3.TabIndex = 11;
            label3.Text = "Họ tên khách hàng (*):";
            // 
            // cboTrangThai
            // 
            cboTrangThai.FormattingEnabled = true;
            cboTrangThai.Location = new Point(134, 99);
            cboTrangThai.Name = "cboTrangThai";
            cboTrangThai.Size = new Size(172, 28);
            cboTrangThai.TabIndex = 10;
            // 
            // btnDatBan
            // 
            btnDatBan.Location = new Point(919, 154);
            btnDatBan.Name = "btnDatBan";
            btnDatBan.Size = new Size(94, 29);
            btnDatBan.TabIndex = 9;
            btnDatBan.Text = "Đặt bàn";
            btnDatBan.UseVisualStyleBackColor = true;
            btnDatBan.Click += btnDatBan_Click;
            // 
            // btnHuyBo
            // 
            btnHuyBo.Location = new Point(1019, 37);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.Size = new Size(94, 29);
            btnHuyBo.TabIndex = 8;
            btnHuyBo.Text = "Hủy bỏ";
            btnHuyBo.UseVisualStyleBackColor = true;
            btnHuyBo.Click += btnHuyBo_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(919, 103);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(94, 29);
            btnThoat.TabIndex = 7;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(919, 38);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 6;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(819, 103);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 29);
            btnSua.TabIndex = 5;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(819, 39);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 4;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // txtSoBan
            // 
            txtSoBan.Location = new Point(134, 37);
            txtSoBan.Name = "txtSoBan";
            txtSoBan.Size = new Size(172, 27);
            txtSoBan.TabIndex = 2;
            txtSoBan.KeyPress += txtSoBan_KeyPress;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView);
            groupBox2.Location = new Point(12, 215);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1119, 223);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin bàn ăn";
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { ID, MaSoBan, NgayDatBan, HoVaTenKhachHang, SoDienThoai, TrangThai });
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.Location = new Point(3, 23);
            dataGridView.MultiSelect = false;
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersVisible = false;
            dataGridView.RowHeadersWidth = 51;
            dataGridView.Size = new Size(1113, 197);
            dataGridView.TabIndex = 0;
            // 
            // ID
            // 
            ID.DataPropertyName = "ID";
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            // 
            // MaSoBan
            // 
            MaSoBan.DataPropertyName = "MaSoBan";
            MaSoBan.HeaderText = "Mã số bàn";
            MaSoBan.MinimumWidth = 6;
            MaSoBan.Name = "MaSoBan";
            // 
            // NgayDatBan
            // 
            NgayDatBan.DataPropertyName = "NgayDatBan";
            NgayDatBan.HeaderText = "Ngày đặt bàn";
            NgayDatBan.MinimumWidth = 6;
            NgayDatBan.Name = "NgayDatBan";
            // 
            // HoVaTenKhachHang
            // 
            HoVaTenKhachHang.DataPropertyName = "HoVaTenKhachHang";
            HoVaTenKhachHang.HeaderText = "Họ và tên khách hàng";
            HoVaTenKhachHang.MinimumWidth = 6;
            HoVaTenKhachHang.Name = "HoVaTenKhachHang";
            // 
            // SoDienThoai
            // 
            SoDienThoai.DataPropertyName = "SoDienThoai";
            SoDienThoai.HeaderText = "Số điện thoại";
            SoDienThoai.MinimumWidth = 6;
            SoDienThoai.Name = "SoDienThoai";
            // 
            // TrangThai
            // 
            TrangThai.DataPropertyName = "TrangThai";
            TrangThai.HeaderText = "Trạng thái";
            TrangThai.MinimumWidth = 6;
            TrangThai.Name = "TrangThai";
            // 
            // frmBanAn
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 450);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "frmBanAn";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bàn Ăn";
            WindowState = FormWindowState.Maximized;
            Load += frmBanAn_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private GroupBox groupBox1;
        private Button btnDatBan;
        private Button btnHuyBo;
        private Button btnThoat;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private TextBox txtSoBan;
        private GroupBox groupBox2;
        private DataGridView dataGridView;
        private TextBox txtSoDienThoai;
        private TextBox txtHoTenKhachHang;
        private Label label4;
        private Label label3;
        private ComboBox cboTrangThai;
        private DateTimePicker dtpNgayDatBan;
        private Label label5;
        private Label label6;
        private TextBox txtGhiChu;
        private Button btnTimKiem;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn MaSoBan;
        private DataGridViewTextBoxColumn NgayDatBan;
        private DataGridViewTextBoxColumn HoVaTenKhachHang;
        private DataGridViewTextBoxColumn SoDienThoai;
        private DataGridViewTextBoxColumn TrangThai;
        private Button btnLuu;
    }
}