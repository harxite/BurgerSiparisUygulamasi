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
    public partial class SiparisOlustur : Form
    {
        public SiparisOlustur()
        {
            InitializeComponent();
        }

        private void SiparisOlustur_Load(object sender, EventArgs e)
        {
            MenuyuGetir();
            EkstraMalzemeleriGetir();
        }

        public void MenuyuGetir()
        {
            for (int i = 0; i < MainMenu.menuler.Count; i++)
            {
                Menu menu = new Menu();
                menu.Ad = MainMenu.menuler[i].Ad;
                menu.Fiyat = MainMenu.menuler[i].Fiyat;

                cboxMenu.Items.Add(menu);
            }
        }

        public void EkstraMalzemeleriGetir()
        {
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;

            for (int i = 0; i < MainMenu.ekstralar.Count; i++)
            {
                Malzeme malzeme = new Malzeme();
                malzeme.Ad = MainMenu.ekstralar[i].Ad;
                malzeme.Fiyat = MainMenu.ekstralar[i].Fiyat;

                CheckBox cb = new CheckBox();
                cb.Text = malzeme.Ad;
                cb.Tag = malzeme;

                flowLayoutPanel1.Controls.Add(cb);
            }
        }

        private void btnSiparisEkle_Click(object sender, EventArgs e)
        {
            Siparis siparis = new Siparis();
            SiparisBilgileriniAl(siparis);
            siparis.ToplamFiyat = ToplamFiyatBelirle(siparis);
            MainMenu.geciciSiparisler.Add(siparis);
            SiparisleriEkranaYazdir(siparis, siparis.malzemeler);
        }
        public void SiparisBilgileriniAl(Siparis siparis)
        {
            string boyut;
            if (rbBuyuk.Checked == true)
            {
                boyut = "Büyük";
            }
            else if (rbOrta.Checked == true)
            {
                boyut = "Orta";
            }
            else { boyut = "Küçük"; }

            siparis.Boyut = boyut;
            siparis.Adet = (int)nudAdet.Value;

            Menu menu = new Menu();
            int index = cboxMenu.SelectedIndex;
            menu = MainMenu.menuler[index];
            siparis.Menu = menu;

            siparis.malzemeler.Clear();
            foreach (Control control in flowLayoutPanel1.Controls)
            {
                if (control is CheckBox)
                {
                    CheckBox cb = (CheckBox)control;
                    if (cb.Checked)
                    {
                        Malzeme malzeme = new Malzeme();
                        malzeme = (Malzeme)cb.Tag;
                        siparis.malzemeler.Add(malzeme);
                    }
                }
            }
        }

        public decimal ToplamFiyatBelirle(Siparis siparis)
        {
            decimal malzemeFiyat = 0;

            foreach (Malzeme malzeme1 in siparis.malzemeler)
            {
                malzemeFiyat += malzeme1.Fiyat;
            }

            decimal toplamFiyat = (BoyutaGoreFiyatBelirle(siparis) + malzemeFiyat) * siparis.Adet;
            return toplamFiyat;
        }

        public decimal BoyutaGoreFiyatBelirle(Siparis siparis)
        {
            string boyut = siparis.Boyut;
            decimal fiyat = siparis.Menu.Fiyat;
            switch (boyut)
            {
                case "Küçük":
                    fiyat *= 1;
                    break;
                case "Orta":
                    fiyat *= 1.2m;
                    break;
                case "Büyük":
                    fiyat *= 1.4m;
                    break;
                default:
                    break;
            }
            return fiyat;
        }

        public void SiparisleriEkranaYazdir(Siparis siparis, List<Malzeme> malzemeler)
        {

            StringBuilder str = new StringBuilder();
            foreach (Malzeme malzeme in malzemeler)
            {
                if (malzemeler != null)
                {
                    str.Append(malzeme.Ad + ", ");
                }
            }

            string info = $"{siparis.Adet} adet {siparis.Menu.Ad},{siparis.Boyut}, {str} == > Toplam Fiyat : {siparis.ToplamFiyat} ₺";
            lstSiparisler.Items.Add(info);

            decimal tutar = 0;
            foreach (Siparis sprs in MainMenu.geciciSiparisler)
            {
                tutar += sprs.ToplamFiyat;
            }

            lblToplamTutar.Text = tutar.ToString("C2");
        }

        private void btnSiparisiOnayla_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Siparisi onaylamak istiyor musunuz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                MainMenu.siparisler.AddRange(MainMenu.geciciSiparisler);
                MainMenu.geciciSiparisler.Clear();
            }
        }
    }
}
