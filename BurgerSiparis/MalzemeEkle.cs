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
    public partial class MalzemeEkle : Form
    {

        public MalzemeEkle()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Malzeme malzeme = new Malzeme();
            malzeme.Ad = txtMalzemeAd.Text;
            malzeme.Fiyat = (int)nudMalzemeFiyat.Value;
            MainMenu.ekstralar.Add(malzeme);
        }
    }
}
