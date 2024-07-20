using B_Bussiness_Layer.Services;
using C_Data_Access_Layer.Models;
using C_Data_Access_Layer.Models.ModelRefer;
using Persentation_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A_Persentation_Layer.Frm.Frm_Dialog
{
    public partial class DangNhap_form : Form
    {
        TaiKhoanService _serviceTaiKhoan = new TaiKhoanService();
        List<Taikhoan> _lstTaiKhoan = new List<Taikhoan>();
        int idTaiKhoan;
        string HoTen;
        int maChucVu;
        public DangNhap_form()
        {
            InitializeComponent();
        }
        public bool XacThucUser(string username, string password, List<Taikhoan> lst_TaiKhoan)
        {
            foreach (var user in lst_TaiKhoan)
            {
                if (username == user.Username && password == user.Password)
                {
                    idTaiKhoan = user.Mataikhoan;
                    HoTen = user.Hoten;
                    maChucVu = user.Machucvu;
                    XacThucDangNhap.Instance.CapNhatThongTinDangNhap(user.Mataikhoan, user.Machucvu, user.Hoten); // gọi ra thằng xác thực trong lớp ModelRefer
                    return true;
                }
            }
            return false;
        }
        public void DangNhap()
        {
            _lstTaiKhoan = _serviceTaiKhoan.GetAll(null, null);
            if (XacThucUser(txt_taiKhoan.Text, txt_matKhau.Text, _lstTaiKhoan))
            {
                MessageBox.Show($"Đăng nhập thành công! \n Xin chào '{HoTen}'");
                this.DialogResult = DialogResult.OK;

            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại \n Vui lòng nhập lại thông tin ");
            }
        }
        private void DangNhap_Frm_Load(object sender, EventArgs e)
        {
            txt_matKhau.UseSystemPasswordChar = true;
            this.BackColor = Color.FromArgb(69, 97, 120);
        }

        private void btn_dangNhap_Click(object sender, EventArgs e)
        {
            DangNhap();
        }

        private void txt_taiKhoan_Enter(object sender, EventArgs e)
        {
            if (e is KeyEventArgs keyEventArgs && keyEventArgs.KeyCode == Keys.Enter) // nếu phím là enter thì kích hoạt chức năng DangNhap
            {
                DangNhap();
            }
        }

        private void txt_taiKhoan_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
