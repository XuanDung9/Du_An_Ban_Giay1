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
    public class NhanVienRepository : INhanVienRepository
    {
        DuAnBanGiay1Context dbContext;
        public NhanVienRepository()
        {
            dbContext = new DuAnBanGiay1Context();
        }
        public bool AddNhanVien(Taikhoan taikhoan)
        {
            dbContext.Add(taikhoan);
            dbContext.SaveChanges();
            return true;
        }

        public List<Chucvu> GetChucvu()
        {
            return dbContext.Chucvus.ToList();
        }

        public List<Taikhoan> GetTaikhoan(string search)
        {
            if (search == null)
            {
                return dbContext.Taikhoans.ToList();
            }
            else
            {
                return dbContext.Taikhoans.Where(x => x.Mataikhoan.ToString().StartsWith(search) || x.Hoten.StartsWith(search) || x.Sdt.ToString().StartsWith(search)).ToList();
            }
        }

        public bool Khoa_Mokhoa(Taikhoan taikhoan)
        {
            dbContext.Update(taikhoan);
            dbContext.SaveChanges();
            return true;
        }

        public bool UpdateNhanVien(Taikhoan taikhoan)
        {
            dbContext.Update(taikhoan);
            dbContext.SaveChanges();
            return true;
        }
    }
}
