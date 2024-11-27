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
    public class UudaiRepos : IUudaiRepos
    {
        DuAnBanGiay1Context dbContext;

        public UudaiRepos()
        {
            dbContext = new DuAnBanGiay1Context();
        }
        public bool AddUudai(Uudai uudai)
        {
            dbContext.Add(uudai);
            dbContext.SaveChanges();
            return true;
        }

        public List<Taikhoan> GetTaikhoan()
        {
            return dbContext.Taikhoans.ToList();
        }

        public List<Uudai> GetUudais(string search)
        {
            if (search == null)
            {
                return dbContext.Uudais.ToList();
            }
            else
            {
                return dbContext.Uudais.Where(x => x.Mauudai.ToString().StartsWith(search) || x.Tenuudai.StartsWith(search)).ToList();
            }
        }

        public bool Trangthai(Uudai uudai)
        {
            dbContext.Update(uudai);
            dbContext.SaveChanges();
            return true;
        }

        public bool Updateuudai(Uudai uudai)
        {
            dbContext.Update(uudai);
            dbContext.SaveChanges();
            return true;
        }
        public Uudai GetUudai_InTime()
        {
            DateTime now = DateTime.Now;

            var obj = dbContext.Uudais.Where(a => a.Ngaybatdau <= now && a.Ngayketthuc >= now && a.Trangthai == 2).FirstOrDefault();
            if (obj == null)
            {
                return dbContext.Uudais.Where(a => a.Mauudai == 1).FirstOrDefault();
            }
            return obj;
        }
    }
}
