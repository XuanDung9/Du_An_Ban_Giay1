using C_Data_Access_Layer.Models;
using C_Data_Access_Layer.Models.ModelRefer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_Bussiness_Layer.IServies
{
    public interface IHoaDonChiTietService
    {
        public List<HoaDonChiTiet_SP> GetAll(string? txtTimKiem, string? searchType);
        public Hoadonchitiet GetByID(int? id);
        public bool Them(Hoadonchitiet hoadonchitiet);
        public bool Sua(int? id, Hoadonchitiet hoadonchitiet);
        public bool Xoa(int? id);
    }
}
