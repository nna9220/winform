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
    public partial class FormChiTietHoaDon : Form
    {
        int i;
        ChiTietHoaDonBUS dbCT = new ChiTietHoaDonBUS();
        string err;
        int giatien,sl;
        public FormChiTietHoaDon()
        {
            InitializeComponent();
            this.txtMaCT.ForeColor = Color.LightGray;
            this.txtMaCT.Text = "ctxxxxx";
            this.txtMaCT.Leave += new System.EventHandler(this.txtMaNV_Leave);
            this.txtMaCT.Enter += new System.EventHandler(this.txtMaNV_Enter);
        }

        private void txtMaNV_Leave(object sender, EventArgs e)
        {
            if (this.txtMaCT.Text == "")
            {
                this.txtMaCT.Text = "ctxxxxx";
                this.txtMaCT.ForeColor = Color.Gray;
            }
        }
        private void txtMaNV_Enter(object sender, EventArgs e)
        {
            if (this.txtMaCT.Text == "ctxxxxx")
            {
                this.txtMaCT.Text = "";
                this.txtMaCT.ForeColor = Color.Black;
            }
        }

        public void LoadData()
        {
            try
            {
                dgvCTHD.DataSource = dbCT.LayCTHD();
                dgvCTHD.AutoResizeColumns();

            }
            catch
            {
                MessageBox.Show("Không truy xuất được dữ liệu!", "Lỗi");
            }
        }

        private void dgvHoaDon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void FormChiTietHoaDon_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLNSDataSet11.NHANVIEN' table. You can move, or remove it, as needed.
            this.nHANVIENTableAdapter1.Fill(this.qLNSDataSet11.NHANVIEN);
            // TODO: This line of code loads data into the 'qLNSDataSet2.NHANVIEN' table. You can move, or remove it, as needed.
            this.nHANVIENTableAdapter.Fill(this.qLNSDataSet2.NHANVIEN);
            // TODO: This line of code loads data into the 'qLNSDataSet2.SACH' table. You can move, or remove it, as needed.
            this.sACHTableAdapter.Fill(this.qLNSDataSet2.SACH);
            // TODO: This line of code loads data into the 'qLNSDataSet2.HOADON' table. You can move, or remove it, as needed.
            this.hOADONTableAdapter.Fill(this.qLNSDataSet2.HOADON);
            LoadData();

        }

        private void btnTinh_Click(object sender, EventArgs e)
        {

            giatien = Convert.ToInt32(this.cmbGiaSach.Text);
            sl = Convert.ToInt32(this.txtSoLuong.Text);
            this.txtTongTien.Text = Convert.ToString(giatien * sl);
        }

        private void btnTinh_Click_1(object sender, EventArgs e)
        {
            giatien = Convert.ToInt32(this.cmbGiaSach.Text);
            sl = Convert.ToInt32(this.txtSoLuong.Text);
            this.txtTongTien.Text = Convert.ToString(giatien * sl);
        }

        private void cmbGiaSach_SelectedIndexChanged(object sender, EventArgs e)
        {  
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult tl = MessageBox.Show("Chắc chắn thoát?(Y/N)", "Thông báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (tl == DialogResult.Yes)
                this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                dbCT.ThemCTHoaDon(this.txtMaCT.Text, this.cmbMaHD.Text, this.cmbMaSach.Text, this.cmbNhanVien.Text,
                    this.txtSoLuong.Text, this.cmbGiaSach.Text, ref err);
                LoadData();
                MessageBox.Show("Thêm thành công!", "Thông báo");
            }
            catch
            {
                MessageBox.Show("Lỗi, không thêm được!", "Error");
            }
            
        }
    }
}
