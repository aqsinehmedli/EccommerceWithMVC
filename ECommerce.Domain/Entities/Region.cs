﻿using ECommerce.Domain.Abstraction;
using System;
using System.Collections.Generic;

namespace ECommerce.Domain.Entities;

public partial class Region:IEntity
{
    public int RegionId { get; set; }

    public string RegionDescription { get; set; } = null!;

    public virtual ICollection<Territory> Territories { get; set; } = new List<Territory>();
}
