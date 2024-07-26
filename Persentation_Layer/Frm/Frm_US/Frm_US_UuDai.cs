﻿using A_Persentation_Layer.Frm.Frm_Dialog;
using B_Bussiness_Layer.Services;
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

namespace A_Persentation_Layer.Frm.Frm_US
{
    public partial class Frm_US_UuDai : UserControl
    {
        public Frm_US_UuDai()
        {
            InitializeComponent();
            datebatdau.Format = DateTimePickerFormat.Custom;
            datebatdau.CustomFormat = "dd/MM/yyyy HH:mm";
            dateketthuc.Format = DateTimePickerFormat.Custom;
            dateketthuc.CustomFormat = "dd/MM/yyyy HH:mm";
            loadGird(null);
        }
        DangNhap_form dangNhapForm = new();
        UudaiService _service = new UudaiService();
        int _id;
        int _idWhenhClick;
        public void loadGird(string search)
        {
            int stt = 1;
            dtgHienthi.ColumnCount = 9;
            dtgHienthi.Columns[0].Name = "STT";
            dtgHienthi.Columns[1].Name = "Mã";
            dtgHienthi.Columns[2].Name = "Tên";
            dtgHienthi.Columns[5].Name = "Số lượng";
            dtgHienthi.Columns[6].Name = "Ngày bắt đầu";
            dtgHienthi.Columns[6].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";
            dtgHienthi.Columns[7].Name = "Ngày kết thúc";
            dtgHienthi.Columns[7].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";
            dtgHienthi.Columns[8].Name = "Trạng thái";

            dtgHienthi.Rows.Clear();
            foreach (var x in _service.GetUudais(search))
            {
                var idtk = _service.GetTaikhoan().FirstOrDefault(e => e.Mataikhoan == x.Mataikhoan);
                dtgHienthi.Rows.Add(stt++, x.Mauudai, x.Tenuudai, x.Soluong, x.Ngaybatdau, x.Ngayketthuc, MapTrangThai(x.Trangthai));
            }
        }
        private void CapNhatTrangThaiUuDai()
        {
            int rowCount = dtgHienthi.Rows.Count;

            if (rowCount > 0)
            {
                for (int i = 0; i < rowCount - 1; i++)
                {
                    DateTime Ngayhientai = DateTime.Now;
                    DateTime? ngayBatDau = dtgHienthi.Rows[i].Cells[6].Value != null ? DateTime.Parse(dtgHienthi.Rows[i].Cells[6].Value.ToString()) : (DateTime?)null;
                    DateTime? ngayKetThuc = dtgHienthi.Rows[i].Cells[7].Value != null ? DateTime.Parse(dtgHienthi.Rows[i].Cells[7].Value.ToString()) : (DateTime?)null;

                    string trangThai = MapTrangThai(Ngayhientai, ngayBatDau, ngayKetThuc);
                    dtgHienthi.Rows[i].Cells[8].Value = trangThai;
                }
            }
        }
        private string MapTrangThai(DateTime ngayHienTai, DateTime? ngayBatDau, DateTime? ngayKetThuc)
        {
            if (ngayBatDau == null && ngayKetThuc == null)
                return "Kết thúc";
            else if (ngayBatDau != null && ngayHienTai < ngayBatDau.Value)
                return "Sắp diễn ra";
            else if (ngayBatDau != null && ngayHienTai >= ngayBatDau.Value && (ngayKetThuc == null || ngayHienTai <= ngayKetThuc.Value))
                return "Đang diễn ra";
            else
                return "Kết thúc";
        }
        private string MapTrangThai(int? trangThai)
        {
            switch (trangThai)
            {
                case 0:
                    return "Kết thúc";
                case 1:
                    return "Sắp diễn ra";
                case 2:
                    return "Đang diễn ra";
                default:
                    return "";
            }
        }

        private void dtgHienthi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = e.RowIndex;
            _idWhenhClick = int.Parse(dtgHienthi.Rows[rowindex].Cells[1].Value.ToString());
            var obj = _service.GetUudais(null).FirstOrDefault(x => x.Mauudai == _idWhenhClick);
            txtTen.Text = obj.Tenuudai;
            txtSoluong.Text = obj.Soluong.ToString();
            datebatdau.Text = obj.Ngaybatdau.ToString();
            dateketthuc.Text = obj.Ngayketthuc.ToString();
        }

        private void txtTimkiem_TextChanged(object sender, EventArgs e)
        {
            loadGird(txtTimkiem.Text);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            DateTime ngayBatDau = datebatdau.Value;
            DateTime ngayKetThuc = dateketthuc.Value;

            if (ngayBatDau < DateTime.Today)
            {
                MessageBox.Show("Ngày bắt đầu phải lớn hơn hoặc bằng hiện tại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (ngayKetThuc <= ngayBatDau)
            {
                MessageBox.Show("Ngày kết thúc phải lớn hơn ngày bắt đầu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Uudai uudai = new Uudai();
            uudai.Tenuudai = txtTen.Text;
            uudai.Soluong = int.Parse(txtSoluong.Text);
            uudai.Ngaybatdau = ngayBatDau;
            uudai.Ngayketthuc = ngayKetThuc;

            if (ngayBatDau <= DateTime.Now && DateTime.Now <= ngayKetThuc)
            {
                uudai.Trangthai = 2;
            }
            else if (ngayBatDau > DateTime.Now)
            {
                uudai.Trangthai = 1;
            }
            if (checktrung(ngayBatDau, ngayKetThuc))
            {
                MessageBox.Show("Không thể thêm ưu đãi vì đã tồn tại ưu đãi trong khoảng thời gian này.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var relust = MessageBox.Show("Xác nhận muốm thêm", "Xác nhận", MessageBoxButtons.YesNo);
            if (relust == DialogResult.Yes)
            {
                MessageBox.Show(_service.AddUudai(uudai));
            }
            CapNhatTrangThaiUuDai();
            loadGird(null);
        }
        public bool checktrung(DateTime? ngayBatDau, DateTime? ngayKetThuc, int? mauudai = null)
        {
            var obj = _service.GetUudais(null)
                .FirstOrDefault(p =>
                    (mauudai == null || p.Mauudai != mauudai) &&
                    ((ngayBatDau >= p.Ngaybatdau && ngayBatDau <= p.Ngayketthuc) ||
                    (ngayKetThuc >= p.Ngaybatdau && ngayKetThuc <= p.Ngayketthuc) ||
                    (ngayBatDau <= p.Ngaybatdau && ngayKetThuc >= p.Ngayketthuc)));

            return obj != null;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            DateTime ngayBatDau = datebatdau.Value;
            DateTime ngayKetThuc = dateketthuc.Value;
            if (datebatdau.Value > dateketthuc.Value)
            {
                MessageBox.Show("Ngày kết thúc phải lớn hơn hoặc bằng ngày bắt đầu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Uudai uudai = new Uudai();
            uudai.Mauudai = _idWhenhClick;
            uudai.Tenuudai = txtTen.Text;
            uudai.Soluong = int.Parse(txtSoluong.Text);
            uudai.Ngaybatdau = ngayBatDau;
            uudai.Ngayketthuc = ngayKetThuc;

            DateTime now = DateTime.Now;

            if (ngayBatDau <= now && now <= ngayKetThuc)
            {
                uudai.Trangthai = 2;
            }
            else if (ngayBatDau > now)
            {
                uudai.Trangthai = 1;
            }
            else
            {
                uudai.Trangthai = 0;
            }
            var relust = MessageBox.Show("Xác nhận muốm sửa", "Xác nhận", MessageBoxButtons.YesNo);
            if (relust == DialogResult.Yes)
            {
                MessageBox.Show(_service.Updateuudai(uudai));
            }
            CapNhatTrangThaiUuDai();
            loadGird(null);
        }

        private void btnlammoi_Click(object sender, EventArgs e)
        {
            txtTen.Text = "";
            txtSoluong.Text = "";
            datebatdau.Value = DateTime.Now;
            dateketthuc.Value = DateTime.Now;
        }

        private void btnketthuc_Click(object sender, EventArgs e)
        {
            CapNhatTrangThaiUuDai();
            Uudai uudai = new Uudai();
            uudai.Mauudai = _idWhenhClick;
            var relust = MessageBox.Show("Xác nhận muốm kết thúc", "Xác nhận", MessageBoxButtons.YesNo);
            if (relust == DialogResult.Yes)
            {
                MessageBox.Show(_service.Trangthai(uudai));
            }
            CapNhatTrangThaiUuDai();
            loadGird(null);
        }
    }
}
