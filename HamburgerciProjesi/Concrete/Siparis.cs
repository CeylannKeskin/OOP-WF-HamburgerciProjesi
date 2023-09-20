using HamburgerciProjesi.Abstract;
using HamburgerciProjesi.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamburgerciProjesi.Concrete
{
    public class Siparis : ISiparis
    {
        public Menu Menu { get; set; }
        public List<Ekstra> Ekstralar { get; set; }
        public Icecek Icecek { get; set; }
        public int Adet { get; set; }
        public decimal ToplamTutar { get; set; }

        public void Hesapla()
        {
            decimal menuTutar = Menu.MenuFiyati * Adet;
            decimal icecekTutar = Icecek.IcecekFiyati;
            decimal ekstraTutar = Ekstralar.Sum(ekstra => ekstra.EkstraFiyati);


            ToplamTutar = menuTutar + ekstraTutar + icecekTutar;
        }

        public override string ToString()
        {
            
            return $"{Menu.MenuAdi} x {Adet} adet, {Icecek.Boyut} {Icecek.IcecekAdi} ({string.Join(",",Ekstralar)})";
        }
    }
}
