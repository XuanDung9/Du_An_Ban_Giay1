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
    public class TaiKhoanService: ITaiKhoanService
    {
        TaiKhoanRepostories _repo;
        public TaiKhoanService()
        {
            _repo = new TaiKhoanRepostories();
        }
        public List<Taikhoan> GetAll(string? txtSearch, string? SearchType)
        {
            return _repo.GetAll(txtSearch, SearchType);
        }

        public bool Sua(int? id, Taikhoan taikhoan)
        {
            return _repo.Sua(id, taikhoan);
        }
    }
}
