using HamburgerciProjesi.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamburgerciProjesi.Concrete
{
    public class Mutfak : IMutfak
    {
        public event EventHandler KasaSiparisHazir;

        public void SiparisiHazirla()
        {
           // MessageBox.Show("Mutfak siparişleri hazırlıyor...");

            System.Threading.Thread.Sleep(3000);

            //MessageBox.Show("Siparişler  hazır.");

            //SiparisiTeslimAl() tetiklenecek
        }
    }
}
