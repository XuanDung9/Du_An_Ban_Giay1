using System;
using System.Collections.Generic;

namespace C_Data_Access_Layer.Models;

public partial class Hinhthucthanhtoan
{
    public int Mahinhthucthanhtoan { get; set; }

    public string Tenhinhthuc { get; set; } = null!;

    public virtual ICollection<Hoadon> Hoadons { get; set; } = new List<Hoadon>();
}
