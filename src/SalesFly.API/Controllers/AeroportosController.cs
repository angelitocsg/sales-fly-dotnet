using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SalesFly.API.Repositories;
using SalesFly.Shared.Models;

namespace SalesFly.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AeroportosController : ControllerBase
    {
        private readonly IAeroportoRepository _aeroportoRepository;

        public AeroportosController(IAeroportoRepository aeroportoRepository)
        {
            _aeroportoRepository = aeroportoRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Aeroporto>>> Get()
        {
            // IEnumerable<Aeroporto> aeroportos = new List<Aeroporto>(){
            //     new Aeroporto("Aeroporto Internacional Juscelino Kubitschek", "BSB","Brasília"),
            //     new Aeroporto("Aeroporto Eurico de Aguiar Salles", "VIX","Vitória"),
            //     new Aeroporto("Aeroporto Internacional Zumbi dos Palmares", "MCZ","Maceió"),
            // };

            IEnumerable<Aeroporto> aeroportos = await _aeroportoRepository.GetAsync();

            return Ok(aeroportos);
        }
    }
}
