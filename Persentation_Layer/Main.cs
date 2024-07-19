using A_Persentation_Layer.Frm.Frm_Dialog;
using C_Data_Access_Layer.Models.ModelRefer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A_Persentation_Layer
{
    public partial class Main : Form
    {
        DangNhap_form form_dangNhap = new DangNhap_form();
        public int idTaiKhoan;
        public int maChucVu;
        public string hoTen;
        public Main()
        {
            InitializeComponent();
        }
        public void OpenLoginForm()
        {
            form_dangNhap.ShowDialog();
            idTaiKhoan = XacThucDangNhap.Instance.IdTaiKhoan;
            maChucVu = XacThucDangNhap.Instance.MaChucVu;
            hoTen = XacThucDangNhap.Instance.HoTen;
            label1.Text = hoTen;
            if (idTaiKhoan != 0 || maChucVu != 0)
            {
                this.Show();
            }
            else
            {
                this.Close();
            }
        }
        private void Main_Load(object sender, EventArgs e)
        {
            this.Hide();
            OpenLoginForm();
            if (XacThucDangNhap.Instance.MaChucVu == 1)
            {
                MessageBox.Show("Bạn là nhân viên");
            }
            else if (XacThucDangNhap.Instance.MaChucVu == 2)
            {
                MessageBox.Show("Bạn là quản lý");
            }
            else
            {
                MessageBox.Show("Không nhận dạng được chức vụ");
            }
        }
    }
}
