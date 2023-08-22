namespace Dominio.Entities;
    public class Salon{
        public int Nro { get; set; }
        public int IdProfesor { get; set; }
        public Profesor ? Profesores { get; set; }
        public int IdAlumno { get; set; }
        public Alumno ? Alumnos { get; set; }

    }
