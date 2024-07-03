
namespace CUOIKY_LTWIN
{
    partial class FormTacGia
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
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.dgvTacGia = new System.Windows.Forms.DataGridView();
            this.dtpNgayMat = new System.Windows.Forms.DateTimePicker();
            this.lbnNgayMat = new System.Windows.Forms.Label();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.lbnNgaySinh = new System.Windows.Forms.Label();
            this.txtQueQuan = new System.Windows.Forms.TextBox();
            this.lbnQueQuan = new System.Windows.Forms.Label();
            this.txtTenTG = new System.Windows.Forms.TextBox();
            this.lbnTenTG = new System.Windows.Forms.Label();
            this.txtMaTG = new System.Windows.Forms.TextBox();
            this.lbnMaTG = new System.Windows.Forms.Label();
            this.lbnThongTin = new System.Windows.Forms.Label();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.cmbXoa = new System.Windows.Forms.ComboBox();
            this.tACGIABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLNSDataSet1 = new CUOIKY_LTWIN.QLNSDataSet1();
            this.tACGIATableAdapter = new CUOIKY_LTWIN.QLNSDataSet1TableAdapters.TACGIATableAdapter();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTacGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tACGIABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNSDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnXoa.Location = new System.Drawing.Point(68, 566);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(110, 35);
            this.btnXoa.TabIndex = 52;
            this.btnXoa.Text = "XÓA";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnLuu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.Color.Black;
            this.btnLuu.Location = new System.Drawing.Point(17, 329);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(110, 35);
            this.btnLuu.TabIndex = 49;
            this.btnLuu.Text = "LƯU";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // dgvTacGia
            // 
            this.dgvTacGia.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvTacGia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTacGia.Location = new System.Drawing.Point(411, 27);
            this.dgvTacGia.Name = "dgvTacGia";
            this.dgvTacGia.RowHeadersWidth = 51;
            this.dgvTacGia.RowTemplate.Height = 24;
            this.dgvTacGia.Size = new System.Drawing.Size(649, 574);
            this.dgvTacGia.TabIndex = 48;
            // 
            // dtpNgayMat
            // 
            this.dtpNgayMat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dtpNgayMat.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayMat.Location = new System.Drawing.Point(159, 282);
            this.dtpNgayMat.Name = "dtpNgayMat";
            this.dtpNgayMat.Size = new System.Drawing.Size(231, 30);
            this.dtpNgayMat.TabIndex = 44;
            // 
            // lbnNgayMat
            // 
            this.lbnNgayMat.AutoSize = true;
            this.lbnNgayMat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnNgayMat.Location = new System.Drawing.Point(16, 287);
            this.lbnNgayMat.Name = "lbnNgayMat";
            this.lbnNgayMat.Size = new System.Drawing.Size(122, 23);
            this.lbnNgayMat.TabIndex = 42;
            this.lbnNgayMat.Text = "NGÀY MẤT:";
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaySinh.Location = new System.Drawing.Point(159, 229);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(231, 30);
            this.dtpNgaySinh.TabIndex = 43;
            // 
            // lbnNgaySinh
            // 
            this.lbnNgaySinh.AutoSize = true;
            this.lbnNgaySinh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnNgaySinh.Location = new System.Drawing.Point(16, 234);
            this.lbnNgaySinh.Name = "lbnNgaySinh";
            this.lbnNgaySinh.Size = new System.Drawing.Size(125, 23);
            this.lbnNgaySinh.TabIndex = 41;
            this.lbnNgaySinh.Text = "NGÀY SINH:";
            // 
            // txtQueQuan
            // 
            this.txtQueQuan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQueQuan.Location = new System.Drawing.Point(159, 173);
            this.txtQueQuan.Name = "txtQueQuan";
            this.txtQueQuan.Size = new System.Drawing.Size(231, 30);
            this.txtQueQuan.TabIndex = 39;
            // 
            // lbnQueQuan
            // 
            this.lbnQueQuan.AutoSize = true;
            this.lbnQueQuan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnQueQuan.Location = new System.Drawing.Point(16, 180);
            this.lbnQueQuan.Name = "lbnQueQuan";
            this.lbnQueQuan.Size = new System.Drawing.Size(123, 23);
            this.lbnQueQuan.TabIndex = 36;
            this.lbnQueQuan.Text = "QUÊ QUÁN:";
            // 
            // txtTenTG
            // 
            this.txtTenTG.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenTG.Location = new System.Drawing.Point(159, 119);
            this.txtTenTG.Name = "txtTenTG";
            this.txtTenTG.Size = new System.Drawing.Size(231, 30);
            this.txtTenTG.TabIndex = 38;
            // 
            // lbnTenTG
            // 
            this.lbnTenTG.AutoSize = true;
            this.lbnTenTG.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnTenTG.Location = new System.Drawing.Point(16, 126);
            this.lbnTenTG.Name = "lbnTenTG";
            this.lbnTenTG.Size = new System.Drawing.Size(145, 23);
            this.lbnTenTG.TabIndex = 35;
            this.lbnTenTG.Text = "TÊN TÁC GIẢ:";
            // 
            // txtMaTG
            // 
            this.txtMaTG.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaTG.Location = new System.Drawing.Point(159, 65);
            this.txtMaTG.Name = "txtMaTG";
            this.txtMaTG.Size = new System.Drawing.Size(231, 30);
            this.txtMaTG.TabIndex = 40;
            // 
            // lbnMaTG
            // 
            this.lbnMaTG.AutoSize = true;
            this.lbnMaTG.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnMaTG.Location = new System.Drawing.Point(16, 72);
            this.lbnMaTG.Name = "lbnMaTG";
            this.lbnMaTG.Size = new System.Drawing.Size(137, 23);
            this.lbnMaTG.TabIndex = 37;
            this.lbnMaTG.Text = "MÃ TÁC GIẢ:";
            // 
            // lbnThongTin
            // 
            this.lbnThongTin.AutoSize = true;
            this.lbnThongTin.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnThongTin.Location = new System.Drawing.Point(13, 27);
            this.lbnThongTin.Name = "lbnThongTin";
            this.lbnThongTin.Size = new System.Drawing.Size(209, 23);
            this.lbnThongTin.TabIndex = 34;
            this.lbnThongTin.Text = "THÔNG TIN TÁC GIẢ:";
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnSua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.Black;
            this.btnSua.Location = new System.Drawing.Point(148, 329);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(104, 35);
            this.btnSua.TabIndex = 54;
            this.btnSua.Text = "SỬA";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnHuy.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.ForeColor = System.Drawing.Color.Black;
            this.btnHuy.Location = new System.Drawing.Point(280, 329);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(110, 35);
            this.btnHuy.TabIndex = 55;
            this.btnHuy.Text = "HỦY";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.Black;
            this.btnThoat.Location = new System.Drawing.Point(208, 566);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(104, 35);
            this.btnThoat.TabIndex = 56;
            this.btnThoat.Text = "THOÁT";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // cmbXoa
            // 
            this.cmbXoa.DataSource = this.tACGIABindingSource;
            this.cmbXoa.DisplayMember = "MATG";
            this.cmbXoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbXoa.FormattingEnabled = true;
            this.cmbXoa.Location = new System.Drawing.Point(159, 434);
            this.cmbXoa.Name = "cmbXoa";
            this.cmbXoa.Size = new System.Drawing.Size(231, 30);
            this.cmbXoa.TabIndex = 57;
            this.cmbXoa.ValueMember = "TENTG";
            // 
            // tACGIABindingSource
            // 
            this.tACGIABindingSource.DataMember = "TACGIA";
            this.tACGIABindingSource.DataSource = this.qLNSDataSet1;
            // 
            // qLNSDataSet1
            // 
            this.qLNSDataSet1.DataSetName = "QLNSDataSet1";
            this.qLNSDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tACGIATableAdapter
            // 
            this.tACGIATableAdapter.ClearBeforeFill = true;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.tACGIABindingSource;
            this.comboBox1.DisplayMember = "MATG";
            this.comboBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(159, 492);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(231, 30);
            this.comboBox1.TabIndex = 58;
            this.comboBox1.ValueMember = "TENTG";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 436);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 23);
            this.label1.TabIndex = 59;
            this.label1.Text = "MÃ TÁC GIẢ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 499);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 23);
            this.label2.TabIndex = 60;
            this.label2.Text = "TÊN TÁC GIẢ:";
            // 
            // FormTacGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1102, 624);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.cmbXoa);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.dgvTacGia);
            this.Controls.Add(this.dtpNgayMat);
            this.Controls.Add(this.lbnNgayMat);
            this.Controls.Add(this.dtpNgaySinh);
            this.Controls.Add(this.lbnNgaySinh);
            this.Controls.Add(this.txtQueQuan);
            this.Controls.Add(this.lbnQueQuan);
            this.Controls.Add(this.txtTenTG);
            this.Controls.Add(this.lbnTenTG);
            this.Controls.Add(this.txtMaTG);
            this.Controls.Add(this.lbnMaTG);
            this.Controls.Add(this.lbnThongTin);
            this.Name = "FormTacGia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TÁC GIẢ";
            this.Load += new System.EventHandler(this.TacGia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTacGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tACGIABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNSDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.DataGridView dgvTacGia;
        private System.Windows.Forms.DateTimePicker dtpNgayMat;
        private System.Windows.Forms.Label lbnNgayMat;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.Label lbnNgaySinh;
        private System.Windows.Forms.TextBox txtQueQuan;
        private System.Windows.Forms.Label lbnQueQuan;
        private System.Windows.Forms.TextBox txtTenTG;
        private System.Windows.Forms.Label lbnTenTG;
        private System.Windows.Forms.TextBox txtMaTG;
        private System.Windows.Forms.Label lbnMaTG;
        private System.Windows.Forms.Label lbnThongTin;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.ComboBox cmbXoa;
        private QLNSDataSet1 qLNSDataSet1;
        private System.Windows.Forms.BindingSource tACGIABindingSource;
        private QLNSDataSet1TableAdapters.TACGIATableAdapter tACGIATableAdapter;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}