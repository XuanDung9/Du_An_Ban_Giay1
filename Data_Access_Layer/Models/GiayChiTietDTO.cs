using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Data_Access_Layer.Models
{
    public class GiayChiTietDTO
    {
        [Key]
        public int Magiay { get; set; }
        public string TenGiay { get; set; }
        public int Magiaychitiet { get; set; }
        public string TenChatLieu { get; set; }
        public string TenMauSac { get; set; }
        public string TenKichCo { get; set; }
        public string TenThuongHieu { get; set; }
        public string TenKieuDang { get; set; }
        public DateTime? Ngaytao { get; set; }
        public DateTime? Ngaysua { get; set; }
        public int Gia { get; set; }
        public string Mota { get; set; }
        public int Soluongton { get; set; }
        public bool Trangthai { get; set; }

        // Thêm các thuộc tính mã
        public int Machatlieu { get; set; }
        public int Mamausac { get; set; }
        public int Makichco { get; set; }
        public int Mathuonghieu { get; set; }
        public int Makieudang { get; set; }

    }
}
