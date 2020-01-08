using Microsoft.EntityFrameworkCore;
using Evento.Dominio.Entidades;

namespace Evento.Repositorio.Config
{
    public class ConvidadoConfiguration : IEntityTypeConfiguration<Convidado>
    {
        
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Convidado> builder)
        {
            builder.HasKey(u => u.Id);

            //Builder utiliza o padrão Fluent
            builder
                .Property(u => u.Nome)
                .IsRequired()
                .HasMaxLength(120);

            builder
                .Property(u => u.Email)
                .IsRequired()
                .HasMaxLength(120);


            builder
               .Property(u => u.Celular)
               .IsRequired()
               .HasMaxLength(50);

            builder
                .Property(u => u.Empresa)
                .IsRequired()
                .HasMaxLength(50);


            builder
                .Property(u => u.Cargo)
                .IsRequired()
                .HasMaxLength(50);

        }
    }
}
