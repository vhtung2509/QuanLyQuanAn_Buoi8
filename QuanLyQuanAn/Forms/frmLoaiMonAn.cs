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
    public partial class frmLoaiMonAn : Form
    {
        QLQADbcontext context = new QLQADbcontext(); // Khởi tạo biến ngữ cảnh CSDL
        bool xuLyThem = false; // Kiểm tra có nhấn vào nút Thêm hay không?
        int id; // Lấy mã loại món ăn (dùng cho Sửa và Xóa)
        public frmLoaiMonAn()
        {
            InitializeComponent();
        }
        private void BatTatChucNang(bool giaTri)
        {
            btnLuu.Enabled = giaTri;
            btnHuyBo.Enabled = giaTri;
            txtTenLoai.Enabled = giaTri;

            btnThem.Enabled = !giaTri;
            btnSua.Enabled = !giaTri;
            btnXoa.Enabled = !giaTri;
        }

        private void frmLoaiMonAn_Load(object sender, EventArgs e)
        {
            BatTatChucNang(false);

            List<LoaiMonAn> lma = new List<LoaiMonAn>();
            lma = context.LoaiMonAn.ToList();

            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = lma;

            txtTenLoai.DataBindings.Clear();
            // Tên thuộc tính vẫn là "TenLoai" giống trong class LoaiMonAn của bạn
            txtTenLoai.DataBindings.Add("Text", bindingSource, "TenLoai", false, DataSourceUpdateMode.Never);

            dataGridView.DataSource = bindingSource;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            xuLyThem = true;
            BatTatChucNang(true);
            txtTenLoai.Clear();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            xuLyThem = false;
            BatTatChucNang(true);
            id = Convert.ToInt32(dataGridView.CurrentRow.Cells["ID"].Value.ToString());
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận xóa loại món ăn này?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                id = Convert.ToInt32(dataGridView.CurrentRow.Cells["ID"].Value.ToString());

                LoaiMonAn lma = context.LoaiMonAn.Find(id);

                if (lma != null)
                {
                    context.LoaiMonAn.Remove(lma);
                }
                context.SaveChanges();

                frmLoaiMonAn_Load(sender, e);
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            frmLoaiMonAn_Load(sender, e);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenLoai.Text))
                MessageBox.Show("Vui lòng nhập tên loại món ăn?", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (xuLyThem)
                {
                    LoaiMonAn lma = new LoaiMonAn();
                    lma.TenLoai = txtTenLoai.Text;
                    context.LoaiMonAn.Add(lma);

                    context.SaveChanges();
                }
                else
                {
                    LoaiMonAn lma = context.LoaiMonAn.Find(id);
                    if (lma != null)
                    {
                        lma.TenLoai = txtTenLoai.Text;
                        context.LoaiMonAn.Update(lma);

                        context.SaveChanges();
                    }
                }
                frmLoaiMonAn_Load(sender, e);
            }
        }
    }
}
