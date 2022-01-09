using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CursosOnDemandAPI.Models;
using CursosOnDemandAPI.Services;

namespace CursosOnDemandAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CursosController : ControllerBase
    {
        private readonly ILogger<CursosController> _logger;
        private ICursosServices _cursosServices;

        public CursosController(ILogger<CursosController> logger, ICursosServices cursosServices)
        {
            _logger = logger;
            _cursosServices = cursosServices;
        }
        
        /// <summary>
        /// Este método retorna toda a lista de Cursos Cadastrados.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_cursosServices.FindAll());
        }
        
        /// <summary>
        /// Este método irá buscar todos os Cursos cadastrados passando o ID como parâmetro.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public IActionResult Get(long id)
        {
            var cursos = _cursosServices.FindBy(id);
            if (cursos == null) return NotFound();
            return Ok(cursos);
        }

        /// <summary>
        /// Este método irá inserir o Curso atráves do curso passado como parâmetro
        /// </summary>
        /// <param name="cursos"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Post([FromBody] Cursos cursos)
        {
            if (cursos == null) return BadRequest();
            return Ok(_cursosServices.Create(cursos));
        }

        /// <summary>
        ///  Este método irá atualizar o Curso cadastrado atráves do curso passado como parâmetro 
        /// </summary>
        /// <param name="cursos"></param>
        /// <returns></returns>
        [HttpPut]
        public IActionResult Put([FromBody] Cursos cursos)
        {
            if (cursos == null) return BadRequest();
            return Ok(_cursosServices.Update(cursos));
        }

        /// <summary>
        /// Irá deletar o Curso passado o ID como Parâmetro
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            _cursosServices.Delete(id);
            return NoContent();
        }

        

    }
}
