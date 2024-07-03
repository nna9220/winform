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
    public partial class FormHoaDon : Form
    {
        string err;
        HoaDonBUS dbhd = new HoaDonBUS();
        public FormHoaDon()
        {
            InitializeComponent();
        }

        public void LoadData()
        {
            try
            {
                dgvHoaDon.DataSource = dbhd.LayHoaDon();
                dgvHoaDon.AutoResizeColumns();

            }
            catch
            {
                MessageBox.Show("Không truy xuất được dữ liệu!", "Lỗi");
            }
        }

        private void FormHoaDon_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLNSDataSet2.HOADON' table. You can move, or remove it, as needed.
            this.hOADONTableAdapter.Fill(this.qLNSDataSet2.HOADON);
            LoadData();
        }

        private void dgvHoaDon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btnReLoad_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                dbhd.SuaHoaDon(this.cmbSua.Text, this.txtTenKH_Sua.Text, this.dtpNgay_Sua.Text, ref err);
                LoadData();
                this.txtTenKH_Sua.Text = "";
                MessageBox.Show("Sửa thành công!");
            }
            catch
            {
                MessageBox.Show("Không sửa được", "Error");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult tl = MessageBox.Show("Chắc chắn thoát?(Y/N)", "Thông báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (tl == DialogResult.Yes)
                this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (!dbhd.checkHoaDon(this.txtMaHD.Text))
                {
                    if (dbhd.checkId(this.txtMaHD.Text))
                    {
                        dbhd.ThemHoaDon(this.txtMaHD.Text, this.txtTenKH.Text, this.dtpNgayTT.Text,ref err);
                        LoadData();
                        FormChiTietHoaDon add = new FormChiTietHoaDon();
                        this.Hide();
                        add.ShowDialog();
                        this.Show();

                    }
                    else
                        MessageBox.Show("Nhập đúng cấu trúc mã đơn!", "Error");

                }
                else
                    MessageBox.Show("Đơn hàng đã tồn tại!", "Thông báo");
            }
            catch
            {
                MessageBox.Show("Không thêm được đơn hàng!", "Thông báo");
            }
            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            
            try
            {
                if(dbhd.checkHoaDon(this.cmbXoa.Text))
                {
                    DialogResult tl = MessageBox.Show("Chắc chắn xóa hóa đơn này?(Y/N)", "Thông báo",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (tl == DialogResult.Yes)
                    {
                        dbhd.XoaHoaDon(this.cmbXoa.Text, ref err);
                        LoadData();
                        MessageBox.Show("Thành công!", "Thông báo");
                    }
                    else
                        MessageBox.Show("Hủy thao tác", "Thông báo");
                }   
                else
                {
                    MessageBox.Show("Không tồn tại hóa đơn này!", "Thông báo");
                }    
            }
            catch
            {
                MessageBox.Show("Lỗi không xóa được đơn hàng!", "Thông báo");
            }
        }

        private void btnCTHD_Click(object sender, EventArgs e)
        {
            FormChiTietHoaDon add = new FormChiTietHoaDon();
            this.Hide();
            add.ShowDialog();
            this.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
