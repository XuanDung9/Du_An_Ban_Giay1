namespace A_Persentation_Layer.Frm.Frm_US
{
    partial class Frm_US_SanPham
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_US_SanPham));
            groupBox1 = new GroupBox();
            dgvSP = new DataGridView();
            panel2 = new Panel();
            btnTimKiem = new Button();
            cbbTimKiem = new ComboBox();
            txtTimKiem = new TextBox();
            groupBox2 = new GroupBox();
            btnLamMoi = new Button();
            btnKhoa_MoKhoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            groupBox3 = new GroupBox();
            ptbKichCo = new PictureBox();
            ptbMauSac = new PictureBox();
            ptbChatLieu = new PictureBox();
            ptbThemThuongHieu = new PictureBox();
            ptbKieuDang = new PictureBox();
            ptbGiay = new PictureBox();
            cbbTenChatLieu = new ComboBox();
            cbbTenMauSac = new ComboBox();
            cbbTenKichCo = new ComboBox();
            label10 = new Label();
            label8 = new Label();
            label6 = new Label();
            cbbTenGiay = new ComboBox();
            cbbTenThuongHieu = new ComboBox();
            label9 = new Label();
            cbbTenKieuDang = new ComboBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label11 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtMoTa = new TextBox();
            txtSoLuong = new TextBox();
            txtGia = new TextBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSP).BeginInit();
            panel2.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptbKichCo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptbMauSac).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptbChatLieu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptbThemThuongHieu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptbKieuDang).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptbGiay).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgvSP);
            groupBox1.Controls.Add(panel2);
            groupBox1.Location = new Point(3, 20);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1040, 930);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Sản phẩm";
            // 
            // dgvSP
            // 
            dgvSP.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSP.Location = new Point(7, 108);
            dgvSP.Name = "dgvSP";
            dgvSP.RowHeadersWidth = 51;
            dgvSP.RowTemplate.Height = 29;
            dgvSP.Size = new Size(1026, 694);
            dgvSP.TabIndex = 3;
            dgvSP.CellClick += dgvSP_CellClick;
            dgvSP.CellContentClick += dgvSP_CellContentClick_1;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnTimKiem);
            panel2.Controls.Add(cbbTimKiem);
            panel2.Controls.Add(txtTimKiem);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(3, 25);
            panel2.Margin = new Padding(4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1034, 77);
            panel2.TabIndex = 2;
            // 
            // btnTimKiem
            // 
            btnTimKiem.BackColor = SystemColors.ActiveCaption;
            btnTimKiem.Cursor = Cursors.Hand;
            btnTimKiem.FlatAppearance.BorderSize = 0;
            btnTimKiem.FlatAppearance.MouseDownBackColor = Color.FromArgb(69, 97, 120);
            btnTimKiem.FlatStyle = FlatStyle.Flat;
            btnTimKiem.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnTimKiem.ForeColor = Color.Black;
            btnTimKiem.Location = new Point(734, 17);
            btnTimKiem.Margin = new Padding(4);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(147, 40);
            btnTimKiem.TabIndex = 9;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = false;
            btnTimKiem.Click += btnTimKiem_Click_1;
            // 
            // cbbTimKiem
            // 
            cbbTimKiem.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbTimKiem.FormattingEnabled = true;
            cbbTimKiem.Location = new Point(512, 20);
            cbbTimKiem.Margin = new Padding(4);
            cbbTimKiem.Name = "cbbTimKiem";
            cbbTimKiem.Size = new Size(192, 29);
            cbbTimKiem.TabIndex = 8;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtTimKiem.Location = new Point(15, 17);
            txtTimKiem.Margin = new Padding(4);
            txtTimKiem.Multiline = true;
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(487, 32);
            txtTimKiem.TabIndex = 7;
            txtTimKiem.TextChanged += txtTimKiem_TextChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnLamMoi);
            groupBox2.Controls.Add(btnKhoa_MoKhoa);
            groupBox2.Controls.Add(btnSua);
            groupBox2.Controls.Add(btnThem);
            groupBox2.Location = new Point(1056, 685);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(341, 189);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Chức năng";
            // 
            // btnLamMoi
            // 
            btnLamMoi.Anchor = AnchorStyles.None;
            btnLamMoi.BackColor = SystemColors.ActiveCaption;
            btnLamMoi.Cursor = Cursors.Hand;
            btnLamMoi.FlatAppearance.BorderSize = 0;
            btnLamMoi.FlatAppearance.MouseDownBackColor = Color.FromArgb(69, 97, 120);
            btnLamMoi.FlatStyle = FlatStyle.Flat;
            btnLamMoi.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnLamMoi.ForeColor = Color.Black;
            btnLamMoi.Location = new Point(184, 89);
            btnLamMoi.Margin = new Padding(4);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(126, 40);
            btnLamMoi.TabIndex = 10;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = false;
            // 
            // btnKhoa_MoKhoa
            // 
            btnKhoa_MoKhoa.Anchor = AnchorStyles.None;
            btnKhoa_MoKhoa.BackColor = SystemColors.ActiveCaption;
            btnKhoa_MoKhoa.Cursor = Cursors.Hand;
            btnKhoa_MoKhoa.FlatAppearance.BorderSize = 0;
            btnKhoa_MoKhoa.FlatAppearance.MouseDownBackColor = Color.FromArgb(69, 97, 120);
            btnKhoa_MoKhoa.FlatStyle = FlatStyle.Flat;
            btnKhoa_MoKhoa.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnKhoa_MoKhoa.ForeColor = Color.Black;
            btnKhoa_MoKhoa.Location = new Point(15, 89);
            btnKhoa_MoKhoa.Margin = new Padding(4);
            btnKhoa_MoKhoa.Name = "btnKhoa_MoKhoa";
            btnKhoa_MoKhoa.Size = new Size(126, 40);
            btnKhoa_MoKhoa.TabIndex = 11;
            btnKhoa_MoKhoa.Text = "Khóa/Mở khóa";
            btnKhoa_MoKhoa.UseVisualStyleBackColor = false;
            btnKhoa_MoKhoa.Click += btnKhoa_MoKhoa_Click;
            // 
            // btnSua
            // 
            btnSua.Anchor = AnchorStyles.None;
            btnSua.BackColor = SystemColors.ActiveCaption;
            btnSua.Cursor = Cursors.Hand;
            btnSua.FlatAppearance.BorderSize = 0;
            btnSua.FlatAppearance.MouseDownBackColor = Color.FromArgb(69, 97, 120);
            btnSua.FlatStyle = FlatStyle.Flat;
            btnSua.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnSua.ForeColor = Color.Black;
            btnSua.Location = new Point(184, 29);
            btnSua.Margin = new Padding(4);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(126, 40);
            btnSua.TabIndex = 12;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click_1;
            // 
            // btnThem
            // 
            btnThem.Anchor = AnchorStyles.None;
            btnThem.BackColor = SystemColors.ActiveCaption;
            btnThem.Cursor = Cursors.Hand;
            btnThem.FlatAppearance.BorderSize = 0;
            btnThem.FlatAppearance.MouseDownBackColor = Color.FromArgb(69, 97, 120);
            btnThem.FlatStyle = FlatStyle.Flat;
            btnThem.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnThem.ForeColor = Color.Black;
            btnThem.Location = new Point(15, 29);
            btnThem.Margin = new Padding(4);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(126, 40);
            btnThem.TabIndex = 13;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click_1;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(ptbKichCo);
            groupBox3.Controls.Add(ptbMauSac);
            groupBox3.Controls.Add(ptbChatLieu);
            groupBox3.Controls.Add(ptbThemThuongHieu);
            groupBox3.Controls.Add(ptbKieuDang);
            groupBox3.Controls.Add(ptbGiay);
            groupBox3.Controls.Add(cbbTenChatLieu);
            groupBox3.Controls.Add(cbbTenMauSac);
            groupBox3.Controls.Add(cbbTenKichCo);
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(cbbTenGiay);
            groupBox3.Controls.Add(cbbTenThuongHieu);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(cbbTenKieuDang);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(label11);
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(label1);
            groupBox3.Controls.Add(txtMoTa);
            groupBox3.Controls.Add(txtSoLuong);
            groupBox3.Controls.Add(txtGia);
            groupBox3.Location = new Point(1056, 3);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(341, 666);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Thông tin";
            // 
            // ptbKichCo
            // 
            ptbKichCo.Cursor = Cursors.Hand;
            ptbKichCo.Image = (Image)resources.GetObject("ptbKichCo.Image");
            ptbKichCo.Location = new Point(297, 610);
            ptbKichCo.Margin = new Padding(4);
            ptbKichCo.Name = "ptbKichCo";
            ptbKichCo.Size = new Size(36, 34);
            ptbKichCo.SizeMode = PictureBoxSizeMode.Zoom;
            ptbKichCo.TabIndex = 73;
            ptbKichCo.TabStop = false;
            ptbKichCo.Click += ptbKichCo_Click;
            // 
            // ptbMauSac
            // 
            ptbMauSac.Cursor = Cursors.Hand;
            ptbMauSac.Image = (Image)resources.GetObject("ptbMauSac.Image");
            ptbMauSac.Location = new Point(297, 546);
            ptbMauSac.Margin = new Padding(4);
            ptbMauSac.Name = "ptbMauSac";
            ptbMauSac.Size = new Size(36, 34);
            ptbMauSac.SizeMode = PictureBoxSizeMode.Zoom;
            ptbMauSac.TabIndex = 72;
            ptbMauSac.TabStop = false;
            ptbMauSac.Click += ptbMauSac_Click;
            // 
            // ptbChatLieu
            // 
            ptbChatLieu.Cursor = Cursors.Hand;
            ptbChatLieu.Image = (Image)resources.GetObject("ptbChatLieu.Image");
            ptbChatLieu.Location = new Point(297, 479);
            ptbChatLieu.Margin = new Padding(4);
            ptbChatLieu.Name = "ptbChatLieu";
            ptbChatLieu.Size = new Size(36, 34);
            ptbChatLieu.SizeMode = PictureBoxSizeMode.Zoom;
            ptbChatLieu.TabIndex = 71;
            ptbChatLieu.TabStop = false;
            ptbChatLieu.Click += ptbChatLieu_Click;
            // 
            // ptbThemThuongHieu
            // 
            ptbThemThuongHieu.Cursor = Cursors.Hand;
            ptbThemThuongHieu.Image = (Image)resources.GetObject("ptbThemThuongHieu.Image");
            ptbThemThuongHieu.Location = new Point(295, 343);
            ptbThemThuongHieu.Margin = new Padding(4);
            ptbThemThuongHieu.Name = "ptbThemThuongHieu";
            ptbThemThuongHieu.Size = new Size(36, 34);
            ptbThemThuongHieu.SizeMode = PictureBoxSizeMode.Zoom;
            ptbThemThuongHieu.TabIndex = 70;
            ptbThemThuongHieu.TabStop = false;
            ptbThemThuongHieu.Click += ptbThemThuongHieu_Click;
            // 
            // ptbKieuDang
            // 
            ptbKieuDang.Cursor = Cursors.Hand;
            ptbKieuDang.Image = (Image)resources.GetObject("ptbKieuDang.Image");
            ptbKieuDang.Location = new Point(297, 412);
            ptbKieuDang.Margin = new Padding(4);
            ptbKieuDang.Name = "ptbKieuDang";
            ptbKieuDang.Size = new Size(36, 34);
            ptbKieuDang.SizeMode = PictureBoxSizeMode.Zoom;
            ptbKieuDang.TabIndex = 69;
            ptbKieuDang.TabStop = false;
            ptbKieuDang.Click += ptbKieuDang_Click;
            // 
            // ptbGiay
            // 
            ptbGiay.Cursor = Cursors.Hand;
            ptbGiay.Image = (Image)resources.GetObject("ptbGiay.Image");
            ptbGiay.Location = new Point(297, 52);
            ptbGiay.Margin = new Padding(4);
            ptbGiay.Name = "ptbGiay";
            ptbGiay.Size = new Size(36, 34);
            ptbGiay.SizeMode = PictureBoxSizeMode.Zoom;
            ptbGiay.TabIndex = 68;
            ptbGiay.TabStop = false;
            ptbGiay.Click += ptbGiay_Click;
            // 
            // cbbTenChatLieu
            // 
            cbbTenChatLieu.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbTenChatLieu.FormattingEnabled = true;
            cbbTenChatLieu.Location = new Point(15, 480);
            cbbTenChatLieu.Margin = new Padding(4);
            cbbTenChatLieu.Name = "cbbTenChatLieu";
            cbbTenChatLieu.Size = new Size(274, 29);
            cbbTenChatLieu.TabIndex = 67;
            // 
            // cbbTenMauSac
            // 
            cbbTenMauSac.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbTenMauSac.FormattingEnabled = true;
            cbbTenMauSac.Location = new Point(15, 547);
            cbbTenMauSac.Margin = new Padding(4);
            cbbTenMauSac.Name = "cbbTenMauSac";
            cbbTenMauSac.Size = new Size(274, 29);
            cbbTenMauSac.TabIndex = 65;
            // 
            // cbbTenKichCo
            // 
            cbbTenKichCo.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbTenKichCo.FormattingEnabled = true;
            cbbTenKichCo.Location = new Point(15, 612);
            cbbTenKichCo.Margin = new Padding(4);
            cbbTenKichCo.Name = "cbbTenKichCo";
            cbbTenKichCo.Size = new Size(274, 29);
            cbbTenKichCo.TabIndex = 64;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(16, 455);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(98, 21);
            label10.TabIndex = 61;
            label10.Text = "Tên chất liệu:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(15, 522);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(97, 21);
            label8.TabIndex = 60;
            label8.Text = "Tên màu sắc:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(15, 587);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(84, 21);
            label6.TabIndex = 59;
            label6.Text = "Số kích cỡ:";
            // 
            // cbbTenGiay
            // 
            cbbTenGiay.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbTenGiay.FormattingEnabled = true;
            cbbTenGiay.Location = new Point(16, 52);
            cbbTenGiay.Margin = new Padding(4);
            cbbTenGiay.Name = "cbbTenGiay";
            cbbTenGiay.Size = new Size(274, 29);
            cbbTenGiay.TabIndex = 62;
            // 
            // cbbTenThuongHieu
            // 
            cbbTenThuongHieu.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbTenThuongHieu.FormattingEnabled = true;
            cbbTenThuongHieu.Location = new Point(16, 343);
            cbbTenThuongHieu.Margin = new Padding(4);
            cbbTenThuongHieu.Name = "cbbTenThuongHieu";
            cbbTenThuongHieu.Size = new Size(274, 29);
            cbbTenThuongHieu.TabIndex = 63;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(16, 319);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(125, 21);
            label9.TabIndex = 58;
            label9.Text = "Tên thương hiệu:";
            // 
            // cbbTenKieuDang
            // 
            cbbTenKieuDang.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbTenKieuDang.FormattingEnabled = true;
            cbbTenKieuDang.Location = new Point(16, 413);
            cbbTenKieuDang.Margin = new Padding(4);
            cbbTenKieuDang.Name = "cbbTenKieuDang";
            cbbTenKieuDang.Size = new Size(274, 29);
            cbbTenKieuDang.TabIndex = 66;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(15, 387);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(108, 21);
            label5.TabIndex = 57;
            label5.Text = "Tên kiểu dáng:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 184);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(53, 21);
            label4.TabIndex = 56;
            label4.Text = "Mô tả:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 143);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(76, 21);
            label3.TabIndex = 55;
            label3.Text = "Số lượng:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Enabled = false;
            label11.Location = new Point(282, 92);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(43, 21);
            label11.TabIndex = 54;
            label11.Text = "VNĐ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 98);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(36, 21);
            label2.TabIndex = 53;
            label2.Text = "Giá:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 28);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(108, 21);
            label1.TabIndex = 52;
            label1.Text = "Tên sản phẩm:";
            // 
            // txtMoTa
            // 
            txtMoTa.Location = new Point(15, 209);
            txtMoTa.Margin = new Padding(4);
            txtMoTa.Multiline = true;
            txtMoTa.Name = "txtMoTa";
            txtMoTa.Size = new Size(314, 92);
            txtMoTa.TabIndex = 50;
            // 
            // txtSoLuong
            // 
            txtSoLuong.BorderStyle = BorderStyle.FixedSingle;
            txtSoLuong.Location = new Point(98, 141);
            txtSoLuong.Margin = new Padding(4);
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.Size = new Size(175, 29);
            txtSoLuong.TabIndex = 49;
            // 
            // txtGia
            // 
            txtGia.BorderStyle = BorderStyle.FixedSingle;
            txtGia.Location = new Point(98, 90);
            txtGia.Margin = new Padding(4);
            txtGia.Multiline = true;
            txtGia.Name = "txtGia";
            txtGia.Size = new Size(175, 28);
            txtGia.TabIndex = 51;
            // 
            // Frm_US_SanPham
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Frm_US_SanPham";
            Size = new Size(1415, 858);
            Load += Frm_US_SanPham_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvSP).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ptbKichCo).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptbMauSac).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptbChatLieu).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptbThemThuongHieu).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptbKieuDang).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptbGiay).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Panel panel2;
        private Button btnTimKiem;
        private ComboBox cbbTimKiem;
        private TextBox txtTimKiem;
        private Button btnLamMoi;
        private Button btnKhoa_MoKhoa;
        private Button btnSua;
        private Button btnThem;
        private GroupBox groupBox3;
        private PictureBox ptbKichCo;
        private PictureBox ptbMauSac;
        private PictureBox ptbChatLieu;
        private PictureBox ptbThemThuongHieu;
        private PictureBox ptbKieuDang;
        private PictureBox ptbGiay;
        private ComboBox cbbTenChatLieu;
        private ComboBox cbbTenMauSac;
        private ComboBox cbbTenKichCo;
        private Label label10;
        private Label label8;
        private Label label6;
        private ComboBox cbbTenGiay;
        private ComboBox cbbTenThuongHieu;
        private Label label9;
        private ComboBox cbbTenKieuDang;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label11;
        private Label label2;
        private Label label1;
        private TextBox txtMoTa;
        private TextBox txtSoLuong;
        private TextBox txtGia;
        private DataGridView dgvSP;
    }
}
