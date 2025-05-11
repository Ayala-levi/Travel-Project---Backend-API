using System;
using System.Collections.Generic;

namespace Travel.Data.Entities;

public partial class User
{
    public int UserId { get; set; }

    public string Username { get; set; } = null!;

    public string Email { get; set; } = null!;

    public virtual ICollection<Participant> Participants { get; } = new List<Participant>();

    public virtual ICollection<Tour> Tours { get; } = new List<Tour>();

    public virtual UserDetail? UserDetail { get; set; }
}
