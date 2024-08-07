using B_Bussiness_Layer.Services;
using C_Data_Access_Layer.Models;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A_Persentation_Layer.Frm.Frm_US
{
    public partial class Frm_US_NhanVien : UserControl
    {
        public Frm_US_NhanVien()
        {
            InitializeComponent(); LoadComBoBox();
            rbnNam.Checked = true;
            dateSinh.Format = DateTimePickerFormat.Custom;
            dateSinh.CustomFormat = "dd/MM/yyyy";
            LoadGird(null);
        }
        private NhanvienService _service = new NhanvienService();
        List<int> _list = new List<int>();
        int _idWhenclick;
        public void LoadComBoBox()
        {

            foreach (var item in _service.GetChucvu())
            {
                _list.Add(item.Machucvu);
                cmbChucvu.Items.Add(item.Tenchucvu);
            }
            cmbChucvu.SelectedIndex = 0;
            cmbChucvu.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        public void LoadGird(string search)
        {
            int stt = 1;
            dgvHienThi.ColumnCount = 13;
            dgvHienThi.Columns[0].Name = "STT";
            dgvHienThi.Columns[1].Name = "Mã";
            dgvHienThi.Columns[2].Name = "UserName";
            dgvHienThi.Columns[3].Name = "Password";
            dgvHienThi.Columns[4].Name = "Tên";
            dgvHienThi.Columns[5].Name = "Giới tính";
            dgvHienThi.Columns[6].Name = "SĐT";
            dgvHienThi.Columns[7].Name = "Địa chỉ";
            dgvHienThi.Columns[8].Name = "Email";
            dgvHienThi.Columns[9].Name = "Ngày sinh";
            dgvHienThi.Columns[9].DefaultCellStyle.Format = "dd/MM/yyyy";
            dgvHienThi.Columns[10].Name = "Chức vụ";

            dgvHienThi.Columns[11].Name = "Trạng thái";

            dgvHienThi.Rows.Clear();

            foreach (var x in _service.GetTaikhoan(search))
            {

                var idcv = _service.GetChucvu().FirstOrDefault(e => e.Machucvu == x.Machucvu);
                dgvHienThi.Rows.Add(stt++, x.Mataikhoan, x.Username, x.Password, x.Hoten, x.Gioitinh == true ? "Nam" : "Nữ", x.Sdt
                    , x.Diachi, x.Email, x.Ngaysinh, idcv.Tenchucvu, x.Trangthai == false ? "Nghỉ làm" : "Đi làm");
            }
        }




        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
        private bool checkusername(string username)
        {
            int dem = 0;
            foreach (Taikhoan taikhoan in _service.GetTaikhoan(null))
            {
                if (taikhoan.Username == username)
                {
                    dem++;
                }
            }
            if (dem == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private bool checksdt(string sodienthoai)
        {
            int dem = 0;
            foreach (Taikhoan taikhoan in _service.GetTaikhoan(null))
            {
                if (taikhoan.Sdt.ToString() == sodienthoai)
                {
                    dem++;
                }
            }
            if (dem == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //private  bool checkngaysinh(DateTime? ngaysinh)
        //{
             
        //    DateTime ngaySinh = ngaysinh.Value;
        //    if (ngaySinh == DateTime.Now)
        //    {
              
        //        return false;
        //    }
        //    return true;
        //}
        private void dgvHienThi_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (e.ColumnIndex == dgvHienThi.ColumnCount - 1)
            {
                e.Cancel = true;
            }
        }


        private void txtTimKiem_TextChanged_1(object sender, EventArgs e)
        {
            LoadGird(txtTimKiem.Text);
        }

        public bool Checkrong(string soDienThoai, string email, string username/*, DateTime? ngaysinh*/)
        {


            if (string.IsNullOrEmpty(txtTaikhoan.Text)
                || string.IsNullOrEmpty(txtMatkhau.Text)
                || string.IsNullOrEmpty(txtTen.Text)
                || string.IsNullOrEmpty(txtSDT.Text)
                || string.IsNullOrEmpty(txtDiachi.Text)
                || string.IsNullOrEmpty(txtEmail.Text)
                || string.IsNullOrEmpty(dateSinh.Text)

                )

            {
                MessageBox.Show("Vui lòng nhập đủ dữ liệu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (soDienThoai.Length != 10 && soDienThoai[0] != '0' && !soDienThoai.All(char.IsDigit) || !int.TryParse(soDienThoai, out _))
            {
                MessageBox.Show("Số điện thoại 0 hợp lệ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            else if(email != @"^[^@\s]+@[^@\s]+\.[^@\s]+$")
            {

                
                MessageBox.Show("Email chưa đúng định dạng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            //if (!checkngaysinh(ngaysinh))
            //{
            //    MessageBox.Show("Ngày sinh khoong hơpj lệ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return false;
            //}

            if (!checkusername(username))
            {
                MessageBox.Show("Username tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!checksdt(txtSDT.Text))
            {
                MessageBox.Show("Số điện thoại tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (Checkrong(txtSDT.Text, txtEmail.Text, txtTaikhoan.Text/*, dateSinh.Value*/))
            {
                Taikhoan taikhoan = new Taikhoan();
                taikhoan.Username = txtTaikhoan.Text;
                taikhoan.Password = txtMatkhau.Text;
                taikhoan.Hoten = txtTen.Text;
                taikhoan.Gioitinh = rbnNam.Checked;
                taikhoan.Sdt = Convert.ToInt32(txtSDT.Text);
                taikhoan.Diachi = txtDiachi.Text;
                taikhoan.Email = txtEmail.Text;
                taikhoan.Ngaysinh = dateSinh.Value;
                taikhoan.Machucvu = _list[cmbChucvu.SelectedIndex];

                taikhoan.Trangthai = true;
                var relust = MessageBox.Show("Xác nhận muốm thêm", "Xác nhận", MessageBoxButtons.YesNo);
                if (relust == DialogResult.Yes)
                {
                    _service.AddNhanVien(taikhoan);
                }
                LoadGird(null);
            }
        }
        private void btnSua_Click(object sender, EventArgs e)
        {

            if (IsValidEmail(txtEmail.Text))
            {
                MessageBox.Show("Email tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (Checkrong(txtSDT.Text, txtEmail.Text/*,dateSinh.Text*/, null))
            {
                Taikhoan taikhoan = new Taikhoan();
                taikhoan.Mataikhoan = _idWhenclick;
                taikhoan.Username = txtTaikhoan.Text;
                taikhoan.Password = txtMatkhau.Text;
                taikhoan.Hoten = txtTen.Text;
                taikhoan.Gioitinh = rbnNam.Checked;
                taikhoan.Sdt = Convert.ToInt32(txtSDT.Text); ;
                taikhoan.Diachi = txtDiachi.Text;
                taikhoan.Email = txtEmail.Text;
                taikhoan.Ngaysinh = dateSinh.Value;
                taikhoan.Machucvu = _list[cmbChucvu.SelectedIndex];
                var relust = MessageBox.Show("Xác nhận muốm sửa", "Xác nhận", MessageBoxButtons.YesNo);
                if (relust == DialogResult.Yes)
                {
                    MessageBox.Show(_service.UpdateNhanVien(taikhoan));
                }
                LoadGird(null);
            }
        }

        private void btnKhoa_MoKhoa_Click_1(object sender, EventArgs e)
        {
            Taikhoan taikhoan = new Taikhoan();
            taikhoan.Mataikhoan = _idWhenclick;
            var relust = MessageBox.Show("Xác nhận muốm Khoá/Mở khoá", "Xác nhận", MessageBoxButtons.YesNo);
            if (relust == DialogResult.Yes)
            {
                MessageBox.Show(_service.Khoa_Mokhoa(taikhoan));
            }
            LoadGird(null);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtTaikhoan.Text = "";
            txtMatkhau.Text = "";
            txtTen.Text = "";
            txtSDT.Text = "";
            rbnNam.Checked = true;
            txtDiachi.Text = "";
            txtEmail.Text = "";
            dateSinh.Text = "";
            cmbChucvu.SelectedIndex = 0;
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            LoadGird(txtTimKiem.Text);
        }

        private void dgvHienThi_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index < 0 || index > dgvHienThi.Rows.Count)
            {
                txtTaikhoan.Text = "";
                txtMatkhau.Text = "";
                txtTen.Text = "";
                txtSDT.Text = "";
                rbnNam.Checked = true;
                txtDiachi.Text = "";
                txtEmail.Text = "";
                dateSinh.Text = "";
                cmbChucvu.SelectedIndex = 0;
            }
            else
            {
                if (index >= 0 && index < dgvHienThi.Rows.Count - 1)
                {
                    _idWhenclick = int.Parse(dgvHienThi.Rows[index].Cells[1].Value.ToString());
                    var nhanvien = _service.GetTaikhoan(null).FirstOrDefault(x => x.Mataikhoan == _idWhenclick);
                    txtTaikhoan.Text = nhanvien.Username;
                    txtMatkhau.Text = nhanvien.Password;
                    txtTen.Text = nhanvien.Hoten;
                    if (nhanvien.Gioitinh == false)
                    {
                        rbnNu.Checked = true;
                    }
                    else
                    {
                        rbnNam.Checked = true;
                    }
                    txtSDT.Text = nhanvien.Sdt.ToString();
                    txtDiachi.Text = nhanvien.Diachi;
                    txtEmail.Text = nhanvien.Email;
                    dateSinh.Text = nhanvien.Ngaysinh.ToString();
                    cmbChucvu.SelectedIndex = _list.FindIndex(x => x == nhanvien.Machucvu);
                }
            }

        }

        private void btnExcel_Click_1(object sender, EventArgs e)
        {
            using (ExcelPackage excelPackage = new ExcelPackage())
            {

                ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.Add("Sheet1");

                for (int i = 0; i < dgvHienThi.Columns.Count; i++)
                {
                    worksheet.Cells[1, i + 1].Value = dgvHienThi.Columns[i].HeaderText;
                }

                for (int i = 0; i < dgvHienThi.Rows.Count; i++)
                {
                    for (int j = 0; j < dgvHienThi.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 2, j + 1].Value = dgvHienThi.Rows[i].Cells[j].Value?.ToString();
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
    }
}

