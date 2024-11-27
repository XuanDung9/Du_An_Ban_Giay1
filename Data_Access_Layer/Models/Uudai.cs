using System;
using System.Collections.Generic;

namespace C_Data_Access_Layer.Models;

public partial class Uudai
{
    public int Mauudai { get; set; }

    public string? Tenuudai { get; set; }

    public DateTime? Ngaybatdau { get; set; }

    public DateTime? Ngayketthuc { get; set; }

    public int? Trangthai { get; set; }

    public int? Soluong { get; set; }

    public int Mataikhoan { get; set; }

    public int? Phantram { get; set; }

    public virtual ICollection<Hoadon> Hoadons { get; set; } = new List<Hoadon>();

    public virtual Taikhoan MataikhoanNavigation { get; set; } = null!;
}
