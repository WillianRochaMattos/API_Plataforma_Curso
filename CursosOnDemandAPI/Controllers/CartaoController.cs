using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CursosOnDemandAPI.Models;
using CursosOnDemandAPI.Services;

namespace CartaoOnDemandAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CartaoController : ControllerBase
    {
        private readonly ILogger<CartaoController> _logger;
        private ICartaoServices _cartaoServices;

        public CartaoController(ILogger<CartaoController> logger, ICartaoServices cartaoServices)
        {
            _logger = logger;
            _cartaoServices = cartaoServices;
        }
        
        /// <summary>
        /// Retorna todos os cartôes cadastrados
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_cartaoServices.FindAll());
        }
        
        /// <summary>
        /// Este método busca o cartão cadastrado passando o ID como Parâmetro.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public IActionResult Get(long id)
        {
            var cartao = _cartaoServices.FindBy(id);
            if (cartao == null) return NotFound();
            return Ok(cartao);
        }

        /// <summary>
        /// Este método irá inserir o Cartão atráves do cartão passado como parâmetro
        /// </summary>
        /// <param name="cartao"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Post([FromBody] Cartao cartao)
        {
            if (cartao == null) return BadRequest();
            return Ok(_cartaoServices.Create(cartao));
        }

        /// <summary>
        /// Este método irá atualizar o Cartão cadastrado atráves do cartao passado como parâmetro 
        /// </summary>
        /// <param name="cartao"></param>
        /// <returns></returns>
        [HttpPut]
        public IActionResult Put([FromBody] Cartao cartao)
        {
            if (cartao == null) return BadRequest();
            return Ok(_cartaoServices.Update(cartao));
        }

        /// <summary>
        ///  Este método irá deletar o cartão passando o ID como parâmetro
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            _cartaoServices.Delete(id);
            return NoContent();
        }
    }
}
