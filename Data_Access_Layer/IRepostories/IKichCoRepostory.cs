using C_Data_Access_Layer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Data_Access_Layer.IRepostories
{
    public interface IKichCoRepostory
    {
        public List<Kichco> GetAll(string? txtTimKiem, string? searchType);
        public Kichco GetByID(int id);
        public bool Them(Kichco kichco);
        public bool Sua(int id, Kichco kichco);
        public bool Khoa_MoKhoa(int id);
    }
}
