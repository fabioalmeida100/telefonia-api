using Microsoft.AspNetCore.Mvc;
using Telefonia.Business;
using Telefonia.Model.Enuns;

namespace Telefonia.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlanoController: ControllerBase
    {
        private IPlanoBusiness _planoBusiness;

        public PlanoController(IPlanoBusiness planoBusiness)
        {
            _planoBusiness = planoBusiness;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var planos = _planoBusiness.FindAll();                                   
            return Ok(planos);
        }

        [HttpGet("codigo/{codigoPlano}/{ddd}", Name = "GetByCodigo")]
        public IActionResult Get(int codigoPlano, int ddd)
        {
            return Ok(_planoBusiness.FindByCodigoPlano(codigoPlano, ddd));
        }
         
        [HttpGet("tipo/{tipo}/{ddd}", Name = "GetByTipo")]
        public IActionResult Get(TipoPlano tipo, int ddd)
        {
            return Ok(_planoBusiness.FindByTipo(tipo, ddd));
        }
                
        [HttpGet("operadora/{operadora}/{ddd}", Name = "GetByOperadora")]
        public IActionResult Get(string operadora, int ddd)
        {
            return Ok(_planoBusiness.FindByOperadora(operadora, ddd));
        }

        [HttpDelete("delete/{codigoPlano}", Name = "DeleteByCodigoPlano")]
        public IActionResult DeleteByCodigoPlano(int codigoPlano)
        {
            _planoBusiness.DeleteByCodigoPlano(codigoPlano);
            return NoContent();
        }

    }
}
