using HamburgerciProjesi.Abstract;
using HamburgerciProjesi.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamburgerciProjesi.Concrete
{
    public class Icecek : IIcecek
    {
        public string IcecekAdi { get; set; }
        public decimal IcecekFiyati { get; set; }
        public Boyut Boyut { get; set; }
        public override string ToString()
        {
            return $"{IcecekAdi} {IcecekFiyati.ToString("C2")} {Boyut}";
        }
    }
}
