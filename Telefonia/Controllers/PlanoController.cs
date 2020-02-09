using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.SwaggerGen;
using System;
using System.Collections.Generic;
using Telefonia.Business;
using Telefonia.Data.VO;
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

        [HttpGet("listarplanos")]
        public IActionResult Get()
        {
            var planos = _planoBusiness.FindAll();                                   
            return Ok(planos);
        }

        [HttpPost("cadastrar")]
        public IActionResult Post([FromBody] PlanoVO planoVO)
        {
            try
            {
                _planoBusiness.Create(planoVO);
                return Ok($"Plano {planoVO.CodigoPlano} inserido com sucesso");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            
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

        [HttpPut("atualizar")]
        public IActionResult Update([FromBody] PlanoVO planoVO)
        {
            if (planoVO == null)
                return BadRequest();
            else
            {
                _planoBusiness.UpdateByCodigoPlano(planoVO);
                return Ok($"Plano {planoVO.CodigoPlano} atualizado");
            }
        }

        [HttpDelete("excluir/{codigoPlano}", Name = "DeleteByCodigoPlano")]
        public IActionResult DeleteByCodigoPlano(int codigoPlano)
        {
            try
            {
                _planoBusiness.DeleteByCodigoPlano(codigoPlano);
                return Ok("Plano excluído");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}
