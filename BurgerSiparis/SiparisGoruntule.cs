using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BurgerSiparis
{
    public partial class SiparisGoruntule : Form
    {
        public SiparisGoruntule()
        {
            InitializeComponent();
        }

        private void SiparisGoruntule_Load(object sender, EventArgs e)
        {
            SiparisleriEkranaYazdir(MainMenu.siparisler);
            ToplamSiparisiYazdir();
            SatilanUrunAdediniYazdir(MainMenu.siparisler);
            EkstraMalzemeGeliriniYazdir(MainMenu.siparisler);
            CiroyuYazdir(MainMenu.siparisler);
        }

        private void CiroyuYazdir(List<Siparis> siparisler)
        {
            decimal toplamCiro = 0;
            foreach (Siparis siparis1 in siparisler)
            {
                toplamCiro += siparis1.ToplamFiyat;
            }
            lblCiro.Text = toplamCiro.ToString("C2");
        }

        private void EkstraMalzemeGeliriniYazdir(List<Siparis> siparisler)
        {
            decimal malzemeGeliri = 0;
            foreach (Siparis siparis1 in siparisler)
            {
                if (siparis1.malzemeler != null)
                {
                    foreach (Malzeme malzeme in siparis1.malzemeler)
                    {
                        malzemeGeliri += malzeme.Fiyat;
                    }
                }
            }
            lblMalzemeGeliri.Text = malzemeGeliri.ToString("C2");
        }

        private void SatilanUrunAdediniYazdir(List<Siparis> siparisler)
        {
            int toplamMalzemeSayisi;
            int adet = 0;

            foreach (Siparis siparis1 in siparisler)
            {
                if (siparis1.malzemeler != null)
                {
                    toplamMalzemeSayisi = siparis1.malzemeler.Count;
                    adet += (toplamMalzemeSayisi + 1) * siparis1.Adet;
                }
            }
            lblUrunAdedi.Text = adet.ToString();
        }

        private void ToplamSiparisiYazdir()
        {
            int toplamSiparisSayisi = lstSiparisler.Items.Count;
            lblToplamSiparis.Text = toplamSiparisSayisi.ToString();
        }

        public void SiparisleriEkranaYazdir(List<Siparis> siparisler)
        {
            lstSiparisler.Items.Clear();
            StringBuilder str = new StringBuilder();

            foreach (Siparis siparis1 in siparisler)
            {
                if (siparis1.malzemeler != null)
                {
                    foreach (Malzeme malzeme in siparis1.malzemeler)
                    {
                        str.Append(", " + malzeme.Ad);
                    }
                    string info = $"{siparis1.Adet} adet {siparis1.Menu.Ad},{siparis1.Boyut} {str}";
                    lstSiparisler.Items.Add(info);
                    str.Clear();
                }
            }
        }
    }
}
