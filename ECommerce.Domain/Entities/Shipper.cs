using ECommerce.Domain.Abstraction;
using System;
using System.Collections.Generic;

namespace ECommerce.Domain.Entities;

public partial class Shipper:IEntity
{
    public int ShipperId { get; set; }

    public string CompanyName { get; set; } = null!;

    public string? Phone { get; set; }

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
