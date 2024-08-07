using C_Data_Access_Layer.Context;
using C_Data_Access_Layer.IRepostories;
using C_Data_Access_Layer.Models;
using C_Data_Access_Layer.Models.ModelRefer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Data_Access_Layer.Repostories
{
    public class Giay_ChiTietGiayRepostory : IGiay_GiayChiTietRepostory
    {
        DuAnBanGiay1Context _db;
        public Giay_ChiTietGiayRepostory()
        {
            _db = new DuAnBanGiay1Context();
        }

        public List<Giay_ChiTietGiay> GetAll(string? txtTimKiem, string? searchType)
        {
            IQueryable<Giaychitiet> query = _db.Giaychitiets;  // sử dụng truy vấn query

            if (!string.IsNullOrEmpty(txtTimKiem) && !string.IsNullOrEmpty(searchType))
            {
                switch (searchType)
                {
                    case "tenGiay":
                        query = query.Where(c => c.Magiay != null && _db.Giays.FirstOrDefault(ph => ph.Magiay == c.Magiay)!.Tengiay.ToLower().Contains(txtTimKiem.ToLower()));
                        break;
                    case "tenThuongHieu":
                        query = query.Where(c => c.Mathuonghieu != null && _db.Thuonghieus.FirstOrDefault(ph => ph.Mathuonghieu == c.Mathuonghieu)!.Tenthuonghieu.ToLower().Contains(txtTimKiem.ToLower()));
                        break;
                    case "tenKieuDang":
                        query = query.Where(c => c.Makieudang != null && _db.Kieudangs.FirstOrDefault(ph => ph.Makieudang == c.Makieudang)!.Tenkieudang.ToLower().Contains(txtTimKiem.ToLower()));
                        break;
                    case "tenKichCo":
                        query = query.Where(c => c.Makichco != null && _db.Kichcos.FirstOrDefault(ph => ph.Makichco == c.Makichco)!.Tenkichco.ToLower().Contains(txtTimKiem.ToLower()));
                        break;
                    case "tenMauSac":
                        query = query.Where(c => c.Mamausac != null && _db.Mausacs.FirstOrDefault(ph => ph.Mamausac == c.Mamausac)!.Tenmausac.ToLower().Contains(txtTimKiem.ToLower()));
                        break;
                    case "tenChatLieu":
                        query = query.Where(c => c.Machatlieu != null && _db.Chatlieus.FirstOrDefault(ph => ph.Machatlieu == c.Machatlieu)!.Tenchatlieu.ToLower().Contains(txtTimKiem.ToLower()));
                        break;
                    default:
                        break;
                }
            }

            return query.Select(c => new Giay_ChiTietGiay()
            {
                giaychitiet = c,
                tenChatLieu = c.Machatlieu == null ? "N/A" : _db.Chatlieus.FirstOrDefault(ph => ph.Machatlieu == c.Machatlieu)!.Tenchatlieu,
                tenMauSac = c.Mamausac == null ? "N/A" : _db.Mausacs.FirstOrDefault(ph => ph.Mamausac == c.Mamausac)!.Tenmausac,
                tenKieuDang = c.Makieudang == null ? "N/A" : _db.Kieudangs.FirstOrDefault(ph => ph.Makieudang == c.Makieudang)!.Tenkieudang,
                tenKichCo = c.Makichco == null ? "N/A" : _db.Kichcos.FirstOrDefault(ph => ph.Makichco == c.Makichco)!.Tenkichco,
                tenGiay = c.Magiay == null ? "N/A" : _db.Giays.FirstOrDefault(ph => ph.Magiay == c.Magiay)!.Tengiay,
                tenThuongHieu = c.Mathuonghieu == null ? "N/A" : _db.Thuonghieus.FirstOrDefault(ph => ph.Mathuonghieu == c.Mathuonghieu)!.Tenthuonghieu,
                soLuongCon = c.Soluongton,
                gia = c.Gia,
            }).ToList();
        }

        public Giay_ChiTietGiay GetById(int? id)
        {
            return _db.Giaychitiets
                .Where(a => a.Magiaychitiet == id)
                .Select(c => new Giay_ChiTietGiay()
                {
                    giaychitiet = c,
                    tenGiay = c.Magiay == null ? "N/A" : _db.Giays.FirstOrDefault(ph => ph.Magiay == c.Magiay)!.Tengiay,
                    tenChatLieu = c.Machatlieu == null ? "N/A" : _db.Chatlieus.FirstOrDefault(ph => ph.Machatlieu == c.Machatlieu)!.Tenchatlieu,
                    tenMauSac = c.Mamausac == null ? "N/A" : _db.Mausacs.FirstOrDefault(ph => ph.Mamausac == c.Mamausac)!.Tenmausac,
                    tenKieuDang = c.Makieudang == null ? "N/A" : _db.Kieudangs.FirstOrDefault(ph => ph.Makieudang == c.Makieudang)!.Tenkieudang,
                    tenKichCo = c.Makichco == null ? "N/A" : _db.Kichcos.FirstOrDefault(ph => ph.Makichco == c.Makichco)!.Tenkichco,
                    tenThuongHieu = c.Mathuonghieu == null ? "N/A" : _db.Thuonghieus.FirstOrDefault(ph => ph.Mathuonghieu == c.Mathuonghieu)!.Tenthuonghieu,
                    soLuongCon = _db.Giaychitiets.FirstOrDefault(ph => ph.Magiaychitiet == c.Magiaychitiet)!.Soluongton,
                    gia = _db.Giaychitiets.FirstOrDefault(ph => ph.Magiaychitiet == c.Magiaychitiet)!.Gia,
                })
                .FirstOrDefault(); // Use FirstOrDefault() here
        }
    }
}
