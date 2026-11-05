using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Emit;
using System.Text;

namespace EF02.Models
{
    [Owned]
    internal class Address
    {
        [MaxLength(150)]
        [Required]
        public string Street { get; set; } = null!;

        [MaxLength(100)]
        [Required]
        public string City { get; set; } = null!;

        [MaxLength(100)]
        [Required]
        public string Country { get; set; } = null!;

        [MaxLength(20)]
        [Required]
        [Column(name:"ZipCode")]
        public string PostalCode { get; set; } = null!;
    }
}
