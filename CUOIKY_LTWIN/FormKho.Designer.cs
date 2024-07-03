
namespace CUOIKY_LTWIN
{
    partial class FormKho
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
            this.dgvKho = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.sACHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLNSDataSet7 = new CUOIKY_LTWIN.QLNSDataSet7();
            this.sACHBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.qLNSDataSet8 = new CUOIKY_LTWIN.QLNSDataSet8();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbSua = new System.Windows.Forms.ComboBox();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.txtSoluong = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.kHOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLNSDataSet5 = new CUOIKY_LTWIN.QLNSDataSet5();
            this.btnThoat = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmbTenThem = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbThem = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtSoLuongThem = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.kHOTableAdapter = new CUOIKY_LTWIN.QLNSDataSet5TableAdapters.KHOTableAdapter();
            this.sACHTableAdapter = new CUOIKY_LTWIN.QLNSDataSet7TableAdapters.SACHTableAdapter();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cmbNameXoa = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbIDXoa = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.sACHTableAdapter1 = new CUOIKY_LTWIN.QLNSDataSet8TableAdapters.SACHTableAdapter();
            this.qLNSDataSet9 = new CUOIKY_LTWIN.QLNSDataSet9();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKho)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sACHBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNSDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sACHBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNSDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNSDataSet5)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qLNSDataSet9)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvKho
            // 
            this.dgvKho.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgvKho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKho.Location = new System.Drawing.Point(12, 12);
            this.dgvKho.Name = "dgvKho";
            this.dgvKho.RowHeadersWidth = 51;
            this.dgvKho.RowTemplate.Height = 24;
            this.dgvKho.Size = new System.Drawing.Size(338, 231);
            this.dgvKho.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.cmbSua);
            this.panel1.Controls.Add(this.btnHuy);
            this.panel1.Controls.Add(this.btnSua);
            this.panel1.Controls.Add(this.txtSoluong);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(356, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(331, 231);
            this.panel1.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.sACHBindingSource;
            this.comboBox1.DisplayMember = "TENSACH";
            this.comboBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(92, 87);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(233, 30);
            this.comboBox1.TabIndex = 14;
            this.comboBox1.ValueMember = "MASACH";
            // 
            // sACHBindingSource
            // 
            this.sACHBindingSource.DataMember = "SACH";
            this.sACHBindingSource.DataSource = this.qLNSDataSet7;
            // 
            // qLNSDataSet7
            // 
            this.qLNSDataSet7.DataSetName = "QLNSDataSet7";
            this.qLNSDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sACHBindingSource1
            // 
            this.sACHBindingSource1.DataMember = "SACH";
            this.sACHBindingSource1.DataSource = this.qLNSDataSet8;
            // 
            // qLNSDataSet8
            // 
            this.qLNSDataSet8.DataSetName = "QLNSDataSet8";
            this.qLNSDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 94);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 23);
            this.label8.TabIndex = 13;
            this.label8.Text = "Tên sách:";
            // 
            // cmbSua
            // 
            this.cmbSua.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.sACHBindingSource, "TENSACH", true));
            this.cmbSua.DataSource = this.sACHBindingSource;
            this.cmbSua.DisplayMember = "MASACH";
            this.cmbSua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSua.FormattingEnabled = true;
            this.cmbSua.Location = new System.Drawing.Point(92, 44);
            this.cmbSua.Name = "cmbSua";
            this.cmbSua.Size = new System.Drawing.Size(233, 30);
            this.cmbSua.TabIndex = 12;
            this.cmbSua.ValueMember = "TENSACH";
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnHuy.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Location = new System.Drawing.Point(193, 169);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(85, 39);
            this.btnHuy.TabIndex = 6;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnSua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(46, 169);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(85, 39);
            this.btnSua.TabIndex = 5;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // txtSoluong
            // 
            this.txtSoluong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoluong.Location = new System.Drawing.Point(92, 133);
            this.txtSoluong.Name = "txtSoluong";
            this.txtSoluong.Size = new System.Drawing.Size(233, 30);
            this.txtSoluong.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Số lượng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID sách:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sửa sách :";
            // 
            // kHOBindingSource
            // 
            this.kHOBindingSource.DataMember = "KHO";
            this.kHOBindingSource.DataSource = this.qLNSDataSet5;
            // 
            // qLNSDataSet5
            // 
            this.qLNSDataSet5.DataSetName = "QLNSDataSet5";
            this.qLNSDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(448, 443);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(128, 39);
            this.btnThoat.TabIndex = 9;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Controls.Add(this.cmbTenThem);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.cmbThem);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.btnThem);
            this.panel2.Controls.Add(this.txtSoLuongThem);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(12, 249);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(338, 233);
            this.panel2.TabIndex = 10;
            // 
            // cmbTenThem
            // 
            this.cmbTenThem.DataSource = this.sACHBindingSource;
            this.cmbTenThem.DisplayMember = "TENSACH";
            this.cmbTenThem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTenThem.FormattingEnabled = true;
            this.cmbTenThem.Location = new System.Drawing.Point(92, 93);
            this.cmbTenThem.Name = "cmbTenThem";
            this.cmbTenThem.Size = new System.Drawing.Size(233, 30);
            this.cmbTenThem.TabIndex = 15;
            this.cmbTenThem.ValueMember = "MASACH";
            this.cmbTenThem.SelectedIndexChanged += new System.EventHandler(this.cmbTenThem_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 23);
            this.label7.TabIndex = 14;
            this.label7.Text = "Tên sách:";
            // 
            // cmbThem
            // 
            this.cmbThem.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.sACHBindingSource, "TENSACH", true));
            this.cmbThem.DataSource = this.sACHBindingSource;
            this.cmbThem.DisplayMember = "MASACH";
            this.cmbThem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbThem.FormattingEnabled = true;
            this.cmbThem.Location = new System.Drawing.Point(92, 44);
            this.cmbThem.Name = "cmbThem";
            this.cmbThem.Size = new System.Drawing.Size(233, 30);
            this.cmbThem.TabIndex = 13;
            this.cmbThem.ValueMember = "TENSACH";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(193, 174);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 39);
            this.button1.TabIndex = 6;
            this.button1.Text = "Hủy";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(46, 174);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(85, 39);
            this.btnThem.TabIndex = 5;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtSoLuongThem
            // 
            this.txtSoLuongThem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoLuongThem.Location = new System.Drawing.Point(92, 138);
            this.txtSoLuongThem.Name = "txtSoLuongThem";
            this.txtSoLuongThem.Size = new System.Drawing.Size(233, 30);
            this.txtSoLuongThem.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Số lượng:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 23);
            this.label5.TabIndex = 1;
            this.label5.Text = "ID sách:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 23);
            this.label6.TabIndex = 0;
            this.label6.Text = "Thêm sách :";
            // 
            // kHOTableAdapter
            // 
            this.kHOTableAdapter.ClearBeforeFill = true;
            // 
            // sACHTableAdapter
            // 
            this.sACHTableAdapter.ClearBeforeFill = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.panel3.Controls.Add(this.cmbNameXoa);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.cmbIDXoa);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.btnXoa);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Location = new System.Drawing.Point(356, 249);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(331, 180);
            this.panel3.TabIndex = 16;
            // 
            // cmbNameXoa
            // 
            this.cmbNameXoa.DataSource = this.sACHBindingSource;
            this.cmbNameXoa.DisplayMember = "TENSACH";
            this.cmbNameXoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbNameXoa.FormattingEnabled = true;
            this.cmbNameXoa.Location = new System.Drawing.Point(92, 87);
            this.cmbNameXoa.Name = "cmbNameXoa";
            this.cmbNameXoa.Size = new System.Drawing.Size(233, 30);
            this.cmbNameXoa.TabIndex = 14;
            this.cmbNameXoa.ValueMember = "MASACH";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 94);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 23);
            this.label9.TabIndex = 13;
            this.label9.Text = "Tên sách:";
            // 
            // cmbIDXoa
            // 
            this.cmbIDXoa.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.sACHBindingSource, "TENSACH", true));
            this.cmbIDXoa.DataSource = this.sACHBindingSource;
            this.cmbIDXoa.DisplayMember = "MASACH";
            this.cmbIDXoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbIDXoa.FormattingEnabled = true;
            this.cmbIDXoa.Location = new System.Drawing.Point(92, 44);
            this.cmbIDXoa.Name = "cmbIDXoa";
            this.cmbIDXoa.Size = new System.Drawing.Size(233, 30);
            this.cmbIDXoa.TabIndex = 12;
            this.cmbIDXoa.ValueMember = "TENSACH";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(193, 132);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 39);
            this.button2.TabIndex = 6;
            this.button2.Text = "Hủy";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(46, 132);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(85, 39);
            this.btnXoa.TabIndex = 5;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click_1);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(6, 51);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 23);
            this.label11.TabIndex = 1;
            this.label11.Text = "ID sách:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(6, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(98, 23);
            this.label12.TabIndex = 0;
            this.label12.Text = "Xóa sách :";
            // 
            // sACHTableAdapter1
            // 
            this.sACHTableAdapter1.ClearBeforeFill = true;
            // 
            // qLNSDataSet9
            // 
            this.qLNSDataSet9.DataSetName = "QLNSDataSet9";
            this.qLNSDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FormKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(697, 494);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvKho);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FormKho";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KHO";
            this.Load += new System.EventHandler(this.FormKho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKho)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sACHBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNSDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sACHBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNSDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNSDataSet5)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qLNSDataSet9)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvKho;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.TextBox txtSoluong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtSoLuongThem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private QLNSDataSet5 qLNSDataSet5;
        private System.Windows.Forms.BindingSource kHOBindingSource;
        private QLNSDataSet5TableAdapters.KHOTableAdapter kHOTableAdapter;
        private System.Windows.Forms.ComboBox cmbSua;
        private System.Windows.Forms.ComboBox cmbThem;
        private QLNSDataSet7 qLNSDataSet7;
        private System.Windows.Forms.BindingSource sACHBindingSource;
        private QLNSDataSet7TableAdapters.SACHTableAdapter sACHTableAdapter;
        private System.Windows.Forms.ComboBox cmbTenThem;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox cmbNameXoa;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbIDXoa;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private QLNSDataSet8 qLNSDataSet8;
        private System.Windows.Forms.BindingSource sACHBindingSource1;
        private QLNSDataSet8TableAdapters.SACHTableAdapter sACHTableAdapter1;
        private QLNSDataSet9 qLNSDataSet9;
    }
}