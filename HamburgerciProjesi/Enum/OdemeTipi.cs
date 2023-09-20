using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HamburgerciProjesi.Enum
{
    public enum OdemeTipi
    {
        Nakit,
       // [Display(Name = "Kredi Kartı")]
        KrediKarti,
       // [Display(Name = "Yemek Kartı")]
        YemekKarti,
        Mobil
    }
}
