namespace A_Persentation_Layer.Frm.Frm_Dialog
{
    partial class TimKiemKhachHHang
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
            btnTimKiem = new Button();
            txtTimKiem = new TextBox();
            label2 = new Label();
            label1 = new Label();
            txtSdt = new TextBox();
            txtTen = new TextBox();
            groupBox1 = new GroupBox();
            btnChon = new Button();
            btnThem = new Button();
            dgv_Objects = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Objects).BeginInit();
            SuspendLayout();
            // 
            // btnTimKiem
            // 
            btnTimKiem.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnTimKiem.Location = new Point(580, 13);
            btnTimKiem.Margin = new Padding(4);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(132, 42);
            btnTimKiem.TabIndex = 82;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtTimKiem.Location = new Point(52, 13);
            txtTimKiem.Margin = new Padding(4);
            txtTimKiem.Multiline = true;
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.PlaceholderText = "Tìm kiếm số điện thoại...";
            txtTimKiem.Size = new Size(518, 40);
            txtTimKiem.TabIndex = 81;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(376, 59);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(104, 21);
            label2.TabIndex = 79;
            label2.Text = "Số điện thoại:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(52, 59);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(36, 21);
            label1.TabIndex = 80;
            label1.Text = "Tên:";
            // 
            // txtSdt
            // 
            txtSdt.Location = new Point(376, 90);
            txtSdt.Margin = new Padding(4);
            txtSdt.Multiline = true;
            txtSdt.Name = "txtSdt";
            txtSdt.Size = new Size(334, 45);
            txtSdt.TabIndex = 77;
            // 
            // txtTen
            // 
            txtTen.Location = new Point(52, 90);
            txtTen.Margin = new Padding(4);
            txtTen.Multiline = true;
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(315, 45);
            txtTen.TabIndex = 78;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnChon);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Location = new Point(12, 142);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(756, 189);
            groupBox1.TabIndex = 83;
            groupBox1.TabStop = false;
            groupBox1.Text = "Chức năng";
            // 
            // btnChon
            // 
            btnChon.BackColor = Color.LightSteelBlue;
            btnChon.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnChon.ForeColor = SystemColors.ActiveCaptionText;
            btnChon.Location = new Point(410, 45);
            btnChon.Margin = new Padding(4);
            btnChon.Name = "btnChon";
            btnChon.Size = new Size(212, 99);
            btnChon.TabIndex = 16;
            btnChon.Text = "Chọn";
            btnChon.UseVisualStyleBackColor = false;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.LightSteelBlue;
            btnThem.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnThem.ForeColor = SystemColors.ActiveCaptionText;
            btnThem.Location = new Point(134, 45);
            btnThem.Margin = new Padding(4);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(212, 99);
            btnThem.TabIndex = 17;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            // 
            // dgv_Objects
            // 
            dgv_Objects.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_Objects.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Objects.Location = new Point(12, 338);
            dgv_Objects.Margin = new Padding(4);
            dgv_Objects.Name = "dgv_Objects";
            dgv_Objects.RowHeadersWidth = 51;
            dgv_Objects.RowTemplate.Height = 25;
            dgv_Objects.Size = new Size(756, 302);
            dgv_Objects.TabIndex = 84;
            // 
            // TimKiemKhachHHang
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(780, 653);
            Controls.Add(dgv_Objects);
            Controls.Add(groupBox1);
            Controls.Add(btnTimKiem);
            Controls.Add(txtTimKiem);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtSdt);
            Controls.Add(txtTen);
            Name = "TimKiemKhachHHang";
            Text = "TimKiemKhachHHang";
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_Objects).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnTimKiem;
        private TextBox txtTimKiem;
        private Label label2;
        private Label label1;
        private TextBox txtSdt;
        private TextBox txtTen;
        private GroupBox groupBox1;
        private Button btnChon;
        private Button btnThem;
        private DataGridView dgv_Objects;
    }
}