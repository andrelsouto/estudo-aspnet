using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using rest_consulta.Enums;
using rest_consulta.Model;
using rest_consulta.Services;

namespace rest_consulta.Controllers
{
    [ApiController]
    [Route("api/plano")]
    public class PlanoController : ControllerBase
    {

        private readonly IPlanoService _planoService;
        
        public PlanoController(IPlanoService planoService)
        {
            _planoService = planoService;
        }

        [HttpPost]
        public IActionResult SavePlano(Plano plano)
        {

            return Created("", _planoService.SavePlano(plano));

        }

        [HttpGet]
        public IEnumerable<Plano> GetPlano([FromQuery] StatusPlano status = StatusPlano.Default, [FromQuery] string cpf = "")
        {

            return _planoService.GetPlano(status, cpf);

        }

    }
}