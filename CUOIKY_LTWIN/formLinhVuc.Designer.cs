
namespace CUOIKY_LTWIN
{
    partial class formLinhVuc
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
            this.dgvLinhVuc = new System.Windows.Forms.DataGridView();
            this.btnXoaLV = new System.Windows.Forms.Button();
            this.btnThemLV = new System.Windows.Forms.Button();
            this.lINHVUCBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.qLNSDataSet = new CUOIKY_LTWIN.QLNSDataSet();
            this.lINHVUCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtID = new System.Windows.Forms.TextBox();
            this.lbnTenSach = new System.Windows.Forms.Label();
            this.lbnTacGia = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.lINHVUCTableAdapter = new CUOIKY_LTWIN.QLNSDataSetTableAdapters.LINHVUCTableAdapter();
            this.lINHVUCBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btnReload = new System.Windows.Forms.Button();
            this.cmbXoaID = new System.Windows.Forms.ComboBox();
            this.lINHVUCBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.qLNSDataSet3 = new CUOIKY_LTWIN.QLNSDataSet3();
            this.lINHVUCTableAdapter1 = new CUOIKY_LTWIN.QLNSDataSet3TableAdapters.LINHVUCTableAdapter();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbNamXoa = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLinhVuc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lINHVUCBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lINHVUCBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lINHVUCBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lINHVUCBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNSDataSet3)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvLinhVuc
            // 
            this.dgvLinhVuc.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvLinhVuc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLinhVuc.Location = new System.Drawing.Point(413, 11);
            this.dgvLinhVuc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvLinhVuc.Name = "dgvLinhVuc";
            this.dgvLinhVuc.RowHeadersWidth = 51;
            this.dgvLinhVuc.RowTemplate.Height = 24;
            this.dgvLinhVuc.Size = new System.Drawing.Size(254, 317);
            this.dgvLinhVuc.TabIndex = 16;
            // 
            // btnXoaLV
            // 
            this.btnXoaLV.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnXoaLV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaLV.ForeColor = System.Drawing.Color.Black;
            this.btnXoaLV.Location = new System.Drawing.Point(101, 129);
            this.btnXoaLV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoaLV.Name = "btnXoaLV";
            this.btnXoaLV.Size = new System.Drawing.Size(133, 40);
            this.btnXoaLV.TabIndex = 14;
            this.btnXoaLV.Text = "XÓA";
            this.btnXoaLV.UseVisualStyleBackColor = false;
            this.btnXoaLV.Click += new System.EventHandler(this.btnXoaLV_Click);
            // 
            // btnThemLV
            // 
            this.btnThemLV.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnThemLV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemLV.ForeColor = System.Drawing.Color.Black;
            this.btnThemLV.Location = new System.Drawing.Point(101, 133);
            this.btnThemLV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThemLV.Name = "btnThemLV";
            this.btnThemLV.Size = new System.Drawing.Size(133, 37);
            this.btnThemLV.TabIndex = 15;
            this.btnThemLV.Text = "THÊM";
            this.btnThemLV.UseVisualStyleBackColor = false;
            this.btnThemLV.Click += new System.EventHandler(this.btnThemLV_Click);
            // 
            // lINHVUCBindingSource2
            // 
            this.lINHVUCBindingSource2.DataMember = "LINHVUC";
            this.lINHVUCBindingSource2.DataSource = this.qLNSDataSet;
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
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(184, 54);
            this.txtID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(172, 30);
            this.txtID.TabIndex = 12;
            // 
            // lbnTenSach
            // 
            this.lbnTenSach.AutoSize = true;
            this.lbnTenSach.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnTenSach.Location = new System.Drawing.Point(14, 17);
            this.lbnTenSach.Name = "lbnTenSach";
            this.lbnTenSach.Size = new System.Drawing.Size(178, 23);
            this.lbnTenSach.TabIndex = 10;
            this.lbnTenSach.Text = "THÊM LĨNH VỰC:";
            // 
            // lbnTacGia
            // 
            this.lbnTacGia.AutoSize = true;
            this.lbnTacGia.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnTacGia.Location = new System.Drawing.Point(16, 56);
            this.lbnTacGia.Name = "lbnTacGia";
            this.lbnTacGia.Size = new System.Drawing.Size(117, 23);
            this.lbnTacGia.TabIndex = 11;
            this.lbnTacGia.Text = "ID Lĩnh vực:";
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.Black;
            this.btnThoat.Location = new System.Drawing.Point(552, 343);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(100, 46);
            this.btnThoat.TabIndex = 17;
            this.btnThoat.Text = "THOÁT";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // lINHVUCTableAdapter
            // 
            this.lINHVUCTableAdapter.ClearBeforeFill = true;
            // 
            // lINHVUCBindingSource1
            // 
            this.lINHVUCBindingSource1.DataMember = "LINHVUC";
            this.lINHVUCBindingSource1.DataSource = this.qLNSDataSet;
            // 
            // btnReload
            // 
            this.btnReload.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnReload.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReload.ForeColor = System.Drawing.Color.Black;
            this.btnReload.Location = new System.Drawing.Point(413, 345);
            this.btnReload.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(118, 43);
            this.btnReload.TabIndex = 18;
            this.btnReload.Text = "RELOAD";
            this.btnReload.UseVisualStyleBackColor = false;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // cmbXoaID
            // 
            this.cmbXoaID.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.lINHVUCBindingSource3, "TENLINHVUC", true));
            this.cmbXoaID.DataSource = this.lINHVUCBindingSource3;
            this.cmbXoaID.DisplayMember = "ID";
            this.cmbXoaID.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbXoaID.FormattingEnabled = true;
            this.cmbXoaID.Location = new System.Drawing.Point(184, 54);
            this.cmbXoaID.Name = "cmbXoaID";
            this.cmbXoaID.Size = new System.Drawing.Size(148, 30);
            this.cmbXoaID.TabIndex = 19;
            this.cmbXoaID.ValueMember = "TENLINHVUC";
            // 
            // lINHVUCBindingSource3
            // 
            this.lINHVUCBindingSource3.DataMember = "LINHVUC";
            this.lINHVUCBindingSource3.DataSource = this.qLNSDataSet3;
            // 
            // qLNSDataSet3
            // 
            this.qLNSDataSet3.DataSetName = "QLNSDataSet3";
            this.qLNSDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lINHVUCTableAdapter1
            // 
            this.lINHVUCTableAdapter1.ClearBeforeFill = true;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(184, 99);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(172, 30);
            this.txtName.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 23);
            this.label1.TabIndex = 21;
            this.label1.Text = "ID Lĩnh vực:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 23);
            this.label2.TabIndex = 22;
            this.label2.Text = "Tên lĩnh vực:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.btnThemLV);
            this.panel1.Controls.Add(this.txtID);
            this.panel1.Controls.Add(this.lbnTenSach);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(380, 185);
            this.panel1.TabIndex = 23;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cmbNamXoa);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.cmbXoaID);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.btnXoaLV);
            this.panel2.Controls.Add(this.lbnTacGia);
            this.panel2.Location = new System.Drawing.Point(12, 204);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(380, 185);
            this.panel2.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 23);
            this.label3.TabIndex = 22;
            this.label3.Text = "Tên lĩnh vực:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 23);
            this.label5.TabIndex = 10;
            this.label5.Text = "XÓA LĨNH VỰC:";
            // 
            // cmbNamXoa
            // 
            this.cmbNamXoa.DataSource = this.lINHVUCBindingSource3;
            this.cmbNamXoa.DisplayMember = "TENLINHVUC";
            this.cmbNamXoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbNamXoa.FormattingEnabled = true;
            this.cmbNamXoa.Location = new System.Drawing.Point(184, 94);
            this.cmbNamXoa.Name = "cmbNamXoa";
            this.cmbNamXoa.Size = new System.Drawing.Size(148, 30);
            this.cmbNamXoa.TabIndex = 23;
            this.cmbNamXoa.ValueMember = "ID";
            // 
            // formLinhVuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(679, 406);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.dgvLinhVuc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "formLinhVuc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LĨNH VỰC";
            this.Load += new System.EventHandler(this.formLinhVuc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLinhVuc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lINHVUCBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lINHVUCBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lINHVUCBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lINHVUCBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNSDataSet3)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLinhVuc;
        private System.Windows.Forms.Button btnXoaLV;
        private System.Windows.Forms.Button btnThemLV;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lbnTenSach;
        private System.Windows.Forms.Label lbnTacGia;
        private System.Windows.Forms.Button btnThoat;
        private QLNSDataSet qLNSDataSet;
        private System.Windows.Forms.BindingSource lINHVUCBindingSource;
        private QLNSDataSetTableAdapters.LINHVUCTableAdapter lINHVUCTableAdapter;
        private System.Windows.Forms.BindingSource lINHVUCBindingSource1;
        private System.Windows.Forms.BindingSource lINHVUCBindingSource2;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.ComboBox cmbXoaID;
        private QLNSDataSet3 qLNSDataSet3;
        private System.Windows.Forms.BindingSource lINHVUCBindingSource3;
        private QLNSDataSet3TableAdapters.LINHVUCTableAdapter lINHVUCTableAdapter1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cmbNamXoa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
    }
}