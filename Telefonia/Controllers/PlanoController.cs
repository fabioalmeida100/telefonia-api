using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Telefonia.Business;
using Telefonia.Model;

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

        [HttpGet("{id}/{DDD}", Name = "Get")]
        public IActionResult Get(int id, int DDD)
        {
            return Ok(_planoBusiness.FindById(id));
        }

    }
}
