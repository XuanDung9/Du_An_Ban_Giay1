using B_Bussiness_Layer.IServies;
using C_Data_Access_Layer.Models;
using C_Data_Access_Layer.Repostories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace B_Bussiness_Layer.Services
{
    public class ThuongHieuService : IThuongHieuService
    {
        ThuongHieuRepostory _Rep;
        public ThuongHieuService()
        {
            _Rep = new ThuongHieuRepostory();
        }

        public List<Thuonghieu> GetAll(string? txtSearch, string? searchType)
        {
            return _Rep.GetAll(txtSearch, searchType);
        }

        public Thuonghieu GetByID(int id)
        {
            return _Rep.GetByID(id);
        }

        public bool Khoa_MoKhoa(int id)
        {
            if (id == 0 || id == null)
            {
                return false;
            }

            return _Rep.Khoa_MoKhoa(id);
        }

        public bool Sua(int id, Thuonghieu Thuonghieu)
        {
            if (id == 0)
            {
                return false;
            }
            else if (Thuonghieu == null)
            {
                return false;
            }
            else if (Thuonghieu.Tenthuonghieu == "" || Thuonghieu.Mota == "" || Thuonghieu.Mataikhoan ==0)
            {
                return false;
            }

            return _Rep.Sua(id, Thuonghieu);
        }

        public bool Them(Thuonghieu Thuonghieu)
        {
            if (Thuonghieu == null)
            {
                return false;
            }
            else if (Thuonghieu.Tenthuonghieu == "" || Thuonghieu.Mota == "" ||Thuonghieu.Mataikhoan == 0)
            {
                return false;
            }


            return _Rep.Them(Thuonghieu);
        }
    }
}
