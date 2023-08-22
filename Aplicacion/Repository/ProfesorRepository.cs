using Dominio.Entities;
using Dominio.Interfaces;
using Persistencia.Data;

namespace Aplicacion.Repository;
public class ProfesorRepository : GenericRepository<Profesor>, IProfesorRepository
{
    public ProfesorRepository(SicerContext context) : base(context)
    {
    }

}
