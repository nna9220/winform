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
    public partial class FormThemNhanVien : Form
    {
        string err;
        NhanVienBUS dbnv = new NhanVienBUS();
        public FormThemNhanVien()
        {
            InitializeComponent();
            //Mã nhân viên
            txtMaNV.ForeColor = Color.LightGray;
            txtMaNV.Text = "nvxxxxx";
            this.txtMaNV.Leave += new System.EventHandler(this.txtMaNV_Leave);
            this.txtMaNV.Enter += new System.EventHandler(this.txtMaNV_Enter);
            //Tên
            txtHoTen.ForeColor = Color.LightGray;
            txtHoTen.Text = "Không chứa ký tự đặc biệt";
            this.txtHoTen.Leave += new System.EventHandler(this.txtHoTen_Leave);
            this.txtHoTen.Enter += new System.EventHandler(this.txtHoTen_Enter);
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
            txtNgayLam.ForeColor = Color.LightGray;
            txtNgayLam.Text = "YYYY-MM-DD";
            this.txtNgayLam.Leave += new System.EventHandler(this.txtNgayVaoLam_Leave);
            this.txtNgayLam.Enter += new System.EventHandler(this.txtNgayVaoLam_Enter);

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtMaNV.Text != "" && dbnv.checkId(txtMaNV.Text)
                && txtHoTen.Text != "" 
                && txtDiaChi.Text != "" && txtNgayLam.Text != ""
                && txtNgaySinh.Text != "" && txtSDT.Text != "" && cbGioiTinh.Text != "")
            {
                NhanVienBUS nv = new NhanVienBUS();
                if (!(nv.checkNhanVien(txtMaNV.Text)))
                {
                    try
                    {
                        nv.ThemNhanVien(this.txtMaNV.Text, this.txtHoTen.Text, this.cbGioiTinh.Enabled, this.txtNgaySinh.Text
                            , this.txtNgayLam.Text, this.txtDiaChi.Text, this.txtSDT.Text, ref err);
                        MessageBox.Show("Thêm thành công!", "Thông báo");
                        this.txtDiaChi.Text = "";
                        this.txtHoTen.Text = "";
                        this.txtMaNV.Text = "";
                        this.txtNgayLam.Text = "";
                        this.txtNgaySinh.Text = "";
                        this.txtSDT.Text = "";
                        this.cbGioiTinh.Text = ""; 
                    }
                    catch
                    {
                        MessageBox.Show("Không thêm được!", "Lỗi");
                    }
                }
                else
                    MessageBox.Show("Mã nhân viên này đã tồn tại!","Thông báo");
            }
            else
                MessageBox.Show("Vui lòng nhập đầy đủ và đúng thông tin!", "Thông báo");
        }

        //Mã 
        private void txtMaNV_Leave(object sender, EventArgs e)
        {
            if (txtMaNV.Text == "")
            {
                txtMaNV.Text = "nvxxxxx";
                txtMaNV.ForeColor = Color.Gray;
            }
        }
        private void txtMaNV_Enter(object sender, EventArgs e)
        {
            if (txtMaNV.Text == "nvxxxxx")
            {
                txtMaNV.Text = "";
                txtMaNV.ForeColor = Color.Black;
            }
        }


        //Tên
        private void txtHoTen_Leave(object sender, EventArgs e)
        {
            if (txtHoTen.Text == "")
            {
                txtHoTen.Text = "Không chứa ký tự đặc biệt";
                txtHoTen.ForeColor = Color.Gray;
            }
        }
        private void txtHoTen_Enter(object sender, EventArgs e)
        {
            if (txtHoTen.Text == "Không chứa ký tự đặc biệt")
            {
                txtHoTen.Text = "";
                txtHoTen.ForeColor = Color.Black;
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
            if (txtNgayLam.Text == "")
            {
                txtNgayLam.Text = "YYYY-MM-DD";
                txtNgayLam.ForeColor = Color.Gray;
            }
        }
        private void txtNgayVaoLam_Enter(object sender, EventArgs e)
        {
            if (txtNgayLam.Text == "YYYY-MM-DD")
            {
                txtNgayLam.Text = "";
                txtNgayLam.ForeColor = Color.Black;
            }
        }

        private void txtMaNV_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult tl = MessageBox.Show("Bạn chắc không?(Y/N)", "Thông báo", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (tl == DialogResult.Yes)
                this.Close();
        }

        private void FormThemNhanVien_Load(object sender, EventArgs e)
        {

        }
    }
}
