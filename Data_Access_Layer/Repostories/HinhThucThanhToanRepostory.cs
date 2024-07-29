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
    public class HinhThucThanhToanRepostory: IHinhThucThanhToanRepostory
    {
        DBContext dbContext ;
        public HinhThucThanhToanRepostory()
        {
            dbContext = new DBContext();
        }
        public bool AddHTTT(Hinhthucthanhtoan ht)
        {
            dbContext.Add(ht);
            dbContext.SaveChanges();
            return true;
        }

        public List<Hinhthucthanhtoan> GetHinhthucTT(string search)
        {
            if (search == null)
            {
                return dbContext.Hinhthucthanhtoans.ToList();
            }
            else
            {
                return dbContext.Hinhthucthanhtoans.Where(x => x.Tenhinhthuc.StartsWith(search)).ToList(); // Tên hình thức được tìm kiếm dựa theo kí tự bắt đầu bằng chuỗi "search"
            }
        }

        public bool UpdateHTTT(Hinhthucthanhtoan ht)
        {
            dbContext.Update(ht);
            dbContext.SaveChanges();
            return true;
        }
    }
}
