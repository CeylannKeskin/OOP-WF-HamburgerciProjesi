using HamburgerciProjesi.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HamburgerciProjesi.Concrete
{
    public class Kasa : IKasa
    {
        public int ID { get; set; }
        public bool MusaitMi { get; set; }
        public Kasa(int id)
        {
            ID = id;
            MusaitMi = true;
        }


        //public event HaberTipi2 KuyrukBenMusaitim;
        //public event HaberTipi SayacIsimBitti;
        //public event HaberTipi SiparisiAldım;

        public void SiparisGir(object sender)
        {
            if(MusaitMi)
            {
                MusaitMi = false;
                //MessageBox.Show($"{ID}. kasadan sipariş girildi.");
            }
            else
            {
                //MessageBox.Show($"{ID}. kasa meşgul.");
            }
        }
        //public Siparis SiparisGonder (object sender)
        //{
        //    return (Siparis)sender;
        //}
    }
}
