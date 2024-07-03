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
    public partial class formNhaXuatBan : Form
    {
        NhaXuatBanBUS nsb = new NhaXuatBanBUS();
        string err;
        public formNhaXuatBan()
        {
            InitializeComponent();
            //Tên nhà xuất bản
            txtName_Xoa.ForeColor = Color.LightGray;
            txtName_Xoa.Text = "Nhập tên nhà xuất bản";
            this.txtName_Xoa.Leave += new System.EventHandler(this.txtMaNV_Leave);
            this.txtName_Xoa.Enter += new System.EventHandler(this.txtMaNV_Enter);
        }

        //Mã 
        private void txtMaNV_Leave(object sender, EventArgs e)
        {
            if (txtName_Xoa.Text == "")
            {
                txtName_Xoa.Text = "Nhập tên nhà xuất bản";
                txtName_Xoa.ForeColor = Color.Gray;
            }
        }
        private void txtMaNV_Enter(object sender, EventArgs e)
        {
            if (txtName_Xoa.Text == "Nhập tên nhà xuất bản")
            {
                txtName_Xoa.Text = "";
                txtName_Xoa.ForeColor = Color.Black;
            }
        }

        public void LoadData()
        {
            try
            {
                dgvNXB.DataSource = nsb.getNhaXuatBan();
                dgvNXB.AutoResizeRows();
            }
            catch
            {
                MessageBox.Show("Không lấy được nội dung trong table NHAXUATBAN. Lỗi rồi!!!","Error");
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.txtName_Xoa.Text != "")
                {
                    if (!(nsb.checkNXB(this.txtName_Xoa.Text)))
                    {
                        nsb.themNXB(this.txtName_Xoa.Text);
                        LoadData();
                        this.txtName_Xoa.Text = "";
                        MessageBox.Show("Thêm nhà xuất bản thành công", "Thông báo");
                    }
                    else
                        MessageBox.Show("Nhà xuất bản này đã có trong bảng", "Thông báo");
                }
                else
                    MessageBox.Show("Vui lòng nhập tên nhà xuất bản hợp lệ!","Thông báo");
            }
            catch
            {
                MessageBox.Show("Lỗi. Không thêm được!", "Error");
            }
        }

        private void formNhaXuatBan_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult tl = MessageBox.Show("Chắc chắn thoát?(Y/N)", "Thông báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (tl == DialogResult.Yes)
                this.Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.txtName_Xoa.Text != "")
                {
                    if ((nsb.checkNXB(this.txtName_Xoa.Text)))
                    {
                        nsb.XoaNXB(this.txtName_Xoa.Text, ref err);
                        LoadData();
                        this.txtName_Xoa.Text = "";
                        MessageBox.Show("Xóa nhà xuất bản thành công", "Thông báo");
                    }
                    else
                        MessageBox.Show("Nhà xuất bản này không có trong bảng", "Thông báo");
                }
                else
                    MessageBox.Show("Vui lòng nhập tên nhà xuất bản hợp lệ!", "Thông báo");
            }
            catch
            {
                MessageBox.Show("Lỗi. Không xóa được!", "Error");
            }
        }
    }
}
