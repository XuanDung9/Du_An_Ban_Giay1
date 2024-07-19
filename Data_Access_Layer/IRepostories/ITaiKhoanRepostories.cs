using C_Data_Access_Layer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Data_Access_Layer.IRepostories
{
    public interface ITaiKhoanRepostories
    {
        public List<Taikhoan> GetAll(string? searchText, string? searchType);
        public bool Sua(int? id, Taikhoan taikhoan);
    }
}
