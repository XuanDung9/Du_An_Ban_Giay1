using C_Data_Access_Layer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Data_Access_Layer.IRepostories
{
    public interface IMauSacRepostory
    {
        public List<Mausac> GetAll(string? txtTimKiem, string? searchType);
        public Mausac GetByID(int id);
        public bool Them(Mausac mausac);
        public bool Sua(int id, Mausac mausac);
        public bool Khoa_MoKhoa(int id);
    }
}
