using C_Data_Access_Layer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Data_Access_Layer.IRepostories
{
    public interface IHinhThucThanhToanRepostory
    {
        public List<Hinhthucthanhtoan> GetHinhthucTT(string search);
        public bool AddHTTT(Hinhthucthanhtoan ht);
        public bool UpdateHTTT(Hinhthucthanhtoan ht);
    }
}
