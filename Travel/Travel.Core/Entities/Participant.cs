using System;
using System.Collections.Generic;

namespace Travel.Data.Entities;

public partial class Participant
{
    public int UserId { get; set; }

    public int TourId { get; set; }

    public DateTime? RegistrationDate { get; set; }

    public virtual Tour Tour { get; set; } = null!;

    public virtual User User { get; set; } = null!;
}
