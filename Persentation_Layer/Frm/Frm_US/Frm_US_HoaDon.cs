﻿using B_Bussiness_Layer.Services;

using C_Data_Access_Layer.Models.ModelRefer;
using OfficeOpenXml;
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
    public partial class Frm_US_HoaDon : UserControl
    {

        HoaDonService _service = new HoaDonService();
        int _idWhenclick;
        public Frm_US_HoaDon()
        {
            InitializeComponent(); LoadGridHD(null, null);
            Loadcombobox();
        }



        public void Loadcombobox()
        {
            List<string> hinhThucThanhToans = _service.GetHinhthucthanhtoans().Select(p => p.Tenhinhthuc).ToList();
            cmbloaitt.Items.Add("Tất cả");
            cmbloaitt.Items.AddRange(hinhThucThanhToans.ToArray());
            cmbloaitt.SelectedIndex = 0;
            cmbloaitt.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTimkiem.Items.Add(SearchType.tatca);
            cmbTimkiem.Items.Add(SearchType.tenkhach);
            cmbTimkiem.Items.Add(SearchType.SDTkhach);
            cmbTimkiem.Items.Add(SearchType.TenTaikhoan);
            cmbTimkiem.SelectedIndex = 0;
            cmbTimkiem.DropDownStyle = ComboBoxStyle.DropDownList;

        }
        public void LoadGridHD(string searchText, string searchType)
        {
            int stt = 1;
            dgvHD.ColumnCount = 11;
            dgvHD.Columns[0].Name = "STT";
            dgvHD.Columns[1].Name = "Mã hoá đơn";
            dgvHD.Columns[2].Name = "Tên khách hàng";
            dgvHD.Columns[3].Name = "SĐT khách hàng";
            dgvHD.Columns[4].Name = "Mã NV";
            dgvHD.Columns[5].Name = "Tên NV";
            dgvHD.Columns[6].Name = "Ngày tạo";
            dgvHD.Columns[6].DefaultCellStyle.Format = "dd/MM/yyyy";
            dgvHD.Columns[7].Name = "Loại thanh toán";
            dgvHD.Columns[8].Name = "Tổng tiền";
            dgvHD.Columns[9].Name = "Ghi chú";
            dgvHD.Columns[10].Name = "Trạng thái";

            dgvHD.Rows.Clear();

            foreach (var x in _service.hoaDonNhes(searchText, searchType))
            {
                dgvHD.Rows.Add(stt++, x.Hoadone.Mahoadon, x.tenkhachhang, x.sdtkhach, x.Hoadone.Mataikhoan, x.hovatentaikhoan, x.Hoadone.Ngaytao, x.tenhinhthuc, x.Hoadone.Tongtien, x.Hoadone.Ghichu, x.Hoadone.Trangthai == false ? "Chưa thanh toán" : "Đã thanh toán");
            }
        }

        public void loadgridHoadonchitiet(int hdctId)
        {
            int stt = 1;
            dgvHDCT.ColumnCount = 5;
            dgvHDCT.Columns[0].Name = "STT";
            dgvHDCT.Columns[1].Name = "Mã hoá đơn";
            dgvHDCT.Columns[2].Name = "Tên sản phẩm";
            dgvHDCT.Columns[3].Name = "Số lượng";
            dgvHDCT.Columns[4].Name = "Giá bán"; 

            dgvHDCT.Rows.Clear();
            foreach (var e in _service.GetHoadonchitietsById(hdctId))
            {
                var idspct = _service.GetGiaychitiets().FirstOrDefault(i => i.Magiaychitiet == e.Magiaychitiet);
                var idsp = _service.GetGiays().FirstOrDefault(s => s.Magiay == idspct.Magiay);
                dgvHDCT.Rows.Add(stt++, e.Mahoadon, idsp.Tengiay, e.Soluongmua, e.Tongtien);
            }
        }
        private void dgvHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Lấy chỉ số hàng được click
                int index = e.RowIndex;
                if (index >= 0 && index < dgvHD.Rows.Count - 1)
                {
                    _idWhenclick = int.Parse(dgvHD.Rows[index].Cells[1].Value.ToString());
                    var hd = _service.GetHoadons(null).FirstOrDefault(x => x.Mahoadon == _idWhenclick);

                    loadgridHoadonchitiet(hd.Mahoadon);
                }
            }
        }

        private void txtTimkiem_TextChanged(object sender, EventArgs e)
        {
            LoadGridHD(txtTimkiem.Text, cmbTimkiem.Text);
        }

        private void cmbloaitt_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string hinhThucThanhToanDuocChon = cmbloaitt.SelectedItem.ToString();
            string loaiThanhToan = (hinhThucThanhToanDuocChon == "Tất cả") ? null : hinhThucThanhToanDuocChon;
            LoadGridHD(null, loaiThanhToan);
        }

        private void cmbTimkiem_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadGridHD(txtTimkiem.Text, cmbTimkiem.Text);
        }

        private void datetao_ValueChanged(object sender, EventArgs e)
        {
            LoadGridHD(txtTimkiem.Text, cmbTimkiem.Text);
        }
        private void dateden_ValueChanged(object sender, EventArgs e)
        {
            LoadGridHD(txtTimkiem.Text, cmbTimkiem.Text);
        }

        private void btnXuatExcel_Click(object sender, EventArgs e)

        {
            // ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            using (ExcelPackage excelPackage = new ExcelPackage())
            {
                ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.Add("Sheet1");

                // Ghi tiêu đề cột
                for (int i = 0; i < dgvHD.Columns.Count; i++)
                {
                    worksheet.Cells[1, i + 1].Value = dgvHD.Columns[i].HeaderText;
                }

                // Ghi dữ liệu từ DataGridView
                for (int i = 0; i < dgvHD.Rows.Count; i++)
                {
                    for (int j = 0; j < dgvHD.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 2, j + 1].Value = dgvHD.Rows[i].Cells[j].Value?.ToString();
                    }
                }

                // Mở hộp thoại lưu tệp
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

        private void dgvHDCT_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Frm_US_HoaDon_Load(object sender, EventArgs e)
        {
            Loadcombobox(); 
            LoadGridHD(null, null);
        }
    }
}
