using HamburgerciProjesi.Abstract;
using HamburgerciProjesi.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamburgerciProjesi.Concrete
{
    public class Musteri 
    {
        public string Ad { get; set; }
        public OdemeTipi OdemeTipi { get; set; }
        public List<Siparis> MusteriSiparisi { get; set; }



        public override string ToString()
        {
            return $"{Ad}-{OdemeTipi} {MusteriSiparisi}";
        }




        public void SiparisVer(Siparis siparis)
        {
            //OdemeYap() tetiklenecek
        }
        public void OdemeYap()
        {
            //MessageBox.Show($"{Ad} ödeme yaptı. Ödeme tipi: {OdemeTipi}");
            //SiparisHazirla() tetiklenecek
        }

        public void SiparisiTeslimAl()
        {
            //MessageBox.Show($"{Ad} siparişi teslim aldı.");
        }

    }
}
