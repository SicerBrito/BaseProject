using Dominio.Entities;
using Dominio.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ApiSicer.Controllers;
    public class ProfesorController : ApiBaseController{

        private readonly IUnitOfWork _UnitOfWork;
        public ProfesorController(IUnitOfWork unitOfWork){
            _UnitOfWork = unitOfWork;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<IEnumerable<Profesor>>> Get(){
            var profesores = await _UnitOfWork.Profesores!.GetAllAsync();
            return Ok(profesores); 
        }
    }
