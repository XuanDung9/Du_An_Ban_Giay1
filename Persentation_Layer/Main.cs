using A_Persentation_Layer.Frm.Frm_Dialog;
using A_Persentation_Layer.Frm.Frm_US;
using C_Data_Access_Layer.Models.ModelRefer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A_Persentation_Layer
{
    public partial class Main : Form
    {
        DangNhap_form form_dangNhap = new DangNhap_form();
        Frm_US_BanHang frm_banHang = new Frm_US_BanHang();
        private Button btnAction;
        private int tempIndex;
        public int idTaiKhoan;
        public int maChucVu;
        public string hoTen;

        public Main()
        {
            InitializeComponent();
        }

        public void ActiveButton(object btnsender)
        {
            if (btnsender != null)
            {
                if (btnAction != (Button)btnsender)
                {
                    if (btnAction != null)
                    {
                        btnAction.BackColor = Color.White; // Màu gốc của các nút
                        btnAction.Font = new System.Drawing.Font("Segoe UI", 10, FontStyle.Regular); // Font gốc của các nút
                    }
                    btnAction = (Button)btnsender;
                    btnAction.BackColor = Color.Gray;
                    btnAction.Font = new System.Drawing.Font("Segoe UI", 12, FontStyle.Bold);
                }
            }
        }

        public void DisableButton()
        {
            foreach (Control previousBtn in pn_menu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.Gray;
                    previousBtn.Font = new System.Drawing.Font("Segoe UI", 12, FontStyle.Bold);
                }
            }
        }

        private void Load_Usercontrol(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            pn_main.Controls.Clear();
            pn_main.Controls.Add(userControl);
            userControl.BringToFront();
        }

        public void OpenLoginForm()
        {
            this.Hide();
            if (form_dangNhap.ShowDialog() == DialogResult.OK)
            {
                idTaiKhoan = XacThucDangNhap.Instance.IdTaiKhoan;
                maChucVu = XacThucDangNhap.Instance.MaChucVu;
                hoTen = XacThucDangNhap.Instance.HoTen;

                if (idTaiKhoan != 0 && maChucVu != 0)
                {
                    txt_tenTaiKhoan.Text = hoTen;
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Đăng nhập thất bại. Vui lòng thử lại.");
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại. Vui lòng thử lại.");
                this.Close();
            }
        }


        private void btn_banHang_Click(object sender, EventArgs e)
        {
            Frm_US_BanHang _banHang = new Frm_US_BanHang();
            Load_Usercontrol(_banHang);
            ActiveButton(sender);
        }

        private void btn_sanPham_Click(object sender, EventArgs e)
        {
            Frm_US_SanPham _sanPham = new Frm_US_SanPham();
            Load_Usercontrol(_sanPham);
            ActiveButton(sender);
        }

        private void btn_khachHang_Click(object sender, EventArgs e)
        {
            Frm_US_KhachHang _khachHang = new Frm_US_KhachHang();
            Load_Usercontrol(_khachHang);
            ActiveButton(sender);
        }

        private void btn_hoaDon_Click(object sender, EventArgs e)
        {
            Frm_US_HoaDon _hoaDon = new Frm_US_HoaDon();
            Load_Usercontrol(_hoaDon);
            ActiveButton(sender);
        }

        private void btn_nhanVien_Click(object sender, EventArgs e)
        {
            Frm_US_NhanVien _nhanVien = new Frm_US_NhanVien();
            Load_Usercontrol(_nhanVien);
            ActiveButton(sender);
        }

        private void btn_khuyenMai_Click(object sender, EventArgs e)
        {
            Frm_US_UuDai _uuDai = new Frm_US_UuDai();
            Load_Usercontrol(_uuDai);
            ActiveButton(sender);
        }

        private void btn_thongKe_Click(object sender, EventArgs e)
        {
            Frm_US_ThongKe _thongKe = new Frm_US_ThongKe();
            Load_Usercontrol(_thongKe);
            ActiveButton(sender);
        }

        private void btn_dangXuat_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            XacThucDangNhap.Instance.DangXuat();
            this.Hide();

            DangNhap_form loginForm = new DangNhap_form();
            loginForm.ShowDialog();

            idTaiKhoan = XacThucDangNhap.Instance.IdTaiKhoan;
            maChucVu = XacThucDangNhap.Instance.MaChucVu;
            hoTen = XacThucDangNhap.Instance.HoTen;
            txt_tenTaiKhoan.Text = hoTen;

            if (idTaiKhoan != 0 && maChucVu != 0)
            {
                this.Show();
                btn_banHang.PerformClick();
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại. Vui lòng thử lại.");
                Application.Exit();
            }
        }

        private void Main_Load_1(object sender, EventArgs e)
        {
           
            OpenLoginForm();
            if (idTaiKhoan != 0 && maChucVu != 0)
            {
                btn_banHang.PerformClick();
            }
        }
    }
}
