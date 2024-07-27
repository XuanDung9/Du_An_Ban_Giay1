using C_Data_Access_Layer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_Bussiness_Layer.IServies
{
    public interface INhanvienService
    {
        public List<Taikhoan> GetTaikhoan(string search);
        public List<Chucvu> GetChucvu();
        public string AddNhanVien(Taikhoan taikhoan);
        public string UpdateNhanVien(Taikhoan taikhoan);
        public string Khoa_Mokhoa(Taikhoan taikhoan);
    }
}
