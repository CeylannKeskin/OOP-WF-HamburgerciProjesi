using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamburgerciProjesi.Abstract
{
    public interface ISayac
    {
        int SiparisSayisi { get; set; }
        int MusteriSayisi { get; set; }
        decimal ToplamKazanc { get; set; }
    }
}
