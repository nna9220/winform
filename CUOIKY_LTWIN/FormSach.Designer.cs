
namespace CUOIKY_LTWIN
{
    partial class FormSach
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
            this.dgvSach = new System.Windows.Forms.DataGridView();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.cmbXoaID = new System.Windows.Forms.ComboBox();
            this.sACHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLNSDataSet2 = new CUOIKY_LTWIN.QLNSDataSet2();
            this.sACHTableAdapter = new CUOIKY_LTWIN.QLNSDataSet2TableAdapters.SACHTableAdapter();
            this.qLNSDataSet = new CUOIKY_LTWIN.QLNSDataSet();
            this.lINHVUCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lINHVUCTableAdapter = new CUOIKY_LTWIN.QLNSDataSetTableAdapters.LINHVUCTableAdapter();
            this.qLNSDataSet1 = new CUOIKY_LTWIN.QLNSDataSet1();
            this.lINHVUCBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.lINHVUCTableAdapter1 = new CUOIKY_LTWIN.QLNSDataSet1TableAdapters.LINHVUCTableAdapter();
            this.lbnThongTin = new System.Windows.Forms.Label();
            this.txtTim = new System.Windows.Forms.TextBox();
            this.btnTim = new System.Windows.Forms.Button();
            this.cmbXoaName = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.qLNSDataSet13 = new CUOIKY_LTWIN.QLNSDataSet13();
            this.lOAISACHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lOAISACHTableAdapter = new CUOIKY_LTWIN.QLNSDataSet13TableAdapters.LOAISACHTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sACHBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNSDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lINHVUCBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNSDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lINHVUCBindingSource1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qLNSDataSet13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOAISACHBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSach
            // 
            this.dgvSach.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvSach.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSach.Location = new System.Drawing.Point(16, 66);
            this.dgvSach.Name = "dgvSach";
            this.dgvSach.RowHeadersWidth = 51;
            this.dgvSach.RowTemplate.Height = 24;
            this.dgvSach.Size = new System.Drawing.Size(837, 331);
            this.dgvSach.TabIndex = 15;
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.SystemColors.Control;
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.Navy;
            this.btnThoat.Location = new System.Drawing.Point(116, 75);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(136, 40);
            this.btnThoat.TabIndex = 14;
            this.btnThoat.Text = "THOÁT";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.SystemColors.Control;
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnXoa.Location = new System.Drawing.Point(143, 92);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(136, 40);
            this.btnXoa.TabIndex = 13;
            this.btnXoa.Text = "XÓA";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.SystemColors.Control;
            this.btnSua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.Olive;
            this.btnSua.Location = new System.Drawing.Point(192, 10);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(136, 40);
            this.btnSua.TabIndex = 12;
            this.btnSua.Text = "SỬA";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.SystemColors.Control;
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.Green;
            this.btnThem.Location = new System.Drawing.Point(35, 10);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(136, 40);
            this.btnThem.TabIndex = 11;
            this.btnThem.Text = "THÊM";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // cmbXoaID
            // 
            this.cmbXoaID.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.sACHBindingSource, "TENSACH", true));
            this.cmbXoaID.DataSource = this.sACHBindingSource;
            this.cmbXoaID.DisplayMember = "MASACH";
            this.cmbXoaID.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbXoaID.FormattingEnabled = true;
            this.cmbXoaID.Location = new System.Drawing.Point(163, 11);
            this.cmbXoaID.Name = "cmbXoaID";
            this.cmbXoaID.Size = new System.Drawing.Size(214, 30);
            this.cmbXoaID.TabIndex = 17;
            this.cmbXoaID.ValueMember = "TENSACH";
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
            // qLNSDataSet
            // 
            this.qLNSDataSet.DataSetName = "QLNSDataSet";
            this.qLNSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lINHVUCBindingSource
            // 
            this.lINHVUCBindingSource.DataMember = "LINHVUC";
            this.lINHVUCBindingSource.DataSource = this.qLNSDataSet;
            // 
            // lINHVUCTableAdapter
            // 
            this.lINHVUCTableAdapter.ClearBeforeFill = true;
            // 
            // qLNSDataSet1
            // 
            this.qLNSDataSet1.DataSetName = "QLNSDataSet1";
            this.qLNSDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lINHVUCBindingSource1
            // 
            this.lINHVUCBindingSource1.DataMember = "LINHVUC";
            this.lINHVUCBindingSource1.DataSource = this.qLNSDataSet1;
            // 
            // lINHVUCTableAdapter1
            // 
            this.lINHVUCTableAdapter1.ClearBeforeFill = true;
            // 
            // lbnThongTin
            // 
            this.lbnThongTin.AutoSize = true;
            this.lbnThongTin.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnThongTin.Location = new System.Drawing.Point(24, 19);
            this.lbnThongTin.Name = "lbnThongTin";
            this.lbnThongTin.Size = new System.Drawing.Size(271, 23);
            this.lbnThongTin.TabIndex = 35;
            this.lbnThongTin.Text = "NHẬP TÊN THỂ LOẠI SÁCH:";
            // 
            // txtTim
            // 
            this.txtTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTim.Location = new System.Drawing.Point(329, 11);
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(346, 30);
            this.txtTim.TabIndex = 36;
            // 
            // btnTim
            // 
            this.btnTim.BackColor = System.Drawing.SystemColors.Control;
            this.btnTim.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTim.ForeColor = System.Drawing.Color.Green;
            this.btnTim.Location = new System.Drawing.Point(717, 14);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(136, 30);
            this.btnTim.TabIndex = 37;
            this.btnTim.Text = "TÌM";
            this.btnTim.UseVisualStyleBackColor = false;
            this.btnTim.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmbXoaName
            // 
            this.cmbXoaName.DataSource = this.sACHBindingSource;
            this.cmbXoaName.DisplayMember = "TENSACH";
            this.cmbXoaName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbXoaName.FormattingEnabled = true;
            this.cmbXoaName.Location = new System.Drawing.Point(163, 56);
            this.cmbXoaName.Name = "cmbXoaName";
            this.cmbXoaName.Size = new System.Drawing.Size(214, 30);
            this.cmbXoaName.TabIndex = 38;
            this.cmbXoaName.ValueMember = "MASACH";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 23);
            this.label1.TabIndex = 39;
            this.label1.Text = "ID Sách :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 23);
            this.label2.TabIndex = 40;
            this.label2.Text = "Tên sách :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cmbXoaName);
            this.panel1.Controls.Add(this.cmbXoaID);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Location = new System.Drawing.Point(16, 407);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(432, 144);
            this.panel1.TabIndex = 41;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Controls.Add(this.btnThoat);
            this.panel2.Controls.Add(this.btnSua);
            this.panel2.Controls.Add(this.btnThem);
            this.panel2.Location = new System.Drawing.Point(459, 407);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(394, 143);
            this.panel2.TabIndex = 42;
            // 
            // qLNSDataSet13
            // 
            this.qLNSDataSet13.DataSetName = "QLNSDataSet13";
            this.qLNSDataSet13.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lOAISACHBindingSource
            // 
            this.lOAISACHBindingSource.DataMember = "LOAISACH";
            this.lOAISACHBindingSource.DataSource = this.qLNSDataSet13;
            // 
            // lOAISACHTableAdapter
            // 
            this.lOAISACHTableAdapter.ClearBeforeFill = true;
            // 
            // FormSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(879, 551);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.txtTim);
            this.Controls.Add(this.lbnThongTin);
            this.Controls.Add(this.dgvSach);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FormSach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SÁCH";
            this.Load += new System.EventHandler(this.FormSach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sACHBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNSDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lINHVUCBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNSDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lINHVUCBindingSource1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.qLNSDataSet13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOAISACHBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSach;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.ComboBox cmbXoaID;
        private QLNSDataSet2 qLNSDataSet2;
        private System.Windows.Forms.BindingSource sACHBindingSource;
        private QLNSDataSet2TableAdapters.SACHTableAdapter sACHTableAdapter;
        private QLNSDataSet qLNSDataSet;
        private System.Windows.Forms.BindingSource lINHVUCBindingSource;
        private QLNSDataSetTableAdapters.LINHVUCTableAdapter lINHVUCTableAdapter;
        private QLNSDataSet1 qLNSDataSet1;
        private System.Windows.Forms.BindingSource lINHVUCBindingSource1;
        private QLNSDataSet1TableAdapters.LINHVUCTableAdapter lINHVUCTableAdapter1;
        private System.Windows.Forms.Label lbnThongTin;
        private System.Windows.Forms.TextBox txtTim;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.ComboBox cmbXoaName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private QLNSDataSet13 qLNSDataSet13;
        private System.Windows.Forms.BindingSource lOAISACHBindingSource;
        private QLNSDataSet13TableAdapters.LOAISACHTableAdapter lOAISACHTableAdapter;
    }
}