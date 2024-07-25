using C_Data_Access_Layer.Context;
using C_Data_Access_Layer.IRepostories;
using C_Data_Access_Layer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Data_Access_Layer.Repostories
{
    public class GiayChiTietDTORepostory: IGiayChiTietDTORepostory
    {
        DBContext _db = new DBContext();
        public List<GiayChiTietDTO> GetAll(string? txtSearch, string? searchType)
        {
            return _db.chiTietGiayDTOs.ToList();
        }
    }
}
