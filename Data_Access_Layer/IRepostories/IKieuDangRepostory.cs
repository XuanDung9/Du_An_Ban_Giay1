using C_Data_Access_Layer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Data_Access_Layer.IRepostories
{
    public interface IKieuDangRepostory
    {
        public List<Kieudang> GetAll(string? txtSearch, string? searchType);
        public Kieudang GetByID(int id);
        public bool Them(Kieudang Kieudang);
        public bool Sua(int id, Kieudang Kieudang);
        public bool Khoa_MoKhoa(int id);
    }
}
