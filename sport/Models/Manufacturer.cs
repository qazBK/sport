using System;
using System.Collections.Generic;

namespace sport.Models;

public partial class Manufacturer
{
    public short Id { get; set; }

    public string ManufacturerName { get; set; } = null!;

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
