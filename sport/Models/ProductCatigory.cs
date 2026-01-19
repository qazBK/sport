using System;
using System.Collections.Generic;

namespace sport.Models;

public partial class ProductCatigory
{
    public short Id { get; set; }

    public string ProductCatigoriName { get; set; } = null!;

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
