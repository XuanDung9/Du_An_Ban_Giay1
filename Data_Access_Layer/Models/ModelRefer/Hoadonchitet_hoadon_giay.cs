using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Data_Access_Layer.Models.ModelRefer
{
    public class Hoadonchitet_hoadon_giay // thêm 
    {
        public Hoadonchitiet Hoadonchitiet { get; set; } 
        public Hoadon GetHoadon { get; set; }
        public int? Mataikhoan { get; set; }
        public string? Ngaytao { get; set; } // Correct casing
        public string? Tentaikhoan { get; set; } // Correct casing
        public string? Tengiay { get; set; } // Correct casing
        public int? Soluongmua { get; set; }
        public double? Gia { get; set; }
    }
}
