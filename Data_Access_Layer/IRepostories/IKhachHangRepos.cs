using C_Data_Access_Layer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Data_Access_Layer.IRepostories
{
    public interface IKhachHangRepos
    {
        public List<Khachhang> GetAllKhachhang(string search);
        public List<Hoadon> GetAllHoadon();
        public List<Hinhthucthanhtoan> GetHinhthucthanhtoans();
        public bool AddKhachHang(Khachhang khachhang);
        public bool UpdateKhachHang(Khachhang khachhang);
    }
}
