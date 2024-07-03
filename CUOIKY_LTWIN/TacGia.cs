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
    public partial class FormTacGia : Form
    {
        TacGiaBUS dbtg = new TacGiaBUS();
        string err;
        public FormTacGia()
        {
            InitializeComponent();//Mã nhân viên
            txtMaTG.ForeColor = Color.LightGray;
            txtMaTG.Text = "tgxxxxx";
            this.txtMaTG.Leave += new System.EventHandler(this.txtMaNV_Leave);
            this.txtMaTG.Enter += new System.EventHandler(this.txtMaNV_Enter);
        }

        //Mã 
        private void txtMaNV_Leave(object sender, EventArgs e)
        {
            if (txtMaTG.Text == "")
            {
                txtMaTG.Text = "tgxxxxx";
                txtMaTG.ForeColor = Color.Gray;
            }
        }
        private void txtMaNV_Enter(object sender, EventArgs e)
        {
            if (txtMaTG.Text == "tgxxxxx")
            {
                txtMaTG.Text = "";
                txtMaTG.ForeColor = Color.Black;
            }
        }


        public void LoadData()
        {
            try
            {
                dgvTacGia.DataSource = dbtg.getTG();
                dgvTacGia.AutoResizeRows();
            }
            catch
            {
                MessageBox.Show("Không lấy được nội dung trong table TACGIA. Lỗi rồi!!!","Error",
                    MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }


        private void TacGia_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLNSDataSet1.TACGIA' table. You can move, or remove it, as needed.
            this.tACGIATableAdapter.Fill(this.qLNSDataSet1.TACGIA);
            LoadData();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (this.txtMaTG.Text !="" && this.txtTenTG.Text!="" 
                && dbtg.checkId(this.txtMaTG.Text)
                && this.txtQueQuan.Text != "" 
                && this.dtpNgaySinh.Value != null && this.dtpNgayMat.Value != null)
            {
                if (!(dbtg.checkTG(this.txtMaTG.Text)))
                {
                    try
                    {
                        dbtg.ThemTacGia(this.txtMaTG.Text, this.txtTenTG.Text,
                            this.dtpNgaySinh.Text, this.dtpNgayMat.Text, this.txtQueQuan.Text, ref err);
                        MessageBox.Show("Thêm thành công!", "Thông báo");
                        LoadData();
                        this.txtMaTG.Text = "";
                        this.txtTenTG.Text = "";
                        this.txtQueQuan.Text = "";
                    }
                    catch
                    {
                        MessageBox.Show("Không thêm được!", "Lỗi");
                    }
                }
                else
                    MessageBox.Show("Tác giả này đã tồn tại!", "Thông báo");
            }
            else
                MessageBox.Show("Vui lòng nhập đầy đủ và đúng thông tin!", "Thông báo");
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.txtMaTG.Text = "";
            this.txtTenTG.Text = "";
            this.txtQueQuan.Text = "";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult tl = MessageBox.Show("Bạn chắc không?(Y/N)", "Thông báo", MessageBoxButtons.YesNo,
               MessageBoxIcon.Question);
            if (tl == DialogResult.Yes)
                this.Close();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if ((dbtg.checkTG(this.txtMaTG.Text)))
            {
                dbtg.SuaTacGia(this.txtMaTG.Text, this.txtTenTG.Text,this.dtpNgaySinh.Text
                     ,this.dtpNgayMat.Text, this.txtQueQuan.Text, ref err);
                MessageBox.Show("Sửa thành công!", "Thông báo");
                LoadData();
                this.txtTenTG.Text = "";
                this.txtMaTG.Text = "";
                this.txtQueQuan.Text = "";
                
            }
            else
                MessageBox.Show("Không tồn tại Tác giả này", "Thông báo");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

            try
            {
                if (dbtg.checkTG(this.cmbXoa.Text))
                {
                    dbtg.XoaTacGia(this.cmbXoa.Text, ref err);
                    LoadData();
                    MessageBox.Show("Xóa thành công!", "Thông báo");
                }
                else
                    MessageBox.Show("Không có tác giả này!", "Thông báo");
            }
            catch
            {
                MessageBox.Show("Không xóa được!", "Thông báo");
            }
        }
    }
}
