using System;
using System.Collections.Generic;

namespace sport.Models;

public partial class UnitsOfMeasurement
{
    public short Id { get; set; }

    public string UnitName { get; set; } = null!;

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
