using System;
using System.Collections.Generic;

namespace sport.Models;

public partial class Order
{
    public int Id { get; set; }

    public DateOnly OrderDate { get; set; }

    public DateOnly? DeliveryDate { get; set; }

    public short IdPoint { get; set; }

    public int IdUser { get; set; }

    public int ReceiptCode { get; set; }

    public short IdOrderStatus { get; set; }

    public virtual OrderStatus IdOrderStatusNavigation { get; set; } = null!;

    public virtual Point IdPointNavigation { get; set; } = null!;

    public virtual User IdUserNavigation { get; set; } = null!;

    public virtual ICollection<OrderProduct> OrderProducts { get; set; } = new List<OrderProduct>();
}
