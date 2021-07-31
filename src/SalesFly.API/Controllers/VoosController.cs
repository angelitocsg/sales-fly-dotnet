using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SalesFly.API.Repositories;
using SalesFly.Shared.Models;

namespace SalesFly.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VoosController : ControllerBase
    {
        private readonly IUberAirRepository _uberAirRepository;

        public VoosController(IUberAirRepository uberAirRepository)
        {
            _uberAirRepository = uberAirRepository;
        }

        [HttpGet]
        public async Task<ActionResult<Voo[]>> GetAsync()
        {
            return Ok(await _uberAirRepository.GetAsync());
        }
    }
}
