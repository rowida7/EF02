using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EF02.Models
{
    internal class Attendee
    {
        public int Id { get; set; }

        [MaxLength(150)]
        [Required]
        public string FullName { get; set; } = null!;

        [MaxLength(200)]
        [Required]
        public string Email { get; set; } = null!;

        public Address Address { get; set; } = new();

        [NotMapped]
        public string FullAdress => $"{Address.Street}, {Address.City}, " +
                                    $"{Address.Country}, {Address.PostalCode}";

        public Badge? Badge { get; set; } 
    }
}
