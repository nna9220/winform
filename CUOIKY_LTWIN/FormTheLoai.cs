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
    public partial class FormTheLoai : Form
    {
        TheLoaiBUS dbtl = new TheLoaiBUS();
        string err;
        public FormTheLoai()
        {
            InitializeComponent();
            txtNameThem.ForeColor = Color.LightGray;
            txtNameThem.Text = "Nhập thể loại";
            this.txtNameThem.Leave += new System.EventHandler(this.txtMaNV_Leave);
            this.txtNameThem.Enter += new System.EventHandler(this.txtMaNV_Enter);
        }
        //Mã 
        private void txtMaNV_Leave(object sender, EventArgs e)
        {
            if (txtNameThem.Text == "")
            {
                txtNameThem.Text = "Nhập thể loại";
                txtNameThem.ForeColor = Color.Gray;
            }
        }
        private void txtMaNV_Enter(object sender, EventArgs e)
        {
            if (txtNameThem.Text == "Nhập thể loại")
            {
                txtNameThem.Text = "";
                txtNameThem.ForeColor = Color.Black;
            }
        }
        public void LoadData()
        {
            try
            {
                dgvLoaiSach.DataSource = dbtl.getLoaiToDGV();
                dgvLoaiSach.AutoResizeRows();
            }
            catch
            {
                MessageBox.Show("Không lấy được nội dung trong table LOAISACH. Lỗi rồi!!!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormTheLoai_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLNSDataSet4.LOAISACH' table. You can move, or remove it, as needed.
            this.lOAISACHTableAdapter.Fill(this.qLNSDataSet4.LOAISACH);
            LoadData();
        }

        private void btnThemLS_Click(object sender, EventArgs e)
        {
            if (this.txtIDThem.Text!="")
            {
                if (!(dbtl.checkTheLoai(this.txtIDThem.Text)))
                {
                    try
                    {
                        dbtl.ThemLoaiSach(this.txtIDThem.Text, this.txtNameThem.Text);
                        MessageBox.Show("Thêm thành công!", "Thông báo");
                        LoadData();
                        this.txtIDThem.Text = "";
                    }
                    catch
                    {
                        MessageBox.Show("Không thêm được!", "Lỗi");
                    }
                }
                else
                    MessageBox.Show("Loại sách này đã tồn tại!", "Thông báo");
            }
            else
                MessageBox.Show("Vui lòng nhập đầy đủ và đúng thông tin!", "Thông báo");
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.txtIDThem.Text = "";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult tl = MessageBox.Show("Bạn chắc không?(Y/N)", "Thông báo", MessageBoxButtons.YesNo,
               MessageBoxIcon.Question);
            if (tl == DialogResult.Yes)
                this.Close();
        }

        private void btnXoaLS_Click(object sender, EventArgs e)
        {
            try
            {
                    dbtl.XoaLoaiSach(ref err, this.cmbIDXoa.Text);
                    LoadData();
                    MessageBox.Show("Xóa thành công!", "Thông báo");
                
            }
            catch
            {
                MessageBox.Show("Không xóa được!", "Thông báo");
            }
        }
    }
}
