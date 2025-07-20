using CatFinanças.Application.Gastos;
using CatFinanças.Domain.Entidades;
using Microsoft.AspNetCore.Mvc;

namespace CatFinanças.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GastosController : ControllerBase
    {


        private readonly ILogger<GastosController> _logger;

        public GastosController(ILogger<GastosController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetGastos")]
        public async Task<List<Gastos>> Get([FromServices] IBuscarGastosQuery handler)
        {
            return await handler.Handle();

        }
    }
}
