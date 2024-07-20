using C_Data_Access_Layer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_Bussiness_Layer.IServies
{
    public interface IMauSacService
    {
        public List<Mausac> GetAll(string? txtTimKiem, string? searchType);
        public Mausac GetByID(int id);
        public bool Them(Mausac mausac);
        public bool Sua(int id, Mausac mausac);
        public bool Khoa_MoKhoa(int id);
    }
}
