using C_Data_Access_Layer.Models;
using C_Data_Access_Layer.Models.ModelRefer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Data_Access_Layer.IRepostories
{
    public interface IGiayChiTietDTORepostory
    {
        public List<Giay_ChiTietGiay> GetAll(string? txtSearch, string? searchType);
        public Giay_ChiTietGiay GetById(int? id);
    }
}
