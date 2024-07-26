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
    public partial class Frm_US_SanPham : UserControl
    {
        public Frm_US_SanPham()
        {
            InitializeComponent();
        }
        DBContext _context = new DBContext();
        GIAYDTO _ser_GiayDTO = new GIAYDTO();
        GiayChiTietService _Ser_ChiTietGiay = new GiayChiTietService();
        ChatLieuService _Ser_ChatLieu = new ChatLieuService();
        GiayService _Ser_Giay = new GiayService();
        KichCoService _Ser_KichCo = new KichCoService();
        KieuDangService _Ser_KieuDang = new KieuDangService();
        MauSacService _Ser_MauSac = new MauSacService();
        ThuongHieuService _Ser_ThuongHieu = new ThuongHieuService();
        List<GiayChiTietDTO> _lst_GiayDTO = new List<GiayChiTietDTO>();
        List<Giay> _lstGiay = new List<Giay>();
        List<Chatlieu> _lstChatLieu = new List<Chatlieu>();
        List<Kichco> _LstKichCo = new List<Kichco>();
        List<Kieudang> _lstKieuDang = new List<Kieudang>();
        List<Mausac> _lstMauSac = new List<Mausac>();
        List<Thuonghieu> _lstThuongHieu = new List<Thuonghieu>();
        List<Giaychitiet> _lstGiayChiTiet = new List<Giaychitiet>();
        DangNhap_form formDangNhap = new DangNhap_form();
        int idClicked;
        bool checkedTexbox;
        private void ptbGiay_Click(object sender, EventArgs e)
        {
            Giay_form frm_Giay = new Giay_form();
            frm_Giay.ShowDialog();
            LoadCBB_Giay(null);
        }

        private void ptbChatLieu_Click(object sender, EventArgs e)
        {
            using (ChatLieu_form frm_chatLieu = new ChatLieu_form())
            {
                frm_chatLieu.FormClosed += (s, args) => LoadCBB_ChatLieu(null);
                frm_chatLieu.ShowDialog();
            }
        }

        private void dgvSP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ptbKichCo_Click(object sender, EventArgs e)
        {
            KichCo_form frm_kichCo = new KichCo_form();
            frm_kichCo.ShowDialog();
            LoadCBB_KichCo(null);
        }

        private void ptbThemThuongHieu_Click(object sender, EventArgs e)
        {
            ThuongHieu_form frm_thuongHieu = new ThuongHieu_form();
            frm_thuongHieu.ShowDialog();
            LoadCBB_ThuongHieu(null);
        }

        private void ptbKieuDang_Click(object sender, EventArgs e)
        {
            KieuDang_form kieuDang_Form = new KieuDang_form();
            kieuDang_Form.ShowDialog();
            LoadCBB_KieuDang(null);
        }

        private void ptbMauSac_Click(object sender, EventArgs e)
        {
            MauSac_form mauSac_frm = new MauSac_form();
            mauSac_frm.ShowDialog();
            LoadCBB_MauSac(null);
        }
        public void ClearTextBox()
        {
            txtGia.Text = "";
            txtMoTa.Text = "";
            txtSoLuong.Text = "";
            txtTimKiem.Text = "";
            cbbTenGiay.Enabled = true;
            cbbTenThuongHieu.Enabled = true;
        }
        private void CheckTextbox()
        {
            if (!double.TryParse(txtGia.Text, out double result))
            {
                MessageBox.Show("Vui lòng nhập lại giá sản phẩm ");
                checkedTexbox = false;
            }
            else if (txtMoTa.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mô tả không quá 200 từ"); checkedTexbox = false;

            }
            else if (XacThucDangNhap.Instance.IdTaiKhoan == 0)
            {
                MessageBox.Show("Lỗi không nhận dạng được tài khoản đang sử dụng"); checkedTexbox = false;

            }
            else if (!int.TryParse(txtSoLuong.Text, out int result1))
            {
                MessageBox.Show("Vui lòng nhập lại số lượng"); checkedTexbox = false;

            }
            else
            {

                checkedTexbox = true;
            }

        }
        private void Frm_US_SanPham_Load(object sender, EventArgs e)
        {
            LoadCBB_TimKiem();
            LoadCBB_Giay(idClicked);
            LoadCBB_ThuongHieu(idClicked);
            LoadCBB_KieuDang(idClicked);
            LoadCBB_ChatLieu(idClicked);
            LoadCBB_MauSac(idClicked);
            LoadCBB_KichCo(idClicked);
            LoadDataGridView(null, null);
            ClearTextBox();
        }
        public void LoadCBB_TimKiem()
        {
            cbbTimKiem.Items.Clear();
            cbbTimKiem.Items.Add(SearchType.All);
            cbbTimKiem.Items.Add(SearchType.maGiay);
            cbbTimKiem.Items.Add(SearchType.maChatLieu);
            cbbTimKiem.Items.Add(SearchType.maMauSac);
            cbbTimKiem.Items.Add(SearchType.maKichCo);
            cbbTimKiem.Items.Add(SearchType.maThuongHieu);
            cbbTimKiem.Items.Add(SearchType.maKieuDang);
            cbbTimKiem.Items.Add(SearchType.moTa_GiayChiTiet);
            cbbTimKiem.Items.Add(SearchType.trangThai_GiayChiTiet);
            cbbTimKiem.SelectedIndex = 0;
        }
        public void LoadCBB_Giay(int? idClicked)
        {
            _lstGiay = _Ser_Giay.GetAll("true", "Trạng thái Giày");
            cbbTenGiay.DataSource = _lstGiay.ToList();
            cbbTenGiay.DisplayMember = "TENGIAY";
            cbbTenGiay.ValueMember = "MAGIAY";
        }
        public void LoadCBB_ThuongHieu(int? idClicked)
        {
            _lstThuongHieu = _Ser_ThuongHieu.GetAll("true", "Trạng thái Thương hiệu");
            cbbTenThuongHieu.DataSource = _lstThuongHieu.ToList();
            cbbTenThuongHieu.DisplayMember = "TENTHUONGHIEU";
            cbbTenThuongHieu.ValueMember = "MATHUONGHIEU";
        }
        public void LoadCBB_KieuDang(int? idClicked)
        {
            _lstKieuDang = _Ser_KieuDang.GetAll("true", "Trạng thái Kiểu dáng");
            cbbTenKieuDang.DataSource = _lstKieuDang.ToList();
            cbbTenKieuDang.DisplayMember = "TENKIEUDANG";
            cbbTenKieuDang.ValueMember = "MAKIEUDANG";
        }
        public void LoadCBB_ChatLieu(int? idClicked)
        {
            _lstChatLieu = _Ser_ChatLieu.GetAll("true", "Trạng thái Chất liệu");
            cbbTenChatLieu.DataSource = _lstChatLieu.ToList();
            cbbTenChatLieu.DisplayMember = "TENCHATLIEU";
            cbbTenChatLieu.ValueMember = "MACHATLIEU";
        }
        public void LoadCBB_MauSac(int? idClicked)
        {
            _lstMauSac = _Ser_MauSac.GetAll("true", "Trạng thái Màu sắc");
            cbbTenMauSac.DataSource = _lstMauSac.ToList();
            cbbTenMauSac.DisplayMember = "TENMAUSAC";
            cbbTenMauSac.ValueMember = "MAMAUSAC";

        }
        public void LoadCBB_KichCo(int? idClicked)
        {
            _LstKichCo = _Ser_KichCo.GetAll("true", "Trạng thái Kích cỡ");
            cbbTenKichCo.DataSource = _LstKichCo.ToList();
            cbbTenKichCo.DisplayMember = "TENKICHCO";
            cbbTenKichCo.ValueMember = "MAKICHCO";
        }
        public void LoadDataGridView(string? txtTimKiem, string? SearchType)
        {
            dgvSP.Rows.Clear();
            dgvSP.ColumnCount = 19;
            dgvSP.Columns[0].Name = "Mã giày chi tiết";
            dgvSP.Columns[1].Name = "Mã giày";
            dgvSP.Columns[2].Name = "Tên giày ";
            dgvSP.Columns[3].Name = "Chất liệu";
            dgvSP.Columns[4].Name = "Màu sắc";
            dgvSP.Columns[5].Name = "Kích cỡ";
            dgvSP.Columns[6].Name = "Thương hiệu";
            dgvSP.Columns[7].Name = "Kiểu dáng";
            dgvSP.Columns[8].Name = "Ngày tạo";
            dgvSP.Columns[9].Name = "Ngày sửa";
            dgvSP.Columns[10].Name = "Giá";
            dgvSP.Columns[11].Name = "Mô tả";
            dgvSP.Columns[12].Name = "Số lượng trong kho";
            dgvSP.Columns[13].Name = " Mã chất liệu";
            dgvSP.Columns[14].Name = "Mã màu sắc";
            dgvSP.Columns[15].Name = "Mã kích cỡ";
            dgvSP.Columns[16].Name = "mã thương hiệu";
            dgvSP.Columns[17].Name = "Mã kiểu dáng";
            dgvSP.Columns[18].Name = "Trạng thái";

            var giayChiTietList = from giaychitiet in _context.Giaychitiets
                                  join giay in _context.Giays on giaychitiet.Magiay equals giay.Magiay
                                  join chatlieu in _context.Chatlieus on giaychitiet.Machatlieu equals chatlieu.Machatlieu
                                  join mausac in _context.Mausacs on giaychitiet.Mamausac equals mausac.Mamausac
                                  join kichco in _context.Kichcos on giaychitiet.Makichco equals kichco.Makichco
                                  join thuonghieu in _context.Thuonghieus on giaychitiet.Mathuonghieu equals thuonghieu.Mathuonghieu
                                  join kieudang in _context.Kieudangs on giaychitiet.Makieudang equals kieudang.Makieudang
                                  select new GiayChiTietDTO
                                  {
                                      Magiay = giaychitiet.Magiay,
                                      TenGiay = giay.Tengiay,
                                      Magiaychitiet = giaychitiet.Magiaychitiet,
                                      TenChatLieu = chatlieu.Tenchatlieu,
                                      TenMauSac = mausac.Tenmausac,
                                      TenKichCo = kichco.Tenkichco,
                                      TenThuongHieu = thuonghieu.Tenthuonghieu,
                                      TenKieuDang = kieudang.Tenkieudang,
                                      Ngaytao = giaychitiet.Ngaytao,
                                      Ngaysua = giaychitiet.Ngaysua,
                                      Gia = giaychitiet.Gia ?? 0,
                                      Mota = giaychitiet.Mota,
                                      Soluongton = giaychitiet.Soluongton ?? 0,
                                      Trangthai = giaychitiet.Trangthai ?? false,
                                      Machatlieu = giaychitiet.Machatlieu,
                                      Mamausac = giaychitiet.Mamausac,
                                      Makichco = giaychitiet.Makichco,
                                      Mathuonghieu = giaychitiet.Mathuonghieu,
                                      Makieudang = giaychitiet.Makieudang
                                  };
            _lst_GiayDTO = giayChiTietList.ToList();
            var resultList = giayChiTietList.ToList();
            _lstGiayChiTiet = _Ser_ChiTietGiay.GetAll(txtTimKiem,SearchType);
            foreach (var item in resultList)
            {
                int stt = _lst_GiayDTO.IndexOf(item) + 1;

                dgvSP.Rows.Add(
                    item.Magiaychitiet,
                    item.Magiay,
                    item.TenGiay,
                    item.TenChatLieu,
                    item.TenMauSac,
                    item.TenKichCo,
                    item.TenThuongHieu,
                    item.TenKieuDang,
                    item.Ngaytao,
                    item.Ngaysua,
                    item.Gia,
                    item.Mota,
                    item.Soluongton,
                    item.Machatlieu,
                    item.Mamausac,
                    item.Makichco,
                    item.Mathuonghieu,
                    item.Makieudang,
                    item.Trangthai ? "Đang kinh doanh" : "Ngừng kinh doanh");
            }
        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            CheckTextbox();
            if (checkedTexbox)
            {

                try
                {
                    var confirmResult = MessageBox.Show("Xác nhận 'THÊM' giày không?", "Xác nhận", MessageBoxButtons.OKCancel);

                    if (confirmResult == DialogResult.OK)
                    {
                        bool result;
                        var existingProduct = _Ser_ChiTietGiay.GetAll(null, null)
                                .FirstOrDefault(p =>
                                    p.Magiay == (int)cbbTenGiay.SelectedValue &&
                                    p.Machatlieu == (int)cbbTenChatLieu.SelectedValue &&
                                    p.Mamausac == (int)cbbTenMauSac.SelectedValue &&
                                    p.Makichco == (int)cbbTenKichCo.SelectedValue &&
                                    p.Mathuonghieu == (int)cbbTenThuongHieu.SelectedValue &&
                                    p.Makieudang == (int)cbbTenKieuDang.SelectedValue);
                        if (existingProduct == null)
                        {
                            result = _Ser_ChiTietGiay.Them(new Giaychitiet()
                            {
                                Magiay = (int)cbbTenGiay.SelectedValue,
                                Machatlieu = (int)cbbTenChatLieu.SelectedValue,
                                Mamausac = (int)cbbTenMauSac.SelectedValue,
                                Makichco = (int)cbbTenKichCo.SelectedValue,
                                Mathuonghieu = (int)cbbTenThuongHieu.SelectedValue,
                                Makieudang = (int)cbbTenKieuDang.SelectedValue,
                                Soluongton = int.Parse(txtSoLuong.Text),
                                Ngaytao = dateTime,
                                Gia = int.Parse(txtGia.Text),
                                Mota = txtMoTa.Text,
                                Trangthai = true
                            });
                        }
                        else
                        {
                            MessageBox.Show("Đã tồn tại giày có các thuộc tính này");
                            result = false;
                        }
                        if (result)
                        {
                            MessageBox.Show("THÊM thành công");

                            LoadDataGridView(null, null);
                        }
                        else
                        {
                            MessageBox.Show("THÊM thất bại");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Hủy THÊM");
                    }
                    ClearTextBox();
                }
                catch (Exception ex)
                {

                    Console.WriteLine($"THÊM THẤT BẠI: {ex.ToString()}");
                }
            }
        }

        private void btnSua_Click_1(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            CheckTextbox();
            if (checkedTexbox)
            {
                var confirmResult = MessageBox.Show("Xác nhận 'SỬA' giày này không?", "Xác nhận", MessageBoxButtons.OKCancel);

                if (confirmResult == DialogResult.OK)
                {
                    var objGiay = _Ser_ChiTietGiay.GetByID(idClicked);
                    objGiay.Magiay = (int)cbbTenGiay.SelectedValue;
                    objGiay.Machatlieu = (int)cbbTenChatLieu.SelectedValue;
                    objGiay.Mamausac = (int)cbbTenMauSac.SelectedValue;
                    objGiay.Makichco = (int)cbbTenKichCo.SelectedValue;
                    objGiay.Mathuonghieu = (int)cbbTenThuongHieu.SelectedValue;
                    objGiay.Makieudang = (int)cbbTenKieuDang.SelectedValue;
                    objGiay.Soluongton = int.Parse(txtSoLuong.Text);
                    objGiay.Ngaysua = dateTime;
                    objGiay.Gia = int.Parse(txtGia.Text);
                    objGiay.Mota = txtMoTa.Text;

                    var result = _Ser_ChiTietGiay.Sua(idClicked, objGiay);

                    if (result)
                    {
                        MessageBox.Show("SỬA thành công");

                        LoadDataGridView(null, null);
                    }
                    else
                    {
                        MessageBox.Show("SỬA thất bại");
                    }
                }
                else
                {
                    MessageBox.Show("Đã hủy SỬA");
                }
                ClearTextBox();

            }
        }

        private void btnKhoa_MoKhoa_Click(object sender, EventArgs e)
        {
            if (_Ser_ChiTietGiay.GetByID(idClicked).Trangthai == true)
            {
                var confirmResult = MessageBox.Show("Xác nhận 'KHÓA' giày này không?", "Xác nhận", MessageBoxButtons.OKCancel);

                if (confirmResult == DialogResult.OK)
                {
                    var result = _Ser_ChiTietGiay.Khoa_MoKhoa(idClicked);

                    if (result)
                    {
                        MessageBox.Show("KHÓA thành công");
                        LoadDataGridView(null, null);
                    }
                    else
                    {
                        MessageBox.Show("KHÓA thất bại");
                    }
                }
                else
                {
                    MessageBox.Show("Đã hủy KHÓA");
                }
            }
            else
            {
                var confirmResult = MessageBox.Show("Xác nhận 'MỞ KHÓA' giày này không?", "Xác nhận", MessageBoxButtons.OKCancel);

                if (confirmResult == DialogResult.OK)
                {
                    var result = _Ser_ChiTietGiay.Khoa_MoKhoa(idClicked);

                    if (result)
                    {
                        MessageBox.Show("MỞ KHÓA thành công");
                        LoadDataGridView(null, null);
                    }
                    else
                    {
                        MessageBox.Show("MỞ KHÓA thất bại");
                    }
                }
                else
                {
                    MessageBox.Show("Đã hủy MỞ KHÓA ");
                }

            }
            ClearTextBox();
        }

        private void btnTimKiem_Click_1(object sender, EventArgs e)
        {
            LoadDataGridView(txtTimKiem.Text, cbbTimKiem.Text);
        }

        private void dgvSP_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;

            if (index < 0 || index >= _lst_GiayDTO.Count)
            {
                ClearTextBox();
                return;
            }

            var objCellClick = _lst_GiayDTO[index];
            if (objCellClick == null)
            {
                MessageBox.Show("Dữ liệu không hợp lệ!");
                ClearTextBox();
                return;
            }

            MessageBox.Show($" Tên sản phẩm: {objCellClick.TenGiay}\nID sản phẩm: {objCellClick.Magiaychitiet}");
            idClicked = objCellClick.Magiaychitiet;
            cbbTenGiay.SelectedValue = objCellClick.Magiay;
            txtGia.Text = objCellClick.Gia.ToString();
            txtSoLuong.Text = objCellClick.Soluongton.ToString();
            txtMoTa.Text = objCellClick.Mota;

            cbbTenThuongHieu.SelectedValue = objCellClick.Mathuonghieu;
            cbbTenKieuDang.SelectedValue = objCellClick.Makieudang;
            cbbTenChatLieu.SelectedValue = objCellClick.Machatlieu;
            cbbTenMauSac.SelectedValue = objCellClick.Mamausac;
            cbbTenKichCo.SelectedValue = objCellClick.Makichco;

            cbbTenGiay.Enabled = false;
            cbbTenThuongHieu.Enabled = false;
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
