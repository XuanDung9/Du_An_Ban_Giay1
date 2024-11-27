using C_Data_Access_Layer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Data_Access_Layer.IRepostories
{
    public interface IBanHangRepostory
    {
        public List<Hoadon> GetHoadons();
        public List<Hoadonchitiet> GetHoadonchitiets();
        public List<Giaychitiet> GetGiaychitiets();
        public List<Giay> GetGiays();
        public List<Khachhang> GetKhachhang();
        public List<Taikhoan> GetTaikhoan();
        public List<Thuonghieu> GetThuonghieu();
        public List<Kichco> GetKichcos();
        public List<Mausac> GetMausacs();
        public List<Chatlieu> GetChatlieu();
        public List<Kieudang> GetKieudangs();
        public bool AddHD(Hoadon hoadon);
        public bool UpdateHD(Hoadon hoadon);
        public bool HuyHD(Hoadon hoadon);
    }
}
