using B_Bussiness_Layer.IServies;
using C_Data_Access_Layer.Models;
using C_Data_Access_Layer.Models.ModelRefer;
using C_Data_Access_Layer.Repostories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_Bussiness_Layer.Services
{
    public class GIAYDTO :IChiTietGiayDTOService
    {
        GiayChiTietDTORepostory _giayChiTietDTOrepo;
        public GIAYDTO()
        {
            _giayChiTietDTOrepo = new();
        }
        public List<Giay_ChiTietGiay> GetAll(string? txtTimKiem, string? searchType)
        {
            return _giayChiTietDTOrepo.GetAll(txtTimKiem, searchType);
        }
        public Giay_ChiTietGiay GetById(int? id)
        {
            return _giayChiTietDTOrepo.GetById(id);

        }
    }
}
