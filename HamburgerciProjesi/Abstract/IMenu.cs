using HamburgerciProjesi.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamburgerciProjesi.Abstract
{
    public interface IMenu
    {
        public string MenuAdi { get; set; }
        public decimal MenuFiyati { get; set; }
        public int HazirlanmaSuresi { get; set; }
        BegenilmeOrani BegenilmeOrani { get; set; }

    }
}
