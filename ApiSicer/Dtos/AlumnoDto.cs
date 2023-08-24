using Dominio.Entities;

namespace ApiSicer.Dtos;
    public class AlumnoDto
    {
        public int Id { get; set; }
        public string ? Nombre { get; set; }
        public List<Profesor> ? Profesores { get; set; }
        
    }
