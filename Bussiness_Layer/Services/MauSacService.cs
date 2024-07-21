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
    public class MauSacService : IMauSacService
    {
        MauSacRepostory _Rep;
        public MauSacService()
        {
            _Rep = new MauSacRepostory();
        }
        public List<Mausac> GetAll(string? txtSearch, string? searchType)
        {
            return _Rep.GetAll(txtSearch, searchType);
        }

        public Mausac GetByID(int id)
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

        public bool Sua(int id, Mausac Mausac)
        {
            if (id == 0 || id == null)
            {
                return false;
            }
            else if (Mausac == null)
            {
                return false;
            }
            else if (Mausac.Tenmausac == "" || Mausac.Mota == "")
            {
                return false;
            }

            return _Rep.Sua(id, Mausac);
        }

        public bool Them(Mausac Mausac)
        {
            if (Mausac == null)
            {
                return false;
            }
            else if (Mausac.Tenmausac == "" || Mausac.Mota == "")
            {
                return false;
            }
            else if (Mausac.Mataikhoan == 0 || Mausac.Mataikhoan == null)
            {
                return false;
            }
            else if (!Regex.IsMatch(Mausac.Tenmausac, @"^[a-zA-Z0-9]+$"))
            {
                throw new ArgumentException("Tên không được chứa ký tự đặc biệt.");
            }

            return _Rep.Them(Mausac);
        }
    }
}
