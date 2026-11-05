using System;
using System.Collections.Generic;
using System.Text;

namespace EF02.Models
{
    internal class Event
    {
        public int Id { get; set; }
        public string Title { get; set; } =  null!;
        public string Description { get; set; } = null!;
        public DateOnly StartDate { get; set; }
        public DateOnly? EndDate { get; set; }
        public int MaxAtendeesAllowed { get; set; }

        public int OrganizerId { get; set; }
        public Organizer Organizer { get; set; } = null!;
    }
}
