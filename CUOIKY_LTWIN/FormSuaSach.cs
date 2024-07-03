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
    public partial class FormSuaSach : Form
    {
        SachBUS dbs = new SachBUS();
        string err;
        public FormSuaSach()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult tl = MessageBox.Show("Bạn chắc không?(Y/N)", "Thông báo", MessageBoxButtons.YesNo,
               MessageBoxIcon.Question);
            if (tl == DialogResult.Yes)
                this.Close();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.cmbID.Text = "";
            this.nmrGiaMua.Value = 0;
            this.nmrGiaBia.Value = 0;

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if ((dbs.checkSach(this.cmbID.Text)))
            {
                try
                {
                    dbs.SuaSach(this.cmbID.Text, (int)this.nmrGiaMua.Value, (int)this.nmrGiaBia.Value
                        ,(int)this.nmrLanTB.Value,this.dtpNamXuatBan.Value, ref err);
                    MessageBox.Show("Sửa thành công!", "Thông báo");
                }
                catch
                {
                    MessageBox.Show("Không sửa được!", "Error");
                }
            }
            else
                MessageBox.Show("Không có sách này trong bảng", "Thông báo");
        }

        private void FormSuaSach_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLNSDataSet2.SACH' table. You can move, or remove it, as needed.
            this.sACHTableAdapter.Fill(this.qLNSDataSet2.SACH);

        }
    }
}
