using ApiPolizas.Models;
using ApiPolizas.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiPolizas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class PolizaController : ControllerBase
    {
        public SeguroService _seguroService;
        public string vigencia = "NO";
        public string noVigencia = "Poliza NO vigente";
        public PolizaController(SeguroService seguroService)
        {
            _seguroService = seguroService;
        }

        
        [HttpGet]
        public ActionResult<List<Poliza>> Get()
        {
            return _seguroService.Get();
        }

        [Route("Poliza/{poliza}")]
        [HttpGet]
        public ActionResult<List<Poliza>> GetNumeroPoliza([FromRoute]  int poliza)
        {
            return _seguroService.GetNumeroPoliza(poliza);

        }

        [HttpPost]
        public ActionResult<Poliza> Create(Poliza poliza)
        {
            if (poliza.Poliza_vigente == vigencia)
            {
                return BadRequest(noVigencia);
            }

            _seguroService.Create(poliza);
            return Ok(poliza);
        }

    }
}
