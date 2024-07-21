using C_Data_Access_Layer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Data_Access_Layer.IRepostories
{
    public interface IThuongHieuRepostory
    {
        public List<Thuonghieu> GetAll(string? txtTimKiem, string? searchType);
        public Thuonghieu GetByID(int id);
        public bool Them(Thuonghieu thuonghieu);
        public bool Sua(int id, Thuonghieu thuonghieu);
        public bool Khoa_MoKhoa(int id);
    }
}
