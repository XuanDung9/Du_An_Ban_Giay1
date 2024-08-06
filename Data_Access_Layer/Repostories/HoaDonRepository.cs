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
        DuAnBanGiay1Context _db;
        public HoaDonRepository()
        {
            _db = new DuAnBanGiay1Context();
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
                if (Obj == null)
                {
                    Console.WriteLine($"Không tìm thấy hóa đơn với mã {id}");
                    return false;
                }

                // In các giá trị trước khi cập nhật để kiểm tra
                Console.WriteLine($"Trước cập nhật: Makhachhang={Obj.Makhachhang}, Mauudai={Obj.Mauudai}, Mahinhthucthanhtoan={Obj.Mahinhthucthanhtoan}, Tongtien={Obj.Tongtien}, Ghichu={Obj.Ghichu}, Trangthai={Obj.Trangthai}");

                Obj.Makhachhang = hoadon.Makhachhang;
                Obj.Mauudai = hoadon.Mauudai;
                Obj.Mahinhthucthanhtoan = hoadon.Mahinhthucthanhtoan;
                Obj.Tongtien = hoadon.Tongtien;
                Obj.Ghichu = hoadon.Ghichu;
                Obj.Trangthai = hoadon.Trangthai;

                // In các giá trị sau khi cập nhật để kiểm tra
                Console.WriteLine($"Sau cập nhật: Makhachhang={Obj.Makhachhang}, Mauudai={Obj.Mauudai}, Mahinhthucthanhtoan={Obj.Mahinhthucthanhtoan}, Tongtien={Obj.Tongtien}, Ghichu={Obj.Ghichu}, Trangthai={Obj.Trangthai}");

                _db.Hoadons.Update(Obj);
                _db.SaveChanges();

                // Kiểm tra xem SaveChanges có trả về kết quả không mong muốn không
                Console.WriteLine("SaveChanges thành công");
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Có lỗi xảy ra khi cập nhật hóa đơn: {ex.Message}");
                return false;
            }
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
        public List<Hoadonchitiet> GetHoadonchitietsById(int hdctId)
        {
            return _db.Hoadonchitiets.Where(h => h.Mahoadon == hdctId).ToList();
        }
        public List<HoaDonNhe> hoaDonNhes(string searchText, string searchType)
        {
            //var query = _db.Hoadons
            //    .Select(c => new HoaDonNhe()
            //    {
            //        Hoadone = c,
            //        tenkhachhang = c.Makhachhang == null ? "N/A" : _db.Khachhangs.FirstOrDefault(cn => cn.Makhachhang == c.Makhachhang)!.Tenkhachhang,
            //        sdtkhach = c.Makhachhang == null ? "N/A" : _db.Khachhangs.FirstOrDefault(cn => cn.Makhachhang == c.Makhachhang)!.Sdt.ToString(),
            //        hovatentaikhoan = c.Mataikhoan == null ? "N/A" : _db.Taikhoans.FirstOrDefault(cn => cn.Mataikhoan == c.Mataikhoan)!.Hoten,
            //        tenhinhthuc = c.Mahinhthucthanhtoan == null ? "N/A" : _db.Hinhthucthanhtoans.FirstOrDefault(cn => cn.Mahinhthucthanhtoan == c.Mahinhthucthanhtoan)!.Tenhinhthuc
            //    });

            //switch (searchType)
            //{
            //    case SearchType.tenkhach:
            //        query = query.Where(c => c.tenkhachhang.Contains(searchText));
            //        break;
            //    case SearchType.SDTkhach:
            //        query = query.Where(c => c.sdtkhach.Contains(searchText));
            //        break;
            //    case SearchType.TenTaikhoan:
            //        query = query.Where(c => c.hovatentaikhoan.Contains(searchText));
            //        break;
            //    case SearchType.tatca:
            //        query = query.Where(c => c.tenkhachhang.Contains(searchText) ||
            //                                 c.sdtkhach.Contains(searchText) ||
            //                                 c.hovatentaikhoan.Contains(searchText));
            //        break;
            //    default:
            //        // Có thể thêm các loại tìm kiếm khác nếu cần
            //        break;
            //}

            //return query.ToList();
            
                if (string.Equals(searchType, SearchType.tenkhach))
                {
                    return _db.Hoadons
                        .Select(c => new HoaDonNhe()
                        {
                            Hoadone = c,
                            tenkhachhang = c.Makhachhang == null ? "N/A" : _db.Khachhangs.FirstOrDefault(cn => cn.Makhachhang == c.Makhachhang)!.Tenkhachhang,
                            sdtkhach = c.Makhachhang == null ? "N/A" : _db.Khachhangs.FirstOrDefault(cn => cn.Makhachhang == c.Makhachhang)!.Sdt.ToString(),
                            hovatentaikhoan = c.Mataikhoan == null ? "N/A" : _db.Taikhoans.FirstOrDefault(cn => cn.Mataikhoan == c.Mataikhoan)!.Hoten,
                            tenhinhthuc = c.Mahinhthucthanhtoan == null ? "N/A" : _db.Hinhthucthanhtoans.FirstOrDefault(cn => cn.Mahinhthucthanhtoan == c.Mahinhthucthanhtoan)!.Tenhinhthuc

                        })
                        .Where(c => c.tenkhachhang.Contains(searchText)).ToList();
                }
                if (string.Equals(searchType, SearchType.SDTkhach))
                {
                    return _db.Hoadons
                        .Select(c => new HoaDonNhe()
                        {
                            Hoadone = c,
                            tenkhachhang = c.Makhachhang == null ? "N/A" : _db.Khachhangs.FirstOrDefault(cn => cn.Makhachhang == c.Makhachhang)!.Tenkhachhang,
                            sdtkhach = c.Makhachhang == null ? "N/A" : _db.Khachhangs.FirstOrDefault(cn => cn.Makhachhang == c.Makhachhang)!.Sdt.ToString(),
                            hovatentaikhoan = c.Mataikhoan == null ? "N/A" : _db.Taikhoans.FirstOrDefault(cn => cn.Mataikhoan == c.Mataikhoan)!.Hoten,
                            tenhinhthuc = c.Mahinhthucthanhtoan == null ? "N/A" : _db.Hinhthucthanhtoans.FirstOrDefault(cn => cn.Mahinhthucthanhtoan == c.Mahinhthucthanhtoan)!.Tenhinhthuc
                        })
                        .Where(c => c.sdtkhach.Contains(searchText)).ToList();
                }
                if (string.Equals(searchType, SearchType.TenTaikhoan))
                {
                    return _db.Hoadons
                        .Select(c => new HoaDonNhe()
                        {
                            Hoadone = c,
                            tenkhachhang = c.Makhachhang == null ? "N/A" : _db.Khachhangs.FirstOrDefault(cn => cn.Makhachhang == c.Makhachhang)!.Tenkhachhang,
                            sdtkhach = c.Makhachhang == null ? "N/A" : _db.Khachhangs.FirstOrDefault(cn => cn.Makhachhang == c.Makhachhang)!.Sdt.ToString(),
                            hovatentaikhoan = c.Mataikhoan == null ? "N/A" : _db.Taikhoans.FirstOrDefault(cn => cn.Mataikhoan == c.Mataikhoan)!.Hoten,
                            tenhinhthuc = c.Mahinhthucthanhtoan == null ? "N/A" : _db.Hinhthucthanhtoans.FirstOrDefault(cn => cn.Mahinhthucthanhtoan == c.Mahinhthucthanhtoan)!.Tenhinhthuc
                        })
                        .Where(c => c.hovatentaikhoan.Contains(searchText)).ToList();
                }
                if (string.Equals(searchType, SearchType.tatca))
                {
                    return _db.Hoadons
                        .Select(c => new HoaDonNhe()
                        {
                            Hoadone = c,
                            tenkhachhang = c.Makhachhang == null ? "N/A" : _db.Khachhangs.FirstOrDefault(cn => cn.Makhachhang == c.Makhachhang)!.Tenkhachhang,
                            sdtkhach = c.Makhachhang == null ? "N/A" : _db.Khachhangs.FirstOrDefault(cn => cn.Makhachhang == c.Makhachhang)!.Sdt.ToString(),
                            hovatentaikhoan = c.Mataikhoan == null ? "N/A" : _db.Taikhoans.FirstOrDefault(cn => cn.Mataikhoan == c.Mataikhoan)!.Hoten,
                            tenhinhthuc = c.Mahinhthucthanhtoan == null ? "N/A" : _db.Hinhthucthanhtoans.FirstOrDefault(cn => cn.Mahinhthucthanhtoan == c.Mahinhthucthanhtoan)!.Tenhinhthuc
                        })
                        .Where(c => c.hovatentaikhoan.Contains(searchText) || c.sdtkhach.Contains(searchText) || c.tenkhachhang.Contains(searchText)).ToList();
                }

                var query = _db.Hoadons.AsQueryable();
                if (!string.IsNullOrEmpty(searchType))
                {
                    query = query
                        .Where(x => x.Mahinhthucthanhtoan != null &&
                                    _db.Hinhthucthanhtoans.Any(cn => cn.Mahinhthucthanhtoan == x.Mahinhthucthanhtoan &&
                                                                            (string.Equals(cn.Tenhinhthuc, searchType))));
                }
                var result = query
                    .Select(x => new HoaDonNhe()
                    {
                        Hoadone = x,
                        tenkhachhang = x.Makhachhang == null ? "N/A" : _db.Khachhangs.FirstOrDefault(cn => cn.Makhachhang == x.Makhachhang)!.Tenkhachhang,
                        sdtkhach = x.Makhachhang == null ? "N/A" : _db.Khachhangs.FirstOrDefault(cn => cn.Makhachhang == x.Makhachhang)!.Sdt.ToString(),
                        hovatentaikhoan = x.Mataikhoan == null ? "N/A" : _db.Taikhoans.FirstOrDefault(cn => cn.Mataikhoan == x.Mataikhoan)!.Hoten,
                        tenhinhthuc = x.Mahinhthucthanhtoan == null ? "N/A" : _db.Hinhthucthanhtoans.FirstOrDefault(cn => cn.Mahinhthucthanhtoan == x.Mahinhthucthanhtoan)!.Tenhinhthuc
                    })
                    .ToList();

                return result;
            
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
