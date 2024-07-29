using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Data_Access_Layer.Models.ModelRefer
{
    public class HoaDon_KhachHang
    {
        public Hoadon Hoadon { get; set; } // thừa kế lại các thuộc tỉnh của hóa đơn
        public string? tenTaiKhoan { get; set; }
        public string? tenUuDai { get; set; }
        public string? tenKhachHang { get; set; }
        public int? diemKhachHang { get; set; }
        public string? tenHinhThucThanhToan { get; set; }
    }
}
