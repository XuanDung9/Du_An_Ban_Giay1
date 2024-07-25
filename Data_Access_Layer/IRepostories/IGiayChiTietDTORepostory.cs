using C_Data_Access_Layer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Data_Access_Layer.IRepostories
{
    public interface IGiayChiTietDTORepostory
    {
        public List<GiayChiTietDTO> GetAll(string? txtSearch, string? searchType);
    }
}
