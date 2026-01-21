namespace sport.Models;

public partial class OrderProduct
{
    public int Id { get; set; }

    public int IdOrder { get; set; }

    public int IdProduct { get; set; }

    public int Count { get; set; }

    public virtual Order Order { get; set; } = null!;

    public virtual Product Product { get; set; } = null!;
}
