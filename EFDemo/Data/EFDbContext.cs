using EFDemo.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EFDemo.Data
{
    public class EFDbContext : DbContext
    {
        public EFDbContext() : base("DefaultConnection")
        { }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Player> Players { get; set; }
    }
}