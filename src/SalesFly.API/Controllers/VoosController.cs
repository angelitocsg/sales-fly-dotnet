using System;
using System.Linq;
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
        private readonly IVoosRepository _voosRepository;

        public VoosController(IVoosRepository voosRepository)
        {
            _voosRepository = voosRepository;
        }

        [HttpGet("{origem}/{destino}/{data}")]
        public async Task<ActionResult<Voo[]>> GetAsync(
            string origem,
            string destino,
            DateTime data)
        {
            var voos = await _voosRepository.GetAsync();
            var result = voos.Where(it => it.Origem.Equals(origem) && it.Destino.Equals(destino) && it.DataSaida.Equals(data));

            return Ok(result);
        }
    }
}
