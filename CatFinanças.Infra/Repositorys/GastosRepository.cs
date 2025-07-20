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

        public Task<List<Gastos>> BuscarGastosAsync()
        {
            var gastos = new List<Gastos>();

            var gasto = new Gastos();
            gasto.Id = 1;
            gasto.Name = "Netflix";
            gasto.Valor = 19.99;

            gastos.Add(gasto);

            return Task.FromResult(gastos);
        }
    }
}
