using HamburgerciProjesi.Concrete;
using HamburgerciProjesi.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamburgerciProjesi.Abstract
{
    public interface IMusteri
    {
        //event HaberTipi2 SiraBenGeldim;
        //event HaberTipi KasaBenGeldim;
        public string Ad { get; set; }
        OdemeTipi OdemeTipi { get; set; }
        ISira Sira { get; set; }
       // void SirayaGir(object sender);
        void SiparisVer();
        void OdemeYap();
        void SiparisiTeslimAl();
    }
}
