namespace A_Persentation_Layer.Frm.Frm_Dialog
{
    partial class KieuDang_form
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
            txtTimKiem = new TextBox();
            cbbTimKiem = new ComboBox();
            btnTimKiem = new Button();
            groupBox1 = new GroupBox();
            btnKhoa_MoKhoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            label2 = new Label();
            label1 = new Label();
            txtMoTa = new TextBox();
            txtTen = new TextBox();
            dgv_Objects = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Objects).BeginInit();
            SuspendLayout();
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(12, 12);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.PlaceholderText = "Tìm kiếm ...";
            txtTimKiem.Size = new Size(220, 27);
            txtTimKiem.TabIndex = 2;
            // 
            // cbbTimKiem
            // 
            cbbTimKiem.FormattingEnabled = true;
            cbbTimKiem.Location = new Point(286, 12);
            cbbTimKiem.Name = "cbbTimKiem";
            cbbTimKiem.Size = new Size(137, 28);
            cbbTimKiem.TabIndex = 3;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnTimKiem.Location = new Point(497, 12);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(131, 36);
            btnTimKiem.TabIndex = 4;
            btnTimKiem.Text = "Search";
            btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnKhoa_MoKhoa);
            groupBox1.Controls.Add(btnSua);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Location = new Point(432, 71);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(193, 217);
            groupBox1.TabIndex = 17;
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
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 123);
            label2.Name = "label2";
            label2.Size = new Size(55, 20);
            label2.TabIndex = 16;
            label2.Text = "Mô tả :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 78);
            label1.Name = "label1";
            label1.Size = new Size(39, 20);
            label1.TabIndex = 15;
            label1.Text = "Tên :";
            // 
            // txtMoTa
            // 
            txtMoTa.Location = new Point(92, 133);
            txtMoTa.Multiline = true;
            txtMoTa.Name = "txtMoTa";
            txtMoTa.Size = new Size(269, 167);
            txtMoTa.TabIndex = 14;
            // 
            // txtTen
            // 
            txtTen.Location = new Point(92, 71);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(269, 27);
            txtTen.TabIndex = 13;
            // 
            // dgv_Objects
            // 
            dgv_Objects.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Objects.Location = new Point(0, 324);
            dgv_Objects.Name = "dgv_Objects";
            dgv_Objects.RowHeadersWidth = 51;
            dgv_Objects.RowTemplate.Height = 29;
            dgv_Objects.Size = new Size(628, 188);
            dgv_Objects.TabIndex = 18;
            dgv_Objects.CellClick += dgv_Objects_CellClick_1;
            // 
            // KieuDang_form
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
            Name = "KieuDang_form";
            Text = "KieuDang_form";
            Load += KieuDang_form_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_Objects).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTimKiem;
        private ComboBox cbbTimKiem;
        private Button btnTimKiem;
        private GroupBox groupBox1;
        private Button btnKhoa_MoKhoa;
        private Button btnSua;
        private Button btnThem;
        private Label label2;
        private Label label1;
        private TextBox txtMoTa;
        private TextBox txtTen;
        private DataGridView dgv_Objects;
    }
}