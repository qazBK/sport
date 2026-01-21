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

    public string? Image { get; set; }

    public virtual Manufacturer Manufacturer { get; set; } = null!;

    public virtual ProductCatigory ProductCatigory { get; set; } = null!;

    public virtual Supplier Supplier { get; set; } = null!;

    public virtual UnitsOfMeasurement UnitsOfMeasurement { get; set; } = null!;

    public virtual ICollection<OrderProduct> OrderProducts { get; set; } = new List<OrderProduct>();
}
