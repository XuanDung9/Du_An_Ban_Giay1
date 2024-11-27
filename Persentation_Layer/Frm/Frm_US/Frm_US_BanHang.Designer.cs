namespace A_Persentation_Layer.Frm.Frm_US
{
    partial class Frm_US_BanHang
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            btn_XoaHoaDon = new Button();
            btn_ThemHoaDon = new Button();
            dgv_HoaDon = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            dgv_HoaDonChiTiet = new DataGridView();
            panel2 = new Panel();
            label6 = new Label();
            lb_TTHD = new Label();
            txt_HoaDonChiTiet = new TextBox();
            label22 = new Label();
            btn_XoaSanPham = new Button();
            label3 = new Label();
            dgv_sanPham = new DataGridView();
            panel3 = new Panel();
            cbb_TimKiem = new ComboBox();
            btn_TimKiem = new Button();
            txt_TimKiemSP = new TextBox();
            groupBox1 = new GroupBox();
            txtGiamGia = new TextBox();
            btn_ThanhToan = new Button();
            txt_GhiChu = new TextBox();
            txt_TienNhan = new TextBox();
            txt_DiemKH = new TextBox();
            cb_SuDungDiem = new CheckBox();
            cbb_HinhThucThanhToan = new ComboBox();
            label20 = new Label();
            label21 = new Label();
            lb_TongTien = new Label();
            label19 = new Label();
            lb_TienThieu = new Label();
            label17 = new Label();
            lb_TraLai = new Label();
            label15 = new Label();
            lb_TongTienHang = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            lb_MaHoaDon = new Label();
            label8 = new Label();
            groupBox2 = new GroupBox();
            lb_maKH = new Label();
            lb_TenKH = new Label();
            btn_TimKhachHang = new Button();
            label5 = new Label();
            label4 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_HoaDon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_HoaDonChiTiet).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_sanPham).BeginInit();
            panel3.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btn_XoaHoaDon);
            panel1.Controls.Add(btn_ThemHoaDon);
            panel1.Location = new Point(3, 25);
            panel1.Name = "panel1";
            panel1.Size = new Size(887, 47);
            panel1.TabIndex = 0;
            // 
            // btn_XoaHoaDon
            // 
            btn_XoaHoaDon.BackColor = Color.LightCoral;
            btn_XoaHoaDon.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_XoaHoaDon.Location = new Point(760, 3);
            btn_XoaHoaDon.Name = "btn_XoaHoaDon";
            btn_XoaHoaDon.Size = new Size(109, 41);
            btn_XoaHoaDon.TabIndex = 2;
            btn_XoaHoaDon.Text = "Xóa hóa đơn";
            btn_XoaHoaDon.UseVisualStyleBackColor = false;
            btn_XoaHoaDon.Click += btn_XoaHoaDon_Click;
            // 
            // btn_ThemHoaDon
            // 
            btn_ThemHoaDon.BackColor = SystemColors.ActiveCaption;
            btn_ThemHoaDon.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_ThemHoaDon.Location = new Point(572, 3);
            btn_ThemHoaDon.Name = "btn_ThemHoaDon";
            btn_ThemHoaDon.Size = new Size(137, 41);
            btn_ThemHoaDon.TabIndex = 1;
            btn_ThemHoaDon.Text = "Tạo hóa đơn mới";
            btn_ThemHoaDon.UseVisualStyleBackColor = false;
            btn_ThemHoaDon.Click += btn_ThemHoaDon_Click;
            // 
            // dgv_HoaDon
            // 
            dgv_HoaDon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_HoaDon.Location = new Point(3, 78);
            dgv_HoaDon.Name = "dgv_HoaDon";
            dgv_HoaDon.RowHeadersWidth = 51;
            dgv_HoaDon.RowTemplate.Height = 29;
            dgv_HoaDon.Size = new Size(887, 175);
            dgv_HoaDon.TabIndex = 1;
            dgv_HoaDon.CellClick += dgv_HoaDon_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 2);
            label1.Name = "label1";
            label1.Size = new Size(71, 20);
            label1.TabIndex = 2;
            label1.Text = "Hóa đơn ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 256);
            label2.Name = "label2";
            label2.Size = new Size(118, 20);
            label2.TabIndex = 5;
            label2.Text = "Giỏ hàng chi tiết";
            // 
            // dgv_HoaDonChiTiet
            // 
            dgv_HoaDonChiTiet.AllowUserToAddRows = false;
            dgv_HoaDonChiTiet.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_HoaDonChiTiet.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_HoaDonChiTiet.Location = new Point(9, 332);
            dgv_HoaDonChiTiet.Name = "dgv_HoaDonChiTiet";
            dgv_HoaDonChiTiet.RowHeadersWidth = 51;
            dgv_HoaDonChiTiet.RowTemplate.Height = 29;
            dgv_HoaDonChiTiet.Size = new Size(887, 209);
            dgv_HoaDonChiTiet.TabIndex = 4;
            dgv_HoaDonChiTiet.CellClick += dgv_HoaDonChiTiet_CellClick;
            // 
            // panel2
            // 
            panel2.Controls.Add(label6);
            panel2.Controls.Add(lb_TTHD);
            panel2.Controls.Add(txt_HoaDonChiTiet);
            panel2.Controls.Add(label22);
            panel2.Controls.Add(btn_XoaSanPham);
            panel2.Location = new Point(6, 279);
            panel2.Name = "panel2";
            panel2.Size = new Size(887, 47);
            panel2.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(549, 14);
            label6.Name = "label6";
            label6.Size = new Size(79, 20);
            label6.TabIndex = 6;
            label6.Text = "Tổng tiền :";
            // 
            // lb_TTHD
            // 
            lb_TTHD.AutoSize = true;
            lb_TTHD.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lb_TTHD.Location = new Point(646, 11);
            lb_TTHD.Name = "lb_TTHD";
            lb_TTHD.Size = new Size(20, 23);
            lb_TTHD.TabIndex = 5;
            lb_TTHD.Text = "0";
            // 
            // txt_HoaDonChiTiet
            // 
            txt_HoaDonChiTiet.Location = new Point(164, 3);
            txt_HoaDonChiTiet.Multiline = true;
            txt_HoaDonChiTiet.Name = "txt_HoaDonChiTiet";
            txt_HoaDonChiTiet.Size = new Size(233, 41);
            txt_HoaDonChiTiet.TabIndex = 4;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(6, 13);
            label22.Name = "label22";
            label22.Size = new Size(132, 20);
            label22.TabIndex = 3;
            label22.Text = "Sản phẩm đã chọn";
            // 
            // btn_XoaSanPham
            // 
            btn_XoaSanPham.BackColor = Color.LightCoral;
            btn_XoaSanPham.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_XoaSanPham.ForeColor = SystemColors.ActiveCaptionText;
            btn_XoaSanPham.Location = new Point(403, 4);
            btn_XoaSanPham.Name = "btn_XoaSanPham";
            btn_XoaSanPham.Size = new Size(75, 41);
            btn_XoaSanPham.TabIndex = 1;
            btn_XoaSanPham.Text = "XÓA";
            btn_XoaSanPham.UseVisualStyleBackColor = false;
            btn_XoaSanPham.Click += btn_XoaSanPham_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 540);
            label3.Name = "label3";
            label3.Size = new Size(145, 20);
            label3.TabIndex = 8;
            label3.Text = "Danh sách sản phẩm";
            // 
            // dgv_sanPham
            // 
            dgv_sanPham.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_sanPham.Location = new Point(9, 616);
            dgv_sanPham.Name = "dgv_sanPham";
            dgv_sanPham.RowHeadersWidth = 51;
            dgv_sanPham.RowTemplate.Height = 29;
            dgv_sanPham.Size = new Size(887, 209);
            dgv_sanPham.TabIndex = 3;
            dgv_sanPham.CellClick += dgvSP_CellClick;
            // 
            // panel3
            // 
            panel3.Controls.Add(cbb_TimKiem);
            panel3.Controls.Add(btn_TimKiem);
            panel3.Controls.Add(txt_TimKiemSP);
            panel3.Location = new Point(9, 563);
            panel3.Name = "panel3";
            panel3.Size = new Size(887, 47);
            panel3.TabIndex = 6;
            // 
            // cbb_TimKiem
            // 
            cbb_TimKiem.FormattingEnabled = true;
            cbb_TimKiem.Location = new Point(301, 13);
            cbb_TimKiem.Name = "cbb_TimKiem";
            cbb_TimKiem.Size = new Size(121, 28);
            cbb_TimKiem.TabIndex = 5;
            // 
            // btn_TimKiem
            // 
            btn_TimKiem.BackColor = SystemColors.ActiveCaption;
            btn_TimKiem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_TimKiem.Location = new Point(729, 3);
            btn_TimKiem.Name = "btn_TimKiem";
            btn_TimKiem.Size = new Size(137, 41);
            btn_TimKiem.TabIndex = 4;
            btn_TimKiem.Text = "Tìm kiếm";
            btn_TimKiem.UseVisualStyleBackColor = false;
            btn_TimKiem.Click += btn_TimKiem_Click;
            // 
            // txt_TimKiemSP
            // 
            txt_TimKiemSP.Location = new Point(3, 10);
            txt_TimKiemSP.Multiline = true;
            txt_TimKiemSP.Name = "txt_TimKiemSP";
            txt_TimKiemSP.Size = new Size(283, 34);
            txt_TimKiemSP.TabIndex = 3;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtGiamGia);
            groupBox1.Controls.Add(btn_ThanhToan);
            groupBox1.Controls.Add(txt_GhiChu);
            groupBox1.Controls.Add(txt_TienNhan);
            groupBox1.Controls.Add(txt_DiemKH);
            groupBox1.Controls.Add(cb_SuDungDiem);
            groupBox1.Controls.Add(cbb_HinhThucThanhToan);
            groupBox1.Controls.Add(label20);
            groupBox1.Controls.Add(label21);
            groupBox1.Controls.Add(lb_TongTien);
            groupBox1.Controls.Add(label19);
            groupBox1.Controls.Add(lb_TienThieu);
            groupBox1.Controls.Add(label17);
            groupBox1.Controls.Add(lb_TraLai);
            groupBox1.Controls.Add(label15);
            groupBox1.Controls.Add(lb_TongTienHang);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(lb_MaHoaDon);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Location = new Point(931, 25);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(352, 784);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thanh toán";
            // 
            // txtGiamGia
            // 
            txtGiamGia.Location = new Point(111, 193);
            txtGiamGia.Name = "txtGiamGia";
            txtGiamGia.Size = new Size(230, 27);
            txtGiamGia.TabIndex = 24;
            // 
            // btn_ThanhToan
            // 
            btn_ThanhToan.BackColor = SystemColors.Info;
            btn_ThanhToan.Font = new Font("Segoe UI Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btn_ThanhToan.Location = new Point(1, 685);
            btn_ThanhToan.Name = "btn_ThanhToan";
            btn_ThanhToan.Size = new Size(339, 93);
            btn_ThanhToan.TabIndex = 23;
            btn_ThanhToan.Text = "THANH TOÁN";
            btn_ThanhToan.UseVisualStyleBackColor = false;
            btn_ThanhToan.Click += btn_ThanhToan_Click;
            // 
            // txt_GhiChu
            // 
            txt_GhiChu.Location = new Point(6, 548);
            txt_GhiChu.Multiline = true;
            txt_GhiChu.Name = "txt_GhiChu";
            txt_GhiChu.Size = new Size(340, 114);
            txt_GhiChu.TabIndex = 22;
            // 
            // txt_TienNhan
            // 
            txt_TienNhan.Location = new Point(111, 348);
            txt_TienNhan.Name = "txt_TienNhan";
            txt_TienNhan.Size = new Size(228, 27);
            txt_TienNhan.TabIndex = 21;
            txt_TienNhan.TextChanged += txt_TienNhan_TextChanged;
            // 
            // txt_DiemKH
            // 
            txt_DiemKH.Location = new Point(12, 307);
            txt_DiemKH.Name = "txt_DiemKH";
            txt_DiemKH.Size = new Size(329, 27);
            txt_DiemKH.TabIndex = 20;
            txt_DiemKH.TextChanged += txt_DiemKH_TextChanged;
            // 
            // cb_SuDungDiem
            // 
            cb_SuDungDiem.AutoSize = true;
            cb_SuDungDiem.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            cb_SuDungDiem.Location = new Point(7, 275);
            cb_SuDungDiem.Name = "cb_SuDungDiem";
            cb_SuDungDiem.Size = new Size(180, 24);
            cb_SuDungDiem.TabIndex = 18;
            cb_SuDungDiem.Text = "Sử dụng điểm tích lũy";
            cb_SuDungDiem.UseVisualStyleBackColor = true;
            cb_SuDungDiem.CheckedChanged += cb_SuDungDiem_CheckedChanged;
            // 
            // cbb_HinhThucThanhToan
            // 
            cbb_HinhThucThanhToan.FormattingEnabled = true;
            cbb_HinhThucThanhToan.Location = new Point(171, 232);
            cbb_HinhThucThanhToan.Name = "cbb_HinhThucThanhToan";
            cbb_HinhThucThanhToan.Size = new Size(170, 28);
            cbb_HinhThucThanhToan.TabIndex = 16;
            cbb_HinhThucThanhToan.SelectedIndexChanged += cbb_HinhThucThanhToan_SelectedIndexChanged;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label20.Location = new Point(7, 525);
            label20.Name = "label20";
            label20.Size = new Size(61, 20);
            label20.TabIndex = 14;
            label20.Text = "Ghi chú";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label21.ForeColor = SystemColors.HotTrack;
            label21.Location = new Point(7, 488);
            label21.Name = "label21";
            label21.Size = new Size(91, 31);
            label21.TabIndex = 13;
            label21.Text = "TỔNG :";
            // 
            // lb_TongTien
            // 
            lb_TongTien.AutoSize = true;
            lb_TongTien.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lb_TongTien.ForeColor = SystemColors.HotTrack;
            lb_TongTien.Location = new Point(100, 488);
            lb_TongTien.Name = "lb_TongTien";
            lb_TongTien.Size = new Size(27, 31);
            lb_TongTien.TabIndex = 12;
            lb_TongTien.Text = "#";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label19.Location = new Point(7, 452);
            label19.Name = "label19";
            label19.Size = new Size(98, 20);
            label19.TabIndex = 11;
            label19.Text = "Số tiền thiếu:";
            // 
            // lb_TienThieu
            // 
            lb_TienThieu.AutoSize = true;
            lb_TienThieu.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lb_TienThieu.ForeColor = Color.Red;
            lb_TienThieu.Location = new Point(111, 452);
            lb_TienThieu.Name = "lb_TienThieu";
            lb_TienThieu.Size = new Size(18, 20);
            lb_TienThieu.TabIndex = 10;
            lb_TienThieu.Text = "#";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label17.Location = new Point(6, 420);
            label17.Name = "label17";
            label17.Size = new Size(103, 20);
            label17.TabIndex = 9;
            label17.Text = "Trả lại khách:";
            // 
            // lb_TraLai
            // 
            lb_TraLai.AutoSize = true;
            lb_TraLai.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lb_TraLai.Location = new Point(111, 420);
            lb_TraLai.Name = "lb_TraLai";
            lb_TraLai.Size = new Size(18, 20);
            lb_TraLai.TabIndex = 8;
            lb_TraLai.Text = "#";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label15.Location = new Point(7, 351);
            label15.Name = "label15";
            label15.Size = new Size(103, 20);
            label15.TabIndex = 7;
            label15.Text = "Số tiền nhận :";
            // 
            // lb_TongTienHang
            // 
            lb_TongTienHang.AutoSize = true;
            lb_TongTienHang.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lb_TongTienHang.Location = new Point(163, 384);
            lb_TongTienHang.Name = "lb_TongTienHang";
            lb_TongTienHang.Size = new Size(18, 20);
            lb_TongTienHang.TabIndex = 6;
            lb_TongTienHang.Text = "#";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label12.Location = new Point(6, 384);
            label12.Name = "label12";
            label12.Size = new Size(148, 20);
            label12.TabIndex = 5;
            label12.Text = "Tổng tiền đơn hàng:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label11.Location = new Point(7, 237);
            label11.Name = "label11";
            label11.Size = new Size(156, 20);
            label11.TabIndex = 4;
            label11.Text = "Hình thức thanh toán";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label10.Location = new Point(7, 196);
            label10.Name = "label10";
            label10.Size = new Size(96, 20);
            label10.TabIndex = 3;
            label10.Text = "Mã giảm giá";
            // 
            // lb_MaHoaDon
            // 
            lb_MaHoaDon.AutoSize = true;
            lb_MaHoaDon.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lb_MaHoaDon.Location = new Point(104, 160);
            lb_MaHoaDon.Name = "lb_MaHoaDon";
            lb_MaHoaDon.Size = new Size(18, 20);
            lb_MaHoaDon.TabIndex = 2;
            lb_MaHoaDon.Text = "#";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label8.Location = new Point(7, 160);
            label8.Name = "label8";
            label8.Size = new Size(96, 20);
            label8.TabIndex = 1;
            label8.Text = "Mã hóa đơn:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lb_maKH);
            groupBox2.Controls.Add(lb_TenKH);
            groupBox2.Controls.Add(btn_TimKhachHang);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Location = new Point(6, 26);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(340, 121);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin khách hàng";
            // 
            // lb_maKH
            // 
            lb_maKH.AutoSize = true;
            lb_maKH.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lb_maKH.Location = new Point(79, 52);
            lb_maKH.Name = "lb_maKH";
            lb_maKH.Size = new Size(20, 23);
            lb_maKH.TabIndex = 4;
            lb_maKH.Text = "#";
            // 
            // lb_TenKH
            // 
            lb_TenKH.AutoSize = true;
            lb_TenKH.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lb_TenKH.Location = new Point(137, 84);
            lb_TenKH.Name = "lb_TenKH";
            lb_TenKH.Size = new Size(20, 23);
            lb_TenKH.TabIndex = 3;
            lb_TenKH.Text = "#";
            // 
            // btn_TimKhachHang
            // 
            btn_TimKhachHang.BackColor = SystemColors.ActiveCaption;
            btn_TimKhachHang.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_TimKhachHang.Location = new Point(240, 16);
            btn_TimKhachHang.Name = "btn_TimKhachHang";
            btn_TimKhachHang.Size = new Size(94, 36);
            btn_TimKhachHang.TabIndex = 2;
            btn_TimKhachHang.Text = "Chọn";
            btn_TimKhachHang.UseVisualStyleBackColor = false;
            btn_TimKhachHang.Click += btn_TimKhachHang_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(6, 52);
            label5.Name = "label5";
            label5.Size = new Size(72, 23);
            label5.TabIndex = 1;
            label5.Text = "Mã KH :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(6, 84);
            label4.Name = "label4";
            label4.Size = new Size(135, 23);
            label4.TabIndex = 0;
            label4.Text = "Tên khách hàng:";
            // 
            // Frm_US_BanHang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox1);
            Controls.Add(label3);
            Controls.Add(dgv_sanPham);
            Controls.Add(panel3);
            Controls.Add(label2);
            Controls.Add(dgv_HoaDonChiTiet);
            Controls.Add(panel2);
            Controls.Add(label1);
            Controls.Add(dgv_HoaDon);
            Controls.Add(panel1);
            Name = "Frm_US_BanHang";
            Size = new Size(1330, 828);
            Load += Frm_US_BanHang_Load_1;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_HoaDon).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_HoaDonChiTiet).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_sanPham).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button btn_XoaHoaDon;
        private Button btn_ThemHoaDon;
        private DataGridView dgv_HoaDon;
        private Label label1;
        private Label label2;
        private DataGridView dgv_HoaDonChiTiet;
        private Panel panel2;
        private Button btn_XoaSanPham;
        private Label label3;
        private DataGridView dgv_sanPham;
        private Panel panel3;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label lb_MaHoaDon;
        private Label label8;
        private Label lb_maKH;
        private Label lb_TenKH;
        private Button btn_TimKhachHang;
        private Label label5;
        private Label label4;
        private CheckBox cb_SuDungDiem;
        private ComboBox cbb_HinhThucThanhToan;
        private Label label20;
        private Label label21;
        private Label lb_TongTien;
        private Label label19;
        private Label lb_TienThieu;
        private Label label17;
        private Label lb_TraLai;
        private Label label15;
        private Label lb_TongTienHang;
        private TextBox txt_TienNhan;
        private TextBox txt_DiemKH;
        private TextBox txt_GhiChu;
        private Button btn_ThanhToan;
        private ComboBox cbb_TimKiem;
        private Button btn_TimKiem;
        private TextBox txt_TimKiemSP;
        private TextBox txt_HoaDonChiTiet;
        private Label label22;
        private TextBox txtGiamGia;
        private Label lb_TTHD;
        private Label label6;
    }
}
