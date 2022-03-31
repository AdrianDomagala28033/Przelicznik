using Microsoft.EntityFrameworkCore;
using ProjektPrzelicznik.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektPrzelicznik.Context
{
    class SqlContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Filename=bazaPrzelicznik.db");
            base.OnConfiguring(optionsBuilder);
        }
            public DbSet<Jednostki> Jednostki { get; set; }
            public DbSet<Przelicznik> Przelicznik { get; set; }
            public DbSet<Rodzaj> Rodzaj { get; set; }
    }
}
