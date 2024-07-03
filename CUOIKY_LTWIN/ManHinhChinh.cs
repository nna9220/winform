using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CUOIKY_LTWIN
{
    public partial class ManHinhChinh : Form
    {
        public ManHinhChinh()
        {
            InitializeComponent();
        }

        private void tsSach_Click(object sender, EventArgs e)
        {
            FormSach add = new FormSach();
            this.Hide();
            add.ShowDialog();
            this.Show();
        }

        private void tsLinhVuc_Click(object sender, EventArgs e)
        {
            formLinhVuc add = new formLinhVuc();
            this.Hide();
            add.ShowDialog();
            this.Show();
        }

        private void tsLoaiSach_Click(object sender, EventArgs e)
        {
            FormTheLoai add = new FormTheLoai();
            this.Hide();
            add.ShowDialog();
            this.Show();
        }

        private void tsTacGia_Click(object sender, EventArgs e)
        {
            FormTacGia add = new FormTacGia();
            this.Hide();
            add.ShowDialog();
            this.Show();
        }

        private void tsNXB_Click(object sender, EventArgs e)
        {
            formNhaXuatBan add = new formNhaXuatBan();
            this.Hide();
            add.ShowDialog();
            this.Show();
        }

        private void tsHoaDon_Click(object sender, EventArgs e)
        {
            FormHoaDon add = new FormHoaDon();
            this.Hide();
            add.ShowDialog();
            this.Show();
        }

        private void tsNhanVien_Click(object sender, EventArgs e)
        {
            FormNhanVien add = new FormNhanVien();
            this.Hide();
            add.ShowDialog();
            this.Show();
        }

        private void tsiDangXuat_Click(object sender, EventArgs e)
        {
            DialogResult tl = MessageBox.Show("Bạn có chắc thoát?(Y/N)",
                "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (tl == DialogResult.Yes)
                Application.Exit();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            FormKho add = new FormKho();
            this.Hide();
            add.ShowDialog();
            this.Show();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            FormNhanVien add = new FormNhanVien();
            this.Hide();
            add.ShowDialog();
            this.Show();
        }
    }
}
