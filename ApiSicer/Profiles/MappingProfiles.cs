using AutoMapper;
using Dominio.Entities;
using ApiSicer.Dtos;


namespace ApiSicer.Profiles;
    public class MappingProfiles : Profile{

        public MappingProfiles(){
            CreateMap<Alumno, AlumnoDto>()
                .ReverseMap();

            /* .ForMember(p => p.Profesores) */
        }
    }
