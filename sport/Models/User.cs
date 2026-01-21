namespace sport.Models;

public partial class User
{
    public int Id { get; set; }

    public short IdRole { get; set; }

    public string Nickname { get; set; } = null!;

    public string Login { get; set; } = null!;

    public string Pasvord { get; set; } = null!;

    public virtual Role Role { get; set; } = null!;

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
