using Registro_de_prioridades.DAL;
using Registro_de_prioridades.Modelo;
using System.Data.Common;

namespace Registro_de_prioridades.DAL
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