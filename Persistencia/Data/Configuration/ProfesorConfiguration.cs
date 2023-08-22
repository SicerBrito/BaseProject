using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration;
public class ProfesorConfiguration : IEntityTypeConfiguration<Profesor>
{
    public void Configure(EntityTypeBuilder<Profesor> builder)
    {
        builder.ToTable("Profesor");

        builder.Property(p => p.Id)
            .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
            .HasColumnName("IdProfesor")
            .HasColumnType("int")
            .IsRequired();

        builder.Property(p => p.Nombre)
            .HasColumnName("NombreProfesor")
            .HasColumnType("varchar")
            .HasMaxLength(100)
            .IsRequired();

        builder.HasMany(p => p.Alumnos)
            .WithMany(p => p.Profesores)
            .UsingEntity<Salon>(
                p => p
                    .HasOne(p => p.Alumnos)
                    .WithMany(p => p.Salones)
                    .HasForeignKey(p => p.IdAlumno),
                p => p
                    .HasOne(p => p.Profesores)
                    .WithMany(p => p.Salones)
                    .HasForeignKey(p => p.IdProfesor),
                p => {
                    p.HasKey(p=> new {p.IdProfesor,p.IdAlumno});                    
                }
            );
    }
}
