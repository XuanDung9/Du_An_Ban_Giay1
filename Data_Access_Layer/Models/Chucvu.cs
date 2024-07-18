using System;
using System.Collections.Generic;

namespace C_Data_Access_Layer.Models;

public partial class Chucvu
{
    public int Machucvu { get; set; }

    public string? Tenchucvu { get; set; }

    public virtual ICollection<Taikhoan> Taikhoans { get; set; } = new List<Taikhoan>();
}
