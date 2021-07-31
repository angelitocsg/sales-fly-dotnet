using System.Collections.Generic;
using System.Threading.Tasks;
using SalesFly.Shared.Models;

namespace SalesFly.API.Repositories
{
    public interface IAeroportoRepository
    {
        Task<IEnumerable<Aeroporto>> GetAsync();
    }
}
