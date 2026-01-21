namespace sport.Models;

public partial class Point
{
    public short Id { get; set; }

    public string PointAdres { get; set; } = null!;

    public string Number { get; set; } = null!;

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
