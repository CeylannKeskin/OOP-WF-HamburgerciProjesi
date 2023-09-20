using HamburgerciProjesi.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamburgerciProjesi.Abstract
{
    public interface IMutfak
    {
        event EventHandler KasaSiparisHazir;
        void SiparisiHazirla();
    }
}
