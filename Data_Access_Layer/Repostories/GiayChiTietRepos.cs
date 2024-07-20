using C_Data_Access_Layer.Context;
using C_Data_Access_Layer.IRepostories;
using C_Data_Access_Layer.Models;
using C_Data_Access_Layer.Models.ModelRefer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Data_Access_Layer.Repostories
{
    public class GiayChiTietRepos : IGiayChiTietRepos
    {
        DBContext _db;

        public GiayChiTietRepos()
        {
            _db = new DBContext();
        }

        public List<Giaychitiet> GetAll(string? txtSearch, string? searchType)
        {
            if (string.Equals(searchType, SearchType.All))
            {
                return _db.Giaychitiets.Where(c => c.Trangthai.ToString().Contains(txtSearch) || c.Mota.Contains(txtSearch) || c.Gia.ToString().Contains(txtSearch) || c.Ngaysua.ToString().Contains(txtSearch) || c.Ngaytao.ToString().Contains(txtSearch) || c.Soluongton.ToString().Contains(txtSearch) || c.Makieudang.ToString().Contains(txtSearch) || c.Mathuonghieu.ToString().Contains(txtSearch) || c.Makichco.ToString().Contains(txtSearch) || c.Mamausac.ToString().Contains(txtSearch) || c.Machatlieu.ToString().Contains(txtSearch) || c.Magiay.ToString().Contains(txtSearch)).ToList();
            }
            if (string.Equals(searchType, SearchType.maGiay))
            {
                return _db.Giaychitiets.Where(c => c.Magiay.ToString().Contains(txtSearch)).ToList();
            }
            if (string.Equals(searchType, SearchType.maChatLieu))
            {
                return _db.Giaychitiets.Where(c => c.Machatlieu.ToString().Contains(txtSearch)).ToList();
            }
            if (string.Equals(searchType, SearchType.maMauSac))
            {
                return _db.Giaychitiets.Where(c => c.Mamausac.ToString().Contains(txtSearch)).ToList();
            }
            if (string.Equals(searchType, SearchType.maKichCo))
            {
                return _db.Giaychitiets.Where(c => c.Makichco.ToString().Contains(txtSearch)).ToList();
            }
            if (string.Equals(searchType, SearchType.maThuongHieu))
            {
                return _db.Giaychitiets.Where(c => c.Mathuonghieu.ToString().Contains(txtSearch)).ToList();
            }
            if (string.Equals(searchType, SearchType.maKieuDang))
            {
                return _db.Giaychitiets.Where(c => c.Makieudang.ToString().Contains(txtSearch)).ToList();
            }
            if (string.Equals(searchType, SearchType.soLuongTrongKhoNhoHon))
            {
                return _db.Giaychitiets.Where(c => c.Soluongton <= int.Parse(txtSearch)).ToList();
            }
            if (string.Equals(searchType, SearchType.soLuongTrongKhoLonHon))
            {
                return _db.Giaychitiets.Where(c => c.Soluongton >= int.Parse(txtSearch)).ToList();
            }
            if (string.Equals(searchType, SearchType.ngayTao_GiayChiTiet))
            {
                return _db.Giaychitiets.Where(c => c.Ngaytao.ToString().Contains(txtSearch)).ToList();
            }
            if (string.Equals(searchType, SearchType.ngaySua_GiayChiTiet))
            {
                return _db.Giaychitiets.Where(c => c.Ngaysua.ToString().Contains(txtSearch)).ToList();
            }
            if (string.Equals(searchType, SearchType.giaLonHon_GiayChiTiet))
            {
                return _db.Giaychitiets.Where(c => c.Gia <= int.Parse(txtSearch)).ToList();
            }
            if (string.Equals(searchType, SearchType.giaNhoHon_GiayChiTiet))
            {
                return _db.Giaychitiets.Where(c => c.Gia >= int.Parse(txtSearch)).ToList();
            }
            if (string.Equals(searchType, SearchType.moTaChatLieu))
            {
                return _db.Giaychitiets.Where(c => c.Mota.Contains(txtSearch)).ToList();
            }
            if (string.Equals(searchType, SearchType.trangThai_GiayChiTiet))
            {
                return _db.Giaychitiets.Where(c => c.Trangthai.ToString().Contains(txtSearch)).ToList();
            }

            return _db.Giaychitiets.ToList();
        }

        public Giaychitiet GetByID(int? id)
        {
            return _db.Giaychitiets.FirstOrDefault(c => c.Magiaychitiet == id);
        }

        public bool Khoa_MoKhoa(int id)
        {
            try
            {
                var Obj = _db.Giaychitiets.FirstOrDefault(c => c.Magiaychitiet == id);
                if (Obj == null) { return false; }
                if (Obj.Trangthai == true)
                {
                    Obj.Trangthai = false;
                }
                else
                {
                    Obj.Trangthai = true;
                }
                _db.Giaychitiets.Update(Obj);
                _db.SaveChanges();
                return true;

            }
            catch { return false; }
        }

        public bool Sua(int? id, Giaychitiet Giaychitiet)
        {
            try
            {
                var Obj = _db.Giaychitiets.FirstOrDefault(c => c.Magiaychitiet == id);
                if (Obj == null) { return false; }

                Obj.Magiay = Giaychitiet.Magiay;
                Obj.Machatlieu = Giaychitiet.Machatlieu;
                Obj.Makichco = Giaychitiet.Makichco;
                Obj.Mamausac = Giaychitiet.Mamausac;
                Obj.Mathuonghieu = Giaychitiet.Mathuonghieu;
                Obj.Makieudang = Giaychitiet.Makieudang;
                Obj.Soluongton = Giaychitiet.Soluongton;
                Obj.Ngaytao = Giaychitiet.Ngaytao;
                Obj.Ngaysua = Giaychitiet.Ngaysua;
                Obj.Gia = Giaychitiet.Gia;
                Obj.Trangthai = Giaychitiet.Trangthai;
                Obj.Mota = Giaychitiet.Mota;

                _db.Giaychitiets.Update(Obj);
                _db.SaveChanges();
                return true;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                Console.WriteLine("Inner Exception: " + ex.InnerException.Message);
                return false;
            }
        }

        public bool Them(Giaychitiet Giaychitiet)
        {
            try
            {
                _db.Giaychitiets.Add(Giaychitiet);
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
    }
}
