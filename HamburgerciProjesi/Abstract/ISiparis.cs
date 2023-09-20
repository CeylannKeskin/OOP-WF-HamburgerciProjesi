using HamburgerciProjesi.Concrete;
using HamburgerciProjesi.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamburgerciProjesi.Abstract
{
    public interface ISiparis
    {
        Menu Menu { get; set; }
        List<Ekstra> Ekstralar { get; set; }
        Icecek Icecek { get; set; }
        public int Adet { get; set; }
        public decimal ToplamTutar { get; set; }
        void Hesapla();
    }
}
