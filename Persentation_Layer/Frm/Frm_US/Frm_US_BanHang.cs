using A_Persentation_Layer.Frm.Frm_Dialog;
using B_Bussiness_Layer.Services;
using C_Data_Access_Layer.Context;
using C_Data_Access_Layer.Models;
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

namespace A_Persentation_Layer.Frm.Frm_US
{
    public partial class Frm_US_BanHang : UserControl
    {
        public Frm_US_BanHang()
        {
            InitializeComponent();
        }
        DBContext _context = new DBContext();
        BanHangService _service = new BanHangService();
        UudaiService _ser_UuDai = new UudaiService();
        HinhThucThanhToanService _ser_HinhThucThanhToan = new HinhThucThanhToanService();
        Giay_GiayChiTietService _Ser_Giay_ChiTietGiay = new Giay_GiayChiTietService();
        GiayChiTietService _ser_GiayChiTiet = new GiayChiTietService();
        HoaDonService _Ser_HoaDon = new HoaDonService();
        DangNhap_form formDangNhap = new DangNhap_form();
        TimKiemKhachHHang formTimKhachHang = new TimKiemKhachHHang();
        KhachHangService _Ser_KhachHang = new KhachHangService();
        HoaDonChiTIetService _Ser_HoaDonChiTiet = new HoaDonChiTIetService();
        List<HoaDonChiTiet_SP> _lstHoadonChiTiet = new List<HoaDonChiTiet_SP>();
        List<Giay_ChiTietGiay> _lstGiay_ChiTietGiay = new List<Giay_ChiTietGiay>();
        List<HoaDon_Model> _lstHoaDon = new List<HoaDon_Model>();
        List<Hinhthucthanhtoan> _lstHinhThucThanhToan = new List<Hinhthucthanhtoan>();


        List<int> idHoaDonChiTiet_Clicked = new List<int>();
        List<int> idHoaDon_ChuaThanhToan = new List<int>();
        DateTime dateTime = DateTime.Now;
        int idSanPham_Clicked;
        int idHoaDon_Clicked;

        private void LoadGridHD(string? txtSearch, string? SearchType) // hóa đơn 
        {
            int stt = 1;
            dgv_HoaDon.ColumnCount = 9;
            dgv_HoaDon.Columns[0].Name = "STT";
            dgv_HoaDon.Columns[1].Name = "Mã hoá đơn";
            dgv_HoaDon.Columns[2].Name = "Tên ưu đãi";
            dgv_HoaDon.Columns[3].Name = "Ngày tạo";
            dgv_HoaDon.Columns[4].Name = "Người tạo";
            dgv_HoaDon.Columns[5].Name = "Tên Khách hàng";
            dgv_HoaDon.Columns[6].Name = "Hình thức thanh toán";
            dgv_HoaDon.Columns[7].Name = "Tổng tiền";
            dgv_HoaDon.Columns[8].Name = "Trạng thái";

            dgv_HoaDon.Rows.Clear();
            _lstHoaDon = _Ser_HoaDon.GetAll("false", "Trạng thái hóa đơn");

            foreach (var x in _lstHoaDon)
            {


                dgv_HoaDon.Rows.Add(stt++,
                                    x.Hoadon.Mahoadon,
                                    x.tenUuDai,
                                    x.Hoadon.Ngaytao,
                                    x.tenTaiKhoan,
                                    x.tenKhachHang,
                                    x.tenHinhThucThanhToan,
                                    x.Hoadon.Tongtien == null ? "N/A" : x.Hoadon.Tongtien.ToString(),
                                    x.Hoadon.Trangthai == true ? "Đã thanh toán" : "Chưa thanh toán");
            }
            dgv_HoaDon.Columns[0].Width = 30;
        }
        private void btn_ThemHoaDon_Click(object sender, EventArgs e)
        {
            try
            {

                var confirmResult = MessageBox.Show("Xác nhận THÊM hóa đơn ", "Xác nhận", MessageBoxButtons.OKCancel);

                if (confirmResult == DialogResult.OK)
                {
                    var result = _Ser_HoaDon.Them(new Hoadon()
                    { // data đượ fake null
                        Mataikhoan = XacThucDangNhap.Instance.IdTaiKhoan,
                        Mauudai = 10,
                        Makhachhang = 16,
                        Mahinhthucthanhtoan = 16,
                        Ngaytao = dateTime,
                        Tongtien = null,
                        Ghichu = "",
                        Trangthai = false
                    });

                    if (result)
                    {
                        LoadGridHD(null, null);
                    }
                    else
                    {
                        MessageBox.Show("THÊM thất bại");
                    }
                }
                else
                {
                    MessageBox.Show("Hủy THÊM hóa đơn");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}");
            }
        }
        private void btn_XoaHoaDon_Click(object sender, EventArgs e)
        {
            try
            {
                if (idHoaDon_Clicked == null)
                {
                    MessageBox.Show("Không có hóa đơn để xóa!");
                    return;
                }

                var confirmResult = MessageBox.Show("Xác nhận XÓA hóa đơn?", "Xác nhận", MessageBoxButtons.OKCancel);

                if (confirmResult == DialogResult.OK)
                {
                    // Xóa tất cả các hóa đơn chi tiết liên quan đến hóa đơn này trước

                    foreach (var item in _lstHoadonChiTiet)
                    {
                        var itemDelete = _Ser_HoaDonChiTiet.GetByID(item.Hoadonchitiet.Mahoadonchitiet);
                        var ketQua = _Ser_HoaDonChiTiet.Xoa(item.Hoadonchitiet.Mahoadonchitiet);
                    }


                    var result = _Ser_HoaDon.Xoa(idHoaDon_Clicked);
                    if (result)
                    {
                        dgv_HoaDonChiTiet.Rows.Clear();
                        lb_TTHD.Text = "0";
                        lb_TongTienHang.Text = "0";
                        LamMoi_ThanhToan();
                        LoadGridHD(null, null);
                    }
                    else
                    {
                        MessageBox.Show("Xóa thất bại!");
                    }
                }
                else
                {
                    MessageBox.Show("Hủy XÓA hóa đơn");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Thông tin chi tiết: {ex}");
            }
        }

        public int TinhTongTien_HoaDon(DataGridView dataGridView)
        {
            int tongTien = 0;

            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                if (!row.IsNewRow)
                {
                    object cellValue = row.Cells["Tổng tiền"].Value;

                    if (cellValue != null && int.TryParse(cellValue.ToString(), out int giaTriCot))
                    {
                        tongTien += giaTriCot;
                    }
                }
            }
            return tongTien;
        }
        public void LoadGridGH(int? idHoaDOn, string? SearchType) // giỏ hàng của hóa đơn 
        {
            int stt = 1;
            dgv_HoaDonChiTiet.ColumnCount = 12;
            dgv_HoaDonChiTiet.Columns[0].Name = "STT";
            dgv_HoaDonChiTiet.Columns[1].Name = "Mã hóa đơn";
            dgv_HoaDonChiTiet.Columns[2].Name = "Tên";
            dgv_HoaDonChiTiet.Columns[3].Name = "Magiaychitiet";
            dgv_HoaDonChiTiet.Columns[4].Name = "Thương hiệu";
            dgv_HoaDonChiTiet.Columns[5].Name = "Kích cỡ";
            dgv_HoaDonChiTiet.Columns[6].Name = "Màu sắc";
            dgv_HoaDonChiTiet.Columns[7].Name = "chất liệu";
            dgv_HoaDonChiTiet.Columns[8].Name = "Kiểu dáng";
            dgv_HoaDonChiTiet.Columns[9].Name = "Số lượng mua";
            dgv_HoaDonChiTiet.Columns[10].Name = "Thành tiền";
            dgv_HoaDonChiTiet.Columns[11].Name = "ID Hóa đơn chi tiết";
            dgv_HoaDonChiTiet.Columns[11].Visible = false;

            dgv_HoaDonChiTiet.Rows.Clear();
            _lstHoadonChiTiet = _Ser_HoaDonChiTiet.GetAll(idHoaDOn.ToString(), SearchType);
            foreach (var e in _lstHoadonChiTiet)
            {
                dgv_HoaDonChiTiet.Rows.Add(stt++, e.Hoadonchitiet.Mahoadon, e.tenGiay,e.Hoadonchitiet.Magiaychitiet, e.tenThuongHieu, e.tenKichCo, e.tenMauSac, e.tenChatLieu, e.tenKieuDang, e.Hoadonchitiet.Soluongmua, e.Hoadonchitiet.Tongtien, e.Hoadonchitiet.Mahoadonchitiet);
            }
            DataGridViewCheckBoxColumn ChooseObj = new DataGridViewCheckBoxColumn();
            ChooseObj.HeaderText = "Chọn";
            ChooseObj.Name = "Chon";
            dgv_HoaDonChiTiet.Columns.Add(ChooseObj);

            dgv_HoaDonChiTiet.Columns[0].Width = 30;

        }
        public void LoadGridSP(string? txtSearch, string? Searchtype)
        {
            int stt = 1;
            dgv_sanPham.ColumnCount = 9;
            dgv_sanPham.Columns[0].Name = "STT";
            dgv_sanPham.Columns[1].Name = "Tên giày";
            dgv_sanPham.Columns[2].Name = "Thương hiệu";
            dgv_sanPham.Columns[3].Name = "Kích cỡ";
            dgv_sanPham.Columns[4].Name = "Màu sắc";
            dgv_sanPham.Columns[5].Name = "chất liệu";
            dgv_sanPham.Columns[6].Name = "Kiểu dáng";
            dgv_sanPham.Columns[7].Name = "Số lượng";
            dgv_sanPham.Columns[8].Name = "Giá";
            if (txtSearch == null && Searchtype == null)
            {
                _lstGiay_ChiTietGiay = _Ser_Giay_ChiTietGiay.GetAll("true", "Trạng thái Giày");
            }
            else
            {
                _lstGiay_ChiTietGiay = _Ser_Giay_ChiTietGiay.GetAll(txtSearch, Searchtype);

            }
            foreach (var item in _lstGiay_ChiTietGiay)
            {
                dgv_sanPham.Rows.Add(stt++, item.tenGiay, item.tenThuongHieu, item.tenKichCo, item.tenMauSac, item.tenChatLieu, item.tenKieuDang, item.soLuongCon, item.gia);
            }
        }


        private void dgvSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = e.RowIndex;
                if (index < 0 || index >= _lstGiay_ChiTietGiay.Count)
                {
                    return;
                }
                else
                {
                    var objCellClick = _lstGiay_ChiTietGiay[index];
                    idSanPham_Clicked = objCellClick.giaychitiet.Magiaychitiet;
                    SoLuongMua formSoluongMua = new SoLuongMua(); // chọn số lượng mua
                    formSoluongMua.ShowDialog();

                    if (formSoluongMua.soLuong > 0 && formSoluongMua.soLuong <= objCellClick.giaychitiet.Soluongton && lb_MaHoaDon.Text != "#")
                    {
                        var existingItem = _lstHoadonChiTiet.FirstOrDefault(a => a.Hoadonchitiet.Magiaychitiet == idSanPham_Clicked);
                        int currentQty = existingItem != null ? (existingItem.Hoadonchitiet.Soluongmua ?? 0) : 0;
                        int newQty = currentQty + formSoluongMua.soLuong;
                        UpdateHoaDonAndDisplayTotal();
                        if (newQty > objCellClick.giaychitiet.Soluongton)
                        {
                            MessageBox.Show("Số lượng trong giỏ hàng không được lớn hơn số lượng trong kho!");
                            return;
                        }

                        bool result;
                        if (existingItem != null)
                        {
                            result = _Ser_HoaDonChiTiet.Sua(existingItem.Hoadonchitiet.Mahoadonchitiet, new Hoadonchitiet()
                            {
                                Magiaychitiet = existingItem.Hoadonchitiet.Magiaychitiet,
                                Mahoadon = int.Parse(lb_MaHoaDon.Text),
                                Soluongmua = newQty,
                                Tongtien = objCellClick.giaychitiet.Gia * newQty,
                            });
                        }
                        else
                        {
                            result = _Ser_HoaDonChiTiet.Them(new Hoadonchitiet()
                            {
                                Magiaychitiet = idSanPham_Clicked,
                                Mahoadon = int.Parse(lb_MaHoaDon.Text),
                                Soluongmua = formSoluongMua.soLuong,
                                Tongtien = objCellClick.giaychitiet.Gia * formSoluongMua.soLuong,
                            });
                        }

                        if (result)
                        {
                            MessageBox.Show("Thêm thành công");
                            _lstHoadonChiTiet = _Ser_HoaDonChiTiet.GetAll(null, null);
                            UpdateHoaDonAndDisplayTotal();
                        }
                        else
                        {
                            MessageBox.Show("Thêm thất bại");
                        }
                    }
                    else
                    {
                        if (lb_MaHoaDon.Text == "#")
                        {
                            MessageBox.Show("Chưa chọn hóa đơn");
                            return;
                        }
                        if (formSoluongMua.soLuong <= 0)
                        {
                            MessageBox.Show("Vui lòng chọn số lượng hợp lệ");
                        }
                        MessageBox.Show("Không đủ số lượng!");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Thông tin chi tiết: {ex}");
            }
        }
        private int TinhTongTienHoaDonChiTiet(int maHoaDon)
        {
            return _lstHoadonChiTiet
                .Where(item => item.Hoadonchitiet.Mahoadon == maHoaDon)
                .Sum(item => item.Hoadonchitiet.Tongtien ?? 0);
        }



        private void dgv_HoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;

            if (index < 0 || index >= _lstHoaDon.Count)
            {
                return;
            }
            var objCellClick = _lstHoaDon[index];
            idHoaDon_Clicked = objCellClick.Hoadon.Mahoadon;
            try
            {

                var confirmResult = MessageBox.Show($"Chọn hóa đơn có mã : {objCellClick.Hoadon.Mahoadon}", "Xác nhận", MessageBoxButtons.OKCancel);

                if (confirmResult == DialogResult.OK)
                {
                    lb_MaHoaDon.Text = objCellClick.Hoadon.Mahoadon.ToString();
                    lb_maKH.Text = objCellClick.Hoadon.Makhachhang.ToString();
                    lb_TenKH.Text = objCellClick.tenKhachHang.ToString();
                    txt_DiemKH.Text = objCellClick.diemKhachHang.ToString();
                    LoadGridGH(objCellClick.Hoadon.Mahoadon, "Mã hóa đơn");
                    txt_TienNhan.Text = "";
                    lb_TraLai.Text = "0";
                    lb_TienThieu.Text = "0";
                    lb_TongTienHang.Text = TinhTongTienHoaDonChiTiet(int.Parse(lb_MaHoaDon.Text)).ToString("N0");
                    lb_TTHD.Text = TinhTongTienHoaDonChiTiet(int.Parse(lb_MaHoaDon.Text)).ToString("N0");
                    lb_TongTien.Text = TinhTongTienHoaDonChiTiet(int.Parse(lb_MaHoaDon.Text)).ToString("N0");
                }
                else
                {
                    MessageBox.Show("Đã hủy chọn");
                }
                lb_TongTienHang.Text = TinhTongTien_HoaDon(dgv_HoaDonChiTiet).ToString();
                lb_TongTien.Text = TinhTongTienHoaDonChiTiet(int.Parse(lb_MaHoaDon.Text)).ToString("N0");
            }
            catch (Exception ex)
            {

                Console.WriteLine($"Thông tin chi tiết: {ex.ToString()}");
            }
        }
        private void LoadHinhThucThanhToan()
        {
            _lstHinhThucThanhToan = _ser_HinhThucThanhToan.GetHinhthucTT(null);
            cbb_HinhThucThanhToan.DataSource = _lstHinhThucThanhToan.ToList();
            cbb_HinhThucThanhToan.DisplayMember = "TENHINHTHUC";
            cbb_HinhThucThanhToan.ValueMember = "MAHINHTHUCTHANHTOAN";
            cbb_HinhThucThanhToan.SelectedIndex = 3;

        }


        private void btn_TimKhachHang_Click(object sender, EventArgs e)
        {
            if (lb_MaHoaDon.Text == "#")
            {
                MessageBox.Show("Vui lòng chọn hóa đơn trước!");
                return;
            }
            TimKiemKhachHHang formTimKhachHang = new TimKiemKhachHHang();
            formTimKhachHang.ShowDialog();
            LoadKhachHang(formTimKhachHang.ChooseID);

            var objHoaDon_KhachHang = _Ser_HoaDon.GetByID(int.Parse(lb_MaHoaDon.Text));
            if (objHoaDon_KhachHang != null)
            {
                objHoaDon_KhachHang.Makhachhang = int.Parse(lb_maKH.Text);
                _Ser_HoaDon.Sua(int.Parse(lb_MaHoaDon.Text), objHoaDon_KhachHang);
            }
            UpdateTotal();
        }
        private void UpdateTotal()
        {
            var maHoaDon = int.Parse(lb_MaHoaDon.Text);
            var tongTien = TinhTongTienHoaDonChiTiet(maHoaDon);
            lb_TongTienHang.Text = tongTien.ToString("N0");
            UpdateTienSauDiem();
        }
        private void UpdateTienSauDiem()
        {
            var maHoaDon = int.Parse(lb_MaHoaDon.Text);
            var tongTien = TinhTongTienHoaDonChiTiet(maHoaDon);

            if (cb_SuDungDiem.Checked)
            {
                int loyaltyPoints = int.Parse(txt_DiemKH.Text);
                int discountAmount = loyaltyPoints * 100;
                tongTien -= discountAmount;

                if (tongTien < 0)
                {
                    tongTien = 0;
                }
            }
            lb_TongTien.Text = tongTien.ToString("N0");
            lb_TongTienHang.Text = tongTien.ToString("N0");
            lb_TTHD.Text = tongTien.ToString("N0");
        }

         public void LoadKhachHang(int? id)
        {
            var Obj = _Ser_KhachHang.GetAllKhachhang(null).FirstOrDefault(x => x.Makhachhang == id);
            if (Obj == null)
            {
                return;
            }
            lb_maKH.Text = Obj.Makhachhang == null ? "N/A" : Obj.Makhachhang.ToString();
            lb_TenKH.Text = Obj.Tenkhachhang == null ? "N/A" : Obj.Tenkhachhang.ToString();
            txt_DiemKH.Text = Obj.Diemkhachhang == null ? "0 điểm" : Obj.Diemkhachhang.ToString() + " điểm";
        }

        private void btn_XoaSanPham_Click(object sender, EventArgs e)
        {
            if (idHoaDonChiTiet_Clicked.Count == 0)
            {
                MessageBox.Show("Chọn vào ô cuối cùng bên phải");
            }
            else
            {
                try
                {
                    var confirmResult = MessageBox.Show("Xác nhận xóa", "Xác nhận", MessageBoxButtons.OKCancel);

                    if (confirmResult == DialogResult.OK)
                    {
                        foreach (var item in idHoaDonChiTiet_Clicked)
                        {
                            var objHoaDonDaCanXoa = _Ser_HoaDonChiTiet.GetByID(item);
                            var result = _Ser_HoaDonChiTiet.Xoa(item);
                            if (!result)
                            {
                                MessageBox.Show($"Xóa mục với ID {item} không thành công.");
                                return;
                            }
                        }
                        txt_HoaDonChiTiet.Text = "";
                        _lstHoadonChiTiet = _Ser_HoaDonChiTiet.GetAll(null, null);
                        var hoadon = _Ser_HoaDon.GetByID(int.Parse(lb_MaHoaDon.Text));
                        if (hoadon != null)
                        {
                            hoadon.Tongtien = TinhTongTienHoaDonChiTiet(hoadon.Mahoadon);
                            _Ser_HoaDon.Sua(hoadon.Mahoadon, hoadon);
                        }
                        LoadGridGH(int.Parse(lb_MaHoaDon.Text), "Mã hóa đơn");
                        LoadGridHD(null, null);
                        lb_TTHD.Text = TinhTongTienHoaDonChiTiet(int.Parse(lb_MaHoaDon.Text)).ToString("N0");
                        lb_TongTienHang.Text = TinhTongTienHoaDonChiTiet(int.Parse(lb_MaHoaDon.Text)).ToString("N0");
                    }
                    else
                    {
                        MessageBox.Show("Đã hủy 'xóa' hóa đơn");
                    }
                    idHoaDonChiTiet_Clicked.Clear();
                    lb_TongTienHang.Text = TinhTongTien_HoaDon(dgv_HoaDonChiTiet).ToString();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Thông tin chi tiết: {ex.ToString()}");
                }
            }
        }
        private void UpdateHoaDonAndDisplayTotal()
        {
            var hoadon = _Ser_HoaDon.GetByID(int.Parse(lb_MaHoaDon.Text));
            if (hoadon != null)
            {
                hoadon.Tongtien = TinhTongTienHoaDonChiTiet(hoadon.Mahoadon);
                _Ser_HoaDon.Sua(hoadon.Mahoadon, hoadon);
                LoadGridHD(null, null);
            }

            var objGiayDaTonTai = _ser_GiayChiTiet.GetByID(idSanPham_Clicked);
            _ser_GiayChiTiet.Sua(idSanPham_Clicked, objGiayDaTonTai);

            LoadGridHD(null, null);
            LoadGridGH(int.Parse(lb_MaHoaDon.Text), "Mã hóa đơn");

            lb_TongTienHang.Text = TinhTongTienHoaDonChiTiet(int.Parse(lb_MaHoaDon.Text)).ToString("N0");
            lb_TTHD.Text = TinhTongTienHoaDonChiTiet(int.Parse(lb_MaHoaDon.Text)).ToString("N0");
        }
        private void txt_TienNhan_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_TienNhan.Text))
            {
                txt_GhiChu.Text = "";
                lb_TienThieu.Text = "";
                lb_TraLai.Text = "";
                return;
            }

            if (decimal.TryParse(txt_TienNhan.Text.Replace(",", ""), out decimal soTienNhan))
            {
                decimal tongTienHoaDon = TinhTongTienHoaDonChiTiet(int.Parse(lb_MaHoaDon.Text));

                // Tính tiền thiếu và tiền trả lại
                decimal tienThieu = tongTienHoaDon - soTienNhan;
                decimal traLai = soTienNhan - tongTienHoaDon;

                // Cập nhật các label
                lb_TienThieu.Text = tienThieu >= 0 ? tienThieu.ToString("N0") : "0";
                lb_TraLai.Text = traLai >= 0 ? traLai.ToString("N0") : "0";

                // Cập nhật ghi chú
                txt_GhiChu.Text = $"Tổng tiền hóa đơn: {tongTienHoaDon:N0}, " +
                                  $"Khách đưa: {soTienNhan:N0}, " +
                                  $"Trả lại khách: {traLai:N0}";
            }

        }


        private void txt_DiemKH_TextChanged(object sender, EventArgs e)
        {
            if (txt_DiemKH.Text == "" || txt_DiemKH.Text == null)
            {
                return;
            }
            else
            {
                cb_SuDungDiem.Enabled = true;
            }
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {

        }

        private void dgv_HoaDonChiTiet_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgv_HoaDonChiTiet.Columns["Chon"].Index && e.RowIndex >= 0)
            {
                DataGridViewCheckBoxCell checkBoxCell = (DataGridViewCheckBoxCell)dgv_HoaDonChiTiet.Rows[e.RowIndex].Cells["Chon"];

                checkBoxCell.Value = !Convert.ToBoolean(checkBoxCell.Value);

                int idHoaDonChiTiet = Convert.ToInt32(dgv_HoaDonChiTiet.Rows[e.RowIndex].Cells["ID Hóa đơn chi tiết"].Value);

                if (Convert.ToBoolean(checkBoxCell.Value))
                {
                    idHoaDonChiTiet_Clicked.Add(idHoaDonChiTiet);
                }
                else
                {
                    idHoaDonChiTiet_Clicked.Remove(idHoaDonChiTiet);
                }

                StringBuilder sb = new StringBuilder();
                foreach (int id in idHoaDonChiTiet_Clicked)
                {
                    sb.Append(id.ToString());
                    sb.Append(", ");
                }
                string danhSachIdText = sb.ToString().TrimEnd(',', ' ');
                txt_HoaDonChiTiet.Text = danhSachIdText;
            }
        }

        private void Frm_US_BanHang_Load_1(object sender, EventArgs e)
        {
            LoadGridHD(null, null);
            LoadGridSP(null, null);
            txt_HoaDonChiTiet.BorderStyle = BorderStyle.FixedSingle;
            LoadHinhThucThanhToan();
        }


        private void cbb_HinhThucThanhToan_SelectedIndexChanged(object sender, EventArgs e)
        {
            //int idHD = int.TryParse(lb_MaHoaDon.Text, out int idH) ? idH : 0;   
            //var hoaDon = _Ser_HoaDon.GetByID(idHD);
            //if (hoaDon != null)
            //{
            //    if (cbb_HinhThucThanhToan.SelectedValue != null)
            //    {
            //        hoaDon.Mahinhthucthanhtoan = (int)cbb_HinhThucThanhToan.SelectedValue;
            //        var result = _Ser_HoaDon.Sua(idHoaDon_Clicked, hoaDon);
            //        if (result)
            //        {
            //            LoadGridHD(null, null);
            //        }
            //        else
            //        {
            //            MessageBox.Show("Cập nhật hình thức thanh toán thất bại.");
            //        }
            //    }
            //    else
            //    {
            //        MessageBox.Show("Vui lòng chọn hình thức thanh toán hợp lệ.");
            //    }
            //}
        }

        private void btn_ThanhToan_Click(object sender, EventArgs e)
        {
            if (cbb_HinhThucThanhToan.SelectedIndex == 3)
            {
                MessageBox.Show("Bạn chưa chọn hình thức thanh toán");
                return;
            }
            else if (string.IsNullOrWhiteSpace(txt_TienNhan.Text))
            {
                MessageBox.Show("Bạn chưa nhận tiền");
                return; // Ngừng thực hiện tiếp khi chưa nhập số tiền nhận
            }
            if (!int.TryParse(lb_TienThieu.Text.Replace(",", "").Replace(".", "").Replace(" ", "").Trim(), out int tienThieu))
            {
                MessageBox.Show("Giá trị tiền thiếu không hợp lệ");
                return;
            }
            else if (tienThieu > 0)
            {
                MessageBox.Show("Khách hàng chưa đưa đủ tiền");
                return;
            }
            else if (lb_MaHoaDon.Text == "#")
            {
                MessageBox.Show("Bạn chưa chọn hóa đơn");
                return;
            }
            else if (lb_TongTienHang.Text == "#")
            {
                MessageBox.Show("Vui lòng kiểm tra lại giỏ hàng");
                return;
            }
            else
            {
                try
                {
                    var confirmResult = MessageBox.Show("Xác nhận thanh toán", "Xác nhận", MessageBoxButtons.OKCancel);
                    if (confirmResult == DialogResult.OK)
                    {
                        if (!int.TryParse(lb_MaHoaDon.Text, out int maHoaDon))
                        {
                            MessageBox.Show("Mã hóa đơn không hợp lệ");
                            return;
                        }

                        var hoaDon_ThanhToan = _Ser_HoaDon.GetByID(maHoaDon);
                        if (hoaDon_ThanhToan == null)
                        {
                            MessageBox.Show("Không tìm thấy hóa đơn");
                            return;
                        }
                       

                        var result = _Ser_HoaDon.Sua(maHoaDon, hoaDon_ThanhToan);
                        if (result)
                        {
                            hoaDon_ThanhToan.Makhachhang = int.Parse(lb_maKH.Text);
                            hoaDon_ThanhToan.Trangthai = true;
                            hoaDon_ThanhToan.Mahinhthucthanhtoan = (int)cbb_HinhThucThanhToan.SelectedValue;

                            if (!int.TryParse(lb_TongTienHang.Text.Replace(",", "").Replace(".", "").Replace(" ", "").Trim(), out int tongTien))
                            {
                                MessageBox.Show("Tổng tiền không hợp lệ");
                                return;
                            }
                            hoaDon_ThanhToan.Tongtien = tongTien;
                            hoaDon_ThanhToan.Ghichu = txt_GhiChu.Text;

                            MessageBox.Show("Thanh toán thành công");
                            LoadGridHD(null, null);
                            dgv_HoaDonChiTiet.Rows.Clear();
                            LamMoi_ThanhToan();
                        }
                        else
                        {
                            MessageBox.Show("'Thanh toán' thất bại.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Đã hủy thanh toán");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Có lỗi xảy ra: {ex.Message}");
                }
            }
        }


        private void LamMoi_ThanhToan()
        {
            //txtMaKhachhang.Text = "1";
            lb_TenKH.Text = "#";
            lb_MaHoaDon.Text = "#";
            lb_MaHoaDon.Text = "#";
            lb_maKH.Text = "";
            txt_DiemKH.Text = "";
            cbb_HinhThucThanhToan.SelectedValue = 4;
            cb_SuDungDiem.Checked = false;
            lb_TienThieu.Text = "";
            lb_TongTien.Text = "#";
            lb_TongTienHang.Text = "#";
            txt_TienNhan.Text = "#";
            txt_GhiChu.Text = "#";
        }
        private int originalTongTienHang = 0;
        private int originalTongTien = 0;
        private int originalTTGH = 0;
        private int originalTraLai = 0;
        private void cb_SuDungDiem_CheckedChanged(object sender, EventArgs e)
        {

            try
            {
                int loyaltyPoints = int.TryParse(txt_DiemKH.Text, out int points) ? points : 0;
                int pointsValue = 100; // Mỗi điểm tương ứng với 100 đồng
                int totalPointsValue = loyaltyPoints * pointsValue;

                // Lấy tổng tiền hiện tại từ lb_TongTienHang và loại bỏ các ký tự không mong muốn
                string lbTongTienHangText = lb_TongTienHang.Text.Replace(",", "").Replace(".", "").Replace(" ", "").Trim();
                string lbTienThieu = lb_TienThieu.Text.Replace(",", "").Replace(".", "").Replace(" ", "").Trim();

                // Kiểm tra xem lbTongTienHangText có phải là một số hợp lệ hay không
                bool isNumber = int.TryParse(lbTongTienHangText, out int currentTotalAmount);
                bool isNumber2 = int.TryParse(lbTienThieu, out int currentTotalAmount2);

                if (!isNumber && !isNumber2)
                {
                    MessageBox.Show($"Giá trị lb_TongTienHang không hợp lệ: {lb_TongTienHang.Text}");
                    return;
                }

                if (cb_SuDungDiem.Checked)
                {
                    // Lưu giá trị tổng tiền ban đầu khi checkbox được chọn lần đầu tiên
                    if (originalTongTienHang == 0)
                    {
                        originalTongTienHang = currentTotalAmount;
                        originalTongTien = int.TryParse(lb_TongTien.Text.Replace(",", ""), out int tongTien) ? tongTien : 0;
                        originalTTGH = int.TryParse(lb_TTHD.Text.Replace(",", ""), out int TTHD) ? TTHD : 0;
                        originalTraLai = int.TryParse(lb_TienThieu.Text.Replace(",", ""), out int tienTraLai) ? tienTraLai : 0;
                    }

                    int amountAfterDiscount = originalTongTienHang - totalPointsValue;
                    if (amountAfterDiscount < 0)
                    {
                        MessageBox.Show("Điểm đổi vượt quá tổng tiền.");
                        amountAfterDiscount = 0;
                    }

                    lb_TongTien.Text = amountAfterDiscount.ToString("N0");

                    int soTienNhan = int.TryParse(txt_TienNhan.Text.Replace(",", ""), out int tienNhan) ? tienNhan : 0;
                    int traLai = tienNhan - amountAfterDiscount;
                    lb_TienThieu.Text = traLai >= 0 ? traLai.ToString("N0") : "0";
                }
                else
                {
                    lb_TongTien.Text = lbTongTienHangText;
                    //lb_TienThieu.Text = lbTienThieu;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra: {ex.Message}");
            }
        }
    }
}
