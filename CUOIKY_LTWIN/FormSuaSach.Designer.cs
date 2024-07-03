
namespace CUOIKY_LTWIN
{
    partial class FormSuaSach
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
            this.lbnChon = new System.Windows.Forms.Label();
            this.nmrLanTB = new System.Windows.Forms.NumericUpDown();
            this.nmrGiaBia = new System.Windows.Forms.NumericUpDown();
            this.nmrGiaMua = new System.Windows.Forms.NumericUpDown();
            this.dtpNamXuatBan = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbnGiaMua = new System.Windows.Forms.Label();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.cmbID = new System.Windows.Forms.ComboBox();
            this.sACHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLNSDataSet2 = new CUOIKY_LTWIN.QLNSDataSet2();
            this.sACHTableAdapter = new CUOIKY_LTWIN.QLNSDataSet2TableAdapters.SACHTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.nmrLanTB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrGiaBia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrGiaMua)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sACHBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNSDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // lbnChon
            // 
            this.lbnChon.AutoSize = true;
            this.lbnChon.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnChon.Location = new System.Drawing.Point(72, 26);
            this.lbnChon.Name = "lbnChon";
            this.lbnChon.Size = new System.Drawing.Size(248, 23);
            this.lbnChon.TabIndex = 15;
            this.lbnChon.Text = "CHỌN SÁCH MUỐN SỬA:";
            // 
            // nmrLanTB
            // 
            this.nmrLanTB.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmrLanTB.Location = new System.Drawing.Point(168, 160);
            this.nmrLanTB.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nmrLanTB.Name = "nmrLanTB";
            this.nmrLanTB.Size = new System.Drawing.Size(229, 30);
            this.nmrLanTB.TabIndex = 36;
            // 
            // nmrGiaBia
            // 
            this.nmrGiaBia.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmrGiaBia.Location = new System.Drawing.Point(648, 99);
            this.nmrGiaBia.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nmrGiaBia.Name = "nmrGiaBia";
            this.nmrGiaBia.Size = new System.Drawing.Size(247, 30);
            this.nmrGiaBia.TabIndex = 34;
            // 
            // nmrGiaMua
            // 
            this.nmrGiaMua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmrGiaMua.Location = new System.Drawing.Point(168, 99);
            this.nmrGiaMua.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nmrGiaMua.Name = "nmrGiaMua";
            this.nmrGiaMua.Size = new System.Drawing.Size(229, 30);
            this.nmrGiaMua.TabIndex = 35;
            // 
            // dtpNamXuatBan
            // 
            this.dtpNamXuatBan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dtpNamXuatBan.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNamXuatBan.Location = new System.Drawing.Point(648, 156);
            this.dtpNamXuatBan.Name = "dtpNamXuatBan";
            this.dtpNamXuatBan.Size = new System.Drawing.Size(247, 30);
            this.dtpNamXuatBan.TabIndex = 33;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(455, 161);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(168, 23);
            this.label8.TabIndex = 29;
            this.label8.Text = "NĂM XUẤT BẢN:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(455, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 23);
            this.label6.TabIndex = 30;
            this.label6.Text = "GIÁ BÌA:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 161);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(143, 23);
            this.label7.TabIndex = 31;
            this.label7.Text = "LẦN TÁI BẢN:";
            // 
            // lbnGiaMua
            // 
            this.lbnGiaMua.AutoSize = true;
            this.lbnGiaMua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnGiaMua.Location = new System.Drawing.Point(13, 106);
            this.lbnGiaMua.Name = "lbnGiaMua";
            this.lbnGiaMua.Size = new System.Drawing.Size(105, 23);
            this.lbnGiaMua.TabIndex = 32;
            this.lbnGiaMua.Text = "GIÁ MUA:";
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnLuu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.Color.Black;
            this.btnLuu.Location = new System.Drawing.Point(37, 237);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(257, 35);
            this.btnLuu.TabIndex = 37;
            this.btnLuu.Text = "LƯU";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnHuy.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.ForeColor = System.Drawing.Color.Black;
            this.btnHuy.Location = new System.Drawing.Point(325, 237);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(257, 35);
            this.btnHuy.TabIndex = 38;
            this.btnHuy.Text = "HỦY";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.Black;
            this.btnThoat.Location = new System.Drawing.Point(620, 237);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(257, 35);
            this.btnThoat.TabIndex = 39;
            this.btnThoat.Text = "THOÁT";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // cmbID
            // 
            this.cmbID.DataSource = this.sACHBindingSource;
            this.cmbID.DisplayMember = "MASACH";
            this.cmbID.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbID.FormattingEnabled = true;
            this.cmbID.Location = new System.Drawing.Point(337, 24);
            this.cmbID.Name = "cmbID";
            this.cmbID.Size = new System.Drawing.Size(329, 30);
            this.cmbID.TabIndex = 40;
            this.cmbID.ValueMember = "TENSACH";
            // 
            // sACHBindingSource
            // 
            this.sACHBindingSource.DataMember = "SACH";
            this.sACHBindingSource.DataSource = this.qLNSDataSet2;
            // 
            // qLNSDataSet2
            // 
            this.qLNSDataSet2.DataSetName = "QLNSDataSet2";
            this.qLNSDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sACHTableAdapter
            // 
            this.sACHTableAdapter.ClearBeforeFill = true;
            // 
            // FormSuaSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(907, 293);
            this.Controls.Add(this.cmbID);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.nmrLanTB);
            this.Controls.Add(this.nmrGiaBia);
            this.Controls.Add(this.nmrGiaMua);
            this.Controls.Add(this.dtpNamXuatBan);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbnGiaMua);
            this.Controls.Add(this.lbnChon);
            this.Name = "FormSuaSach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SỬA SÁCH";
            this.Load += new System.EventHandler(this.FormSuaSach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nmrLanTB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrGiaBia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrGiaMua)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sACHBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNSDataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbnChon;
        private System.Windows.Forms.NumericUpDown nmrLanTB;
        private System.Windows.Forms.NumericUpDown nmrGiaBia;
        private System.Windows.Forms.NumericUpDown nmrGiaMua;
        private System.Windows.Forms.DateTimePicker dtpNamXuatBan;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbnGiaMua;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.ComboBox cmbID;
        private QLNSDataSet2 qLNSDataSet2;
        private System.Windows.Forms.BindingSource sACHBindingSource;
        private QLNSDataSet2TableAdapters.SACHTableAdapter sACHTableAdapter;
    }
}