using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamburgerciProjesi.Abstract
{
    public interface IHamburgerci
    {
        List<IKasa> Kasalar { get; set; }
        public static List<IMusteri> Sira { get; set; }
        ISayac Sayac { get; set; }
        public bool MesaiMi { get; set; }
        public void MesaiBaslat(int kasaSayisi);
        public void MesaiBitir();
    }
}
