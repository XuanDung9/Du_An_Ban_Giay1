namespace A_Persentation_Layer
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            txt_tenTaiKhoan = new Label();
            pn_menu = new Panel();
            btn_dangXuat = new Button();
            btn_thongKe = new Button();
            btn_khuyenMai = new Button();
            btn_nhanVien = new Button();
            btn_hoaDon = new Button();
            btn_khachHang = new Button();
            btn_sanPham = new Button();
            btn_banHang = new Button();
            panel3 = new Panel();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            pn_main = new Panel();
            pn_menu.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txt_tenTaiKhoan
            // 
            txt_tenTaiKhoan.AutoSize = true;
            txt_tenTaiKhoan.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            txt_tenTaiKhoan.Location = new Point(85, 10);
            txt_tenTaiKhoan.Name = "txt_tenTaiKhoan";
            txt_tenTaiKhoan.Size = new Size(23, 25);
            txt_tenTaiKhoan.TabIndex = 0;
            txt_tenTaiKhoan.Text = "#";
            // 
            // pn_menu
            // 
            pn_menu.BackColor = SystemColors.ActiveCaption;
            pn_menu.Controls.Add(btn_dangXuat);
            pn_menu.Controls.Add(btn_thongKe);
            pn_menu.Controls.Add(btn_khuyenMai);
            pn_menu.Controls.Add(btn_nhanVien);
            pn_menu.Controls.Add(btn_hoaDon);
            pn_menu.Controls.Add(btn_khachHang);
            pn_menu.Controls.Add(btn_sanPham);
            pn_menu.Controls.Add(btn_banHang);
            pn_menu.Controls.Add(panel3);
            pn_menu.Controls.Add(pictureBox1);
            pn_menu.Location = new Point(26, 12);
            pn_menu.Name = "pn_menu";
            pn_menu.Size = new Size(246, 828);
            pn_menu.TabIndex = 1;
            // 
            // btn_dangXuat
            // 
            btn_dangXuat.BackColor = Color.DarkGray;
            btn_dangXuat.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btn_dangXuat.Location = new Point(3, 772);
            btn_dangXuat.Name = "btn_dangXuat";
            btn_dangXuat.Size = new Size(243, 53);
            btn_dangXuat.TabIndex = 10;
            btn_dangXuat.Text = "ĐĂNG XUẤT";
            btn_dangXuat.UseVisualStyleBackColor = false;
            btn_dangXuat.Click += btn_dangXuat_Click;
            // 
            // btn_thongKe
            // 
            btn_thongKe.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btn_thongKe.Location = new Point(3, 682);
            btn_thongKe.Name = "btn_thongKe";
            btn_thongKe.Size = new Size(243, 53);
            btn_thongKe.TabIndex = 9;
            btn_thongKe.Text = "THỐNG KÊ";
            btn_thongKe.UseVisualStyleBackColor = true;
            btn_thongKe.Click += btn_thongKe_Click;
            // 
            // btn_khuyenMai
            // 
            btn_khuyenMai.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btn_khuyenMai.Location = new Point(3, 577);
            btn_khuyenMai.Name = "btn_khuyenMai";
            btn_khuyenMai.Size = new Size(243, 53);
            btn_khuyenMai.TabIndex = 8;
            btn_khuyenMai.Text = "Quản lý Khuyến Mãi";
            btn_khuyenMai.UseVisualStyleBackColor = true;
            btn_khuyenMai.Click += btn_khuyenMai_Click;
            // 
            // btn_nhanVien
            // 
            btn_nhanVien.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btn_nhanVien.Location = new Point(3, 518);
            btn_nhanVien.Name = "btn_nhanVien";
            btn_nhanVien.Size = new Size(243, 53);
            btn_nhanVien.TabIndex = 7;
            btn_nhanVien.Text = "Quản lý Nhân Viên";
            btn_nhanVien.UseVisualStyleBackColor = true;
            btn_nhanVien.Click += btn_nhanVien_Click;
            // 
            // btn_hoaDon
            // 
            btn_hoaDon.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btn_hoaDon.Location = new Point(3, 459);
            btn_hoaDon.Name = "btn_hoaDon";
            btn_hoaDon.Size = new Size(243, 53);
            btn_hoaDon.TabIndex = 6;
            btn_hoaDon.Text = "Hóa đơn";
            btn_hoaDon.UseVisualStyleBackColor = true;
            btn_hoaDon.Click += btn_hoaDon_Click;
            // 
            // btn_khachHang
            // 
            btn_khachHang.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btn_khachHang.Location = new Point(3, 400);
            btn_khachHang.Name = "btn_khachHang";
            btn_khachHang.Size = new Size(243, 53);
            btn_khachHang.TabIndex = 5;
            btn_khachHang.Text = "Khách Hàng";
            btn_khachHang.UseVisualStyleBackColor = true;
            btn_khachHang.Click += btn_khachHang_Click;
            // 
            // btn_sanPham
            // 
            btn_sanPham.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btn_sanPham.Location = new Point(3, 341);
            btn_sanPham.Name = "btn_sanPham";
            btn_sanPham.Size = new Size(243, 53);
            btn_sanPham.TabIndex = 4;
            btn_sanPham.Text = "Danh sách Sản phẩm ";
            btn_sanPham.UseVisualStyleBackColor = true;
            btn_sanPham.Click += btn_sanPham_Click;
            // 
            // btn_banHang
            // 
            btn_banHang.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btn_banHang.Location = new Point(3, 282);
            btn_banHang.Name = "btn_banHang";
            btn_banHang.Size = new Size(243, 53);
            btn_banHang.TabIndex = 3;
            btn_banHang.Text = "Bán Hàng";
            btn_banHang.UseVisualStyleBackColor = true;
            btn_banHang.Click += btn_banHang_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(label2);
            panel3.Controls.Add(txt_tenTaiKhoan);
            panel3.Location = new Point(3, 230);
            panel3.Name = "panel3";
            panel3.Size = new Size(243, 46);
            panel3.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(3, 10);
            label2.Name = "label2";
            label2.Size = new Size(76, 20);
            label2.TabIndex = 1;
            label2.Text = "Xin chào :";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(244, 224);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // pn_main
            // 
            pn_main.Location = new Point(278, 12);
            pn_main.Name = "pn_main";
            pn_main.Size = new Size(1330, 828);
            pn_main.TabIndex = 2;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1620, 867);
            Controls.Add(pn_main);
            Controls.Add(pn_menu);
            Name = "Main";
            Text = "Main";
            Load += Main_Load_1;
            pn_menu.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label txt_tenTaiKhoan;
        private Panel pn_menu;
        private Button btn_dangXuat;
        private Button btn_thongKe;
        private Button btn_khuyenMai;
        private Button btn_nhanVien;
        private Button btn_hoaDon;
        private Button btn_khachHang;
        private Button btn_sanPham;
        private Button btn_banHang;
        private Panel panel3;
        private PictureBox pictureBox1;
        private Panel pn_main;
        private Label label2;
    }
}