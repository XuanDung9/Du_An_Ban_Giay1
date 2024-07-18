using System;
using System.Collections.Generic;

namespace C_Data_Access_Layer.Models;

public partial class Khachhang
{
    public int Makhachhang { get; set; }

    public string? Tenkhachhang { get; set; }

    public int? Sdt { get; set; }

    public int? Diemkhachhang { get; set; }

    public bool? Trangthai { get; set; }

    public virtual ICollection<Hoadon> Hoadons { get; set; } = new List<Hoadon>();
}
