using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SalesFly.Shared.Models;

namespace SalesFly.UI.Interfaces
{
    public interface IVooService
    {
         Task<IEnumerable<Voo>> GetVoosAsync(string origem, string destino, DateTime data);
    }
}
