using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.InteropServices;
using System.Text;

namespace EF02.Models
{
    [Table("EventOrganizers")]
    internal class Organizer
    {
        public int Id {  get; set; }

        [MaxLength(100)]
        [Required]
        public string Name {  get; set; } = null!;

        [MaxLength(150)]
        public string? CompanyName {  get; set; }
        public bool IsVerified {  get; set; }

        public OrganizerProfile OrganizerProfile { get; set; } = null!;
        //public ICollection<Event> PublishedEvents { get; set; }
    }
}
