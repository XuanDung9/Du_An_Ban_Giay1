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
            txtSDT = new TextBox();
            btnLamMoi = new Button();
            txtHoVaTen = new TextBox();
            label4 = new Label();
            txtMaKhachHang = new TextBox();
            txtDiemKH = new TextBox();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            btnThem = new Button();
            btnSua = new Button();
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
            groupBox4 = new GroupBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKH).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHD).BeginInit();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtSDT);
            groupBox1.Controls.Add(btnLamMoi);
            groupBox1.Controls.Add(txtHoVaTen);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtMaKhachHang);
            groupBox1.Controls.Add(txtDiemKH);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(906, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(320, 327);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin khách hàng ";
            // 
            // txtSDT
            // 
            txtSDT.BorderStyle = BorderStyle.FixedSingle;
            txtSDT.Location = new Point(22, 254);
            txtSDT.Margin = new Padding(4);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(257, 27);
            txtSDT.TabIndex = 2;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnLamMoi.BackColor = SystemColors.ActiveCaption;
            btnLamMoi.Cursor = Cursors.Hand;
            btnLamMoi.FlatAppearance.BorderSize = 0;
            btnLamMoi.FlatAppearance.MouseDownBackColor = Color.FromArgb(69, 97, 120);
            btnLamMoi.FlatStyle = FlatStyle.Flat;
            btnLamMoi.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnLamMoi.ForeColor = Color.Black;
            btnLamMoi.Location = new Point(205, 27);
            btnLamMoi.Margin = new Padding(4);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(80, 31);
            btnLamMoi.TabIndex = 16;
            btnLamMoi.Text = "Clear";
            btnLamMoi.UseVisualStyleBackColor = false;
            btnLamMoi.Click += btnLamMoi_Click_1;
            // 
            // txtHoVaTen
            // 
            txtHoVaTen.BorderStyle = BorderStyle.FixedSingle;
            txtHoVaTen.Location = new Point(22, 131);
            txtHoVaTen.Margin = new Padding(4);
            txtHoVaTen.Name = "txtHoVaTen";
            txtHoVaTen.Size = new Size(257, 27);
            txtHoVaTen.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 230);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(104, 20);
            label4.TabIndex = 4;
            label4.Text = "Số điện thoại :";
            // 
            // txtMaKhachHang
            // 
            txtMaKhachHang.BorderStyle = BorderStyle.FixedSingle;
            txtMaKhachHang.Enabled = false;
            txtMaKhachHang.Location = new Point(22, 76);
            txtMaKhachHang.Margin = new Padding(4);
            txtMaKhachHang.Name = "txtMaKhachHang";
            txtMaKhachHang.Size = new Size(257, 27);
            txtMaKhachHang.TabIndex = 5;
            // 
            // txtDiemKH
            // 
            txtDiemKH.BorderStyle = BorderStyle.FixedSingle;
            txtDiemKH.Location = new Point(22, 193);
            txtDiemKH.Margin = new Padding(4);
            txtDiemKH.Name = "txtDiemKH";
            txtDiemKH.Size = new Size(257, 27);
            txtDiemKH.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 107);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(76, 20);
            label2.TabIndex = 7;
            label2.Text = "Họ và tên:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 44);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(112, 20);
            label1.TabIndex = 8;
            label1.Text = "Mã khách hàng:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 169);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(131, 20);
            label3.TabIndex = 6;
            label3.Text = "Điểm khách hàng :";
            label3.Click += label3_Click;
            // 
            // btnThem
            // 
            btnThem.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnThem.BackColor = SystemColors.ActiveCaption;
            btnThem.Cursor = Cursors.Hand;
            btnThem.FlatAppearance.BorderSize = 0;
            btnThem.FlatAppearance.MouseDownBackColor = Color.FromArgb(69, 97, 120);
            btnThem.FlatStyle = FlatStyle.Flat;
            btnThem.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnThem.ForeColor = Color.Black;
            btnThem.Location = new Point(178, 36);
            btnThem.Margin = new Padding(4);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(107, 52);
            btnThem.TabIndex = 10;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSua.BackColor = SystemColors.ActiveCaption;
            btnSua.Cursor = Cursors.Hand;
            btnSua.FlatAppearance.BorderSize = 0;
            btnSua.FlatAppearance.MouseDownBackColor = Color.FromArgb(69, 97, 120);
            btnSua.FlatStyle = FlatStyle.Flat;
            btnSua.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnSua.ForeColor = Color.Black;
            btnSua.Location = new Point(24, 36);
            btnSua.Margin = new Padding(4);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(107, 52);
            btnSua.TabIndex = 11;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(panel2);
            groupBox2.Controls.Add(panel1);
            groupBox2.Location = new Point(6, 71);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(883, 438);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách khách hàng ";
            // 
            // panel2
            // 
            panel2.Controls.Add(rdbTimKiemTen);
            panel2.Controls.Add(txtTimKiem_KhachHang);
            panel2.Controls.Add(rdbTimKiemMa);
            panel2.Controls.Add(label5);
            panel2.Location = new Point(0, 27);
            panel2.Name = "panel2";
            panel2.Size = new Size(1252, 42);
            panel2.TabIndex = 1;
            // 
            // rdbTimKiemTen
            // 
            rdbTimKiemTen.AutoSize = true;
            rdbTimKiemTen.Location = new Point(543, 10);
            rdbTimKiemTen.Name = "rdbTimKiemTen";
            rdbTimKiemTen.Size = new Size(53, 24);
            rdbTimKiemTen.TabIndex = 15;
            rdbTimKiemTen.TabStop = true;
            rdbTimKiemTen.Text = "Tên";
            rdbTimKiemTen.UseVisualStyleBackColor = true;
            // 
            // txtTimKiem_KhachHang
            // 
            txtTimKiem_KhachHang.BorderStyle = BorderStyle.FixedSingle;
            txtTimKiem_KhachHang.Location = new Point(95, 7);
            txtTimKiem_KhachHang.Margin = new Padding(4);
            txtTimKiem_KhachHang.Name = "txtTimKiem_KhachHang";
            txtTimKiem_KhachHang.PlaceholderText = "Tìm kiếm...";
            txtTimKiem_KhachHang.Size = new Size(381, 27);
            txtTimKiem_KhachHang.TabIndex = 1;
            txtTimKiem_KhachHang.TextChanged += txtTimKiem_KhachHang_TextChanged;
            // 
            // rdbTimKiemMa
            // 
            rdbTimKiemMa.AutoSize = true;
            rdbTimKiemMa.Location = new Point(491, 10);
            rdbTimKiemMa.Name = "rdbTimKiemMa";
            rdbTimKiemMa.Size = new Size(51, 24);
            rdbTimKiemMa.TabIndex = 14;
            rdbTimKiemMa.TabStop = true;
            rdbTimKiemMa.Text = "Mã";
            rdbTimKiemMa.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(23, 10);
            label5.Name = "label5";
            label5.Size = new Size(70, 20);
            label5.TabIndex = 0;
            label5.Text = "Tìm kiếm";
            // 
            // panel1
            // 
            panel1.Controls.Add(dgvKH);
            panel1.Location = new Point(0, 68);
            panel1.Name = "panel1";
            panel1.Size = new Size(1252, 365);
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
            dgvKH.Size = new Size(1252, 365);
            dgvKH.TabIndex = 1;
            dgvKH.CellClick += dgvKH_CellClick;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dgvHD);
            groupBox3.Location = new Point(6, 534);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(883, 350);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Hóa đơn đã mua";
            // 
            // dgvHD
            // 
            dgvHD.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHD.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHD.Dock = DockStyle.Fill;
            dgvHD.Location = new Point(3, 23);
            dgvHD.Margin = new Padding(4);
            dgvHD.Name = "dgvHD";
            dgvHD.RowHeadersWidth = 51;
            dgvHD.RowTemplate.Height = 25;
            dgvHD.Size = new Size(877, 324);
            dgvHD.TabIndex = 1;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(btnSua);
            groupBox4.Controls.Add(btnThem);
            groupBox4.Location = new Point(906, 376);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(320, 144);
            groupBox4.TabIndex = 17;
            groupBox4.TabStop = false;
            groupBox4.Text = "Chức năng";
            // 
            // Frm_US_KhachHang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Frm_US_KhachHang";
            Size = new Size(1259, 978);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvKH).EndInit();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvHD).EndInit();
            groupBox4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnThem;
        private Button btnSua;
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
        private GroupBox groupBox4;
    }
}
