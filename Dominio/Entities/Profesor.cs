namespace Dominio.Entities;
    public class Profesor : BaseEntity{


        public ICollection<Alumno> ? Alumnos { get; set; } = new HashSet<Alumno>();
        public ICollection<Salon> ? Salones { get; set;}

    }
