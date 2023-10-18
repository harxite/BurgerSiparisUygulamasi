using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerSiparis
{
    public class Siparis
    {
        public int Adet { get; set; }

        public string Boyut { get; set; }

        public decimal ToplamFiyat { get; set; }
     
        public  Menu Menu { get; set; }

        public List<Malzeme> malzemeler = new List<Malzeme>();

    }
}
