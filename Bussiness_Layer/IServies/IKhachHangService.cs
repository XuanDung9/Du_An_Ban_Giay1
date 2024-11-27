using C_Data_Access_Layer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_Bussiness_Layer.IServies
{
    public interface IKhachHangService
    {
        public List<Khachhang> GetAllKhachhang(string search);
        public List<Hinhthucthanhtoan> GetHinhthucthanhtoans();
        public List<Hoadon> GetAllHoadon();
        public List<Hoadon> GetHoadonsByKhachHangId(int khachHangId);
        public string AddKhachHang(Khachhang khachhang);
        public string UpdateKhachHang(Khachhang khachhang);
        public string Khoa_MoKhoa(Khachhang khachhang);
    }
}
