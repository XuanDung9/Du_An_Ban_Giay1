using System;
using System.Collections.Generic;

namespace C_Data_Access_Layer.Models;

public partial class Hoadon
{
    public int Mahoadon { get; set; }

    public int? Mataikhoan { get; set; }

    public int Makhachhang { get; set; }

    public int Mahinhthucthanhtoan { get; set; }

    public int? Mauudai { get; set; }

    public DateTime? Ngaytao { get; set; }

    public int? Tongtien { get; set; }

    public bool? Trangthai { get; set; }

    public string? Ghichu { get; set; }

    public virtual ICollection<Hoadonchitiet> Hoadonchitiets { get; set; } = new List<Hoadonchitiet>();

    public virtual Hinhthucthanhtoan? MahinhthucthanhtoanNavigation { get; set; } = null!;

    public virtual Khachhang? MakhachhangNavigation { get; set; } = null!;

    public virtual Taikhoan? MataikhoanNavigation { get; set; } = null!;

    public virtual Uudai? MauudaiNavigation { get; set; } = null!;
}
