using C_Data_Access_Layer.Context;
using C_Data_Access_Layer.IRepostories;
using C_Data_Access_Layer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Data_Access_Layer.Repostories
{
    public class TaiKhoanRepostories: ITaiKhoanRepostories
    {
        DuAnBanGiay1Context _context;
        public TaiKhoanRepostories()
        {
            _context = new DuAnBanGiay1Context();
        }
        public List<Taikhoan> GetAll(string? serchText , string? searchType)
        {
            return _context.Taikhoans.ToList();
        }
        public bool Sua(int? id, Taikhoan taikhoan)
        {
            try
            {
                var objTaiKhoan = _context.Taikhoans.FirstOrDefault(a => a.Mataikhoan == id);
                objTaiKhoan.Username = taikhoan.Username;
                objTaiKhoan.Password = taikhoan.Password;
                objTaiKhoan.Hoten = taikhoan.Hoten;
                objTaiKhoan.Gioitinh = taikhoan.Gioitinh;
                objTaiKhoan.Sdt = taikhoan.Sdt;
                objTaiKhoan.Diachi = taikhoan.Diachi;
                objTaiKhoan.Email = taikhoan.Email;
                objTaiKhoan.Ngaysinh = taikhoan.Ngaysinh;
                objTaiKhoan.Machucvu = taikhoan.Machucvu;
                objTaiKhoan.Trangthai = taikhoan.Trangthai;
                _context.Taikhoans.Update(objTaiKhoan);
                _context.SaveChanges();
                return true;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                Console.WriteLine("Inner Exception: " + ex.InnerException.Message);

                return false;
            }
        }
    }
}
