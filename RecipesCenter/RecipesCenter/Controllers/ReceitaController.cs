using Microsoft.AspNetCore.Mvc;
using RecipesCenter.Model;
using RecipesCenter.Services;

namespace RecipesCenter.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReceitaController : ControllerBase
    {
        private IReceitaService _receitaService;

        public ReceitaController(IReceitaService receitaService)
        {
            _receitaService = receitaService;
        }

        // GET api/values
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_receitaService.FindAll());
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            Receita receita = _receitaService.FindById(id);
            if (receita == null)
                return NotFound();
            else
                return Ok(receita);
        }

        // POST api/values
        [HttpPost]
        public IActionResult Post([FromBody] Receita receita)
        {
            if (receita == null)
                return BadRequest();
            else
                return new ObjectResult(_receitaService.Create(receita));
        }

        // PUT api/values/5
        [HttpPut]
        public IActionResult Put([FromBody] Receita receita)
        {
            if (receita == null)
                return BadRequest();
            else
                return new ObjectResult(_receitaService.Update(receita));
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _receitaService.Delete(id);
            return NoContent();
        }
    }
}
