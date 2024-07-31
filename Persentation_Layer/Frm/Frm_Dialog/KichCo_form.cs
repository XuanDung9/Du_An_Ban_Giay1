using B_Bussiness_Layer.Services;
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

namespace A_Persentation_Layer.Frm.Frm_Dialog
{
    public partial class KichCo_form : Form
    {
        KichCoService _service;
        List<Kichco> _lstKichCo;
        int idClicked;
        int maTaiKhoan;
        public KichCo_form()
        {
            _service = new KichCoService();
            _lstKichCo = new List<Kichco>();
            InitializeComponent();
        }
        public void ClearTextBox()
        {
            txtMoTa.Text = "";
            txtTen.Text = "";
            txtTimKiem.Text = "";
        }
        public bool CheckData()
        {
            if (txtTen.Text == "" || txtMoTa.Text == "" || XacThucDangNhap.Instance.IdTaiKhoan == 0)
            {
                return false;
            }
            return true;
        }
        private void KichCo_form_Load(object sender, EventArgs e)
        {
            LoadData(null, null);
            SerchType_CBB();
        }
        private void SerchType_CBB()
        {
            cbbTimKiem.Items.Clear();
            cbbTimKiem.Items.Add(SearchType.All);
            cbbTimKiem.Items.Add(SearchType.tenKichCo);
            cbbTimKiem.Items.Add(SearchType.moTaKichCo);
            cbbTimKiem.Items.Add(SearchType.trangThaiKichCo);
            cbbTimKiem.Items.Add(SearchType.idNguoiThemKichCo);
            cbbTimKiem.SelectedIndex = 0; // mặc định thằng ko được chọn là all
        }
        private void LoadData(string? txtTimKiem, string? SearchType)
        {
            dgv_Objects.Rows.Clear();
            dgv_Objects.ColumnCount = 5;
            dgv_Objects.Columns[0].Name = "STT";
            dgv_Objects.Columns[1].Name = "Tên";
            dgv_Objects.Columns[2].Name = "Mô tả";
            dgv_Objects.Columns[3].Name = "id người tạo";
            dgv_Objects.Columns[4].Name = "Trạng thái";
            _lstKichCo = _service.GetAll(txtTimKiem, SearchType);
            foreach (var item in _lstKichCo)
            {
                int stt = _lstKichCo.IndexOf(item) + 1;

                dgv_Objects.Rows.Add(stt, item.Tenkichco, item.Mota, item.Mataikhoan, (item.Trangthai == true ? "Còn kinh doanh" : "Ngưng kinh doanh"));
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            bool result;
            // check dữ liệu đầu vào 
            if (CheckData())
            {
                var confirmResult = MessageBox.Show("Xác nhận THÊM ? ", "Đúng", MessageBoxButtons.OKCancel);
                if (confirmResult == DialogResult.OK)
                {
                    // check đã có trong csdl chưa 
                    var existingObj = _service.GetAll(null, null).FirstOrDefault(p => p.Tenkichco == txtTen.Text && p.Mota == txtMoTa.Text);
                    if (existingObj != null)
                    {
                        MessageBox.Show("Kích cỡ đã tồn tại");
                        result = false;
                    }
                    else
                    {
                        result = _service.Them(new Kichco()
                        {
                            Tenkichco = txtTen.Text,
                            Mota = txtMoTa.Text,
                            Mataikhoan = XacThucDangNhap.Instance.IdTaiKhoan,
                            Trangthai = true
                        });
                    }
                    if (result)
                    {
                        // thành công 
                        MessageBox.Show("THÊM thành công ");
                        LoadData(null, null);
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
            }
            else
            {
                MessageBox.Show("Vui lòng nhập dữ liệu hợp lệ");
            }
            ClearTextBox();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (CheckData())
            {
                var confirmResult = MessageBox.Show("Xác nhận SỬA", "Xác nhận", MessageBoxButtons.OKCancel);
                if (confirmResult == DialogResult.OK)
                {
                    var result = _service.Sua(idClicked, new Kichco()
                    {
                        Tenkichco = txtTen.Text,
                        Mota = txtMoTa.Text,
                    });
                    if (result)
                    {
                        MessageBox.Show("SỬA thành công");
                        LoadData(null, null);
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
            }
            else
            {
                MessageBox.Show("Nhập thông tin hợp lệ");
            }
            ClearTextBox();
        }

        private void btnKhoa_MoKhoa_Click(object sender, EventArgs e)
        {
            if (_service.GetByID(idClicked).Trangthai == true)
            {
                var confirmResult = MessageBox.Show("Xác nhận KHÓA", "Xác nhận", MessageBoxButtons.OKCancel);
                if (confirmResult == DialogResult.OK)
                {
                    var result = _service.Khoa_MoKhoa(idClicked);
                    if (result)
                    {
                        MessageBox.Show("KHÓA thành công");
                        LoadData(null, null);
                    }
                    else
                    {
                        MessageBox.Show("KHÓA thất bại");
                    }
                }
                else
                {
                    MessageBox.Show("Đã hủy KHÓA ");
                }
                ClearTextBox();
            }
            else
            {
                var confirmResult = MessageBox.Show("Xác nhận MỞ KHÓA ", "Xác nhận", MessageBoxButtons.OKCancel);
                if (confirmResult == DialogResult.OK)
                {
                    var result = _service.Khoa_MoKhoa(idClicked);
                    if (result)
                    {
                        MessageBox.Show("MỞ KHÓA thành công");
                        LoadData(null, null);
                    }
                    else
                    {
                        MessageBox.Show(" MỞ KHÓA thất bại");
                    }
                }
                else
                {
                    MessageBox.Show("Đã hủy MỞ KHÓA ");
                }
                ClearTextBox();
            }
        }

        private void dgv_Objects_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;

            // Kiểm tra xem chỉ số hàng có hợp lệ không
            if (index < 0 || index >= _lstKichCo.Count)
            {
                ClearTextBox();
                return;
            }

            // Lấy đối tượng Chatlieu tương ứng với hàng đã click
            var objCellClick = _lstKichCo[index];

            // Cập nhật dữ liệu lên các trường văn bản
            idClicked = objCellClick.Makichco;
            txtTen.Text = objCellClick.Tenkichco;
            txtMoTa.Text = objCellClick.Mota;
        }

        private void btnTimKiem_Click_1(object sender, EventArgs e)
        {
            LoadData(txtTimKiem.Text, cbbTimKiem.Text);
        }
    }
}
