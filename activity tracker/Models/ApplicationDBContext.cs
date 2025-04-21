using System;
using activity_tracker.Models;
using Microsoft.EntityFrameworkCore;

namespace Websitetime2.Models
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {

        }
        public DbSet<Activities> Activities { get; set; }
    }
}

