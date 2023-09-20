using HamburgerciProjesi.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamburgerciProjesi.Concrete
{
    public class Ekstra : IEkstra
    {
        public string EkstraAdi { get; set; }
        public decimal EkstraFiyati { get; set; } = 1M;
        public override string ToString()
        {
            return EkstraAdi;
        }
    }
}
