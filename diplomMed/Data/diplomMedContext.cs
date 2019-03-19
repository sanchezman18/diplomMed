using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using diplomMed.Models;

namespace diplomMed.Models
{
    public class diplomMedContext : DbContext
    {
        public diplomMedContext (DbContextOptions<diplomMedContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<diplomMed.Models.Equipment> Equips { get; set; }
        public DbSet<diplomMed.Models.Defs> Defs { get; set; }
        public DbSet<diplomMed.Models.Ekg> Ekgs { get; set; }
        public DbSet<diplomMed.Models.Ivl> Ivls { get; set; }
        public DbSet<diplomMed.Models.Monitor> Monitors { get; set; }
        public DbSet<diplomMed.Models.Stretcher> Stretchers { get; set; }
        public DbSet<diplomMed.Models.PulsOxx> PulsOxx { get; set; }


    }
}
