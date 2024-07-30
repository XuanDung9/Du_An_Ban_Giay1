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
        GiayChiTietService _Ser_ChiTietGiay = new GiayChiTietService();
        List<HoaDon_Model> _lstHoaDon = new List<HoaDon_Model>();
        List<GiayChiTietDTO> _lst_GiayDTO = new List<GiayChiTietDTO>();
        List<Giaychitiet> _lstGiayChiTiet = new List<Giaychitiet>();
        List<Hinhthucthanhtoan> _lstHinhThucThanhToan = new List<Hinhthucthanhtoan>();


        List<int> idHoaDonChiTiet_Clicked = new List<int>();
        List<int> idHoaDon_ChuaThanhToan = new List<int>();
        DateTime dateTime = DateTime.Now;
        int idSanPham_Clicked;
        int idHoaDon_Clicked;
        private void dgv_HoaDon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

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
                dgv_HoaDon.Rows.Add(stt++, x.Hoadon.Mahoadon, x.tenUuDai, x.Hoadon.Ngaytao, x.tenTaiKhoan, x.tenKhachHang, x.tenHinhThucThanhToan, x.Hoadon.Tongtien == null ? "N/A" : x.Hoadon.Tongtien, x.Hoadon.Trangthai == true ? "Đã thanh toán" : "Chưa thanht toán");
            }

            dgv_HoaDon.Columns[0].Width = 30;
        }
        private void btn_ThemHoaDon_Click(object sender, EventArgs e)
        {
            try
            {
                var objUuDai = _ser_UuDai.GetUudai_InTime(); // nếu trong thời gian này có mã ưu đãi thì tự động thêm vào hóa đơn 
                var confirmResult = MessageBox.Show("Xác nhận 'thêm' hóa đơn không?", "Xác nhận", MessageBoxButtons.OKCancel);

                if (confirmResult == DialogResult.OK)
                {
                    var result = _Ser_HoaDon.Them(new Hoadon()
                    { // data đượ fake null
                        Mataikhoan = XacThucDangNhap.Instance.IdTaiKhoan,
                        Mauudai = 10,
                        Makhachhang = 16,
                        Mahinhthucthanhtoan = 8,
                        Ngaytao = dateTime,
                        Tongtien = null,
                        Ghichu = "",
                        Trangthai = false
                    });

                    if (result)
                    {
                        MessageBox.Show("Đã 'thêm' thành công 1 hóa đơn mới");
                        LoadGridHD(null, null);
                    }
                    else
                    {
                        MessageBox.Show("'Thêm' thất bại");
                    }
                }
                else
                {
                    MessageBox.Show("Đã hủy 'thêm' hóa đơn");
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
                }
                var confirmResult = MessageBox.Show("Xác nhận XÓA hóa đơn ?", "Xác nhận", MessageBoxButtons.OKCancel);

                if (confirmResult == DialogResult.OK)
                {

                    //foreach (var item in _lstHoadonChiTiet) // khi xóa hóa đơn thì số lượng sp có trong hóa đơn sẽ hoàn trả lại vào danh sách sản phẩm
                    //{
                    //    var objHoaDonDaCanXoa = _Ser_HoaDonChiTiet.GetByID(item.Hoadonchitiet.Mahoadonchitiet);
                    //    var objGiayCanSua = _ser_GiayChiTiet.GetByID(objHoaDonDaCanXoa.Magiaychitiet); // chọn giày trong cái hóa đơn cần xóa
                    //    objGiayCanSua.Soluongton = objGiayCanSua.Soluongton + objHoaDonDaCanXoa.Soluongmua; // số lượng mua trong hóa đơn chi tiết
                    //    _ser_GiayChiTiet.Sua(objHoaDonDaCanXoa.Magiaychitiet, objGiayCanSua);
                    //    var ketqua = _Ser_HoaDonChiTiet.Xoa(item.Hoadonchitiet.Mahoadonchitiet);
                    //}
                    var result = _Ser_HoaDon.Xoa(idHoaDon_Clicked);
                    if (result)
                    {
                        MessageBox.Show("Xóa thành công!");
                        LoadGridHD(null, null);
                        LoadGridSP(null, null);
                        dgv_HoaDonChiTiet.Rows.Clear();
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
                Console.WriteLine($"Thông tin chi tiết: {ex.ToString()}");
            }

        }
        private void LoadTien_ThanhToan()
        {
            var objUuDai = _ser_UuDai.GetUudai_InTime();
            string searchName = lb_TenKH.Text == "#" ? "1" : lb_TenKH.Text;
            var Obj = _Ser_KhachHang.GetAllKhachhang(null).Find(x => x.Tenkhachhang == searchName);
            lb_TongTienHang.Text = TinhTongTien_HoaDon(dgv_HoaDonChiTiet).ToString();
            lb_TongTien.Text = (TinhTongTien_HoaDon(dgv_HoaDonChiTiet)
                - (int.Parse(lb_TongTienHang.Text)
                * ((objUuDai.Soluong <= 0 ? 0 : double.Parse("0,"))))
                - ((cb_SuDungDiem.Checked ? (Obj.Diemkhachhang == null || txt_DiemKH.Text == "" ? 0 : Obj.Diemkhachhang) : 0)
                * 1000)).ToString();

        }
        private int TinhTongTien_HoaDon(DataGridView dataGridView)
        {
            int tongTien = 0;

            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                if (!row.IsNewRow)
                {
                    object cellValue = row.Cells["Thành tiền"].Value;

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
            dgv_HoaDonChiTiet.ColumnCount = 11;
            dgv_HoaDonChiTiet.Columns[0].Name = "STT";
            dgv_HoaDonChiTiet.Columns[1].Name = "Mã hóa đơn";
            dgv_HoaDonChiTiet.Columns[2].Name = "Tên";
            dgv_HoaDonChiTiet.Columns[3].Name = "Thương hiệu";
            dgv_HoaDonChiTiet.Columns[4].Name = "Kích cỡ";
            dgv_HoaDonChiTiet.Columns[5].Name = "Màu sắc";
            dgv_HoaDonChiTiet.Columns[6].Name = "chất liệu";
            dgv_HoaDonChiTiet.Columns[7].Name = "Kiểu dáng";
            dgv_HoaDonChiTiet.Columns[8].Name = "Số lượng mua";
            dgv_HoaDonChiTiet.Columns[9].Name = "Thành tiền";
            dgv_HoaDonChiTiet.Columns[10].Name = "ID Hóa đơn chi tiết";
            dgv_HoaDonChiTiet.Columns[11].Visible = false;

            dgv_HoaDonChiTiet.Rows.Clear();
            _lstHoadonChiTiet = _Ser_HoaDonChiTiet.GetAll(idHoaDOn.ToString(), SearchType);
            foreach (var e in _lstHoadonChiTiet)
            {
                dgv_HoaDonChiTiet.Rows.Add(stt++, e.Hoadonchitiet.Mahoadon, e.tenGiay, e.tenThuongHieu, e.tenKichCo, e.tenMauSac, e.tenChatLieu, e.tenKieuDang, e.Hoadonchitiet.Soluongmua, e.Hoadonchitiet.Tongtien, e.Hoadonchitiet.Mahoadonchitiet);
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
                var objCellClick = _lstGiay_ChiTietGiay[index]; // click vào item trong bảng giày
                idSanPham_Clicked = objCellClick.giaychitiet.Magiaychitiet;
                SoLuongMua formSoluongMua = new SoLuongMua(); // chọn số lượng mua
                formSoluongMua.ShowDialog();

                if (formSoluongMua.soLuong > 0 && formSoluongMua.soLuong < objCellClick.giaychitiet.Soluongton && lb_MaHoaDon.Text != "#")
                {
                    if (_lstHoadonChiTiet.Any(a => a.Hoadonchitiet.Magiaychitiet == idSanPham_Clicked))
                    {
                        var Obj = _lstHoadonChiTiet.FirstOrDefault(a => a.Hoadonchitiet.Magiaychitiet == idSanPham_Clicked);

                        var Sua = _Ser_HoaDonChiTiet.Sua(Obj.Hoadonchitiet.Mahoadonchitiet, new Hoadonchitiet()
                        {
                            Magiaychitiet = Obj.Hoadonchitiet.Magiaychitiet,
                            Mahoadon = int.Parse(lb_MaHoaDon.Text),
                            Soluongmua = Obj.Hoadonchitiet.Soluongmua + formSoluongMua.soLuong,
                            Tongtien = objCellClick.giaychitiet.Gia * (Obj.Hoadonchitiet.Soluongmua + formSoluongMua.soLuong),
                        });

                        if (Sua)
                        {
                            MessageBox.Show("Đã 'thêm' thành công 1 giày mới vào hóa đơn.");
                            var objGiayDaTonTai = _ser_GiayChiTiet.GetByID(idSanPham_Clicked);
                            objGiayDaTonTai.Soluongton = objGiayDaTonTai.Soluongton - formSoluongMua.soLuong;
                            objGiayDaTonTai.Ngaysua = dateTime;
                            var a = _ser_GiayChiTiet.Sua(idSanPham_Clicked, objGiayDaTonTai);
                            LoadGridGH(int.Parse(lb_MaHoaDon.Text), "Mã hóa đơn");
                            LoadGridSP(null, null);
                        }
                        else
                        {
                            MessageBox.Show("'Thêm' thất bại");
                        }
                    }
                    else
                    {
                        var result = _Ser_HoaDonChiTiet.Them(new Hoadonchitiet()
                        {
                            Magiaychitiet = idSanPham_Clicked,
                            Mahoadon = int.Parse(lb_MaHoaDon.Text),
                            Soluongmua = formSoluongMua.soLuong,
                            Tongtien = objCellClick.giaychitiet.Gia * formSoluongMua.soLuong,
                        });

                        if (result)
                        {
                            MessageBox.Show("Đã 'thêm' thành công 1 giày mới vào hóa đơn");
                            var objGiayChuaTonTai = _ser_GiayChiTiet.GetByID(idSanPham_Clicked);
                            objGiayChuaTonTai.Soluongton = objGiayChuaTonTai.Soluongton - formSoluongMua.soLuong;
                            objGiayChuaTonTai.Ngaysua = dateTime;
                            var a = _ser_GiayChiTiet.Sua(idSanPham_Clicked, objGiayChuaTonTai);
                            LoadGridGH(int.Parse(lb_MaHoaDon.Text), "Mã hóa đơn");
                        }
                        else
                        {
                            MessageBox.Show("'Thêm' thất bại");
                        }
                    }
                    var objHoaDon_TongTien = _Ser_HoaDon.GetByID(int.Parse(lb_MaHoaDon.Text));
                    objHoaDon_TongTien.Tongtien = TinhTongTien_HoaDon(dgv_HoaDonChiTiet);
                    _Ser_HoaDon.Sua(int.Parse(lb_MaHoaDon.Text), objHoaDon_TongTien);
                    LoadGridHD(null, null);

                }
                else
                {
                    if (lb_MaHoaDon.Text == "N/A")
                    {
                        MessageBox.Show("Chưa chọn hóa đơn!");
                        return;
                    }
                    if (formSoluongMua.soLuong == 0)
                    {
                        MessageBox.Show("Vui lòng chọn số lượng hợp lệ");
                    }
                    MessageBox.Show($"Không đủ số lượng! Chỉ còn {objCellClick.giaychitiet.Soluongton} đôi.");
                }
                LoadGridSP(null, null);
                lb_TongTienHang.Text = TinhTongTien_HoaDon(dgv_HoaDonChiTiet).ToString();
                LoadTien_ThanhToan();
            }
            catch (Exception ex)
            {

                Console.WriteLine($"Thông tin chi tiết: {ex.ToString()}");
            }
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

                var confirmResult = MessageBox.Show($"Chọn hóa đơn của khách hàng{objCellClick.Hoadon.Makhachhang}", "Xác nhận", MessageBoxButtons.OKCancel);

                if (confirmResult == DialogResult.OK)
                {
                    lb_MaHoaDon.Text = objCellClick.Hoadon.Mahoadon.ToString();
                    lb_maKH.Text = objCellClick.Hoadon.Makhachhang.ToString();
                    lb_TenKH.Text = objCellClick.tenKhachHang.ToString();
                    txt_DiemKH.Text = objCellClick.diemKhachHang.ToString();
                    LoadGridGH(objCellClick.Hoadon.Mahoadon, "Mã hóa đơn");
                }
                lb_TongTienHang.Text = TinhTongTien_HoaDon(dgv_HoaDonChiTiet).ToString();
                LoadTien_ThanhToan();
            }
            catch (Exception ex)
            {

                Console.WriteLine($"Thông tin chi tiết: {ex.ToString()}");
            }
        }
    }
}
