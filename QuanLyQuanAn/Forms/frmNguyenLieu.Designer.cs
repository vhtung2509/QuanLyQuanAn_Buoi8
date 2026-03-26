namespace QuanLyQuanAn.Forms
{
    partial class frmNguyenLieu
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
            groupBox1 = new GroupBox();
            btnLuu = new Button();
            btnTimKiem = new Button();
            btnHuyBo = new Button();
            btnThoat = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            cboDonViTinh = new ComboBox();
            txtSoLuongTon = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            txtGhiChu = new TextBox();
            txtTenNguyenLieu = new TextBox();
            groupBox2 = new GroupBox();
            dataGridView = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            TenNguyenLieu = new DataGridViewTextBoxColumn();
            DonViTinh = new DataGridViewTextBoxColumn();
            SoLuongTon = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 50);
            label1.Name = "label1";
            label1.Size = new Size(135, 20);
            label1.TabIndex = 0;
            label1.Text = "Tên nguyên liệu (*):";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnLuu);
            groupBox1.Controls.Add(btnTimKiem);
            groupBox1.Controls.Add(btnHuyBo);
            groupBox1.Controls.Add(btnThoat);
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(btnSua);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Controls.Add(cboDonViTinh);
            groupBox1.Controls.Add(txtSoLuongTon);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtGhiChu);
            groupBox1.Controls.Add(txtTenNguyenLieu);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(967, 192);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin nguyên liệu";
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(845, 90);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(94, 29);
            btnLuu.TabIndex = 28;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(745, 140);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(94, 29);
            btnTimKiem.TabIndex = 27;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // btnHuyBo
            // 
            btnHuyBo.Location = new Point(845, 39);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.Size = new Size(94, 29);
            btnHuyBo.TabIndex = 25;
            btnHuyBo.Text = "Hủy bỏ";
            btnHuyBo.UseVisualStyleBackColor = true;
            btnHuyBo.Click += btnHuyBo_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(745, 92);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(94, 29);
            btnThoat.TabIndex = 24;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(745, 40);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 23;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(645, 92);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 29);
            btnSua.TabIndex = 22;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(645, 41);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 21;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // cboDonViTinh
            // 
            cboDonViTinh.FormattingEnabled = true;
            cboDonViTinh.Location = new Point(457, 42);
            cboDonViTinh.Name = "cboDonViTinh";
            cboDonViTinh.Size = new Size(151, 28);
            cboDonViTinh.TabIndex = 9;
            // 
            // txtSoLuongTon
            // 
            txtSoLuongTon.Location = new Point(455, 88);
            txtSoLuongTon.Name = "txtSoLuongTon";
            txtSoLuongTon.Size = new Size(153, 27);
            txtSoLuongTon.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(333, 95);
            label5.Name = "label5";
            label5.Size = new Size(118, 20);
            label5.TabIndex = 7;
            label5.Text = "Số lượng tồn (*):";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(333, 50);
            label4.Name = "label4";
            label4.Size = new Size(104, 20);
            label4.TabIndex = 6;
            label4.Text = "Đơn vị tính (*):";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 96);
            label3.Name = "label3";
            label3.Size = new Size(81, 20);
            label3.TabIndex = 5;
            label3.Text = "Ghi chú (*):";
            // 
            // txtGhiChu
            // 
            txtGhiChu.Location = new Point(147, 88);
            txtGhiChu.Name = "txtGhiChu";
            txtGhiChu.Size = new Size(153, 27);
            txtGhiChu.TabIndex = 4;
            // 
            // txtTenNguyenLieu
            // 
            txtTenNguyenLieu.Location = new Point(147, 43);
            txtTenNguyenLieu.Name = "txtTenNguyenLieu";
            txtTenNguyenLieu.Size = new Size(153, 27);
            txtTenNguyenLieu.TabIndex = 1;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView);
            groupBox2.Location = new Point(12, 228);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(967, 210);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách nguyên liệu";
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { ID, TenNguyenLieu, DonViTinh, SoLuongTon });
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.Location = new Point(3, 23);
            dataGridView.MultiSelect = false;
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersVisible = false;
            dataGridView.RowHeadersWidth = 51;
            dataGridView.Size = new Size(961, 184);
            dataGridView.TabIndex = 0;
            // 
            // ID
            // 
            ID.DataPropertyName = "ID";
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            // 
            // TenNguyenLieu
            // 
            TenNguyenLieu.DataPropertyName = "TenNguyenLieu";
            TenNguyenLieu.HeaderText = "Tên nguyên liệu";
            TenNguyenLieu.MinimumWidth = 6;
            TenNguyenLieu.Name = "TenNguyenLieu";
            // 
            // DonViTinh
            // 
            DonViTinh.DataPropertyName = "DonViTinh";
            DonViTinh.HeaderText = "Đơn vị tính";
            DonViTinh.MinimumWidth = 6;
            DonViTinh.Name = "DonViTinh";
            // 
            // SoLuongTon
            // 
            SoLuongTon.DataPropertyName = "SoLuongTon";
            SoLuongTon.HeaderText = "Số lượng tồn";
            SoLuongTon.MinimumWidth = 6;
            SoLuongTon.Name = "SoLuongTon";
            // 
            // frmNguyenLieu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(991, 450);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "frmNguyenLieu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nguyên Liệu Món Ăn";
            WindowState = FormWindowState.Maximized;
            Load += frmNguyenLieu_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private ComboBox cboDonViTinh;
        private TextBox txtSoLuongTon;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox txtGhiChu;
        private TextBox txtTenNguyenLieu;
        private Button btnLuu;
        private Button btnTimKiem;
        private Button btnHuyBo;
        private Button btnThoat;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private GroupBox groupBox2;
        private DataGridView dataGridView;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn TenNguyenLieu;
        private DataGridViewTextBoxColumn DonViTinh;
        private DataGridViewTextBoxColumn SoLuongTon;
    }
}