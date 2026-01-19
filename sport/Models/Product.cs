using System;
using System.Collections.Generic;

namespace sport.Models;

public partial class Product
{
    public int Id { get; set; }

    public string Article { get; set; } = null!;

    public string ProductName { get; set; } = null!;

    public short IdProductCatigori { get; set; }

    public short IdManufacturer { get; set; }

    public short IdSupplier { get; set; }

    public int Praise { get; set; }

    public short IdUnit { get; set; }

    public int? Discount { get; set; }

    public int Count { get; set; }

    public string? Description { get; set; }

    public virtual Manufacturer IdManufacturerNavigation { get; set; } = null!;

    public virtual ProductCatigory IdProductCatigoriNavigation { get; set; } = null!;

    public virtual Supplier IdSupplierNavigation { get; set; } = null!;

    public virtual UnitsOfMeasurement IdUnitNavigation { get; set; } = null!;

    public virtual ICollection<OrderProduct> OrderProducts { get; set; } = new List<OrderProduct>();
}
