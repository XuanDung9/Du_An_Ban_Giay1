using C_Data_Access_Layer.Context;
using C_Data_Access_Layer.IRepostories;
using C_Data_Access_Layer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Data_Access_Layer.Repostories
{
    public class KhachHangRepos : IKhachHangRepos
    {
        DuAnBanGiay1Context dbContext;

        public KhachHangRepos()
        {
            dbContext = new DuAnBanGiay1Context();
        }
        public bool AddKhachHang(Khachhang khachhang)
        {
            dbContext.Add(khachhang);
            dbContext.SaveChanges();
            return true;
        }

        public List<Hoadon> GetAllHoadon()
        {
            return dbContext.Hoadons.ToList();
        }

        public List<Khachhang> GetAllKhachhang(string search)
        {
            if (string.IsNullOrEmpty(search))
            {
                return dbContext.Khachhangs.ToList();
            }
            else
            {
                return dbContext.Khachhangs.Where(x => x.Sdt.ToString().StartsWith(search)).ToList();
            }
        }

        public List<Hinhthucthanhtoan> GetHinhthucthanhtoans()
        {
            return dbContext.Hinhthucthanhtoans.ToList();
        }

        public bool UpdateKhachHang(Khachhang khachhang)
        {
            dbContext.Update(khachhang);
            dbContext.SaveChanges();
            return true;
        }
        public List<Hoadon> GetHoadonsByKhachHangId(int khachHangId)
        {
            return dbContext.Hoadons.Where(h => h.Makhachhang == khachHangId).ToList();
        }
    }
}
