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
    public partial class FormThemSach : Form
    {
        string err;
        SachBUS dbs = new SachBUS();
        public FormThemSach()
        {
            InitializeComponent();
            //Mã
            this.txtMaSach.ForeColor = Color.LightGray;
            this.txtMaSach.Text = "qsxxxxx";
            this.txtMaSach.Leave += new System.EventHandler(this.txtMaSach_Leave);
            this.txtMaSach.Enter += new System.EventHandler(this.txtMaSach_Enter);

        }
        //Mã
        private void txtMaSach_Leave(object sender, EventArgs e)
        {
            if (this.txtMaSach.Text == "")
            {
                this.txtMaSach.Text = "qsxxxxx";
                this.txtMaSach.ForeColor = Color.Gray;
            }
        }
        private void txtMaSach_Enter(object sender, EventArgs e)
        {
            if (this.txtMaSach.Text == "qsxxxxx")
            {
                this.txtMaSach.Text = "";
                this.txtMaSach.ForeColor = Color.Black;
            }
        }


        private void FormThemSach_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLNSDataSet14.LOAISACH' table. You can move, or remove it, as needed.
            this.lOAISACHTableAdapter1.Fill(this.qLNSDataSet14.LOAISACH);
            // TODO: This line of code loads data into the 'qLNSDataSet14.LINHVUC' table. You can move, or remove it, as needed.
            this.lINHVUCTableAdapter1.Fill(this.qLNSDataSet14.LINHVUC);
            // TODO: This line of code loads data into the 'qLNSDataSet1.NHAXUATBAN' table. You can move, or remove it, as needed.
            this.nHAXUATBANTableAdapter.Fill(this.qLNSDataSet1.NHAXUATBAN);
            // TODO: This line of code loads data into the 'qLNSDataSet1.LOAISACH' table. You can move, or remove it, as needed.
            this.lOAISACHTableAdapter.Fill(this.qLNSDataSet1.LOAISACH);
            // TODO: This line of code loads data into the 'qLNSDataSet1.TACGIA' table. You can move, or remove it, as needed.
            this.tACGIATableAdapter.Fill(this.qLNSDataSet1.TACGIA);
            // TODO: This line of code loads data into the 'qLNSDataSet1.LINHVUC' table. You can move, or remove it, as needed.
            this.lINHVUCTableAdapter.Fill(this.qLNSDataSet1.LINHVUC);

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (this.txtMaSach.Text !="" && this.txtTenSach.Text !="" 
                && this.cmbTenLV.SelectedItem != null && this.cmbTenLS.SelectedItem != null
                && this.cboNXB.SelectedItem != null && this.cboTacGiaID.SelectedItem != null
                && this.nmrGiaBia.Value != 0 && this.nmrGiaMua.Value != 0  && this.nmrLanTB.Value != 0)
            {
                if (!(dbs.checkSach(this.txtMaSach.Text)))
                {
                    try
                    {
                        dbs.ThemSach(this.txtMaSach.Text, this.txtTenSach.Text, this.cboTacGiaID.Text,
                            this.cmbTenLV.Text, this.cmbTenLS.Text, (int)this.nmrGiaMua.Value,
                            (int)this.nmrGiaBia.Value, this.cboNXB.Text, (int)this.nmrLanTB.Value, this.dtpNamXuatBan.Value);
                        MessageBox.Show("Thêm thành công!", "Thông báo");
                        this.txtMaSach.Text = "";
                        this.txtTenSach.Text = "";
                        this.nmrGiaMua.Value = 0;
                        this.nmrGiaBia.Value = 0;
                    }
                    catch
                    {
                        MessageBox.Show("Lỗi, Không thêm được!", "Error");
                    }

                    
                }
                else
                    MessageBox.Show("Sách này đã tồn tại!", "Thông báo");
            }
            else
                MessageBox.Show("Vui lòng nhập đầy đủ và đúng thông tin!", "Thông báo");
        }

        private void bthThoat_Click(object sender, EventArgs e)
        {
            DialogResult tl = MessageBox.Show("Bạn chắc không?(Y/N)", "Thông báo", MessageBoxButtons.YesNo,
               MessageBoxIcon.Question);
            if (tl == DialogResult.Yes)
                this.Close();
        }

        private void bthHuy_Click(object sender, EventArgs e)
        {
            this.txtMaSach.Text = "";
            this.txtTenSach.Text = "";
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
