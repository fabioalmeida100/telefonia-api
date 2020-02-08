using Microsoft.EntityFrameworkCore;
using Telefonia.Model.Config;

namespace Telefonia.Model.Context
{
    public class MySQLContext: DbContext
    {
        public DbSet<Plano> Planos { get; set; }
        public DbSet<Plano> DDDs { get; set; }
        public DbSet<PlanoDDD> PlanoDDDs { get; set; }
        public DbSet<Operadora> Operadoras { get; set; }

        public MySQLContext()
        {
           
        }

        public MySQLContext(DbContextOptions<MySQLContext> options): base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new PlanoConfiguration());
            modelBuilder.ApplyConfiguration(new DDDConfiguration());
            modelBuilder.ApplyConfiguration(new PlanoDDDConfiguration());
            modelBuilder.ApplyConfiguration(new OperadoraConfiguration());
            base.OnModelCreating(modelBuilder);
        }
    }
}
