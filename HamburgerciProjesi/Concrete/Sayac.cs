using HamburgerciProjesi.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamburgerciProjesi.Concrete
{
    public class Sayac : ISayac
    {
        public int MusteriSayisi { get; set; }
        public int SiparisSayisi { get; set; }
        public decimal ToplamKazanc { get; set; }
        public override string ToString()
        {
            return $"Toplam Müşteri Sayısı: {MusteriSayisi}\n Toplam Sipariş Sayısı: {SiparisSayisi}\n Günlük Ciro :{ToplamKazanc.ToString("C2")}";
        }

    }
}
