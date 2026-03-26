namespace QuanLyQuanAn.Forms
{
    partial class frmCongThuc
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
            groupBox1 = new GroupBox();
            btnThoat = new Button();
            txtChiTietCongThuc = new TextBox();
            cboMonAn = new ComboBox();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnThoat);
            groupBox1.Controls.Add(txtChiTietCongThuc);
            groupBox1.Controls.Add(cboMonAn);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(919, 500);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Công thức chi tiết ";
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(819, 39);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(94, 29);
            btnThoat.TabIndex = 3;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // txtChiTietCongThuc
            // 
            txtChiTietCongThuc.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtChiTietCongThuc.Location = new Point(6, 69);
            txtChiTietCongThuc.Multiline = true;
            txtChiTietCongThuc.Name = "txtChiTietCongThuc";
            txtChiTietCongThuc.ReadOnly = true;
            txtChiTietCongThuc.Size = new Size(907, 419);
            txtChiTietCongThuc.TabIndex = 2;
            // 
            // cboMonAn
            // 
            cboMonAn.FormattingEnabled = true;
            cboMonAn.Location = new Point(132, 35);
            cboMonAn.Name = "cboMonAn";
            cboMonAn.Size = new Size(151, 28);
            cboMonAn.TabIndex = 1;
            cboMonAn.SelectedIndexChanged += cboMonAn_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 43);
            label1.Name = "label1";
            label1.Size = new Size(120, 20);
            label1.TabIndex = 0;
            label1.Text = "Chọn món ăn (*):";
            // 
            // frmCongThuc
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(949, 512);
            Controls.Add(groupBox1);
            Name = "frmCongThuc";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Công Thức Nấu Ăn";
            WindowState = FormWindowState.Maximized;
            Load += frmCongThuc_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private ComboBox cboMonAn;
        private Label label1;
        private TextBox txtChiTietCongThuc;
        private Button btnThoat;
    }
}