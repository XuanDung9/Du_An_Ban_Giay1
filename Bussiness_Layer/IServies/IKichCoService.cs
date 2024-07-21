using C_Data_Access_Layer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_Bussiness_Layer.IServies
{
    public interface IKichCoService
    {
        public List<Kichco> GetAll(string? txtTimKiem, string? searchType);
        public Kichco GetByID(int id);
        public bool Them(Kichco kichco);
        public bool Sua(int id, Kichco kichco);
        public bool Khoa_MoKhoa(int id);
    }
}
