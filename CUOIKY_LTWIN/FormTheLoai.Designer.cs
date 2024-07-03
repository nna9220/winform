
namespace CUOIKY_LTWIN
{
    partial class FormTheLoai
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
            this.dgvLoaiSach = new System.Windows.Forms.DataGridView();
            this.btnXoaLS = new System.Windows.Forms.Button();
            this.btnThemLS = new System.Windows.Forms.Button();
            this.txtIDThem = new System.Windows.Forms.TextBox();
            this.lbnTenLoai = new System.Windows.Forms.Label();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.txtNameThem = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbXoaName = new System.Windows.Forms.ComboBox();
            this.lOAISACHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLNSDataSet4 = new CUOIKY_LTWIN.QLNSDataSet4();
            this.lOAISACHTableAdapter = new CUOIKY_LTWIN.QLNSDataSet4TableAdapters.LOAISACHTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbIDXoa = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOAISACHBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNSDataSet4)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvLoaiSach
            // 
            this.dgvLoaiSach.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvLoaiSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoaiSach.Location = new System.Drawing.Point(12, 12);
            this.dgvLoaiSach.Name = "dgvLoaiSach";
            this.dgvLoaiSach.RowHeadersWidth = 51;
            this.dgvLoaiSach.RowTemplate.Height = 24;
            this.dgvLoaiSach.Size = new System.Drawing.Size(250, 394);
            this.dgvLoaiSach.TabIndex = 23;
            // 
            // btnXoaLS
            // 
            this.btnXoaLS.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnXoaLS.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaLS.ForeColor = System.Drawing.Color.Black;
            this.btnXoaLS.Location = new System.Drawing.Point(130, 125);
            this.btnXoaLS.Name = "btnXoaLS";
            this.btnXoaLS.Size = new System.Drawing.Size(112, 30);
            this.btnXoaLS.TabIndex = 21;
            this.btnXoaLS.Text = "XÓA";
            this.btnXoaLS.UseVisualStyleBackColor = false;
            this.btnXoaLS.Click += new System.EventHandler(this.btnXoaLS_Click);
            // 
            // btnThemLS
            // 
            this.btnThemLS.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnThemLS.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemLS.ForeColor = System.Drawing.Color.Black;
            this.btnThemLS.Location = new System.Drawing.Point(121, 123);
            this.btnThemLS.Name = "btnThemLS";
            this.btnThemLS.Size = new System.Drawing.Size(112, 30);
            this.btnThemLS.TabIndex = 22;
            this.btnThemLS.Text = "THÊM";
            this.btnThemLS.UseVisualStyleBackColor = false;
            this.btnThemLS.Click += new System.EventHandler(this.btnThemLS_Click);
            // 
            // txtIDThem
            // 
            this.txtIDThem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDThem.Location = new System.Drawing.Point(149, 37);
            this.txtIDThem.Name = "txtIDThem";
            this.txtIDThem.Size = new System.Drawing.Size(173, 30);
            this.txtIDThem.TabIndex = 19;
            // 
            // lbnTenLoai
            // 
            this.lbnTenLoai.AutoSize = true;
            this.lbnTenLoai.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnTenLoai.Location = new System.Drawing.Point(20, 11);
            this.lbnTenLoai.Name = "lbnTenLoai";
            this.lbnTenLoai.Size = new System.Drawing.Size(177, 23);
            this.lbnTenLoai.TabIndex = 17;
            this.lbnTenLoai.Text = "THÊM THỂ LOẠI:";
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnHuy.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.ForeColor = System.Drawing.Color.Black;
            this.btnHuy.Location = new System.Drawing.Point(341, 366);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(112, 40);
            this.btnHuy.TabIndex = 25;
            this.btnHuy.Text = "HỦY";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.Black;
            this.btnThoat.Location = new System.Drawing.Point(459, 366);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(112, 40);
            this.btnThoat.TabIndex = 26;
            this.btnThoat.Text = "THOÁT";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // txtNameThem
            // 
            this.txtNameThem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameThem.Location = new System.Drawing.Point(149, 78);
            this.txtNameThem.Name = "txtNameThem";
            this.txtNameThem.Size = new System.Drawing.Size(173, 30);
            this.txtNameThem.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 23);
            this.label1.TabIndex = 28;
            this.label1.Text = "ID Thể loại:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 23);
            this.label2.TabIndex = 29;
            this.label2.Text = "Tên Thể loại:";
            // 
            // cmbXoaName
            // 
            this.cmbXoaName.DataSource = this.lOAISACHBindingSource;
            this.cmbXoaName.DisplayMember = "TENLOAISACH";
            this.cmbXoaName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbXoaName.FormattingEnabled = true;
            this.cmbXoaName.Location = new System.Drawing.Point(147, 77);
            this.cmbXoaName.Name = "cmbXoaName";
            this.cmbXoaName.Size = new System.Drawing.Size(173, 30);
            this.cmbXoaName.TabIndex = 30;
            this.cmbXoaName.ValueMember = "IDSACH";
            // 
            // lOAISACHBindingSource
            // 
            this.lOAISACHBindingSource.DataMember = "LOAISACH";
            this.lOAISACHBindingSource.DataSource = this.qLNSDataSet4;
            // 
            // qLNSDataSet4
            // 
            this.qLNSDataSet4.DataSetName = "QLNSDataSet4";
            this.qLNSDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lOAISACHTableAdapter
            // 
            this.lOAISACHTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtNameThem);
            this.panel1.Controls.Add(this.btnThemLS);
            this.panel1.Controls.Add(this.txtIDThem);
            this.panel1.Controls.Add(this.lbnTenLoai);
            this.panel1.Location = new System.Drawing.Point(272, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(360, 171);
            this.panel1.TabIndex = 31;
            // 
            // cmbIDXoa
            // 
            this.cmbIDXoa.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.lOAISACHBindingSource, "TENLOAISACH", true));
            this.cmbIDXoa.DataSource = this.lOAISACHBindingSource;
            this.cmbIDXoa.DisplayMember = "IDSACH";
            this.cmbIDXoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbIDXoa.FormattingEnabled = true;
            this.cmbIDXoa.Location = new System.Drawing.Point(147, 41);
            this.cmbIDXoa.Name = "cmbIDXoa";
            this.cmbIDXoa.Size = new System.Drawing.Size(173, 30);
            this.cmbIDXoa.TabIndex = 32;
            this.cmbIDXoa.ValueMember = "TENLOAISACH";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 23);
            this.label3.TabIndex = 30;
            this.label3.Text = "XÓA THỂ LOẠI:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.cmbIDXoa);
            this.panel2.Controls.Add(this.cmbXoaName);
            this.panel2.Controls.Add(this.btnXoaLS);
            this.panel2.Location = new System.Drawing.Point(274, 192);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(357, 163);
            this.panel2.TabIndex = 33;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 23);
            this.label4.TabIndex = 30;
            this.label4.Text = "ID Thể loại:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 23);
            this.label5.TabIndex = 30;
            this.label5.Text = "Tên Thể loại:";
            // 
            // FormTheLoai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(642, 418);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.dgvLoaiSach);
            this.Name = "FormTheLoai";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "THỂ LOẠI";
            this.Load += new System.EventHandler(this.FormTheLoai_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOAISACHBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNSDataSet4)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLoaiSach;
        private System.Windows.Forms.Button btnXoaLS;
        private System.Windows.Forms.Button btnThemLS;
        private System.Windows.Forms.TextBox txtIDThem;
        private System.Windows.Forms.Label lbnTenLoai;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.TextBox txtNameThem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbXoaName;
        private QLNSDataSet4 qLNSDataSet4;
        private System.Windows.Forms.BindingSource lOAISACHBindingSource;
        private QLNSDataSet4TableAdapters.LOAISACHTableAdapter lOAISACHTableAdapter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbIDXoa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}