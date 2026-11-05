using System;
using System.Collections.Generic;
using System.Text;

namespace EF02.Models
{
    internal class Badge
    {
        public int Id { get; set; }
        public int BadgeNumber { get; set; }
        public DateOnly IssuedDate { get; set; }
        public Tier Tier { get; set; }
        public int AttendeeId {  get; set; }
        public Attendee Attendee { get; set; } = null!;
    }
}
