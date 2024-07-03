using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccessLayer;
using BusinessLogicLayer;
namespace CUOIKY_LTWIN
{
    public partial class formLinhVuc : Form
    {
        LinhVucBUS dbLV = new LinhVucBUS();
        string err;
        public formLinhVuc()
        {
            InitializeComponent();
            //filling comboBox            
        }

        public void LoadData()
        {
            try
            {
                dgvLinhVuc.DataSource = dbLV.getLinhVucToDGV();
                dgvLinhVuc.AutoResizeRows();
            }
            catch
            {
                MessageBox.Show("Không lấy được nội dung trong table LINHVUC. Lỗi rồi!!!");
            }

        }

        private void btnThemLV_Click(object sender, EventArgs e)
        {
            if (this.txtID.Text != "")
            {
                try
                {
                    dbLV.ThemLinhVuc( this.txtName.Text, this.txtID.Text);
                    LoadData();
                    this.txtID.Text = "";
                    MessageBox.Show("Đã thêm xong!");
                }
                catch
                {
                    MessageBox.Show("Không thêm được. Lỗi rồi!");
                }
            }
            else
                MessageBox.Show("Nhập đầy dủ thông tin.", "Thông báo");
        }

        private void formLinhVuc_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLNSDataSet3.LINHVUC' table. You can move, or remove it, as needed.
            this.lINHVUCTableAdapter1.Fill(this.qLNSDataSet3.LINHVUC);
            // TODO: This line of code loads data into the 'qLNSDataSet.LINHVUC' table. You can move, or remove it, as needed.

            LoadData();
        }


        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult tl = MessageBox.Show("Chắc chắn thoát?(Y/N)", "Thông báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (tl == DialogResult.Yes)
                this.Close();
        }

        private void btnXoaLV_Click(object sender, EventArgs e)
        {
            try
            {
                if (!dbLV.checkLinhVuc(this.cmbXoaID.Text))
                {
                    DialogResult tl = MessageBox.Show("Chắc chắn xóa lĩnh vực này?(Y/N)",
                        "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (tl == DialogResult.Yes)
                    {
                        dbLV.XoaLinhVuc(ref err, this.cmbXoaID.Text);
                        MessageBox.Show("Xóa thành công!", "Thông báo");
                        this.cmbXoaID.Text = "";
                        LoadData();
                    }
                    else
                        MessageBox.Show("Không xóa được!", "Thông báo");
                }
                else
                    MessageBox.Show("Lĩnh vực này không có trong bảng LINHVUC!", "Thông báo");
            }
            catch
            {
                MessageBox.Show("Lỗi, Không thể xóa!", "Thông báo");
            }
            
        }

        private void cboLinhVuc_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
