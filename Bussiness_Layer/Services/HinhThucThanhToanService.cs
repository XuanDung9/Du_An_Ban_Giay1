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
    public class HinhThucThanhToanService:IHinhThucThanhToanService
    {
        HinhThucThanhToanRepostory _repos;
        public HinhThucThanhToanService()
        {
            _repos = new HinhThucThanhToanRepostory();
        }
        public string AddHTTT(Hinhthucthanhtoan ht)
        {
            try
            {
                _repos.AddHTTT(ht);
                return "Thêm thành công";
            }
            catch (Exception)
            {

                return "Thêm thất bại";
            }
        }

        public List<Hinhthucthanhtoan> GetHinhthucTT(string search)
        {
            return _repos.GetHinhthucTT(search);
        }

        public string UpdateHTTT(Hinhthucthanhtoan ht)
        {
            var thanhToan = _repos.GetHinhthucTT(null).FirstOrDefault(x => x.Mahinhthucthanhtoan == ht.Mahinhthucthanhtoan);
            try
            {
                if (thanhToan != null)
                {
                    thanhToan.Tenhinhthuc = ht.Tenhinhthuc;
                    _repos.UpdateHTTT(thanhToan);
                    return "Sửa thành công";
                }
                else
                {
                    return "Sửa thất bại";
                }
            }
            catch (Exception)
            {

                return "Có lỗi xảy ra";
            }

        }
    }
}
