namespace A_Persentation_Layer.Frm.Frm_US
{
    partial class Frm_US_UuDai
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
            dtgHienthi = new DataGridView();
            groupBox2 = new GroupBox();
            btnlammoi = new Button();
            btnketthuc = new Button();
            txtTimkiem = new TextBox();
            dateketthuc = new GroupBox();
            dateTimePicker2 = new DateTimePicker();
            datebatdau = new DateTimePicker();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtSoluong = new TextBox();
            txtTen = new TextBox();
            groupBox4 = new GroupBox();
            btnSua = new Button();
            btnThem = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgHienthi).BeginInit();
            groupBox2.SuspendLayout();
            dateketthuc.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dtgHienthi);
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(777, 726);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Danh sách ưu đãi";
            // 
            // dtgHienthi
            // 
            dtgHienthi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgHienthi.Location = new Point(6, 26);
            dtgHienthi.Name = "dtgHienthi";
            dtgHienthi.RowHeadersWidth = 51;
            dtgHienthi.RowTemplate.Height = 29;
            dtgHienthi.Size = new Size(765, 694);
            dtgHienthi.TabIndex = 0;
            dtgHienthi.CellClick += dtgHienthi_CellClick;

            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnlammoi);
            groupBox2.Controls.Add(btnketthuc);
            groupBox2.Controls.Add(txtTimkiem);
            groupBox2.Location = new Point(802, 15);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(322, 161);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Tìm kiếm";
            // 
            // btnlammoi
            // 
            btnlammoi.BackColor = Color.FromArgb(64, 79, 105);
            btnlammoi.ForeColor = SystemColors.ButtonHighlight;
            btnlammoi.Location = new Point(179, 87);
            btnlammoi.Name = "btnlammoi";
            btnlammoi.Size = new Size(110, 51);
            btnlammoi.TabIndex = 2;
            btnlammoi.Text = "Làm mới";
            btnlammoi.UseVisualStyleBackColor = false;
            btnlammoi.Click += btnlammoi_Click;
            // 
            // btnketthuc
            // 
            btnketthuc.BackColor = Color.FromArgb(64, 79, 105);
            btnketthuc.ForeColor = SystemColors.ButtonFace;
            btnketthuc.Location = new Point(36, 87);
            btnketthuc.Name = "btnketthuc";
            btnketthuc.Size = new Size(110, 51);
            btnketthuc.TabIndex = 1;
            btnketthuc.Text = "Kết thúc";
            btnketthuc.UseVisualStyleBackColor = false;
            btnketthuc.Click += btnketthuc_Click;
            // 
            // txtTimkiem
            // 
            txtTimkiem.BorderStyle = BorderStyle.FixedSingle;
            txtTimkiem.Location = new Point(21, 39);
            txtTimkiem.Name = "txtTimkiem";
            txtTimkiem.Size = new Size(280, 27);
            txtTimkiem.TabIndex = 0;
            txtTimkiem.TextChanged += txtTimkiem_TextChanged;
            // 
            // dateketthuc
            // 
            dateketthuc.Controls.Add(dateTimePicker2);
            dateketthuc.Controls.Add(datebatdau);
            dateketthuc.Controls.Add(label4);
            dateketthuc.Controls.Add(label3);
            dateketthuc.Controls.Add(label2);
            dateketthuc.Controls.Add(label1);
            dateketthuc.Controls.Add(txtSoluong);
            dateketthuc.Controls.Add(txtTen);
            dateketthuc.Location = new Point(802, 182);
            dateketthuc.Name = "dateketthuc";
            dateketthuc.Size = new Size(322, 379);
            dateketthuc.TabIndex = 3;
            dateketthuc.TabStop = false;
            dateketthuc.Text = "Thông tin";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(21, 286);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(280, 27);
            dateTimePicker2.TabIndex = 11;
            // 
            // datebatdau
            // 
            datebatdau.Location = new Point(21, 215);
            datebatdau.Name = "datebatdau";
            datebatdau.Size = new Size(280, 27);
            datebatdau.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 263);
            label4.Name = "label4";
            label4.Size = new Size(100, 20);
            label4.TabIndex = 9;
            label4.Text = "Ngày kết thúc";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 192);
            label3.Name = "label3";
            label3.Size = new Size(99, 20);
            label3.TabIndex = 8;
            label3.Text = "Ngày bắt đầu";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 110);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 7;
            label2.Text = "Số lượng";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 46);
            label1.Name = "label1";
            label1.Size = new Size(78, 20);
            label1.TabIndex = 6;
            label1.Text = "Tên ưu đãi";
            // 
            // txtSoluong
            // 
            txtSoluong.BorderStyle = BorderStyle.FixedSingle;
            txtSoluong.Location = new Point(21, 133);
            txtSoluong.Name = "txtSoluong";
            txtSoluong.Size = new Size(280, 27);
            txtSoluong.TabIndex = 4;
            // 
            // txtTen
            // 
            txtTen.BorderStyle = BorderStyle.FixedSingle;
            txtTen.Location = new Point(21, 69);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(280, 27);
            txtTen.TabIndex = 3;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(btnSua);
            groupBox4.Controls.Add(btnThem);
            groupBox4.Location = new Point(802, 575);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(322, 154);
            groupBox4.TabIndex = 4;
            groupBox4.TabStop = false;
            groupBox4.Text = "Chức năng";
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.FromArgb(64, 79, 105);
            btnSua.ForeColor = SystemColors.ButtonFace;
            btnSua.Location = new Point(21, 93);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(268, 51);
            btnSua.TabIndex = 4;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.FromArgb(64, 79, 105);
            btnThem.ForeColor = SystemColors.ButtonFace;
            btnThem.Location = new Point(21, 36);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(268, 51);
            btnThem.TabIndex = 3;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // Frm_US_UuDai
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox4);
            Controls.Add(dateketthuc);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Frm_US_UuDai";
            Size = new Size(1179, 743);
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgHienthi).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            dateketthuc.ResumeLayout(false);
            dateketthuc.PerformLayout();
            groupBox4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView dtgHienthi;
        private GroupBox groupBox2;
        private Button btnlammoi;
        private Button btnketthuc;
        private TextBox txtTimkiem;
        private GroupBox dateketthuc;
        private GroupBox groupBox4;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker datebatdau;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtSoluong;
        private TextBox txtTen;
        private Button btnSua;
        private Button btnThem;
    }
}
