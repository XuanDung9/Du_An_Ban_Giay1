using C_Data_Access_Layer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_Bussiness_Layer.IServies
{
    public interface IChiTietGiayDTOService
    {
        public List<GiayChiTietDTO> GetAll(string? txtSearch, string? searchType);
    }
}
