using System;
using System.Collections.Generic;

namespace Travel.Data.Entities;

public partial class Tour
{
    public int TourId { get; set; }

    public int OrganizerId { get; set; }

    public string TourName { get; set; } = null!;

    public string? Description { get; set; }

    public string? Location { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public virtual User Organizer { get; set; } = null!;

    public virtual ICollection<Participant> Participants { get; } = new List<Participant>();
}
