using C_Data_Access_Layer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_Bussiness_Layer.IServies
{
    internal interface IThuongHieuService
    {
        public List<Thuonghieu> GetAll(string? txtTimKiem, string? searchType);
        public Thuonghieu GetByID(int id);
        public bool Them(Thuonghieu thuonghieu);
        public bool Sua(int id, Thuonghieu thuonghieu);
        public bool Khoa_MoKhoa(int id);
    }
}
