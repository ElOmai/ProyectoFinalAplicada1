using ProyectoAplicadaI.Entidades;
using System.Data.Entity;
namespace ProyectoAplicadaI.Entidades
{
    public class Contexto : DbContext
    {
        public DbSet<Clientes> Clientes { get; set; }
        public DbSet<Articulos> Articulos { get; set; }
        public DbSet<Empeños> Empeños { get; set; }
        public DbSet<EmpeñosDetalle> Detalles { get; set; }
        public DbSet<Usuarios> Usuarios { get; set; } 
        public DbSet<Cobros> Cobro { get; set; }

        public Contexto() : base ("ConStr"){}

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
