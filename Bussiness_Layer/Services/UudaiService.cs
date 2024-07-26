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
    public class UudaiService : IUudaiService
    {
        UudaiRepos _repos;
        public UudaiService()
        {
            _repos = new UudaiRepos();
        }
        public string AddUudai(Uudai uudai)
        {
            try
            {
                _repos.AddUudai(uudai);
                return "Thêm thành công";
            }
            catch
            {
                return "Thêm thất bại";
            }
        }

        public List<Taikhoan> GetTaikhoan()
        {
            return _repos.GetTaikhoan();
        }

        public List<Uudai> GetUudais(string search)
        {
            return _repos.GetUudais(search);
        }

        public string Trangthai(Uudai uudai)
        {
            var coler = _repos.GetUudais(null).FirstOrDefault(x => x.Mauudai == uudai.Mauudai);
            if (coler == null)
            {
                return "Kết thúc thất bại";
            }
            else
            {
                return "Sản phẩm đã kết thúc rồi";
            }
        }
        public string Updateuudai(Uudai uudai)
        {
            var coler = _repos.GetUudais(null).FirstOrDefault(x => x.Mauudai == uudai.Mauudai);
            try
            {
                if (coler == null)
                {
                    return "Sửa thất bại";
                }
                else
                {
                    coler.Mataikhoan = uudai.Mataikhoan;
                    coler.Tenuudai = uudai.Tenuudai;
                    coler.Soluong = uudai.Soluong;
                    coler.Ngaybatdau = uudai.Ngaybatdau;
                    coler.Ngayketthuc = uudai.Ngayketthuc;
                    coler.Trangthai = uudai.Trangthai;
                    _repos.Updateuudai(coler);
                    return "Sửa thành công";
                }
            }
            catch (Exception)
            {

                return "Có lỗi xảy ra";
            }

        }
        public Uudai GetUudai_InTime()
        {
            return _repos.GetUudai_InTime();
        }
    }
}
