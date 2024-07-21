using C_Data_Access_Layer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Data_Access_Layer.IRepostories
{
    public interface IChatLieuRepostory
    {
        public List<Chatlieu> GetAll(string? txtSearch, string? searchType);
        public Chatlieu GetByID(int id);
        public bool Them(Chatlieu chatlieu);
        public bool Sua(int id, Chatlieu chatlieu);
        public bool Khoa_MoKhoa(int id);
    }
}
