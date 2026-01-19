using System;
using System.Collections.Generic;

namespace sport.Models;

public partial class User
{
    public int Id { get; set; }

    public short IdRole { get; set; }

    public string Nickname { get; set; } = null!;

    public string Login { get; set; } = null!;

    public string Pasvord { get; set; } = null!;

    public virtual Role IdRoleNavigation { get; set; } = null!;

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
