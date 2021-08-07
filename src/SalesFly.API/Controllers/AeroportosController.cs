using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SalesFly.API.Interfaces;
using SalesFly.Shared.Models;

namespace SalesFly.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AeroportosController : ControllerBase
    {
        private readonly IAeroportosRepository _aeroportoRepository;

        public AeroportosController(IAeroportosRepository aeroportoRepository)
        {
            _aeroportoRepository = aeroportoRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Aeroporto>>> Get()
        {
            IEnumerable<Aeroporto> aeroportos = await _aeroportoRepository.GetAsync();
            return Ok(aeroportos);
        }
    }
}
