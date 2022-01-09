using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CursosOnDemandAPI.Models;
using CursosOnDemandAPI.Services;

namespace CursosOnDemandAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EstudanteController : ControllerBase
    {
        private readonly ILogger<EstudanteController> _logger;
        private IEstudanteServices _estudanteServices;

        public EstudanteController(ILogger<EstudanteController> logger, IEstudanteServices estudanteServices)
        {
            _logger = logger;
            _estudanteServices = estudanteServices;
        }
        
        /// <summary>
        /// Retorna toda a lista de estudantes cadastrados
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_estudanteServices.FindAll());
        }
        
        /// <summary>
        /// Este método irá buscar o Estudante através do ID passado como parâmetro
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public IActionResult Get(long id)
        {
            var estudante = _estudanteServices.FindBy(id);
            if (estudante == null) return NotFound();
            return Ok(estudante);
        }

        /// <summary>
        ///  Este método irá inserir o Estudante atráves do estudante passado como parâmetro
        /// </summary>
        /// <param name="estudante"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Post([FromBody] Estudante estudante)
        {
            if (estudante == null) return BadRequest();
            return Ok(_estudanteServices.Create(estudante));
        }
        
        /// <summary>
        /// Este método irá atualizar o Estudante cadastrado atráves do estudante passado como parâmetro 
        /// </summary>
        /// <param name="estudante"></param>
        /// <returns></returns>
        [HttpPut]
        public IActionResult Put([FromBody] Estudante estudante)
        {
            if (estudante == null) return BadRequest();
            return Ok(_estudanteServices.Update(estudante));
        }

        /// <summary>
        /// Este método irá deletar o etudante passando o ID como parâmetro
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            _estudanteServices.Delete(id);
            return NoContent();
        }
    }
}
