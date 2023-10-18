namespace BurgerSiparis
{
    public partial class MainMenu : Form
    {
        public static List<Menu> menuler = new List<Menu>();
        public static List<Malzeme> ekstralar = new List<Malzeme>();
        public static List<Siparis> siparisler = new List<Siparis>();
        public static List<Siparis> geciciSiparisler = new List<Siparis>();

        Menu menu = new Menu()
        {
            Ad = "Whopper Menu",
            Fiyat = 150
        };

        Menu menu1 = new Menu()
        {
            Ad = "Big King Menu",
            Fiyat = 170
        };

        Malzeme malzeme = new Malzeme()
        {
            Ad = "Ketcap",
            Fiyat = 5
        };

        Malzeme malzeme1 = new Malzeme()
        {
            Ad = "Mayonez",
            Fiyat = 5
        };
        
        public MainMenu()
        {
            InitializeComponent();
            menuler.Add(menu);
            menuler.Add(menu1);
            ekstralar.Add(malzeme);
            ekstralar.Add(malzeme1);
        }
        private void MainMenu_Load(object sender, EventArgs e)
        {
            SiparisOlustur siparis1 = new SiparisOlustur();
            EkranıGetir(siparis1);
        }
        private void siparişOluşturToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormlariKapat();
            SiparisOlustur siparis1 = new SiparisOlustur();
            EkranıGetir(siparis1);
        }

        private void siparişGörüntüleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormlariKapat();
            SiparisGoruntule siparisGoruntule = new SiparisGoruntule();
            EkranıGetir(siparisGoruntule);
        }

        private void menuEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormlariKapat();
            MenuEkle menuEkle = new MenuEkle();
            EkranıGetir(menuEkle);
        }

        private void ekstraMalzemeEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormlariKapat();
            MalzemeEkle malzemeEkle = new MalzemeEkle();
            EkranıGetir(malzemeEkle);
        }

        public void EkranıGetir(Form form)
        {
            form.MdiParent = this;
            form.Dock = DockStyle.Fill;
            this.Width = form.Width + 30;
            this.Height = form.Height + 60;
            form.Show();
        }

        public void FormlariKapat()
        {
            Form[] forms = this.MdiChildren;
            foreach (Form form in forms)
            {
                form.Close();
            }
        }
    }
}