using System.Collections.Generic;
using System.Threading.Tasks;
using SalesFly.Shared.Models;

namespace SalesFly.UI.Interfaces
{
    public interface IAeroportoService
    {
        Task<IEnumerable<Aeroporto>> GetAeroportosAsync();
    }
}
