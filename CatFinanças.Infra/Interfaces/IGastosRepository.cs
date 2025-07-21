using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatFinanças.Infra.Interfaces
{
    public interface IGastosRepository
    {
        Task<List<Domain.Entidades.Gasto>> BuscarGastosAsync();
    }
}
