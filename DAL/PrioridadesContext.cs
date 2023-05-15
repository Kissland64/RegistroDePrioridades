using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;
using Registrodeprioridades.Modelo;
using System.Data.Common;

namespace Registrodeprioridades.DAL
{
    public class PrioridadesContext : DbContext
    {
        public PrioridadesContext(DbContextOptions<PrioridadesContext> Options)
            : base(Options) { }

        public DbSet<Prioridades> Prioridades { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source = Data\\Prioridades.Db");
            base.OnConfiguring(optionsBuilder);
        }
    }
}