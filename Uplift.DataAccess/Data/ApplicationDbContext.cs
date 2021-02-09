using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Uplift.Models;

namespace Uplift.DataAccess.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        //public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        //    : base(options)
        //{
        //}

        public DbSet<Category> Category { get; set; }
        public DbSet<Frequency> Frequency { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlServer("Server=localhost,1401;Database=Practice;User=sa;Password=benzy5@Rarc");
    }
}
