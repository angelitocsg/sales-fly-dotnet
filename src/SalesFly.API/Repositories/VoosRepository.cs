using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using SalesFly.Shared.Models;

namespace SalesFly.API.Repositories
{
    public class VoosRepository : IVoosRepository
    {
        public async Task<IEnumerable<Voo>> GetAsync()
        {
            var UberAir = await (new UberAirRepository().GetAsync());
            var _99Planes = await (new NineNinePlanesRepository().GetAsync());
            return UberAir.Concat(_99Planes);
        }
    }
}
