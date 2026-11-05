using EF02.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EF02.Context
{
    internal class EventContext : DbContext
    {      
        DbSet<Organizer> Organizers { get; set; }
        DbSet<OrganizerProfile> OrganizersProfiles { get; set; }
        DbSet<Event> Events { get; set; }
        DbSet<Badge> Badges { get; set; }
        DbSet<Attendee> Attendees { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.; Database= EventHub ; Trusted_Connection=true; trustServerCertificate=true");
      
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Organizer>().ToTable("EventOrganizers");
            modelBuilder.Entity<Organizer>().HasOne(o => o.OrganizerProfile)
                .WithOne(p => p.Organizer)
                .HasForeignKey<OrganizerProfile>(p => p.OrganizerId);

            modelBuilder.Entity<Badge>().HasIndex(b => b.BadgeNumber).IsUnique();

            modelBuilder.Entity<Attendee>().HasOne(a => a.Badge)
                .WithOne(b => b.Attendee).HasForeignKey<Badge>(b => b.AttendeeId);


        }
    }
}
