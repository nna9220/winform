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
    public partial class FormKho : Form
    {
        int parentIndex;
        string err;
        KhoBUS dbK = new KhoBUS();
        public FormKho()
        {
            InitializeComponent();
            
        }
        
        //Thêm
        public void LoadData()
        {
            try
            {
                dgvKho.DataSource = dbK.LaySachTrongKho();
                dgvKho.AutoResizeColumns();

            }
            catch
            {
                MessageBox.Show("Không truy xuất được dữ liệu!", "Lỗi");
            }
        }
        private void dgvHoaDon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void FormKho_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLNSDataSet9.SACH' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'qLNSDataSet8.SACH' table. You can move, or remove it, as needed.
            this.sACHTableAdapter1.Fill(this.qLNSDataSet8.SACH);
            // TODO: This line of code loads data into the 'qLNSDataSet7.SACH' table. You can move, or remove it, as needed.
            this.sACHTableAdapter.Fill(this.qLNSDataSet7.SACH);
            // TODO: This line of code loads data into the 'qLNSDataSet5.KHO' table. You can move, or remove it, as needed.
            this.kHOTableAdapter.Fill(this.qLNSDataSet5.KHO);
            LoadData();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult tl = MessageBox.Show("Chắc chắn thoát?(Y/N)", "Thông báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (tl == DialogResult.Yes)
                this.Close();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.cmbSua.Text = "";
            this.txtSoluong.Text = "";
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if ((dbK.checkSachKho(this.cmbThem.Text)))
                {
                    dbK.SuaSoLuong(this.cmbSua.Text, this.txtSoluong.Text, ref err);
                    LoadData();
                    MessageBox.Show("Sửa thành công!", "Thông báo");
                }
                else
                    MessageBox.Show("Không có sách này trong kho","Thông báo");
            }
            catch
            {
                MessageBox.Show("Không sửa được", "Thông báo");
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (!(dbK.checkSachKho(this.cmbThem.Text)))
                {
                    dbK.ThemSachVaoKho(this.cmbThem.Text, this.txtSoLuongThem.Text, ref err);
                    LoadData();
                    MessageBox.Show("Thêm thành công!", "Thông báo");
                }
                else
                    MessageBox.Show("Đã có sách này trong kho", "Thông báo");
            }
            catch
            {
                MessageBox.Show("Lỗi. Không thêm được", "Error");
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
        }

        private void cmbTenThem_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {

            try
            {
                if ((dbK.checkSachKho(this.cmbIDXoa.Text)))
                {
                    dbK.XoaSach(this.cmbIDXoa.Text, ref err);
                    LoadData();
                    MessageBox.Show("Thành công", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Sách này không có trong kho!");
                }
            }
            catch
            {
                MessageBox.Show("Không xóa được!", "Error");
            }

        }
    }
}
