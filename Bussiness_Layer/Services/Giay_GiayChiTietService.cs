using B_Bussiness_Layer.IServies;
using C_Data_Access_Layer.Models.ModelRefer;
using C_Data_Access_Layer.Repostories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_Bussiness_Layer.Services
{
    public class Giay_GiayChiTietService: IGiay_GiayChiTietService
    {
        Giay_ChiTietGiayRepostory _Rep;
        public Giay_GiayChiTietService()
        {
            _Rep = new();
        }
        public List<Giay_ChiTietGiay> GetAll(string? txtTimKiem, string? searchType)
        {
            return _Rep.GetAll(txtTimKiem, searchType);
        }
        public Giay_ChiTietGiay GetById(int? id)
        {
            return _Rep.GetById(id);

        }
    }
}
