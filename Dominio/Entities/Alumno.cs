namespace Dominio.Entities;
    public class Alumno : BaseEntity{

        public ICollection<Profesor> ? Profesores { get; set; } = new HashSet<Profesor>();
        public ICollection<Salon> ? Salones { get; set;}
    }
