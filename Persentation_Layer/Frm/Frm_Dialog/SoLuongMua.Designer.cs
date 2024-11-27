namespace A_Persentation_Layer.Frm.Frm_Dialog
{
    partial class SoLuongMua
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
            label1 = new Label();
            txtSoLuong = new TextBox();
            btnSoLuong = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(13, 37);
            label1.Name = "label1";
            label1.Size = new Size(142, 20);
            label1.TabIndex = 0;
            label1.Text = "NHẬP SỐ LƯỢNG :";
            // 
            // txtSoLuong
            // 
            txtSoLuong.Location = new Point(161, 34);
            txtSoLuong.Multiline = true;
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.Size = new Size(227, 34);
            txtSoLuong.TabIndex = 1;
            txtSoLuong.TextChanged += txtSoLuong_TextChanged;
            // 
            // btnSoLuong
            // 
            btnSoLuong.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnSoLuong.Location = new Point(245, 120);
            btnSoLuong.Name = "btnSoLuong";
            btnSoLuong.Size = new Size(143, 46);
            btnSoLuong.TabIndex = 2;
            btnSoLuong.Text = "Xác nhận";
            btnSoLuong.UseVisualStyleBackColor = true;
            btnSoLuong.Click += btnSoLuong_Click;
            // 
            // SoLuongMua
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(426, 178);
            Controls.Add(btnSoLuong);
            Controls.Add(txtSoLuong);
            Controls.Add(label1);
            Name = "SoLuongMua";
            Text = "SoLuongMua";
            Load += SoLuongMua_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtSoLuong;
        private Button btnSoLuong;
    }
}