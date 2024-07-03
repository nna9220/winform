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
    public partial class FormSach : Form
    {
        string err;
        SachBUS dbs = new SachBUS();
        public FormSach()
        {
            InitializeComponent();
        }
        public void LoadData()
        {
            try
            {
                dgvSach.DataSource = dbs.getSachToDGV(txtTim.Text);
                dgvSach.AutoResizeColumns();
            }
            catch
            {
                MessageBox.Show("Không truy xuất được dữ liệu!", "Lỗi");
            }
        }
        public void LoadData1()
        {
            try
            {
                dgvSach.DataSource = dbs.getSachToDGV1(txtTim.Text);
                dgvSach.AutoResizeColumns();
            }
            catch
            {
                MessageBox.Show("Không truy xuất được dữ liệu!", "Lỗi");
            }
        }
        public void LoadData2()
        {
            try
            {
                dgvSach.DataSource = dbs.getSachToDGV2(txtTim.Text);
                dgvSach.AutoResizeColumns();
            }
            catch
            {
                MessageBox.Show("Không truy xuất được dữ liệu!", "Lỗi");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult tl = MessageBox.Show("Bạn chắc không?(Y/N)", "Thông báo", MessageBoxButtons.YesNo,
               MessageBoxIcon.Question);
            if (tl == DialogResult.Yes)
                this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            FormThemSach add = new FormThemSach();
            this.Hide();
            add.ShowDialog();
            this.Show();
            LoadData();
        }

        private void FormSach_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLNSDataSet13.LOAISACH' table. You can move, or remove it, as needed.
            this.lOAISACHTableAdapter.Fill(this.qLNSDataSet13.LOAISACH);
            // TODO: This line of code loads data into the 'qLNSDataSet1.LINHVUC' table. You can move, or remove it, as needed.
            this.lINHVUCTableAdapter1.Fill(this.qLNSDataSet1.LINHVUC);
            // TODO: This line of code loads data into the 'qLNSDataSet.LINHVUC' table. You can move, or remove it, as needed.
            this.lINHVUCTableAdapter.Fill(this.qLNSDataSet.LINHVUC);
            // TODO: This line of code loads data into the 'qLNSDataSet2.SACH' table. You can move, or remove it, as needed.
            this.sACHTableAdapter.Fill(this.qLNSDataSet2.SACH);
            LoadData();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            FormSuaSach add = new FormSuaSach();
            this.Hide();
            add.ShowDialog();
            this.Show();
            LoadData();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if ((dbs.checkSach(this.cmbXoaID.Text)))
                {
                    dbs.XoaSach(ref err, this.cmbXoaID.Text);
                    MessageBox.Show("Xóa thành công!", "Thông báo");
                    LoadData();
                }
                else
                    MessageBox.Show("Không có sách này!", "Thông báo");
            }
            catch
            {
                MessageBox.Show("Không xóa được!", "Error");
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadData();
            LoadData1();
            LoadData2();
        }
    }
}
