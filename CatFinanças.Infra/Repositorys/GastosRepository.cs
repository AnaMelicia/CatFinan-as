using CatFinanças.Domain.Entidades;
using CatFinanças.Infra.Interfaces;
using CatFinanças.Infra.Persistencia;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatFinanças.Infra.Repositorys
{
    public class GastosRepository : IGastosRepository
    {
        public GastosRepository(CatFinancasContext context)
        {
            _context = context;
        }

        private readonly CatFinancasContext _context;

        public async Task<List<Gasto>> BuscarGastosAsync()
        {
            var gastos = await _context.Gasto.ToListAsync();

            return gastos;
        }
    }
}
