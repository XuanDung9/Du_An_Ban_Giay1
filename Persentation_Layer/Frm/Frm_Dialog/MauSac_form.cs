﻿using C_Data_Access_Layer.Models.ModelRefer;
using C_Data_Access_Layer.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using B_Bussiness_Layer.Services;

namespace A_Persentation_Layer.Frm.Frm_Dialog
{
    public partial class MauSac_form : Form
    {
        MauSacService _service = new MauSacService();
        List<Mausac> lst_MauSac = new List<Mausac>();
        int idClicked;
        int maTaiKhoan;
        public MauSac_form()
        {
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
        private void MauSac_form_Load(object sender, EventArgs e)
        {
            LoadData(null, null);
            SerchType_CBB();
        }
        private void SerchType_CBB()
        {
            cbbTimKiem.Items.Clear();
            cbbTimKiem.Items.Add(SearchType.All);
            cbbTimKiem.Items.Add(SearchType.tenMauSac);
            cbbTimKiem.Items.Add(SearchType.moTaMauSac);
            cbbTimKiem.Items.Add(SearchType.trangThaiMauSac);
            cbbTimKiem.Items.Add(SearchType.idNguoiThemMauSac);
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
            lst_MauSac = _service.GetAll(txtTimKiem, SearchType);
            foreach (var item in lst_MauSac)
            {
                int stt = lst_MauSac.IndexOf(item) + 1;

                dgv_Objects.Rows.Add(stt, item.Tenmausac, item.Mota, item.Mataikhoan, (item.Trangthai == true ? "Còn kinh doanh" : "Ngưng kinh doanh"));
            }
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            LoadData(txtTimKiem.Text, cbbTimKiem.Text);
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            bool result;
            // check dữ liệu đầu vào 
            if (CheckData())
            {
                var confirmResult = MessageBox.Show("Xác nhận 'THÊM' chất liệu ? ", "Đúng", MessageBoxButtons.OKCancel);
                if (confirmResult == DialogResult.OK)
                {
                    // check đã có trong csdl chưa 
                    var existingObj = _service.GetAll(null, null).FirstOrDefault(p => p.Tenmausac == txtTen.Text && p.Mota == txtMoTa.Text);
                    if (existingObj != null)
                    {
                        MessageBox.Show("Chất liệu đã tồn tại");
                        result = false;
                    }
                    else
                    {
                        result = _service.Them(new Mausac()
                        {
                            Tenmausac = txtTen.Text,
                            Mota = txtMoTa.Text,
                            Mataikhoan = XacThucDangNhap.Instance.IdTaiKhoan,
                            Trangthai = true
                        });
                    }
                    if (result)
                    {
                        // thành công 
                        MessageBox.Show("Thêm thành công ");
                        LoadData(null, null);
                    }
                    else
                    {
                        MessageBox.Show("Thêm thất bại");
                    }
                }
                else
                {
                    MessageBox.Show("Đã 'HỦY'");
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
                var confirmResult = MessageBox.Show("Xác nhận 'SỬA' chất liệu", "Xác nhận", MessageBoxButtons.OKCancel);
                if (confirmResult == DialogResult.OK)
                {
                    var result = _service.Sua(idClicked, new Mausac()
                    {
                        Tenmausac = txtTen.Text,
                        Mota = txtMoTa.Text,
                    });
                    if (result)
                    {
                        MessageBox.Show("SỬA chất liệu thành công");
                        LoadData(null, null);
                    }
                    else
                    {
                        MessageBox.Show("SỬA thất bại");
                    }
                }
                else
                {
                    MessageBox.Show("HỦY sửa chất liệu");
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
                var confirmResult = MessageBox.Show("Xác nhận 'KHÓA' chất liệu", "Xác nhận", MessageBoxButtons.OKCancel);
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
                    MessageBox.Show("Đã hủy KHÓA chất liệu ");
                }
                ClearTextBox();
            }
            else
            {
                var confirmResult = MessageBox.Show("Xác nhận ' MỞ KHÓA' chất liệu", "Xác nhận", MessageBoxButtons.OKCancel);
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
                    MessageBox.Show("Đã hủy MỞ KHÓA chất liệu ");
                }
                ClearTextBox();
            }
        }

        private void dgv_Objects_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;

            // Kiểm tra xem chỉ số hàng có hợp lệ không
            if (index < 0 || index >= lst_MauSac.Count)
            {
                ClearTextBox();
                return;
            }

            // Lấy đối tượng Chatlieu tương ứng với hàng đã click
            var objCellClick = lst_MauSac[index];

            // Cập nhật dữ liệu lên các trường văn bản
            idClicked = objCellClick.Mamausac;
            txtTen.Text = objCellClick.Tenmausac;
            txtMoTa.Text = objCellClick.Mota;
        }

        private void dgv_Objects_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;

            // Kiểm tra xem chỉ số hàng có hợp lệ không
            if (index < 0 || index >= lst_MauSac.Count)
            {
                ClearTextBox();
                return;
            }

            // Lấy đối tượng Chatlieu tương ứng với hàng đã click
            var objCellClick = lst_MauSac[index];

            // Cập nhật dữ liệu lên các trường văn bản
            idClicked = objCellClick.Mamausac;
            txtTen.Text = objCellClick.Tenmausac;
            txtMoTa.Text = objCellClick.Mota;
        }
    }
}