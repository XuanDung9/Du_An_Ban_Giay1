using C_Data_Access_Layer.Context;
using C_Data_Access_Layer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Data_Access_Layer.IRepostories
{
    public interface IHoadonRepository_Chuan
    {
        public List<Hoadon> GetHoadons();
        public List<Hoadonchitiet> GetHoadonchitiets();
        public List<Taikhoan> GetTaikhoans();
        public List<Hinhthucthanhtoan> GetHinhthucthanhtoans();
        public List<Uudai> GetUudais();
        public List<Khachhang> GetKhachhangs();
        public List<Giay> GetGiays();
        public List<Giaychitiet> GetGiaychitiets();

    }
}
