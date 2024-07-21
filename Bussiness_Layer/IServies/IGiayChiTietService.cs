using C_Data_Access_Layer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_Bussiness_Layer.IServies
{
    public interface IGiayChiTietService
    {
        public List<Giaychitiet> GetAll(string? txtSearch, string? searchType);
        public Giaychitiet GetByID(int? id);
        public bool Them(Giaychitiet Giaychitiet);
        public bool Sua(int? id, Giaychitiet Giaychitiet);
        public bool Khoa_MoKhoa(int id);
    }
}
