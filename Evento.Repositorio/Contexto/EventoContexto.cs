
using Microsoft.EntityFrameworkCore;
using Evento.Dominio.Entidades;
using Evento.Repositorio.Config;

namespace Evento.Repositorio.Contexto
{
    public class EventoContexto : DbContext
    {
        public DbSet<Convidado> Convidados { get; set; }


        public EventoContexto(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            /// Classes de mapeamento
            modelBuilder.ApplyConfiguration(new ConvidadoConfiguration());


            base.OnModelCreating(modelBuilder);
        }

    }
}
