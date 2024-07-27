using B_Bussiness_Layer.IServies;
using C_Data_Access_Layer.Models;
using C_Data_Access_Layer.Repostories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_Bussiness_Layer.Services
{
    public class BanHangService: IBanHangService
    {
        BanHangRepostory _repos;
        public BanHangService()
        {
            _repos = new BanHangRepostory();
        }

        public List<Chatlieu> GetChatlieu()
        {
            return _repos.GetChatlieu();
        }

        public List<Giaychitiet> GetGiaychitiets()
        {
            return _repos.GetGiaychitiets();
        }

        public List<Giay> GetGiays()
        {
            return _repos.GetGiays();
        }

        public List<Hoadonchitiet> GetHoadonchitiets()
        {
            return _repos.GetHoadonchitiets();
        }

        public List<Hoadon> GetHoadons()
        {
            return _repos.GetHoadons();
        }

        public List<Khachhang> GetKhachhang()
        {
            return _repos.GetKhachhang();
        }

        public List<Kichco> GetKichcos()
        {
            return _repos.GetKichcos();
        }

        public List<Kieudang> GetKieudangs()
        {
            return _repos.GetKieudangs();
        }

        public List<Mausac> GetMausacs()
        {
            return _repos.GetMausacs();
        }

        public List<Taikhoan> GetTaikhoan()
        {
            return _repos.GetTaikhoan();
        }

        public List<Thuonghieu> GetThuonghieu()
        {
            return _repos.GetThuonghieu();
        }
    }
}
