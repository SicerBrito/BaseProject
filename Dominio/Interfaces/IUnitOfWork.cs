namespace Dominio.Interfaces;
    public interface IUnitOfWork{
        IAlumnoRepository ? Alumnos { get; }
        IProfesorRepository ? Profesores { get; }
        Task<int> SaveAsync();
    }
