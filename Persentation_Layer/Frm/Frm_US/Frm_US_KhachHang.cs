using B_Bussiness_Layer.Services;
using C_Data_Access_Layer.Models;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A_Persentation_Layer.Frm.Frm_US
{
    public partial class Frm_US_KhachHang : UserControl
    {
        public Frm_US_KhachHang()
        {
            InitializeComponent();
            LoadGrid(null, "Tên");
        }

        private KhachHangService _service = new KhachHangService();
        int idWhenClick;

        public void LoadGrid(string search, string searchType)
        {
            int stt = 1;

            dgvKH.ColumnCount = 5;
            dgvKH.Columns[0].Name = "STT";
            dgvKH.Columns[1].Name = "Mã";
            dgvKH.Columns[2].Name = "Tên";
            dgvKH.Columns[3].Name = "SDT";
            dgvKH.Columns[4].Name = "Điểm";
            dgvKH.Rows.Clear();

            IEnumerable<Khachhang> khachhangs = _service.GetAllKhachhang(null);

            if (!string.IsNullOrEmpty(search))
            {
                if (searchType == "Mã")
                {
                    khachhangs = khachhangs.Where(x => x.Makhachhang.ToString().Contains(search));
                }
                else if (searchType == "Tên")
                {
                    khachhangs = khachhangs.Where(x => x.Tenkhachhang.IndexOf(search, StringComparison.OrdinalIgnoreCase) >= 0);
                }
            }

            foreach (var x in khachhangs)
            {
                string sdtFormatted = x.Sdt.HasValue ? x.Sdt.Value.ToString("D10") : "Chưa có số";
                dgvKH.Rows.Add(stt++, x.Makhachhang, x.Tenkhachhang, sdtFormatted, x.Diemkhachhang);
            }
        }



        public void LoadHoaDon(int khachHangId)
        {
            int stt = 1;

            dgvHD.ColumnCount = 5;
            dgvHD.Columns[0].Name = "STT";
            dgvHD.Columns[1].Name = "Mã Hoá Đơn";
            dgvHD.Columns[2].Name = "Ngày tạo";
            dgvHD.Columns[3].Name = "Loại thanh toán";
            dgvHD.Columns[4].Name = "Tổng tiền";
            dgvHD.Rows.Clear();

            foreach (var e in _service.GetHoadonsByKhachHangId(khachHangId))
            {
                var idtt = _service.GetHinhthucthanhtoans().FirstOrDefault(x => x.Mahinhthucthanhtoan == e.Mahinhthucthanhtoan);
                dgvHD.Rows.Add(stt++, e.Mahoadon, e.Ngaytao, idtt.Tenhinhthuc, e.Tongtien);
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSDT.Text) || string.IsNullOrEmpty(txtHoVaTen.Text) || string.IsNullOrEmpty(txtDiemKH.Text))
            {
                MessageBox.Show("Vui lòng nhập đủ dữ liệu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(txtSDT.Text, out int sdt) || txtSDT.Text.Length != 10)
            {
                MessageBox.Show("Số điện thoại không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!checksdt(sdt))
            {
                MessageBox.Show("Số điện thoại đã tồn tại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (checkdulieu(txtSDT.Text, txtDiemKH.Text))
            {
                Khachhang khachhang = new Khachhang
                {
                    Tenkhachhang = txtHoVaTen.Text,
                    Sdt = sdt,
                    Diemkhachhang = int.Parse(txtDiemKH.Text),
                    Trangthai = true
                };

                var result = MessageBox.Show("Xác nhận muốn thêm", "Xác nhận", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    MessageBox.Show(_service.AddKhachHang(khachhang));
                }
                LoadGrid(null, "Tên");
            }
        }

        public void btnSua_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtSDT.Text, out int sdt) || txtSDT.Text.Length != 10)
            {
                MessageBox.Show("Số điện thoại không hợp lệ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (checkdulieu(txtSDT.Text, txtDiemKH.Text))
            {
                Khachhang khachhang = new Khachhang
                {
                    Makhachhang = idWhenClick,
                    Tenkhachhang = txtHoVaTen.Text,
                    Sdt = sdt,
                    Diemkhachhang = int.Parse(txtDiemKH.Text)
                };

                var result = MessageBox.Show("Xác nhận muốn sửa", "Xác nhận", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    MessageBox.Show(_service.UpdateKhachHang(khachhang));
                }
                LoadGrid(null, "Tên");
            }
        }


        //public void btnKhoa_MoKhoa_Click(object sender, EventArgs e)
        //{
        //    Khachhang khachhang = new Khachhang
        //    {
        //        Makhachhang = idWhenClick
        //    };

        //    var result = MessageBox.Show("Xác nhận muốn Khoá/Mở khoá", "Xác nhận", MessageBoxButtons.YesNo);
        //    if (result == DialogResult.Yes)
        //    {
        //        MessageBox.Show(_service.Khoa_MoKhoa(khachhang));
        //    }
        //    LoadGrid(null, "Tên");
        //}

        private void dgvKH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0 && index < dgvKH.Rows.Count - 1)
            {
                idWhenClick = int.Parse(dgvKH.Rows[index].Cells[1].Value.ToString());
                var khach = _service.GetAllKhachhang(null).FirstOrDefault(x => x.Makhachhang == idWhenClick);
                if (khach != null)
                {
                    txtMaKhachHang.Text = khach.Makhachhang.ToString();
                    txtHoVaTen.Text = khach.Tenkhachhang;
                    txtSDT.Text = khach.Sdt.ToString();
                    txtDiemKH.Text = khach.Diemkhachhang.ToString();
                    LoadHoaDon(khach.Makhachhang);
                }
            }
        }
        private void txtTimKiem_KhachHang_TextChanged(object sender, EventArgs e)
        {
            string search = txtTimKiem_KhachHang.Text;
            string searchType = rdbTimKiemMa.Checked ? "Mã" : "Tên";
            LoadGrid(search, searchType);
        }

        public bool checksdt(int sodienthoai)
        {
            return !_service.GetAllKhachhang(null).Any(khachhang => khachhang.Sdt == sodienthoai);
        }
        public bool checkdulieu(string sodienthoai, string diem)
        {
            if (string.IsNullOrEmpty(sodienthoai) || string.IsNullOrEmpty(txtHoVaTen.Text) || string.IsNullOrEmpty(diem))
            {
                MessageBox.Show("Vui lòng nhập đủ dữ liệu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (!int.TryParse(sodienthoai, out int sdt) || sodienthoai.Length != 10 || !sodienthoai.All(char.IsDigit) || sdt <= 0)
            {
                MessageBox.Show("Số điện thoại không hợp lệ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (!int.TryParse(diem, out int diemkhachhang) || diemkhachhang <= 0)
            {
                MessageBox.Show("Điểm khách hàng phải là số nguyên dương", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        public void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaKhachHang.Text = string.Empty;
            txtHoVaTen.Text = string.Empty;
            txtSDT.Text = string.Empty;
            txtDiemKH.Text = string.Empty;
        }

        private void btnLamMoi_Click_1(object sender, EventArgs e)
        {
            txtMaKhachHang.Text = string.Empty;
            txtHoVaTen.Text = string.Empty;
            txtSDT.Text = string.Empty;
            txtDiemKH.Text = string.Empty;
        }
    }
}
