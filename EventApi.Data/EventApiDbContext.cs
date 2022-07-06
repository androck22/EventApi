using EventApi.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventApi.Data
{
    public class EventApiDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, string>
    {
        public EventApiDbContext(DbContextOptions<EventApiDbContext> options)
           : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Meetup> Meetups { get; set; }

        public DbSet<Sponsor> Sponsors { get; set; }

    }
}
