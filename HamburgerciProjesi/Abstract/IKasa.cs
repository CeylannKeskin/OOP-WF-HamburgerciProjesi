using HamburgerciProjesi.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamburgerciProjesi.Abstract
{
    public interface IKasa
    {
        //event HaberTipi2 KuyrukBenMusaitim;
        //event HaberTipi SayacIsimBitti;
        int ID { get; set; }
        public bool MusaitMi { get; set; }
        void SiparisGir(object sender);
    }
}
