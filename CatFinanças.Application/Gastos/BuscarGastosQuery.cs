using CatFinanças.Infra.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatFinanças.Application.Gastos
{
    public class BuscarGastosQuery : IBuscarGastosQuery
    {
        public IGastosRepository _gastosRepository;
        public BuscarGastosQuery(IGastosRepository gastosRepository)
        {
            _gastosRepository = gastosRepository;
        }

        public async Task<List<Domain.Entidades.Gasto>> Handle()
        {
            var gastos = await _gastosRepository.BuscarGastosAsync();
            return gastos;
        }
    }
}
