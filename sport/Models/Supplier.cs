using System;
using System.Collections.Generic;

namespace sport.Models;

public partial class Supplier
{
    public short Id { get; set; }

    public string SupplierName { get; set; } = null!;

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
