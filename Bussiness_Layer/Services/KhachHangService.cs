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
    public class KhachHangService : IKhachHangService
    {
        private KhachHangRepos _repos;

        public KhachHangService()
        {
            _repos = new KhachHangRepos();
        }
        public string AddKhachHang(Khachhang khachhang)
        {
            try
            {
                _repos.AddKhachHang(khachhang);
                return "Thêm thành công";
            }
            catch
            {
                return "Thêm thất bại";
            }
        }

        public List<Hoadon> GetAllHoadon()
        {
            return _repos.GetAllHoadon();
        }

        public List<Khachhang> GetAllKhachhang(string search)
        {
            return _repos.GetAllKhachhang(search);
        }

        public List<Hinhthucthanhtoan> GetHinhthucthanhtoans()
        {
            return _repos.GetHinhthucthanhtoans();
        }
        public List<Hoadon> GetHoadonsByKhachHangId(int khachHangId)
        {
            return _repos.GetHoadonsByKhachHangId(khachHangId);
        }
        public string Khoa_MoKhoa(Khachhang khachhang)
        {
            var cloer = _repos.GetAllKhachhang(null).FirstOrDefault(x => x.Makhachhang == khachhang.Makhachhang);
            if (cloer == null)
            {
                return "Sửa thất bại";
            }
            else
            {
                if (cloer.Trangthai == true)
                {
                    cloer.Trangthai = false;
                    _repos.UpdateKhachHang(cloer);
                    return "Khoá thành công";
                }
                else if (cloer.Trangthai == false)
                {
                    cloer.Trangthai = true;
                    _repos.UpdateKhachHang(cloer);
                    return "Mở Khoá thành công";
                }
                return "";
            }
        }
        public string UpdateKhachHang(Khachhang khachhang)
        {
            var cloer = _repos.GetAllKhachhang(null).FirstOrDefault(x => x.Makhachhang == khachhang.Makhachhang);
            try
            {
                if (cloer == null)
                {
                    return "Sửa thất bại";
                }
                else
                {
                    cloer.Tenkhachhang = khachhang.Tenkhachhang;
                    cloer.Sdt = khachhang.Sdt;
                    cloer.Diemkhachhang = khachhang.Diemkhachhang;
                    cloer.Trangthai = khachhang.Trangthai;
                    _repos.UpdateKhachHang(cloer);
                    return "Sửa thành công";
                }
            }
            catch
            {
                return "Có lỗi xảy ra";
            }
        }
    }
}
