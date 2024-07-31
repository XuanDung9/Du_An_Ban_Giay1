using C_Data_Access_Layer.IRepostories;
using C_Data_Access_Layer.Context;
using C_Data_Access_Layer.Models;
using C_Data_Access_Layer.Models.ModelRefer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Data_Access_Layer.Repositories
{
    public class HoaDonRepository : IHoaDonRepository
    {
        DBContext _db;
        public HoaDonRepository()
        {
            _db = new DBContext();
        }
        public List<HoaDon_Model> GetAll(string? txtTimKiem, string? searchType)
        {
            if (string.Equals(searchType, SearchType.trangThaiHoaDon))
            {
                return _db.Hoadons.Where(a => a.Trangthai == bool.Parse(txtTimKiem))
                        .Select(c => new HoaDon_Model()
                        {
                            Hoadon = c,
                            tenTaiKhoan = c.Mataikhoan == null ? "N/A" : _db.Taikhoans.FirstOrDefault(ph => ph.Mataikhoan == c.Mataikhoan)!.Hoten,
                            tenUuDai = c.Mauudai == null ? "N/A" : _db.Uudais.FirstOrDefault(ph => ph.Mauudai == c.Mauudai)!.Tenuudai,
                            tenKhachHang = c.Makhachhang == null ? "N/A" : _db.Khachhangs.FirstOrDefault(ph => ph.Makhachhang == c.Makhachhang)!.Tenkhachhang,
                            diemKhachHang = _db.Khachhangs.FirstOrDefault(ph => ph.Makhachhang == c.Makhachhang)!.Diemkhachhang,
                            tenHinhThucThanhToan = c.Mahinhthucthanhtoan == null ? "N/A" : _db.Hinhthucthanhtoans.FirstOrDefault(ph => ph.Mahinhthucthanhtoan == c.Mahinhthucthanhtoan)!.Tenhinhthuc,
                        }).ToList();
            }
            if (string.Equals(searchType, SearchType.maHoaDon))
            {
                return _db.Hoadons.Where(a => a.Mahoadon == int.Parse(txtTimKiem))
                        .Select(c => new HoaDon_Model()
                        {
                            Hoadon = c,
                            tenTaiKhoan = c.Mataikhoan == null ? "N/A" : _db.Taikhoans.FirstOrDefault(ph => ph.Mataikhoan == c.Mataikhoan)!.Hoten,
                            tenUuDai = c.Mauudai == null ? "N/A" : _db.Uudais.FirstOrDefault(ph => ph.Mauudai == c.Mauudai)!.Tenuudai,
                            tenKhachHang = c.Makhachhang == null ? "N/A" : _db.Khachhangs.FirstOrDefault(ph => ph.Makhachhang == c.Makhachhang)!.Tenkhachhang,
                            diemKhachHang = _db.Khachhangs.FirstOrDefault(ph => ph.Makhachhang == c.Makhachhang)!.Diemkhachhang,
                            tenHinhThucThanhToan = c.Mahinhthucthanhtoan == null ? "N/A" : _db.Hinhthucthanhtoans.FirstOrDefault(ph => ph.Mahinhthucthanhtoan == c.Mahinhthucthanhtoan)!.Tenhinhthuc,
                        }).ToList();
            }

            return _db.Hoadons
                .Select(c => new HoaDon_Model()
                {
                    Hoadon = c,
                    tenTaiKhoan = c.Mataikhoan == null ? "N/A" : _db.Taikhoans.FirstOrDefault(ph => ph.Mataikhoan == c.Mataikhoan)!.Hoten,
                    tenUuDai = c.Mauudai == null ? "N/A" : _db.Uudais.FirstOrDefault(ph => ph.Mauudai == c.Mauudai)!.Tenuudai,
                    tenKhachHang = c.Makhachhang == null ? "N/A" : _db.Khachhangs.FirstOrDefault(ph => ph.Makhachhang == c.Makhachhang)!.Tenkhachhang,
                    tenHinhThucThanhToan = c.Mahinhthucthanhtoan == null ? "N/A" : _db.Hinhthucthanhtoans.FirstOrDefault(ph => ph.Mahinhthucthanhtoan == c.Mahinhthucthanhtoan)!.Tenhinhthuc,
                }).ToList();

        }

        public Hoadon GetByID(int id)
        {
            return _db.Hoadons.FirstOrDefault(a => a.Mahoadon == id);
        }

        public bool Sua(int id, Hoadon hoadon)
        {
            try
            {
                var Obj = _db.Hoadons.FirstOrDefault(a => a.Mahoadon == id);
                if (Obj == null) { return false; }

                Obj.Mataikhoan = hoadon.Mataikhoan;
                Obj.Mauudai = hoadon.Mauudai;
                Obj.Makhachhang = hoadon.Makhachhang;
                Obj.Mahinhthucthanhtoan = hoadon.Mahinhthucthanhtoan;
                Obj.Tongtien = hoadon.Tongtien;
                Obj.Ghichu = hoadon.Ghichu;

                _db.Hoadons.Update(Obj);
                _db.SaveChanges();
                return true;

            }
            catch { return false; }
        }
        public List<Giaychitiet> GetGiaychitiets()
        {
            return _db.Giaychitiets.ToList();
        }

        public bool Them(Hoadon hoadon)
        {
            try
            {
                _db.Hoadons.Add(hoadon);
                _db.SaveChanges();

                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                Console.WriteLine("Inner Exception: " + e.InnerException.Message);
                return false;
            }
        }

        public bool Xoa(int id)
        {
            try
            {
                var existedObj = _db.Hoadons.FirstOrDefault(a => a.Mahoadon == id);

                if (existedObj == null) return false;

                _db.Hoadons.Remove(existedObj);
                _db.SaveChanges();

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Thông tin chi tiết: {ex.ToString()}");
                Console.WriteLine("Inner Exception: " + ex.InnerException.Message);
                return false;

            }
        }
        public List<Hinhthucthanhtoan> GetHinhthucthanhtoans()
        {
            return _db.Hinhthucthanhtoans.ToList();
        }
        public List<Hoadonchitiet> GetHoadonchitiets()
        {

            return _db.Hoadonchitiets.ToList();
        }
        public List<HoaDonNhe> hoaDonNhes(string searchText, string searchType)
        {
            var query = _db.Hoadons
                .Select(c => new HoaDonNhe()
                {
                    Hoadone = c,
                    tenkhachhang = c.Makhachhang == null ? "N/A" : _db.Khachhangs.FirstOrDefault(cn => cn.Makhachhang == c.Makhachhang)!.Tenkhachhang,
                    sdtkhach = c.Makhachhang == null ? "N/A" : _db.Khachhangs.FirstOrDefault(cn => cn.Makhachhang == c.Makhachhang)!.Sdt.ToString(),
                    hovatentaikhoan = c.Mataikhoan == null ? "N/A" : _db.Taikhoans.FirstOrDefault(cn => cn.Mataikhoan == c.Mataikhoan)!.Hoten,
                    tenhinhthuc = c.Mahinhthucthanhtoan == null ? "N/A" : _db.Hinhthucthanhtoans.FirstOrDefault(cn => cn.Mahinhthucthanhtoan == c.Mahinhthucthanhtoan)!.Tenhinhthuc
                });

            switch (searchType)
            {
                case SearchType.tenkhach:
                    query = query.Where(c => c.tenkhachhang.Contains(searchText));
                    break;
                case SearchType.SDTkhach:
                    query = query.Where(c => c.sdtkhach.Contains(searchText));
                    break;
                case SearchType.TenTaikhoan:
                    query = query.Where(c => c.hovatentaikhoan.Contains(searchText));
                    break;
                case SearchType.tatca:
                    query = query.Where(c => c.tenkhachhang.Contains(searchText) ||
                                             c.sdtkhach.Contains(searchText) ||
                                             c.hovatentaikhoan.Contains(searchText));
                    break;
                default:
                    // Có thể thêm các loại tìm kiếm khác nếu cần
                    break;
            }

            return query.ToList();
        }


        public List<Giay> GetGiays()
        {
            return _db.Giays.ToList();
        }

        public List<Hoadon> GetHoadons(string search)
        {
            return _db.Hoadons.ToList();
        }

        public List<Khachhang> GetKhachhangs()
        {
            return _db.Khachhangs.ToList();
        }

        public List<Taikhoan> GetTaikhoans()
        {
            return _db.Taikhoans.ToList();
        }

        public List<Uudai> GetUudais()
        {
            return _db.Uudais.ToList();
        }

    }
}
