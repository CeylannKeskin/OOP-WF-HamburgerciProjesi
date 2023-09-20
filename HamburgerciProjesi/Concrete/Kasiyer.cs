using HamburgerciProjesi.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamburgerciProjesi.Concrete
{
    public class Kasiyer : IPersonel
    {
        public string Ad { get; set; }
        public string Gorev { get; set; }
        public override string ToString()
        {
            return $"{Ad}, {Gorev}";
        }
    }
}
