using Dominio.Entities;
using Dominio.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ApiSicer.Controllers;
    public class AlumnoController : ApiBaseController{

        private readonly IUnitOfWork _UnitOfWork;
        public AlumnoController(IUnitOfWork unitOfWork){
            _UnitOfWork = unitOfWork;
        }

        //Tipos de respuesta dentro del servidor configurado en los decoradores.
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<IEnumerable<Alumno>>> Get(){
            var alumnos = await _UnitOfWork.Alumnos!.GetAllAsync();
            return Ok(alumnos); 
        }

    }
