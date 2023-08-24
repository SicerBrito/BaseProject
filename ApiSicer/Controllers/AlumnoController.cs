using ApiSicer.Dtos;
using AutoMapper;
using Dominio.Entities;
using Dominio.Interfaces;
using Microsoft.AspNetCore.Mvc;


namespace ApiSicer.Controllers;
    public class AlumnoController : ApiBaseController{

        private readonly IUnitOfWork _UnitOfWork;
        private readonly IMapper _Mapper;
        public AlumnoController(IUnitOfWork unitOfWork, IMapper mapper){
            _UnitOfWork = unitOfWork;
            _Mapper = mapper;
        }

        //Tipos de respuesta dentro del servidor configurado en los decoradores.
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<IEnumerable<AlumnoDto>>> Get(){
            var alumnos = await _UnitOfWork.Alumnos!.GetAllAsync();
            
            return _Mapper.Map<List<AlumnoDto>>(alumnos);
        }

    }
