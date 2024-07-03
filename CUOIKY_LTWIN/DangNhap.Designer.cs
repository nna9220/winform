
namespace CUOIKY_LTWIN
{
    partial class DangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DangNhap));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlMatKhau = new System.Windows.Forms.Panel();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.txtDangNhap = new System.Windows.Forms.TextBox();
            this.btnDangky = new System.Windows.Forms.Button();
            this.picHidePass = new System.Windows.Forms.PictureBox();
            this.picShowPass = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picHidePass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picShowPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Green;
            this.panel1.ForeColor = System.Drawing.Color.Peru;
            this.panel1.Location = new System.Drawing.Point(103, 308);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(280, 4);
            this.panel1.TabIndex = 40;
            // 
            // pnlMatKhau
            // 
            this.pnlMatKhau.BackColor = System.Drawing.Color.Green;
            this.pnlMatKhau.ForeColor = System.Drawing.Color.Peru;
            this.pnlMatKhau.Location = new System.Drawing.Point(103, 238);
            this.pnlMatKhau.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlMatKhau.Name = "pnlMatKhau";
            this.pnlMatKhau.Size = new System.Drawing.Size(280, 4);
            this.pnlMatKhau.TabIndex = 39;
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.BackColor = System.Drawing.SystemColors.Control;
            this.txtMatKhau.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatKhau.ForeColor = System.Drawing.Color.Green;
            this.txtMatKhau.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtMatKhau.Location = new System.Drawing.Point(103, 276);
            this.txtMatKhau.Multiline = true;
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.PasswordChar = '*';
            this.txtMatKhau.Size = new System.Drawing.Size(240, 36);
            this.txtMatKhau.TabIndex = 37;
            this.txtMatKhau.Text = "Mật khẩu";
            this.txtMatKhau.TextChanged += new System.EventHandler(this.txtMatKhau_TextChanged);
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangNhap.ForeColor = System.Drawing.Color.Green;
            this.btnDangNhap.Location = new System.Drawing.Point(62, 356);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(148, 33);
            this.btnDangNhap.TabIndex = 31;
            this.btnDangNhap.Text = "Đăng nhập";
            this.btnDangNhap.UseVisualStyleBackColor = true;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click_1);
            // 
            // txtDangNhap
            // 
            this.txtDangNhap.BackColor = System.Drawing.SystemColors.Control;
            this.txtDangNhap.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDangNhap.ForeColor = System.Drawing.Color.Green;
            this.txtDangNhap.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtDangNhap.Location = new System.Drawing.Point(103, 212);
            this.txtDangNhap.Multiline = true;
            this.txtDangNhap.Name = "txtDangNhap";
            this.txtDangNhap.Size = new System.Drawing.Size(240, 36);
            this.txtDangNhap.TabIndex = 30;
            this.txtDangNhap.Text = "Tên đăng nhập";
            this.txtDangNhap.TextChanged += new System.EventHandler(this.txtDangNhap_TextChanged);
            // 
            // btnDangky
            // 
            this.btnDangky.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangky.ForeColor = System.Drawing.Color.Green;
            this.btnDangky.Location = new System.Drawing.Point(240, 356);
            this.btnDangky.Name = "btnDangky";
            this.btnDangky.Size = new System.Drawing.Size(148, 33);
            this.btnDangky.TabIndex = 31;
            this.btnDangky.Text = "Đăng ký";
            this.btnDangky.UseVisualStyleBackColor = true;
            this.btnDangky.Click += new System.EventHandler(this.btnDangKy_Click);
            // 
            // picHidePass
            // 
            this.picHidePass.Image = ((System.Drawing.Image)(resources.GetObject("picHidePass.Image")));
            this.picHidePass.Location = new System.Drawing.Point(349, 265);
            this.picHidePass.Name = "picHidePass";
            this.picHidePass.Size = new System.Drawing.Size(39, 38);
            this.picHidePass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picHidePass.TabIndex = 42;
            this.picHidePass.TabStop = false;
            this.picHidePass.Click += new System.EventHandler(this.picHidePass_Click);
            // 
            // picShowPass
            // 
            this.picShowPass.Image = ((System.Drawing.Image)(resources.GetObject("picShowPass.Image")));
            this.picShowPass.Location = new System.Drawing.Point(349, 265);
            this.picShowPass.Name = "picShowPass";
            this.picShowPass.Size = new System.Drawing.Size(39, 38);
            this.picShowPass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picShowPass.TabIndex = 41;
            this.picShowPass.TabStop = false;
            this.picShowPass.Click += new System.EventHandler(this.picShowPass_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(62, 276);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(35, 36);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 38;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(62, 212);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(35, 36);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 36;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(170, 59);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(103, 98);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            // 
            // DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 479);
            this.Controls.Add(this.picHidePass);
            this.Controls.Add(this.picShowPass);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlMatKhau);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnDangky);
            this.Controls.Add(this.btnDangNhap);
            this.Controls.Add(this.txtDangNhap);
            this.Name = "DangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ĐĂNG NHẬP";
            ((System.ComponentModel.ISupportInitialize)(this.picHidePass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picShowPass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picHidePass;
        private System.Windows.Forms.PictureBox picShowPass;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlMatKhau;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.TextBox txtDangNhap;
        private System.Windows.Forms.Button btnDangky;
    }
}

