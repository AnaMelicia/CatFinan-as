using CatFinanças.Domain.Entidades;
using CatFinanças.Infra.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatFinanças.Infra.Repositorys
{
    public class GastosRepository : IGastosRepository
    {
        public GastosRepository() { }

        public Task<List<Gasto>> BuscarGastosAsync()
        {
            var gastos = new List<Gasto>();

            var gasto = new Gasto();
            gasto.Id = 1;
            gasto.Name = "Netflix";
            gasto.Valor = 19.99;

            gastos.Add(gasto);

            return Task.FromResult(gastos);
        }
    }
}
