using System;
using System.Collections.Generic;

namespace sport.Models;

public partial class OrderStatus
{
    public short Id { get; set; }

    public string OrderStatuses { get; set; } = null!;

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
