using Dominio.Entities;
using Dominio.Interfaces;
using Persistencia.Data;

namespace Aplicacion.Repository;
public class AlumnoRepository : GenericRepository<Alumno>, IAlumnoRepository
{
    public AlumnoRepository(SicerContext context) : base(context)
    {
    }

}
