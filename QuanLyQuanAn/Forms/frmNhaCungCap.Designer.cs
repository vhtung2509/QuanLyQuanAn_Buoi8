namespace QuanLyQuanAn.Forms
{
    partial class frmNhaCungCap
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
            DiaChi = new DataGridViewTextBoxColumn();
            btnXuat = new Button();
            btnNhap = new Button();
            btnLuu = new Button();
            btnTimKiem = new Button();
            btnHuyBo = new Button();
            btnThoat = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            TenNCC = new DataGridViewTextBoxColumn();
            ID = new DataGridViewTextBoxColumn();
            dataGridView = new DataGridView();
            SoDienThoai = new DataGridViewTextBoxColumn();
            groupBox2 = new GroupBox();
            txtDiaChi = new TextBox();
            txtSoDienThoai = new TextBox();
            txtNhaCungCap = new TextBox();
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            groupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // DiaChi
            // 
            DiaChi.DataPropertyName = "DiaChi";
            DiaChi.HeaderText = "Địa chỉ ";
            DiaChi.MinimumWidth = 6;
            DiaChi.Name = "DiaChi";
            // 
            // btnXuat
            // 
            btnXuat.Location = new Point(656, 131);
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(94, 29);
            btnXuat.TabIndex = 37;
            btnXuat.Text = "Xuất";
            btnXuat.UseVisualStyleBackColor = true;
            btnXuat.Click += btnXuat_Click;
            // 
            // btnNhap
            // 
            btnNhap.Location = new Point(456, 131);
            btnNhap.Name = "btnNhap";
            btnNhap.Size = new Size(94, 29);
            btnNhap.TabIndex = 36;
            btnNhap.Text = "Nhập";
            btnNhap.UseVisualStyleBackColor = true;
            btnNhap.Click += btnNhap_Click;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(656, 87);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(94, 29);
            btnLuu.TabIndex = 35;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(556, 131);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(94, 29);
            btnTimKiem.TabIndex = 34;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // btnHuyBo
            // 
            btnHuyBo.Location = new Point(656, 39);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.Size = new Size(94, 29);
            btnHuyBo.TabIndex = 33;
            btnHuyBo.Text = "Hủy bỏ";
            btnHuyBo.UseVisualStyleBackColor = true;
            btnHuyBo.Click += btnHuyBo_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(556, 87);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(94, 29);
            btnThoat.TabIndex = 32;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(556, 39);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 31;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(456, 87);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 29);
            btnSua.TabIndex = 30;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(456, 39);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 29;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // TenNCC
            // 
            TenNCC.DataPropertyName = "TenNCC";
            TenNCC.HeaderText = "Tên nhà cung cấp";
            TenNCC.MinimumWidth = 6;
            TenNCC.Name = "TenNCC";
            // 
            // ID
            // 
            ID.DataPropertyName = "ID";
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { ID, TenNCC, SoDienThoai, DiaChi });
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.Location = new Point(3, 23);
            dataGridView.MultiSelect = false;
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersVisible = false;
            dataGridView.RowHeadersWidth = 51;
            dataGridView.Size = new Size(870, 213);
            dataGridView.TabIndex = 0;
            // 
            // SoDienThoai
            // 
            SoDienThoai.DataPropertyName = "SoDienThoai";
            SoDienThoai.HeaderText = "Số điện thoại";
            SoDienThoai.MinimumWidth = 6;
            SoDienThoai.Name = "SoDienThoai";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView);
            groupBox2.Location = new Point(12, 199);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(876, 239);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách nhà cung cấp";
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(159, 131);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(178, 27);
            txtDiaChi.TabIndex = 5;
            // 
            // txtSoDienThoai
            // 
            txtSoDienThoai.Location = new Point(159, 89);
            txtSoDienThoai.Name = "txtSoDienThoai";
            txtSoDienThoai.Size = new Size(178, 27);
            txtSoDienThoai.TabIndex = 4;
            // 
            // txtNhaCungCap
            // 
            txtNhaCungCap.Location = new Point(159, 45);
            txtNhaCungCap.Name = "txtNhaCungCap";
            txtNhaCungCap.Size = new Size(178, 27);
            txtNhaCungCap.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 138);
            label3.Name = "label3";
            label3.Size = new Size(78, 20);
            label3.TabIndex = 2;
            label3.Text = "Địa chỉ (*):";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 48);
            label1.Name = "label1";
            label1.Size = new Size(147, 20);
            label1.TabIndex = 0;
            label1.Text = "Tên nhà cung cấp (*):";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 96);
            label2.Name = "label2";
            label2.Size = new Size(120, 20);
            label2.TabIndex = 1;
            label2.Text = "Số điện thoại (*):";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnXuat);
            groupBox1.Controls.Add(btnNhap);
            groupBox1.Controls.Add(btnLuu);
            groupBox1.Controls.Add(btnTimKiem);
            groupBox1.Controls.Add(btnHuyBo);
            groupBox1.Controls.Add(btnThoat);
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(btnSua);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Controls.Add(txtDiaChi);
            groupBox1.Controls.Add(txtSoDienThoai);
            groupBox1.Controls.Add(txtNhaCungCap);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(876, 169);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin nhà cung cấp";
            // 
            // frmNhaCungCap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(913, 450);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "frmNhaCungCap";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nhà Cung Cấp Nguyên Liệu";
            WindowState = FormWindowState.Maximized;
            Load += frmNhaCungCap_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridViewTextBoxColumn DiaChi;
        private Button btnXuat;
        private Button btnNhap;
        private Button btnLuu;
        private Button btnTimKiem;
        private Button btnHuyBo;
        private Button btnThoat;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private DataGridViewTextBoxColumn TenNCC;
        private DataGridViewTextBoxColumn ID;
        private DataGridView dataGridView;
        private DataGridViewTextBoxColumn SoDienThoai;
        private GroupBox groupBox2;
        private TextBox txtDiaChi;
        private TextBox txtSoDienThoai;
        private TextBox txtNhaCungCap;
        private Label label3;
        private Label label1;
        private Label label2;
        private GroupBox groupBox1;
    }
}