namespace A_Persentation_Layer.Frm.Frm_Dialog
{
    partial class DangNhap_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DangNhap_form));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            txt_taiKhoan = new TextBox();
            txt_matKhau = new TextBox();
            btn_dangNhap = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.ErrorImage = Properties.Resources.Giay_Banner;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(21, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(295, 417);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(407, 29);
            label1.Name = "label1";
            label1.Size = new Size(316, 62);
            label1.TabIndex = 1;
            label1.Text = "SHOES SHOP";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(355, 114);
            label3.Name = "label3";
            label3.Size = new Size(151, 28);
            label3.TabIndex = 3;
            label3.Text = "Tên tài khoản :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(355, 203);
            label4.Name = "label4";
            label4.Size = new Size(113, 28);
            label4.TabIndex = 4;
            label4.Text = "Mật khẩu :";
            // 
            // txt_taiKhoan
            // 
            txt_taiKhoan.Location = new Point(355, 155);
            txt_taiKhoan.Name = "txt_taiKhoan";
            txt_taiKhoan.Size = new Size(356, 27);
            txt_taiKhoan.TabIndex = 5;
            txt_taiKhoan.TextChanged += txt_taiKhoan_TextChanged;
            // 
            // txt_matKhau
            // 
            txt_matKhau.Location = new Point(355, 249);
            txt_matKhau.Name = "txt_matKhau";
            txt_matKhau.Size = new Size(356, 27);
            txt_matKhau.TabIndex = 6;
            // 
            // btn_dangNhap
            // 
            btn_dangNhap.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btn_dangNhap.Location = new Point(355, 294);
            btn_dangNhap.Name = "btn_dangNhap";
            btn_dangNhap.Size = new Size(155, 53);
            btn_dangNhap.TabIndex = 7;
            btn_dangNhap.Text = "Đăng nhập";
            btn_dangNhap.UseVisualStyleBackColor = true;
            btn_dangNhap.Click += btn_dangNhap_Click;
            // 
            // DangNhap_form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_dangNhap);
            Controls.Add(txt_matKhau);
            Controls.Add(txt_taiKhoan);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "DangNhap_form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DangNhap";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label3;
        private Label label4;
        private TextBox txt_taiKhoan;
        private TextBox txt_matKhau;
        private Button btn_dangNhap;
    }
}