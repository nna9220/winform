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
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click_1(object sender, EventArgs e)
        {

            if (this.txtDangNhap.Text != "" && this.txtMatKhau.Text!= "")
            {
                DangNhapBUS dn = new DangNhapBUS();
                if (dn.checkTaiKhoan(this.txtDangNhap.Text, this.txtMatKhau.Text))
                {                    
                    ManHinhChinh add = new ManHinhChinh();
                    this.Hide();
                    add.ShowDialog();
                }
                else
                    MessageBox.Show("Sai tên người dùng hoặc mật khẩu!","Thông báo");
            }
            else
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!","Error");
        }

        private void txtMatKhau_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDangNhap_TextChanged(object sender, EventArgs e)
        {

        }
        //hiện ẩn pass
        private void picHidePass_Click(object sender, EventArgs e)
        {
            if (txtMatKhau.PasswordChar == '*')
            {
                picShowPass.BringToFront();
                txtMatKhau.PasswordChar = '\0';
            }
        }
        private void picShowPass_Click(object sender, EventArgs e)
        {
            if (txtMatKhau.PasswordChar == '\0')
            {
                picHidePass.BringToFront();
                txtMatKhau.PasswordChar = '*';
            }
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            DangKy frm = new DangKy();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }
    }
}
