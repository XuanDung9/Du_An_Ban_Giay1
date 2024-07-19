using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Data_Access_Layer.Models.ModelRefer
{
    public class XacThucDangNhap
    {
        private static XacThucDangNhap _instance;// khai báo biến tính của xác thực
        public static XacThucDangNhap Instance => _instance ??(_instance =new XacThucDangNhap()); // nếu _instace rỗng , tạo mới thằng xác thực. ( chỉ có 1 xác thực chạy trong hương trình)
        public int IdTaiKhoan { get; private set; }
        public int MaChucVu { get; private set; }
        public string HoTen { get; private set; }

        public void CapNhatThongTinDangNhap(int idTaiKhoan , int maChucVu , string hoTen)
        {
            IdTaiKhoan = idTaiKhoan;
            MaChucVu = maChucVu;
            HoTen = hoTen;
        }
        public void DangXuat()
        {
            IdTaiKhoan = 0;
            MaChucVu = 0;
            HoTen = null;
        }
    }
}
