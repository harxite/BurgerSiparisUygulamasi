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
    public partial class MenuEkle : Form
    {
        List<Menu> menuler = new List<Menu>();
        public MenuEkle()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Ad = txtMenuAd.Text;
            menu.Fiyat = (int)nudMenuFiyat.Value;
            MainMenu.menuler.Add(menu);
        }
    }
}
