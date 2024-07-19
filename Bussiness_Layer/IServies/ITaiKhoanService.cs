using C_Data_Access_Layer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_Bussiness_Layer.IServies
{
    public interface ITaiKhoanService
    {
        public List<Taikhoan> GetAll(string? txtSearch, string? SearchType);
        public bool Sua(int? id, Taikhoan taikhoan);
    }
}
