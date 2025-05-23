﻿using System;
using System.Collections.Generic;

namespace Travel.Data.Entities;

public partial class UserDetail
{
    public int UserId { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? PhoneNumber { get; set; }

    public virtual User User { get; set; } = null!;
}
