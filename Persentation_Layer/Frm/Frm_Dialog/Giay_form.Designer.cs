namespace A_Persentation_Layer.Frm.Frm_Dialog
{
    partial class Giay_form
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
            cbbTimKiem = new ComboBox();
            txtTimKiem = new TextBox();
            groupBox1 = new GroupBox();
            btnSua = new Button();
            btnThem = new Button();
            label1 = new Label();
            txtTen = new TextBox();
            dgv_Objects = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Objects).BeginInit();
            SuspendLayout();
            // 
            // btnTimKiem
            // 
            btnTimKiem.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnTimKiem.Location = new Point(496, 5);
            btnTimKiem.Margin = new Padding(3, 4, 3, 4);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(118, 40);
            btnTimKiem.TabIndex = 76;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click_1;
            // 
            // cbbTimKiem
            // 
            cbbTimKiem.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbTimKiem.FormattingEnabled = true;
            cbbTimKiem.Location = new Point(315, 7);
            cbbTimKiem.Margin = new Padding(3, 4, 3, 4);
            cbbTimKiem.Name = "cbbTimKiem";
            cbbTimKiem.Size = new Size(171, 28);
            cbbTimKiem.TabIndex = 75;
            cbbTimKiem.SelectedIndexChanged += cbbTimKiem_SelectedIndexChanged;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtTimKiem.Location = new Point(27, 5);
            txtTimKiem.Margin = new Padding(3, 4, 3, 4);
            txtTimKiem.Multiline = true;
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.PlaceholderText = "Tìm kiếm...";
            txtTimKiem.Size = new Size(281, 39);
            txtTimKiem.TabIndex = 74;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnSua);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Location = new Point(27, 130);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(586, 123);
            groupBox1.TabIndex = 73;
            groupBox1.TabStop = false;
            groupBox1.Text = "Chức năng";
            // 
            // btnSua
            // 
            btnSua.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnSua.Location = new Point(321, 20);
            btnSua.Margin = new Padding(3, 4, 3, 4);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(189, 95);
            btnSua.TabIndex = 14;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click_1;
            // 
            // btnThem
            // 
            btnThem.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnThem.Location = new Point(75, 20);
            btnThem.Margin = new Padding(3, 4, 3, 4);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(189, 95);
            btnThem.TabIndex = 15;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 49);
            label1.Name = "label1";
            label1.Size = new Size(35, 20);
            label1.TabIndex = 72;
            label1.Text = "Tên:";
            // 
            // txtTen
            // 
            txtTen.Location = new Point(27, 78);
            txtTen.Margin = new Padding(3, 4, 3, 4);
            txtTen.Multiline = true;
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(586, 43);
            txtTen.TabIndex = 71;
            // 
            // dgv_Objects
            // 
            dgv_Objects.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_Objects.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Objects.Location = new Point(27, 261);
            dgv_Objects.Margin = new Padding(3, 4, 3, 4);
            dgv_Objects.Name = "dgv_Objects";
            dgv_Objects.RowHeadersWidth = 51;
            dgv_Objects.RowTemplate.Height = 25;
            dgv_Objects.Size = new Size(586, 259);
            dgv_Objects.TabIndex = 70;
            dgv_Objects.CellClick += dgv_Objects_CellClick_1;
            // 
            // Giay_form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 524);
            Controls.Add(btnTimKiem);
            Controls.Add(cbbTimKiem);
            Controls.Add(txtTimKiem);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(txtTen);
            Controls.Add(dgv_Objects);
            Name = "Giay_form";
            Text = "Giay_form";
            Load += Giay_form_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_Objects).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnTimKiem;
        private ComboBox cbbTimKiem;
        private TextBox txtTimKiem;
        private GroupBox groupBox1;
        private Button btnSua;
        private Button btnThem;
        private Label label1;
        private TextBox txtTen;
        private DataGridView dgv_Objects;
    }
}