using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatFinanças.Application.Gastos
{
    public interface IBuscarGastosQuery
    {
        Task<List<Domain.Entidades.Gasto>> Handle();
    }
}
