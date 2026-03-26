namespace QuanLyQuanAn.Reports
{
    partial class frmThongKeDoanhThu
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
            dtpTuNgay = new DateTimePicker();
            dtpDenNgay = new DateTimePicker();
            btnLocKetQua = new Button();
            btnHienTatCa = new Button();
            SuspendLayout();
            // 
            // reportViewer
            // 
            reportViewer.Location = new Point(-1, 79);
            reportViewer.Name = "reportViewer";
            reportViewer.ServerReport.BearerToken = null;
            reportViewer.Size = new Size(1031, 369);
            reportViewer.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(322, 14);
            label1.Name = "label1";
            label1.Size = new Size(65, 20);
            label1.TabIndex = 1;
            label1.Text = "Từ ngày:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(322, 51);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 2;
            label2.Text = "Đến ngày:";
            // 
            // dtpTuNgay
            // 
            dtpTuNgay.CustomFormat = "dd/MM/yy";
            dtpTuNgay.Format = DateTimePickerFormat.Custom;
            dtpTuNgay.Location = new Point(403, 9);
            dtpTuNgay.MaxDate = new DateTime(2100, 12, 31, 0, 0, 0, 0);
            dtpTuNgay.MinDate = new DateTime(2024, 1, 1, 0, 0, 0, 0);
            dtpTuNgay.Name = "dtpTuNgay";
            dtpTuNgay.Size = new Size(115, 27);
            dtpTuNgay.TabIndex = 3;
            // 
            // dtpDenNgay
            // 
            dtpDenNgay.CustomFormat = "dd/MM/yy";
            dtpDenNgay.Format = DateTimePickerFormat.Custom;
            dtpDenNgay.Location = new Point(403, 46);
            dtpDenNgay.MaxDate = new DateTime(2100, 12, 31, 0, 0, 0, 0);
            dtpDenNgay.MinDate = new DateTime(2024, 1, 1, 0, 0, 0, 0);
            dtpDenNgay.Name = "dtpDenNgay";
            dtpDenNgay.Size = new Size(115, 27);
            dtpDenNgay.TabIndex = 4;
            // 
            // btnLocKetQua
            // 
            btnLocKetQua.Location = new Point(534, 5);
            btnLocKetQua.Name = "btnLocKetQua";
            btnLocKetQua.Size = new Size(94, 29);
            btnLocKetQua.TabIndex = 5;
            btnLocKetQua.Text = "Lọc kết quả";
            btnLocKetQua.UseVisualStyleBackColor = true;
            btnLocKetQua.Click += btnLocKetQua_Click;
            // 
            // btnHienTatCa
            // 
            btnHienTatCa.Location = new Point(534, 42);
            btnHienTatCa.Name = "btnHienTatCa";
            btnHienTatCa.Size = new Size(94, 29);
            btnHienTatCa.TabIndex = 6;
            btnHienTatCa.Text = "Hiện tất cả";
            btnHienTatCa.UseVisualStyleBackColor = true;
            btnHienTatCa.Click += btnHienTatCa_Click;
            // 
            // frmThongKeDoanhThu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1032, 450);
            Controls.Add(btnHienTatCa);
            Controls.Add(btnLocKetQua);
            Controls.Add(dtpDenNgay);
            Controls.Add(dtpTuNgay);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(reportViewer);
            Name = "frmThongKeDoanhThu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thống kê doanh thu";
            Load += frmThongKeDoanhThu_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer;
        private Label label1;
        private Label label2;
        private DateTimePicker dtpTuNgay;
        private DateTimePicker dtpDenNgay;
        private Button btnLocKetQua;
        private Button btnHienTatCa;
    }
}