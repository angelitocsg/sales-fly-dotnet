using System.Collections.Generic;
using System.Threading.Tasks;
using SalesFly.Shared.Models;

namespace SalesFly.API.Repositories
{
    public interface IUberAirRepository
    {
        Task<IEnumerable<Voo>> GetAsync();
    }
}
