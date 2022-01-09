using CursosOnDemandAPI.Models;
using CursosOnDemandAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace CursosOnDemandAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MatriculaController : ControllerBase
    {
        private ICursosServices _cursosServices;
        private IMatriculaServices _matriculaServices;

        public MatriculaController(ICursosServices cursosServices, IMatriculaServices matriculaServices)
        {
            _cursosServices = cursosServices;
            _matriculaServices = matriculaServices;
        }

        /// <summary>
        /// Este método irá inserir a matrícula 
        /// </summary>
        /// <param name="matricula"></param>
        /// <returns></returns>
        [HttpPost()]
        public IActionResult Matricula([FromBody] Matricula matricula)
        {
            try
            {
                _cursosServices.Matricular(matricula);
                return Ok(_matriculaServices.EnviarEmail());
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
