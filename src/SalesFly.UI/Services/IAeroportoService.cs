using System.Collections.Generic;
using System.Threading.Tasks;
using SalesFly.Shared.Models;

namespace SalesFly.UI.Services
{
    public interface IAeroportoService
    {
        Task<IEnumerable<Aeroporto>> GetAeroportosAsync();
    }
}
