using B_Bussiness_Layer.IServies;
using C_Data_Access_Layer.Models;
using C_Data_Access_Layer.Repostories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_Bussiness_Layer.Services
{
    public class GiayChiTietService : IGiayChiTietService
    {
        GiayChiTietRepos giayChiTietRepos;

        public GiayChiTietService()
        {
            giayChiTietRepos = new GiayChiTietRepos();
        }
        public List<Giaychitiet> GetAll(string? txtSearch, string? searchType)
        {
            return giayChiTietRepos.GetAll(txtSearch, searchType);
        }

        public Giaychitiet GetByID(int? id)
        {
            return giayChiTietRepos.GetByID(id);
        }

        public bool Khoa_MoKhoa(int id)
        {
            if (id == 0)
            {
                return false;
            }
            return giayChiTietRepos.Khoa_MoKhoa(id);
        }

        public bool Sua(int? id, Giaychitiet Giaychitiet)
        {
            if (id == 0 || Giaychitiet == null)
            {
                return false;
            }
            else if (Giaychitiet.Magiay == 0 ||
                Giaychitiet.Machatlieu == 0 ||
                Giaychitiet.Mamausac == 0 ||
                Giaychitiet.Makichco == 0 ||
                Giaychitiet.Mathuonghieu == 0 ||
                Giaychitiet.Makieudang == 0 ||
                Giaychitiet.Soluongton < 0 ||
                Giaychitiet.Ngaysua == null ||
                Giaychitiet.Gia < 0 ||
                Giaychitiet.Mota == "")
            {
                return false;
            }
            return giayChiTietRepos.Sua(id, Giaychitiet);
        }

        public bool Them(Giaychitiet Giaychitiet)
        {
            if (Giaychitiet.Magiay == 0 ||
                Giaychitiet.Machatlieu == 0 ||
                Giaychitiet.Mamausac == 0 ||
                Giaychitiet.Makichco == 0 ||
                Giaychitiet.Mathuonghieu == 0 ||
                Giaychitiet.Makieudang == 0 ||
                Giaychitiet.Soluongton <= 0 ||
                Giaychitiet.Ngaytao == null ||
                Giaychitiet.Gia < 0 ||
                Giaychitiet.Mota == "")
            {
                return false;
            }
            return giayChiTietRepos.Them(Giaychitiet);
        }
    }
    
}
