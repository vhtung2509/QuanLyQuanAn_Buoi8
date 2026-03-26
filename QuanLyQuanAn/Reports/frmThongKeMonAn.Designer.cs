namespace QuanLyQuanAn.Reports
{
    partial class frmThongKeMonAn
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
            reportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            label1 = new Label();
            label2 = new Label();
            cboLoaiMonAn = new ComboBox();
            txtTrangThai = new TextBox();
            btnLocKetQua = new Button();
            SuspendLayout();
            // 
            // reportViewer
            // 
            reportViewer.Location = new Point(2, 80);
            reportViewer.Name = "reportViewer";
            reportViewer.ServerReport.BearerToken = null;
            reportViewer.Size = new Size(986, 445);
            reportViewer.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(184, 25);
            label1.Name = "label1";
            label1.Size = new Size(94, 20);
            label1.TabIndex = 1;
            label1.Text = "Loại món ăn:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(510, 25);
            label2.Name = "label2";
            label2.Size = new Size(71, 20);
            label2.TabIndex = 2;
            label2.Text = "Tìm món:";
            // 
            // cboLoaiMonAn
            // 
            cboLoaiMonAn.FormattingEnabled = true;
            cboLoaiMonAn.Location = new Point(284, 25);
            cboLoaiMonAn.Name = "cboLoaiMonAn";
            cboLoaiMonAn.Size = new Size(151, 28);
            cboLoaiMonAn.TabIndex = 3;
            // 
            // txtTrangThai
            // 
            txtTrangThai.Location = new Point(594, 26);
            txtTrangThai.Name = "txtTrangThai";
            txtTrangThai.Size = new Size(125, 27);
            txtTrangThai.TabIndex = 4;
            // 
            // btnLocKetQua
            // 
            btnLocKetQua.Location = new Point(760, 26);
            btnLocKetQua.Name = "btnLocKetQua";
            btnLocKetQua.Size = new Size(94, 29);
            btnLocKetQua.TabIndex = 5;
            btnLocKetQua.Text = "Lọc kết quả";
            btnLocKetQua.UseVisualStyleBackColor = true;
            btnLocKetQua.Click += btnLocKetQua_Click;
            // 
            // frmThongKeMonAn
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(990, 465);
            Controls.Add(btnLocKetQua);
            Controls.Add(txtTrangThai);
            Controls.Add(cboLoaiMonAn);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(reportViewer);
            Name = "frmThongKeMonAn";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thống kê món ăn";
            Load += frmThongKeMonAn_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer;
        private Label label1;
        private Label label2;
        private ComboBox cboLoaiMonAn;
        private TextBox txtTrangThai;
        private Button btnLocKetQua;
    }
}