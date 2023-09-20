using HamburgerciProjesi.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamburgerciProjesi.Abstract
{
    public interface IIcecek
    {
        public string IcecekAdi { get; set; }
        public decimal IcecekFiyati { get; set; }
        Boyut Boyut { get; set; }
    }
}
