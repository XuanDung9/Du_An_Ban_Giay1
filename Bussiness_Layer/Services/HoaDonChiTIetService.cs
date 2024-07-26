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
    public class HoaDonChiTIetService : IHoaDonChiTietService
    {
        HoaDonChiTietRepository _Rep;
        public HoaDonChiTIetService()
        {
            _Rep = new HoaDonChiTietRepository();
        }
        public List<HoaDonChiTiet_SP> GetAll(string? txtTimKiem, string? searchType)
        {
            return _Rep.GetAll(txtTimKiem, searchType);
        }

        public Hoadonchitiet GetByID(int? id)
        {
            return _Rep.GetByID(id);
        }

        public bool Sua(int? id, Hoadonchitiet hoadonchitiet)
        {
            return _Rep.Sua(id, hoadonchitiet);
        }

        public bool Them(Hoadonchitiet hoadonchitiet)
        {
            return _Rep.Them(hoadonchitiet);
        }

        public bool Xoa(int? id)
        {
            return _Rep.Xoa(id);
        }
    }
}
