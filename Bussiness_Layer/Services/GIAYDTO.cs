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
    public class GIAYDTO :IChiTietGiayDTOService
    {
        GiayChiTietDTORepostory _giayChiTietDTOrepo = new GiayChiTietDTORepostory();
        public List<GiayChiTietDTO> GetAll(string? txtSearch, string? searchType)
        {
            return _giayChiTietDTOrepo.GetAll(null,null);
        }
    }
}
