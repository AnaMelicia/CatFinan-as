using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatFinanças.Domain.Entidades
{
    public class Gasto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Valor { get; set; }
        public bool Fixo { get; set; }

    }
}
