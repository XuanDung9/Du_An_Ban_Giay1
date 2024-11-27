using System;
using System.Collections.Generic;

namespace C_Data_Access_Layer.Models;

public partial class Giay
{
    public int Magiay { get; set; }

    public string? Tengiay { get; set; }

    public virtual ICollection<Giaychitiet> Giaychitiets { get; set; } = new List<Giaychitiet>();
}
