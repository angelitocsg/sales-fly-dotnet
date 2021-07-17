using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using SalesFly.Shared.Models;

namespace SalesFly.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AeroportosController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<Aeroporto>> Get()
        {
            IEnumerable<Aeroporto> aeroportos = new List<Aeroporto>(){
                new Aeroporto("Aeroporto Internacional Juscelino Kubitschek", "BSB","Brasília"),
                new Aeroporto("Aeroporto Eurico de Aguiar Salles", "VIX","Vitória"),
                new Aeroporto("Aeroporto Internacional Zumbi dos Palmares", "MCZ","Maceió"),
            };

            return Ok(aeroportos);
        }
    }
}
