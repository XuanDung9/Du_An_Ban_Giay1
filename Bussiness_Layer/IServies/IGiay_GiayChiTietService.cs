using C_Data_Access_Layer.Models.ModelRefer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_Bussiness_Layer.IServies
{
    public interface IGiay_GiayChiTietService
    {
        public List<Giay_ChiTietGiay> GetAll(string? txtTimKiem, string? searchType);
        public Giay_ChiTietGiay GetById(int? id);
    }
}
