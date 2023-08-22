using Aplicacion.Repository;
using Dominio.Interfaces;
using Persistencia.Data;

namespace Aplicacion.UnitOfWork;
public class UnitOfWork : IUnitOfWork, IDisposable
{
    private IAlumnoRepository? _Alumno;
    private IProfesorRepository? _Profesor;
    private readonly SicerContext _Context;

    public UnitOfWork(SicerContext context)=> _Context = context;
    
    public IAlumnoRepository? Alumnos => _Alumno ??= new AlumnoRepository(_Context);

    public IProfesorRepository? Profesores => _Profesor ??= new ProfesorRepository(_Context);




    public void Dispose()
    {
        _Context.Dispose();
    }

    public async Task<int> SaveAsync()
    {
        return await _Context.SaveChangesAsync();
    }
}
