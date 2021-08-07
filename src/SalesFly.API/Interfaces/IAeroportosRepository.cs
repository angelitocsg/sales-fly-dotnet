using System.Collections.Generic;
using System.Threading.Tasks;
using SalesFly.Shared.Models;

namespace SalesFly.API.Interfaces
{
    public interface IAeroportosRepository
    {
        Task<IEnumerable<Aeroporto>> GetAsync();
    }
}
