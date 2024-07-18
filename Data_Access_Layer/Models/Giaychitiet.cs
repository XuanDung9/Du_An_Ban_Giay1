using System;
using System.Collections.Generic;

namespace C_Data_Access_Layer.Models;

public partial class Giaychitiet
{
    public int Magiaychitiet { get; set; }

    public int Magiay { get; set; }

    public int Mamausac { get; set; }

    public int Machatlieu { get; set; }

    public int Mathuonghieu { get; set; }

    public int Makieudang { get; set; }

    public int Makichco { get; set; }

    public int? Soluongton { get; set; }

    public int? Gia { get; set; }

    public string? Mota { get; set; }

    public bool? Trangthai { get; set; }

    public DateTime? Ngaytao { get; set; }

    public DateTime? Ngaysua { get; set; }

    public virtual ICollection<Hoadonchitiet> Hoadonchitiets { get; set; } = new List<Hoadonchitiet>();

    public virtual Chatlieu MachatlieuNavigation { get; set; } = null!;

    public virtual Giay MagiayNavigation { get; set; } = null!;

    public virtual Kichco MakichcoNavigation { get; set; } = null!;

    public virtual Kieudang MakieudangNavigation { get; set; } = null!;

    public virtual Mausac MamausacNavigation { get; set; } = null!;

    public virtual Thuonghieu MathuonghieuNavigation { get; set; } = null!;
}
