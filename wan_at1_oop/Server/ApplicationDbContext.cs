using System;
using Microsoft.EntityFrameworkCore;
using wan_at1_oop.Shared.Models;

namespace wan_at1_oop.Server
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }

        public DbSet<Accountant> Employees { get; set; }
        public DbSet<Branch> Branches { get; set; }
        public DbSet<Position> Positions { get; set; }
    }
}
