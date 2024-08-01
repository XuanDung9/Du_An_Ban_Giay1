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
    public class Giay_ChiTietGiayRepostory: IGiay_GiayChiTietRepostory
    {
        DuAnBanGiay1Context _db;
        public Giay_ChiTietGiayRepostory()
        {
            _db = new DuAnBanGiay1Context();
        }
        public List<Giay_ChiTietGiay> GetAll(string? txtTimKiem, string? searchType)
        {
            IQueryable<Giaychitiet> query = _db.Giaychitiets;  // sử dụng truy vấn query

            if (string.Equals(searchType, SearchType.trangThai_GiayChiTiet))
            {
                query = query.Where(a => a.Trangthai == bool.Parse(txtTimKiem));
            }
            else if (string.Equals(searchType, SearchType.tenGiay))
            {
                query = query.Where(a => a.Trangthai == true)
                             .Where(c => c.Magiay != null && _db.Giays.FirstOrDefault(ph => ph.Magiay == c.Magiay)!.Tengiay.ToLower().Contains(txtTimKiem.ToLower()));
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
                    //giaychitiet = c,
                    //tenChatLieu = c.Machatlieu == null ? "N/A" : _db.Chatlieus.FirstOrDefault(ph => ph.Machatlieu == c.Machatlieu)!.Tenchatlieu,
                    //tenMauSac = c.Mamausac == null ? "N/A" : _db.Mausacs.FirstOrDefault(ph => ph.Mamausac == c.Mamausac)!.Tenmausac,
                    //tenKieuDang = c.Makieudang == null ? "N/A" : _db.Kieudangs.FirstOrDefault(ph => ph.Makieudang == c.Makieudang)!.Tenkieudang,
                    //tenKichCo = c.Makichco == null ? "N/A" : _db.Kichcos.FirstOrDefault(ph => ph.Makichco == c.Makichco)!.Tenkichco,
                    //tenGiay = c.Magiay == null ? "N/A" : _db.Giays.FirstOrDefault(ph => ph.Magiay == c.Machatlieu)!.Tengiay,
                    //tenThuongHieu = c.Mathuonghieu == null ? "N/A" : _db.Thuonghieus.FirstOrDefault(ph => ph.Mathuonghieu == c.Mathuonghieu)!.Tenthuonghieu,

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
