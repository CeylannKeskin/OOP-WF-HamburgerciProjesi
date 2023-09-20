using HamburgerciProjesi.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamburgerciProjesi.Concrete
{
    //public delegate void HaberTipi(object sender, object sender2);
    //public delegate void HaberTipi2(object sender);
    public class Hamburgerci : IHamburgerci
    {
        public Hamburgerci()
        {
            //Kasalar = new List<IKasa>();
            //Kuyruk = new List<IMusteri>();
            //MesaiMi = false;
        }

        public List<IKasa> Kasalar { get; set ; }

        public ISayac Sayac { get; set; }
        public bool MesaiMi { get; set; }
        public List<IMusteri> MusteriSirasi { get; set; }

        public void MesaiBaslat(int kasaSayisi)
        {
            Kasalar = new List<IKasa>();
            for (int i = 0; i <= kasaSayisi; i++)
            {
                Kasalar.Add(new Kasa(i));
            }
            //Sira = new List<IMusteri>();
            Sayac = new Sayac();
            MesaiMi = true;

            //Sira sira = new Sira();
            //Kuyruk = new List<IMusteri>();
            //Sayac = new Sayac();
            //if (kasaSayisi > 3)
            //{
            //    throw new Exception("En fazla 3 kasa oluşturabilirsin");
            //}
            //else
            //{
            //    for (int i = 0; i < kasaSayisi; i++)
            //    {                    
            //        IKasa kasa = new Kasa();
            //        kasa.KuyrukBenMusaitim += sira.KasayaGit;
            //       // Sayac.KasadanIsiBitenSiparisiAl;
            //        Kasalar.Add(kasa);
            //    }
            //}
        }



        public void MesaiBitir()
        {
            MesaiMi = false;
        }
    }
}
