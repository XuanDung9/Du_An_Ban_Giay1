using C_Data_Access_Layer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Data_Access_Layer.IRepostories
{
    public interface IUudaiRepos
    {
        public List<Uudai> GetUudais(string search);
        public List<Taikhoan> GetTaikhoan();
        public bool AddUudai(Uudai uudai);
        public bool Updateuudai(Uudai uudai);
        public bool Trangthai(Uudai uudai);
        public Uudai GetUudai_InTime();
    }
}
