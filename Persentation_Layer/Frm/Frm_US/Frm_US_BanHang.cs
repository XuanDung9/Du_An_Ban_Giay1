using B_Bussiness_Layer.Services;
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
        HoaDonService _ser_hoaDon = new HoaDonService();
        HoaDonChiTIetService _ser_hoaDonChiTiet = new HoaDonChiTIetService();
        Giay_GiayChiTietService _Ser_Giay_ChiTietGiay = new Giay_GiayChiTietService();
        List<HoaDonChiTiet_SP> _lst_HDCT_SP = new List<HoaDonChiTiet_SP>();
        List<HoaDon_Model> _lst_HD_Model = new List<HoaDon_Model>();
        private void dgv_HoaDon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void Load_dvg_HoaDon(string? txtSearch, string? SearchType)
        {
            int stt = 1;
            dgv_HoaDon.ColumnCount = 9;
            dgv_HoaDon.Columns[0].Name = "STT";
            dgv_HoaDon.Columns[1].Name = "Mã hóa đơn";
            dgv_HoaDon.Columns[2].Name = "Tên người tạo";
            dgv_HoaDon.Columns[3].Name = "Ngày tạo";
            dgv_HoaDon.Columns[4].Name = "Tên khách hàng";
            dgv_HoaDon.Columns[5].Name = "Tên ưu đãi";
            dgv_HoaDon.Columns[6].Name = "Tổng tiền";
            dgv_HoaDon.Columns[7].Name = "Hình thức thanh toán";
            dgv_HoaDon.Columns[8].Name = "Trạng thái";

            dgv_HoaDon.Rows.Clear();
            _lst_HD_Model = _ser_hoaDon.GetAll("false", "Trạng thái hóa đơn");
            foreach (var item in _lst_HD_Model)
            {
                dgv_HoaDon.Rows.Add(stt++, item.Hoadon.Mahoadon, item.tenTaiKhoan, item.Hoadon.Ngaytao, item.tenKhachHang, item.tenUuDai, item.Hoadon.Tongtien, item.tenHinhThucThanhToan, item.Hoadon.Trangthai);
            }
            dgv_HoaDon.Columns[0].Width = 25;


        }

        private void btn_ThemHoaDon_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    var confirmResult = MessageBox.Show("Xác nhận thêm mới hóa đơn ?","Xác nhận",MessageBoxButtons.OKCancel);
            //    if (confirmResult == DialogResult.OK)
            //    {
            //        var result = _ser_hoaDon.Them(new HoaDon_Model()
            //        {
                      
            //        });
            //    }

            //}
            //catch
            //{

            //}
        }

        private void btn_XoaHoaDon_Click(object sender, EventArgs e)
        {

        }
    }
}
