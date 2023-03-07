﻿using System;
using System.Collections.Generic;

namespace CI.Entity.Models;

public partial class City
{
    public long CityId { get; set; }

    public long? CountryId { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public string? CityName { get; set; }

    public virtual Country? Country { get; set; }

    public virtual ICollection<Mission> Missions { get; } = new List<Mission>();

    public virtual ICollection<User> Users { get; } = new List<User>();
}
