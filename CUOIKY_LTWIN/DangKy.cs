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
    public partial class DangKy : Form
    {
        public DangKy()
        {
            InitializeComponent();
        }

        private void btnDangky_Click(object sender, EventArgs e)
        {
            if(txtDangNhap.Text != "" && txtMatKhau.Text != "")
            {
                DangNhapBUS tk = new DangNhapBUS();
                if(!tk.checkTaiKhoan(txtDangNhap.Text, txtMatKhau.Text))
                {
                    try
                    {
                        tk.themTaiKhoan(txtDangNhap.Text, txtMatKhau.Text);
                        MessageBox.Show("Thêm thành công!", "Thông báo");
                        DangNhap frm = new DangNhap();                        
                        frm.Show();
                        this.Close();
                    }
                    catch
                    {
                        MessageBox.Show("Không thêm được!", "Lỗi");
                    }
                }
                else
                    MessageBox.Show("Tài khoản này đã tồn tại!", "Thông báo");
            }
            else
                MessageBox.Show("Vui lòng nhập đầy đủ và đúng thông tin!", "Thông báo");
        }
    }
}
