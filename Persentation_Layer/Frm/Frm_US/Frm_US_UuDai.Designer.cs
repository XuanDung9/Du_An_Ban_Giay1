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
            groupBox3 = new GroupBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dateketthuc = new DateTimePicker();
            datebatdau = new DateTimePicker();
            txtSoluong = new TextBox();
            txtTen = new TextBox();
            groupBox4 = new GroupBox();
            btnSua = new Button();
            btnThem = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgHienthi).BeginInit();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.AccessibleRole = AccessibleRole.TitleBar;
            groupBox1.Controls.Add(dtgHienthi);
            groupBox1.Location = new Point(15, 13);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(720, 699);
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
            dtgHienthi.Size = new Size(708, 667);
            dtgHienthi.TabIndex = 0;
            dtgHienthi.CellClick += dtgHienthi_CellClick;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnlammoi);
            groupBox2.Controls.Add(btnketthuc);
            groupBox2.Controls.Add(txtTimkiem);
            groupBox2.Location = new Point(760, 13);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(330, 146);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Tìm kiếm";
            // 
            // btnlammoi
            // 
            btnlammoi.BackColor = Color.FromArgb(64, 79, 105);
            btnlammoi.ForeColor = SystemColors.ButtonHighlight;
            btnlammoi.Location = new Point(177, 87);
            btnlammoi.Name = "btnlammoi";
            btnlammoi.Size = new Size(115, 51);
            btnlammoi.TabIndex = 2;
            btnlammoi.Text = "Làm mới";
            btnlammoi.UseVisualStyleBackColor = false;
            btnlammoi.Click += btnlammoi_Click;
            // 
            // btnketthuc
            // 
            btnketthuc.BackColor = Color.FromArgb(64, 79, 105);
            btnketthuc.ForeColor = SystemColors.ButtonHighlight;
            btnketthuc.Location = new Point(41, 87);
            btnketthuc.Name = "btnketthuc";
            btnketthuc.Size = new Size(120, 51);
            btnketthuc.TabIndex = 1;
            btnketthuc.Text = "Kết thúc";
            btnketthuc.UseVisualStyleBackColor = false;
            btnketthuc.Click += btnketthuc_Click;
            // 
            // txtTimkiem
            // 
            txtTimkiem.BorderStyle = BorderStyle.FixedSingle;
            txtTimkiem.Location = new Point(27, 39);
            txtTimkiem.Name = "txtTimkiem";
            txtTimkiem.Size = new Size(281, 27);
            txtTimkiem.TabIndex = 0;
            txtTimkiem.TextChanged += txtTimkiem_TextChanged;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(label1);
            groupBox3.Controls.Add(dateketthuc);
            groupBox3.Controls.Add(datebatdau);
            groupBox3.Controls.Add(txtSoluong);
            groupBox3.Controls.Add(txtTen);
            groupBox3.Location = new Point(760, 165);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(330, 365);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Thông tin";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(27, 264);
            label4.Name = "label4";
            label4.Size = new Size(100, 20);
            label4.TabIndex = 10;
            label4.Text = "Ngày kết thúc";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 199);
            label3.Name = "label3";
            label3.Size = new Size(99, 20);
            label3.TabIndex = 9;
            label3.Text = "Ngày bắt đầu";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 106);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 8;
            label2.Text = "Số lượng";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 40);
            label1.Name = "label1";
            label1.Size = new Size(78, 20);
            label1.TabIndex = 7;
            label1.Text = "Tên ưu đãi";
            // 
            // dateketthuc
            // 
            dateketthuc.Location = new Point(27, 287);
            dateketthuc.Name = "dateketthuc";
            dateketthuc.Size = new Size(281, 27);
            dateketthuc.TabIndex = 6;
            // 
            // datebatdau
            // 
            datebatdau.Location = new Point(27, 222);
            datebatdau.Name = "datebatdau";
            datebatdau.Size = new Size(281, 27);
            datebatdau.TabIndex = 5;
            // 
            // txtSoluong
            // 
            txtSoluong.BorderStyle = BorderStyle.FixedSingle;
            txtSoluong.Location = new Point(27, 129);
            txtSoluong.Name = "txtSoluong";
            txtSoluong.Size = new Size(281, 27);
            txtSoluong.TabIndex = 4;
            // 
            // txtTen
            // 
            txtTen.BorderStyle = BorderStyle.FixedSingle;
            txtTen.Location = new Point(27, 63);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(281, 27);
            txtTen.TabIndex = 3;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(btnSua);
            groupBox4.Controls.Add(btnThem);
            groupBox4.Location = new Point(760, 544);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(330, 168);
            groupBox4.TabIndex = 2;
            groupBox4.TabStop = false;
            groupBox4.Text = "Chức năng";
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.FromArgb(64, 79, 105);
            btnSua.ForeColor = SystemColors.ButtonHighlight;
            btnSua.Location = new Point(27, 97);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(281, 51);
            btnSua.TabIndex = 4;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.FromArgb(64, 79, 105);
            btnThem.ForeColor = SystemColors.ButtonHighlight;
            btnThem.Location = new Point(27, 40);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(281, 51);
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
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Frm_US_UuDai";
            Size = new Size(1115, 728);
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgHienthi).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
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
        private GroupBox groupBox3;
        private DateTimePicker dateketthuc;
        private DateTimePicker datebatdau;
        private TextBox txtSoluong;
        private TextBox txtTen;
        private GroupBox groupBox4;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnSua;
        private Button btnThem;
    }
}
