
namespace CUOIKY_LTWIN
{
    partial class FormChiTietHoaDon
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dgvCTHD = new System.Windows.Forms.DataGridView();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbMaHD = new System.Windows.Forms.ComboBox();
            this.hOADONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLNSDataSet2 = new CUOIKY_LTWIN.QLNSDataSet2();
            this.cmbMaSach = new System.Windows.Forms.ComboBox();
            this.sACHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.cmbGiaSach = new System.Windows.Forms.ComboBox();
            this.sACHBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbNhanVien = new System.Windows.Forms.ComboBox();
            this.nHANVIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.hOADONTableAdapter = new CUOIKY_LTWIN.QLNSDataSet2TableAdapters.HOADONTableAdapter();
            this.sACHTableAdapter = new CUOIKY_LTWIN.QLNSDataSet2TableAdapters.SACHTableAdapter();
            this.nHANVIENTableAdapter = new CUOIKY_LTWIN.QLNSDataSet2TableAdapters.NHANVIENTableAdapter();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnTinh = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMaCT = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.qLNSDataSet11 = new CUOIKY_LTWIN.QLNSDataSet11();
            this.nHANVIENBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.nHANVIENTableAdapter1 = new CUOIKY_LTWIN.QLNSDataSet11TableAdapters.NHANVIENTableAdapter();
            this.cmbTenSach = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTHD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOADONBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNSDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sACHBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sACHBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHANVIENBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNSDataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHANVIENBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCTHD
            // 
            this.dgvCTHD.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dgvCTHD.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvCTHD.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgvCTHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCTHD.Location = new System.Drawing.Point(12, 12);
            this.dgvCTHD.Name = "dgvCTHD";
            this.dgvCTHD.RowHeadersWidth = 51;
            this.dgvCTHD.RowTemplate.Height = 24;
            this.dgvCTHD.Size = new System.Drawing.Size(747, 245);
            this.dgvCTHD.TabIndex = 0;
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(540, 587);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(227, 38);
            this.btnThoat.TabIndex = 2;
            this.btnThoat.Text = "THOÁT";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnHuy.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Location = new System.Drawing.Point(281, 587);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(227, 38);
            this.btnHuy.TabIndex = 3;
            this.btnHuy.Text = "HỦY";
            this.btnHuy.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(372, 282);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Mã hóa đơn:";
            // 
            // cmbMaHD
            // 
            this.cmbMaHD.DataSource = this.hOADONBindingSource;
            this.cmbMaHD.DisplayMember = "MAHOADON";
            this.cmbMaHD.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMaHD.FormattingEnabled = true;
            this.cmbMaHD.Location = new System.Drawing.Point(505, 280);
            this.cmbMaHD.Name = "cmbMaHD";
            this.cmbMaHD.Size = new System.Drawing.Size(223, 30);
            this.cmbMaHD.TabIndex = 5;
            // 
            // hOADONBindingSource
            // 
            this.hOADONBindingSource.DataMember = "HOADON";
            this.hOADONBindingSource.DataSource = this.qLNSDataSet2;
            // 
            // qLNSDataSet2
            // 
            this.qLNSDataSet2.DataSetName = "QLNSDataSet2";
            this.qLNSDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbMaSach
            // 
            this.cmbMaSach.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.sACHBindingSource, "TENSACH", true));
            this.cmbMaSach.DataSource = this.sACHBindingSource;
            this.cmbMaSach.DisplayMember = "MASACH";
            this.cmbMaSach.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMaSach.FormattingEnabled = true;
            this.cmbMaSach.Location = new System.Drawing.Point(185, 378);
            this.cmbMaSach.Name = "cmbMaSach";
            this.cmbMaSach.Size = new System.Drawing.Size(154, 30);
            this.cmbMaSach.TabIndex = 7;
            this.cmbMaSach.ValueMember = "TENSACH";
            // 
            // sACHBindingSource
            // 
            this.sACHBindingSource.DataMember = "SACH";
            this.sACHBindingSource.DataSource = this.qLNSDataSet2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(52, 385);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Mã sách:";
            // 
            // cmbGiaSach
            // 
            this.cmbGiaSach.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.sACHBindingSource, "TENSACH", true));
            this.cmbGiaSach.DataSource = this.sACHBindingSource;
            this.cmbGiaSach.DisplayMember = "GIAMUA";
            this.cmbGiaSach.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGiaSach.FormattingEnabled = true;
            this.cmbGiaSach.Location = new System.Drawing.Point(185, 433);
            this.cmbGiaSach.Name = "cmbGiaSach";
            this.cmbGiaSach.Size = new System.Drawing.Size(154, 30);
            this.cmbGiaSach.TabIndex = 9;
            this.cmbGiaSach.ValueMember = "TENSACH";
            this.cmbGiaSach.SelectedIndexChanged += new System.EventHandler(this.cmbGiaSach_SelectedIndexChanged);
            // 
            // sACHBindingSource1
            // 
            this.sACHBindingSource1.DataMember = "SACH";
            this.sACHBindingSource1.DataSource = this.qLNSDataSet2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(52, 433);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 23);
            this.label3.TabIndex = 8;
            this.label3.Text = "Giá sách:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(52, 333);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 23);
            this.label4.TabIndex = 10;
            this.label4.Text = "Mã nhân Viên:";
            // 
            // cmbNhanVien
            // 
            this.cmbNhanVien.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.nHANVIENBindingSource1, "TENNHANVIEN", true));
            this.cmbNhanVien.DataSource = this.nHANVIENBindingSource1;
            this.cmbNhanVien.DisplayMember = "MANHANVIEN";
            this.cmbNhanVien.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbNhanVien.FormattingEnabled = true;
            this.cmbNhanVien.Location = new System.Drawing.Point(185, 326);
            this.cmbNhanVien.Name = "cmbNhanVien";
            this.cmbNhanVien.Size = new System.Drawing.Size(154, 30);
            this.cmbNhanVien.TabIndex = 11;
            this.cmbNhanVien.ValueMember = "TENNHANVIEN";
            // 
            // nHANVIENBindingSource
            // 
            this.nHANVIENBindingSource.DataMember = "NHANVIEN";
            this.nHANVIENBindingSource.DataSource = this.qLNSDataSet2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(372, 433);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 23);
            this.label5.TabIndex = 12;
            this.label5.Text = "Số lượng:";
            // 
            // txtTongTien
            // 
            this.txtTongTien.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongTien.Location = new System.Drawing.Point(219, 537);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(359, 30);
            this.txtTongTien.TabIndex = 14;
            // 
            // hOADONTableAdapter
            // 
            this.hOADONTableAdapter.ClearBeforeFill = true;
            // 
            // sACHTableAdapter
            // 
            this.sACHTableAdapter.ClearBeforeFill = true;
            // 
            // nHANVIENTableAdapter
            // 
            this.nHANVIENTableAdapter.ClearBeforeFill = true;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoLuong.Location = new System.Drawing.Point(505, 431);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(223, 30);
            this.txtSoLuong.TabIndex = 16;
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnLuu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Location = new System.Drawing.Point(20, 587);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(227, 38);
            this.btnLuu.TabIndex = 1;
            this.btnLuu.Text = "LƯU";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnTinh
            // 
            this.btnTinh.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnTinh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTinh.Location = new System.Drawing.Point(309, 493);
            this.btnTinh.Name = "btnTinh";
            this.btnTinh.Size = new System.Drawing.Size(186, 38);
            this.btnTinh.TabIndex = 17;
            this.btnTinh.Text = "THÀNH TIỀN";
            this.btnTinh.UseVisualStyleBackColor = false;
            this.btnTinh.Click += new System.EventHandler(this.btnTinh_Click_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(52, 287);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 23);
            this.label6.TabIndex = 18;
            this.label6.Text = "Mã CT:";
            // 
            // txtMaCT
            // 
            this.txtMaCT.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaCT.Location = new System.Drawing.Point(185, 280);
            this.txtMaCT.Name = "txtMaCT";
            this.txtMaCT.Size = new System.Drawing.Size(154, 30);
            this.txtMaCT.TabIndex = 19;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.nHANVIENBindingSource1;
            this.comboBox1.DisplayMember = "TENNHANVIEN";
            this.comboBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(505, 331);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(223, 30);
            this.comboBox1.TabIndex = 21;
            this.comboBox1.ValueMember = "MANHANVIEN";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(372, 333);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 23);
            this.label7.TabIndex = 20;
            this.label7.Text = "Tên nhân Viên:";
            // 
            // qLNSDataSet11
            // 
            this.qLNSDataSet11.DataSetName = "QLNSDataSet11";
            this.qLNSDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nHANVIENBindingSource1
            // 
            this.nHANVIENBindingSource1.DataMember = "NHANVIEN";
            this.nHANVIENBindingSource1.DataSource = this.qLNSDataSet11;
            // 
            // nHANVIENTableAdapter1
            // 
            this.nHANVIENTableAdapter1.ClearBeforeFill = true;
            // 
            // cmbTenSach
            // 
            this.cmbTenSach.DataSource = this.sACHBindingSource;
            this.cmbTenSach.DisplayMember = "TENSACH";
            this.cmbTenSach.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTenSach.FormattingEnabled = true;
            this.cmbTenSach.Location = new System.Drawing.Point(505, 383);
            this.cmbTenSach.Name = "cmbTenSach";
            this.cmbTenSach.Size = new System.Drawing.Size(223, 30);
            this.cmbTenSach.TabIndex = 23;
            this.cmbTenSach.ValueMember = "GIAMUA";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(372, 385);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 23);
            this.label8.TabIndex = 22;
            this.label8.Text = "Tên sách:";
            // 
            // FormChiTietHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(771, 640);
            this.Controls.Add(this.cmbTenSach);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtMaCT);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnTinh);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.txtTongTien);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbNhanVien);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbGiaSach);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbMaSach);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbMaHD);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.dgvCTHD);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FormChiTietHoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CHI TIẾT HÓA ĐƠN";
            this.Load += new System.EventHandler(this.FormChiTietHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTHD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOADONBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNSDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sACHBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sACHBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHANVIENBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNSDataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHANVIENBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCTHD;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbMaHD;
        private System.Windows.Forms.ComboBox cmbMaSach;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbGiaSach;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbNhanVien;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTongTien;
        private QLNSDataSet2 qLNSDataSet2;
        private System.Windows.Forms.BindingSource hOADONBindingSource;
        private QLNSDataSet2TableAdapters.HOADONTableAdapter hOADONTableAdapter;
        private System.Windows.Forms.BindingSource sACHBindingSource;
        private QLNSDataSet2TableAdapters.SACHTableAdapter sACHTableAdapter;
        private System.Windows.Forms.BindingSource sACHBindingSource1;
        private System.Windows.Forms.BindingSource nHANVIENBindingSource;
        private QLNSDataSet2TableAdapters.NHANVIENTableAdapter nHANVIENTableAdapter;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnTinh;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMaCT;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label7;
        private QLNSDataSet11 qLNSDataSet11;
        private System.Windows.Forms.BindingSource nHANVIENBindingSource1;
        private QLNSDataSet11TableAdapters.NHANVIENTableAdapter nHANVIENTableAdapter1;
        private System.Windows.Forms.ComboBox cmbTenSach;
        private System.Windows.Forms.Label label8;
    }
}