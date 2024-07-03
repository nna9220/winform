using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogicLayer;
namespace CUOIKY_LTWIN
{
    public partial class FormNhanVien : Form
    {
        
        string err;
        NhanVienBUS dbnv = new NhanVienBUS();
        public FormNhanVien()
        {
            InitializeComponent();
        }

        public void LoadData()
        {
            try
            {
                dgvNhanVien.DataSource = dbnv.LayNhanVien();
                dgvNhanVien.AutoResizeColumns();
            }
            catch
            {
                MessageBox.Show("Không truy xuất được dữ liệu!", "Lỗi");
            }

        }

        private void FormNhanVien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLNSDataSet2.NHANVIEN' table. You can move, or remove it, as needed.
            this.nHANVIENTableAdapter.Fill(this.qLNSDataSet2.NHANVIEN);
            LoadData();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            FormThemNhanVien add = new FormThemNhanVien();
            this.Hide();
            add.ShowDialog();
            this.Show();
            LoadData();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            FormSuaNhanVien add = new FormSuaNhanVien();
            this.Hide();
            add.ShowDialog();
            this.Show();
            LoadData();
        }

        private void Thoát_Click(object sender, EventArgs e)
        {
            DialogResult tl = MessageBox.Show("Bạn có chắc muốn thoát?(Y/N)", "Thông báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (tl == DialogResult.Yes)
                this.Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if(dbnv.checkNhanVien(this.cmbXoa.Text))
                {
                    dbnv.XoaNhanVien(this.cmbXoa.Text, ref err);
                    MessageBox.Show("Xóa thành công!", "Thông báo");
                    LoadData();
                }
                else
                    MessageBox.Show("Không có trong bảng NHANVIEN","Thông báo");
            }
            catch
            {
                MessageBox.Show("Không xóa được!", "Thông báo");
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
    }
}
