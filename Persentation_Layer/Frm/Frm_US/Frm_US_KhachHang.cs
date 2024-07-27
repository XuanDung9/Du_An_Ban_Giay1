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
            LoadGrid(null);
        }
        private KhachHangService _service = new KhachHangService();
        int idWhenClick;

        public void LoadGrid(string search)
        {
            int stt = 1;

            dgvKH.ColumnCount = 6;
            dgvKH.Columns[0].Name = "STT";
            dgvKH.Columns[1].Name = "Mã";
            dgvKH.Columns[2].Name = "Tên";
            dgvKH.Columns[3].Name = "SDT";
            dgvKH.Columns[4].Name = "Điểm";
            dgvKH.Columns[5].Name = "Trạng Thái";
            dgvKH.Rows.Clear();

            foreach (var x in _service.GetAllKhachhang(search))
            {
                dgvKH.Rows.Add(stt++, x.Makhachhang, x.Tenkhachhang, x.Sdt.ToString(), x.Diemkhachhang, x.Trangthai == false ? "Không hoạt động" : "Hoạt đông");
            }
        }
        public void LoadHoaDon()
        {
            int stt = 1;

            dgvHD.ColumnCount = 5;
            dgvHD.Columns[0].Name = "STT";
            dgvHD.Columns[1].Name = "Mã Hoá Đơn";
            dgvHD.Columns[2].Name = "Ngày tạo";
            dgvHD.Columns[3].Name = "Loại thanh toán";
            dgvHD.Columns[4].Name = "Tổng tiền";
            dgvHD.Rows.Clear();

            foreach (var e in _service.GetAllHoadon())
            {
                var idtt = _service.GetHinhthucthanhtoans().FirstOrDefault(x => x.Mahinhthucthanhtoan == e.Mahinhthucthanhtoan);
                dgvHD.Rows.Add(stt++, e.Mahoadon, e.Ngaytao, idtt.Tenhinhthuc, e.Tongtien);
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!checksdt(int.Parse(txtSDT.Text)))
            {
                MessageBox.Show("Số điện thoại tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (checkdulieu(txtSDT.Text))
            {
                Khachhang khachhang = new Khachhang();
                khachhang.Tenkhachhang = txtHoVaTen.Text;
                khachhang.Sdt = int.Parse(txtSDT.Text);
                khachhang.Diemkhachhang = 0;
                khachhang.Trangthai = true;

                var relust = MessageBox.Show("Xác nhận muốm thêm", "Xác nhận", MessageBoxButtons.YesNo);
                if (relust == DialogResult.Yes)
                {
                    MessageBox.Show(_service.AddKhachHang(khachhang));
                }
                LoadGrid(null);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (checkdulieu(txtSDT.Text))
            {
                Khachhang khachhang = new Khachhang();
                khachhang.Makhachhang = idWhenClick;
                khachhang.Tenkhachhang = txtHoVaTen.Text;
                khachhang.Sdt = int.Parse(txtSDT.Text);
                var relust = MessageBox.Show("Xác nhận muốm sửa", "Xác nhận", MessageBoxButtons.YesNo);
                if (relust == DialogResult.Yes)
                {
                    MessageBox.Show(_service.UpdateKhachHang(khachhang));
                }
                LoadGrid(null);
            }
        }

        private void btnKhoa_MoKhoa_Click(object sender, EventArgs e)
        {
            Khachhang khachhang = new Khachhang();
            khachhang.Makhachhang = idWhenClick;
            var relust = MessageBox.Show("Xác nhận muốm Khoá/Mở khoá", "Xác nhận", MessageBoxButtons.YesNo);
            if (relust == DialogResult.Yes)
            {
                MessageBox.Show(_service.Khoa_MoKhoa(khachhang));
            }
            LoadGrid(null);
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            using (ExcelPackage excelPackage = new ExcelPackage())
            {
                ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.Add("Sheet1");

                for (int i = 0; i < dgvKH.Columns.Count; i++)
                {
                    worksheet.Cells[1, i + 1].Value = dgvKH.Columns[i].HeaderText;
                }

                for (int i = 0; i < dgvKH.Rows.Count; i++)
                {
                    for (int j = 0; j < dgvKH.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 2, j + 1].Value = dgvKH.Rows[i].Cells[j].Value?.ToString();
                    }
                }

                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    FileInfo fileInfo = new FileInfo(saveFileDialog.FileName);
                    excelPackage.SaveAs(fileInfo);
                }
            }
            MessageBox.Show("Dữ liệu đã được xuất thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dgvKH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvKH_CellBorderStyleChanged(object sender, EventArgs e)
        {

        }

        private void dgvKH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                idWhenClick = int.Parse(dgvKH.Rows[index].Cells[1].Value.ToString());
                var khach = _service.GetAllKhachhang(null).FirstOrDefault(x => x.Makhachhang == idWhenClick);
                txtMaKhachHang.Text = khach.Makhachhang.ToString();
                txtHoVaTen.Text = khach.Tenkhachhang;
                txtSDT.Text = khach.Sdt.ToString();
                txtDiemKH.Text = khach.Diemkhachhang.ToString();
                LoadHoaDon();
            }
        }

        private void txtTimKiem_KhachHang_TextChanged(object sender, EventArgs e)
        {
            LoadGrid(txtTimKiem_KhachHang.Text);
        }
        public bool checksdt(int sodienthoai)
        {
            return !_service.GetAllKhachhang(null).Any(khachhang => khachhang.Sdt == sodienthoai);
        }
        public bool checkdulieu(string sodienthoai)
        {
            if (string.IsNullOrEmpty(txtSDT.Text) || string.IsNullOrEmpty(txtHoVaTen.Text))
            {
                MessageBox.Show("Vui lòng nhập đủ dữ liệu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (!int.TryParse(sodienthoai, out int sdt) || sodienthoai.Length != 10 || sodienthoai[0] != '0')
            {
                MessageBox.Show("Số điện thoại không hợp lệ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
    }
}
