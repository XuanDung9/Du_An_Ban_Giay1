namespace A_Persentation_Layer.Frm.Frm_US
{
    partial class Frm_US_KhachHang
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
            groupBox1 = new GroupBox();
            btnLamMoi = new Button();
            btnThem = new Button();
            btnSua = new Button();
            btnKhoa_MoKhoa = new Button();
            txtDiemKH = new TextBox();
            txtSDT = new TextBox();
            txtHoVaTen = new TextBox();
            label4 = new Label();
            txtMaKhachHang = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            panel2 = new Panel();
            rdbTimKiemTen = new RadioButton();
            txtTimKiem_KhachHang = new TextBox();
            rdbTimKiemMa = new RadioButton();
            label5 = new Label();
            panel1 = new Panel();
            dgvKH = new DataGridView();
            groupBox3 = new GroupBox();
            dgvHD = new DataGridView();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKH).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHD).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnLamMoi);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Controls.Add(btnSua);
            groupBox1.Controls.Add(btnKhoa_MoKhoa);
            groupBox1.Controls.Add(txtDiemKH);
            groupBox1.Controls.Add(txtSDT);
            groupBox1.Controls.Add(txtHoVaTen);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtMaKhachHang);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1406, 181);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thêm khách hàng";
            // 
            // btnLamMoi
            // 
            btnLamMoi.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnLamMoi.BackColor = Color.FromArgb(64, 79, 105);
            btnLamMoi.Cursor = Cursors.Hand;
            btnLamMoi.FlatAppearance.BorderSize = 0;
            btnLamMoi.FlatAppearance.MouseDownBackColor = Color.FromArgb(69, 97, 120);
            btnLamMoi.FlatStyle = FlatStyle.Flat;
            btnLamMoi.ForeColor = Color.White;
            btnLamMoi.Location = new Point(860, 131);
            btnLamMoi.Margin = new Padding(4);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(90, 33);
            btnLamMoi.TabIndex = 16;
            btnLamMoi.Text = "Clear";
            btnLamMoi.UseVisualStyleBackColor = false;
            // 
            // btnThem
            // 
            btnThem.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnThem.BackColor = Color.FromArgb(64, 79, 105);
            btnThem.Cursor = Cursors.Hand;
            btnThem.FlatAppearance.BorderSize = 0;
            btnThem.FlatAppearance.MouseDownBackColor = Color.FromArgb(69, 97, 120);
            btnThem.FlatStyle = FlatStyle.Flat;
            btnThem.ForeColor = Color.White;
            btnThem.Location = new Point(860, 59);
            btnThem.Margin = new Padding(4);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(120, 55);
            btnThem.TabIndex = 10;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSua.BackColor = Color.FromArgb(64, 79, 105);
            btnSua.Cursor = Cursors.Hand;
            btnSua.FlatAppearance.BorderSize = 0;
            btnSua.FlatAppearance.MouseDownBackColor = Color.FromArgb(69, 97, 120);
            btnSua.FlatStyle = FlatStyle.Flat;
            btnSua.ForeColor = Color.White;
            btnSua.Location = new Point(1060, 59);
            btnSua.Margin = new Padding(4);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(120, 55);
            btnSua.TabIndex = 11;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // btnKhoa_MoKhoa
            // 
            btnKhoa_MoKhoa.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnKhoa_MoKhoa.BackColor = Color.FromArgb(64, 79, 105);
            btnKhoa_MoKhoa.Cursor = Cursors.Hand;
            btnKhoa_MoKhoa.FlatAppearance.BorderSize = 0;
            btnKhoa_MoKhoa.FlatAppearance.MouseDownBackColor = Color.FromArgb(69, 97, 120);
            btnKhoa_MoKhoa.FlatStyle = FlatStyle.Flat;
            btnKhoa_MoKhoa.ForeColor = Color.White;
            btnKhoa_MoKhoa.Location = new Point(1246, 59);
            btnKhoa_MoKhoa.Margin = new Padding(4);
            btnKhoa_MoKhoa.Name = "btnKhoa_MoKhoa";
            btnKhoa_MoKhoa.Size = new Size(131, 55);
            btnKhoa_MoKhoa.TabIndex = 12;
            btnKhoa_MoKhoa.Text = "Khóa/Mở khóa";
            btnKhoa_MoKhoa.UseVisualStyleBackColor = false;
            btnKhoa_MoKhoa.Click += btnKhoa_MoKhoa_Click;
            // 
            // txtDiemKH
            // 
            txtDiemKH.BorderStyle = BorderStyle.FixedSingle;
            txtDiemKH.Location = new Point(522, 106);
            txtDiemKH.Margin = new Padding(4);
            txtDiemKH.Name = "txtDiemKH";
            txtDiemKH.Size = new Size(289, 29);
            txtDiemKH.TabIndex = 1;
            // 
            // txtSDT
            // 
            txtSDT.BorderStyle = BorderStyle.FixedSingle;
            txtSDT.Location = new Point(567, 40);
            txtSDT.Margin = new Padding(4);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(244, 29);
            txtSDT.TabIndex = 2;
            // 
            // txtHoVaTen
            // 
            txtHoVaTen.BorderStyle = BorderStyle.FixedSingle;
            txtHoVaTen.Location = new Point(132, 106);
            txtHoVaTen.Margin = new Padding(4);
            txtHoVaTen.Name = "txtHoVaTen";
            txtHoVaTen.Size = new Size(289, 29);
            txtHoVaTen.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(436, 112);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(50, 21);
            label4.TabIndex = 4;
            label4.Text = "Điểm:";
            // 
            // txtMaKhachHang
            // 
            txtMaKhachHang.BorderStyle = BorderStyle.FixedSingle;
            txtMaKhachHang.Enabled = false;
            txtMaKhachHang.Location = new Point(177, 40);
            txtMaKhachHang.Margin = new Padding(4);
            txtMaKhachHang.Name = "txtMaKhachHang";
            txtMaKhachHang.Size = new Size(244, 29);
            txtMaKhachHang.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(436, 46);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(104, 21);
            label3.TabIndex = 6;
            label3.Text = "Số điện thoại:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(46, 112);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(79, 21);
            label2.TabIndex = 7;
            label2.Text = "Họ và tên:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(46, 46);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(119, 21);
            label1.TabIndex = 8;
            label1.Text = "Mã khách hàng:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(panel2);
            groupBox2.Controls.Add(panel1);
            groupBox2.Location = new Point(3, 190);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1409, 460);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Khách hàng";
            // 
            // panel2
            // 
            panel2.Controls.Add(rdbTimKiemTen);
            panel2.Controls.Add(txtTimKiem_KhachHang);
            panel2.Controls.Add(rdbTimKiemMa);
            panel2.Controls.Add(label5);
            panel2.Location = new Point(0, 28);
            panel2.Name = "panel2";
            panel2.Size = new Size(1409, 44);
            panel2.TabIndex = 1;
            // 
            // rdbTimKiemTen
            // 
            rdbTimKiemTen.AutoSize = true;
            rdbTimKiemTen.Location = new Point(611, 11);
            rdbTimKiemTen.Name = "rdbTimKiemTen";
            rdbTimKiemTen.Size = new Size(54, 25);
            rdbTimKiemTen.TabIndex = 15;
            rdbTimKiemTen.TabStop = true;
            rdbTimKiemTen.Text = "Tên";
            rdbTimKiemTen.UseVisualStyleBackColor = true;
            // 
            // txtTimKiem_KhachHang
            // 
            txtTimKiem_KhachHang.BorderStyle = BorderStyle.FixedSingle;
            txtTimKiem_KhachHang.Location = new Point(107, 7);
            txtTimKiem_KhachHang.Margin = new Padding(4);
            txtTimKiem_KhachHang.Name = "txtTimKiem_KhachHang";
            txtTimKiem_KhachHang.PlaceholderText = "Tìm kiếm...";
            txtTimKiem_KhachHang.Size = new Size(428, 29);
            txtTimKiem_KhachHang.TabIndex = 1;
            txtTimKiem_KhachHang.TextChanged += txtTimKiem_KhachHang_TextChanged;
            // 
            // rdbTimKiemMa
            // 
            rdbTimKiemMa.AutoSize = true;
            rdbTimKiemMa.Location = new Point(552, 11);
            rdbTimKiemMa.Name = "rdbTimKiemMa";
            rdbTimKiemMa.Size = new Size(53, 25);
            rdbTimKiemMa.TabIndex = 14;
            rdbTimKiemMa.TabStop = true;
            rdbTimKiemMa.Text = "Mã";
            rdbTimKiemMa.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(26, 10);
            label5.Name = "label5";
            label5.Size = new Size(74, 21);
            label5.TabIndex = 0;
            label5.Text = "Tìm kiếm";
            // 
            // panel1
            // 
            panel1.Controls.Add(dgvKH);
            panel1.Location = new Point(0, 71);
            panel1.Name = "panel1";
            panel1.Size = new Size(1409, 383);
            panel1.TabIndex = 0;
            // 
            // dgvKH
            // 
            dgvKH.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKH.Dock = DockStyle.Fill;
            dgvKH.Location = new Point(0, 0);
            dgvKH.Name = "dgvKH";
            dgvKH.RowHeadersWidth = 51;
            dgvKH.RowTemplate.Height = 31;
            dgvKH.Size = new Size(1409, 383);
            dgvKH.TabIndex = 1;
            dgvKH.CellClick += dgvKH_CellClick;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dgvHD);
            groupBox3.Location = new Point(3, 656);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1409, 368);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Hóa đơn đã mua";
            // 
            // dgvHD
            // 
            dgvHD.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHD.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHD.Dock = DockStyle.Fill;
            dgvHD.Location = new Point(3, 25);
            dgvHD.Margin = new Padding(4);
            dgvHD.Name = "dgvHD";
            dgvHD.RowHeadersWidth = 51;
            dgvHD.RowTemplate.Height = 25;
            dgvHD.Size = new Size(1403, 340);
            dgvHD.TabIndex = 1;
            // 
            // Frm_US_KhachHang
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Frm_US_KhachHang";
            Size = new Size(1416, 1027);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvKH).EndInit();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvHD).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnThem;
        private Button btnSua;
        private Button btnKhoa_MoKhoa;
        private TextBox txtDiemKH;
        private TextBox txtSDT;
        private TextBox txtHoVaTen;
        private Label label4;
        private TextBox txtMaKhachHang;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private Panel panel1;
        private Panel panel2;
        private TextBox txtTimKiem_KhachHang;
        private Label label5;
        private DataGridView dgvKH;
        private GroupBox groupBox3;
        private DataGridView dgvHD;
        private Button btnLamMoi;
        private RadioButton rdbTimKiemTen;
        private RadioButton rdbTimKiemMa;
    }
}
