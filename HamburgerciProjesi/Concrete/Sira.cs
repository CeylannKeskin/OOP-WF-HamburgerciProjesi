using HamburgerciProjesi.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamburgerciProjesi.Concrete
{
    public class Sira 
    {
        Queue<Musteri> kuyruk = new Queue<Musteri>();
        public void KuyrugaGir(Musteri musteri)
        {
                kuyruk.Enqueue(musteri);   
        }

    }
}
