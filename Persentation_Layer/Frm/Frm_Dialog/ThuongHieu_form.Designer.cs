namespace A_Persentation_Layer.Frm.Frm_Dialog
{
    partial class ThuongHieu_form
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
            dgv_Objects = new DataGridView();
            groupBox1 = new GroupBox();
            btnKhoa_MoKhoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            label2 = new Label();
            label1 = new Label();
            txtMoTa = new TextBox();
            txtTen = new TextBox();
            btnTimKiem = new Button();
            cbbTimKiem = new ComboBox();
            txtTimKiem = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgv_Objects).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dgv_Objects
            // 
            dgv_Objects.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Objects.Location = new Point(6, 333);
            dgv_Objects.Name = "dgv_Objects";
            dgv_Objects.RowHeadersWidth = 51;
            dgv_Objects.RowTemplate.Height = 29;
            dgv_Objects.Size = new Size(628, 188);
            dgv_Objects.TabIndex = 22;
            dgv_Objects.CellClick += dgv_Objects_CellClick_1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnKhoa_MoKhoa);
            groupBox1.Controls.Add(btnSua);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Location = new Point(441, 62);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(193, 217);
            groupBox1.TabIndex = 21;
            groupBox1.TabStop = false;
            groupBox1.Text = "Chức năng ";
            // 
            // btnKhoa_MoKhoa
            // 
            btnKhoa_MoKhoa.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnKhoa_MoKhoa.Location = new Point(23, 150);
            btnKhoa_MoKhoa.Name = "btnKhoa_MoKhoa";
            btnKhoa_MoKhoa.Size = new Size(146, 47);
            btnKhoa_MoKhoa.TabIndex = 2;
            btnKhoa_MoKhoa.Text = "Khóa / Mở khóa";
            btnKhoa_MoKhoa.UseVisualStyleBackColor = true;
            btnKhoa_MoKhoa.Click += btnKhoa_MoKhoa_Click_1;
            // 
            // btnSua
            // 
            btnSua.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnSua.Location = new Point(23, 85);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(146, 47);
            btnSua.TabIndex = 1;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click_1;
            // 
            // btnThem
            // 
            btnThem.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnThem.Location = new Point(23, 26);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(146, 47);
            btnThem.TabIndex = 0;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 114);
            label2.Name = "label2";
            label2.Size = new Size(55, 20);
            label2.TabIndex = 20;
            label2.Text = "Mô tả :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 69);
            label1.Name = "label1";
            label1.Size = new Size(39, 20);
            label1.TabIndex = 19;
            label1.Text = "Tên :";
            // 
            // txtMoTa
            // 
            txtMoTa.Location = new Point(101, 124);
            txtMoTa.Multiline = true;
            txtMoTa.Name = "txtMoTa";
            txtMoTa.Size = new Size(269, 167);
            txtMoTa.TabIndex = 18;
            // 
            // txtTen
            // 
            txtTen.Location = new Point(101, 62);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(269, 27);
            txtTen.TabIndex = 17;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnTimKiem.Location = new Point(487, 3);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(131, 36);
            btnTimKiem.TabIndex = 16;
            btnTimKiem.Text = "Search";
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click_1;
            // 
            // cbbTimKiem
            // 
            cbbTimKiem.FormattingEnabled = true;
            cbbTimKiem.Location = new Point(287, 3);
            cbbTimKiem.Name = "cbbTimKiem";
            cbbTimKiem.Size = new Size(137, 28);
            cbbTimKiem.TabIndex = 15;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(18, 3);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.PlaceholderText = "Tìm kiếm ...";
            txtTimKiem.Size = new Size(220, 27);
            txtTimKiem.TabIndex = 14;
            // 
            // ThuongHieu_form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 524);
            Controls.Add(dgv_Objects);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtMoTa);
            Controls.Add(txtTen);
            Controls.Add(btnTimKiem);
            Controls.Add(cbbTimKiem);
            Controls.Add(txtTimKiem);
            Name = "ThuongHieu_form";
            Text = "ThuongHieu_form";
            Load += ThuongHieu_form_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_Objects).EndInit();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv_Objects;
        private GroupBox groupBox1;
        private Button btnKhoa_MoKhoa;
        private Button btnSua;
        private Button btnThem;
        private Label label2;
        private Label label1;
        private TextBox txtMoTa;
        private TextBox txtTen;
        private Button btnTimKiem;
        private ComboBox cbbTimKiem;
        private TextBox txtTimKiem;
    }
}