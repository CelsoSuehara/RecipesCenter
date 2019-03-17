using Microsoft.AspNetCore.Mvc;

namespace RecipesCenter.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConversorController : ControllerBase
    {
        // GET api/values/ConverterParaGramas/150
        [HttpGet("ConverterParaGramas/{pesoEmOncas}")]
        public ActionResult<double> ConverterParaGramas(double pesoEmOncas)
        {
            return Ok(pesoEmOncas * 28.34952313);

            //return BadRequest("Erro!");
        }

        // GET api/values/ConverterParaOncas/250
        [HttpGet("ConverterParaOncas/{pesoEmGramas}")]
        public ActionResult<double> ConverterParaOncas(double pesoEmGramas)
        {
            return Ok(pesoEmGramas / 28.34952313);
        }

    }
}
