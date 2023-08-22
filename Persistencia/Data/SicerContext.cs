using System.Reflection;
using Dominio.Entities;
using Microsoft.EntityFrameworkCore;

namespace Persistencia.Data;
public class SicerContext : DbContext
{
    public SicerContext(DbContextOptions<SicerContext> options) : base(options){

    }

    public DbSet<Alumno> Alumnos { get; set; } = null!;
    public DbSet<Profesor> Profesores { get; set; } = null!;


    protected override void OnModelCreating(ModelBuilder modelBuilder){
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }

}
