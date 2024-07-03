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
    public partial class FormSuaNhanVien : Form
    {
        string err;
        public FormSuaNhanVien()
        {
            InitializeComponent();
            //Mã nhân viên
            //Tên
            txtTen.ForeColor = Color.LightGray;
            txtTen.Text = "Không chứa ký tự đặc biệt";
            this.txtTen.Leave += new System.EventHandler(this.txtHoTen_Leave);
            this.txtTen.Enter += new System.EventHandler(this.txtHoTen_Enter);
            //SDT
            txtSDT.ForeColor = Color.LightGray;
            txtSDT.Text = "0..(10 số) or +84...(12 số)";
            this.txtSDT.Leave += new System.EventHandler(this.txtSDT_Leave);
            this.txtSDT.Enter += new System.EventHandler(this.txtSDT_Enter);

            //Ngày
            txtNgaySinh.ForeColor = Color.LightGray;
            txtNgaySinh.Text = "YYYY-MM-DD";
            this.txtNgaySinh.Leave += new System.EventHandler(this.txtNgaySinh_Leave);
            this.txtNgaySinh.Enter += new System.EventHandler(this.txtNgaySinh_Enter);

            //Ngày
            txtVaoLam.ForeColor = Color.LightGray;
            txtVaoLam.Text = "YYYY-MM-DD";
            this.txtVaoLam.Leave += new System.EventHandler(this.txtNgayVaoLam_Leave);
            this.txtVaoLam.Enter += new System.EventHandler(this.txtNgayVaoLam_Enter);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            NhanVienBUS nv = new NhanVienBUS();
            if ((nv.checkNhanVien(cmbSua.Text)))
            {
                if ((nv.checkPhone(this.txtSDT.Text)))
                {
                    nv.SuaNhanVien(this.cmbSua.Text, this.txtTen.Text,
                        this.cbGioiTinh.Enabled, this.txtNgaySinh.Text,
                        this.txtVaoLam.Text, this.txtDiaChi.Text,
                        this.txtSDT.Text, ref err);
                    MessageBox.Show("Sửa thành công!", "Thông báo");
                    this.txtDiaChi.Text = "";
                    this.txtTen.Text = "";
                    this.cmbSua.Text = "";
                    this.txtVaoLam.Text = "";
                    this.txtNgaySinh.Text = "";
                    this.txtSDT.Text = "";
                    this.cbGioiTinh.Text = "";
                }
                else
                    MessageBox.Show("Nhập số điện thoại hợp lệ!", "Thông báo");
            }
            else
                MessageBox.Show("Không tồn tại nhân viên này", "Thông báo");
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult tl = MessageBox.Show("Bạn có chắc thoát?(Y/N)",
                "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (tl == DialogResult.Yes)
                this.Close();
        }

        private void btnKiemTra_Click(object sender, EventArgs e)
        {
        }

        //Mã 



        //Tên
        private void txtHoTen_Leave(object sender, EventArgs e)
        {
            if (txtTen.Text == "")
            {
                txtTen.Text = "Không chứa ký tự đặc biệt";
                txtTen.ForeColor = Color.Gray;
            }
        }
        private void txtHoTen_Enter(object sender, EventArgs e)
        {
            if (txtTen.Text == "Không chứa ký tự đặc biệt")
            {
                txtTen.Text = "";
                txtTen.ForeColor = Color.Black;
            }
        }


        //SĐT
        private void txtSDT_Leave(object sender, EventArgs e)
        {
            if (txtSDT.Text == "")
            {
                txtSDT.Text = "0..(10 số) or +84...(12 số)";
                txtSDT.ForeColor = Color.Gray;
            }
        }
        private void txtSDT_Enter(object sender, EventArgs e)
        {
            if (txtSDT.Text == "0..(10 số) or +84...(12 số)")
            {
                txtSDT.Text = "";
                txtSDT.ForeColor = Color.Black;
            }
        }


        //Ngày sinh
        private void txtNgaySinh_Leave(object sender, EventArgs e)
        {
            if (txtNgaySinh.Text == "")
            {
                txtNgaySinh.Text = "YYYY-MM-DD";
                txtNgaySinh.ForeColor = Color.Gray;
            }
        }
        private void txtNgaySinh_Enter(object sender, EventArgs e)
        {
            if (txtNgaySinh.Text == "YYYY-MM-DD")
            {
                txtNgaySinh.Text = "";
                txtNgaySinh.ForeColor = Color.Black;
            }
        }

        //Ngày vào làm
        private void txtNgayVaoLam_Leave(object sender, EventArgs e)
        {
            if (txtVaoLam.Text == "")
            {
                txtVaoLam.Text = "YYYY-MM-DD";
                txtVaoLam.ForeColor = Color.Gray;
            }
        }
        private void txtNgayVaoLam_Enter(object sender, EventArgs e)
        {
            if (txtVaoLam.Text == "YYYY-MM-DD")
            {
                txtVaoLam.Text = "";
                txtVaoLam.ForeColor = Color.Black;
            }
        }

        private void FormSuaNhanVien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLNSDataSet6.NHANVIEN' table. You can move, or remove it, as needed.
            this.nHANVIENTableAdapter.Fill(this.qLNSDataSet6.NHANVIEN);

        }
    }
}
