using System;
using System.Collections.Generic;
using System.Text;

namespace EF02.Models
{
    internal class OrganizerProfile
    {
        public int Id {  get; set; }
        public string Biography { get; set; }
        public string CompanyWebsie { get; set; }
        public string Logo { get; set; }


        public int OrganizerId { get; set; }
        public Organizer Organizer { get; set; } = null!;

    }
}
