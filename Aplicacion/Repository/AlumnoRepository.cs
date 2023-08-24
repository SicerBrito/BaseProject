using Dominio.Entities;
using Dominio.Interfaces;
using Persistencia.Data;
using Microsoft.EntityFrameworkCore;
namespace Aplicacion.Repository;
public class AlumnoRepository : GenericRepository<Alumno>, IAlumnoRepository
{
    private readonly SicerContext _Context;
    public AlumnoRepository(SicerContext context) : base(context)
    {
        _Context = context;
    }


    public override async Task<IEnumerable<Alumno>> GetAllAsync()
    {
        return await _Context.Alumnos
            .Include(p => (p.Profesores as List<Profesor>).Select(i=>i.Nombre)) //Si no se coloca en la parte del json apareceria como null            
            .ToListAsync();
    }

}
