using System;
using System.Collections.Generic;

namespace C_Data_Access_Layer.Models;

public partial class Hoadonchitiet
{
    public int Mahoadonchitiet { get; set; }

    public int Magiaychitiet { get; set; }

    public int Mahoadon { get; set; }

    public int? Soluongmua { get; set; }

    public int? Tongtien { get; set; }

    public virtual Giaychitiet MagiaychitietNavigation { get; set; } = null!;

    public virtual Hoadon MahoadonNavigation { get; set; } = null!;
}
