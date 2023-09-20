using HamburgerciProjesi.Abstract;
using HamburgerciProjesi.Concrete;
using HamburgerciProjesi.Enum;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private Hamburgerci hamburgerci;
        private List<Musteri> musteriler;
        private Siparis siparis;
        Queue<Musteri> kuyruk;
        List<Menu> menuler;
        List<Icecek> icecekler;
        List<Ekstra> ekstralar;
        Sayac sayac;
        int _musteriSayaci = 0;
        int _siparisSayaci = 0;
        decimal _toplamSiparisTutari = 0;
        public Form1()
        {
            InitializeComponent();
            hamburgerci = new Hamburgerci();
            musteriler = new List<Musteri>();
            siparis = new Siparis();
            kuyruk = new Queue<Musteri>();
            menuler = new List<Menu>();
            icecekler = new List<Icecek>();
            ekstralar = new List<Ekstra>();
            sayac = new Sayac();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            cmbOdemeTipi.DataSource = Enum.GetValues(typeof(OdemeTipi));
            txtMusteriAdi.Visible = false;
            cmbOdemeTipi.Visible = false;
            cmbMenuler.Visible = false;
            cmbIcecekler.Visible = false;
            numMenuAdet.Visible = false;
            btnMusteriEkle.Enabled = false;
            btnMesaiBaslat.Enabled = false;
            btnMenuOlustur.Enabled = false;
            btnSiparisVer.Enabled = false;
            btnMesaiBitir.Visible = false;
            lstPersoneller.Visible = false;
            lstMusteriKuyruk.Visible = false;
            lstSiparisler.Visible = false;
            lblToplamTutar.Visible = false;
            lblOdemeTipi.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            lblPersoneller.Visible = false;
            lblGunSonu.Visible = false;

        }
        private void btnDukkanAc_Click(object sender, EventArgs e)
        {

            List<IPersonel> personeller = new List<IPersonel>(5);
            string[] _personeller = { "Ömer", "Faruk", "Ceylan", "Cevdet", "Dursun" };
            int sayac1 = 0;
            int kasiyerSayaci = 0;
            for (int i = 0; i < personeller.Capacity; i++)
            {

                int sayi = new Random().Next(2);
                sayac1 += sayi;
                if (sayac1 <= 3)
                {
                    switch (sayi)
                    {
                        case 1:
                            personeller.Add(new Kasiyer { Ad = _personeller[i], Gorev = "Kasiyer" });
                            kasiyerSayaci++;
                            break;
                        case 0:
                            personeller.Add(new MutfakCalisani { Ad = _personeller[i], Gorev = "Mutfakçý" });
                            break;
                    }
                }
                else
                {
                    personeller.Add(new MutfakCalisani { Ad = _personeller[i], Gorev = "Mutfakçý" });
                }

            }
            foreach (var i in personeller)
            {
                lstPersoneller.Items.Add(i);
            }


            for (int i = 1; i <= kasiyerSayaci; i++)
            {
                Button button = new Button();
                button.Text = "Kasa" + i.ToString();
                button.AutoSize = true;
                flpKasalar.Controls.Add(button);
            }

            btnMesaiBaslat.Enabled = false;
            btnMesaiBaslat.Enabled = true;
            lstPersoneller.Visible = true;
            btnMesaiBaslat.Enabled = true;
            lblPersoneller.Visible = true;
            btnDukkanAc.Enabled = false;
        }
        private void btnMesaiBaslat_Click(object sender, EventArgs e)
        {
            btnMesaiBaslat.Enabled = false;

            txtMusteriAdi.Enabled = true;
            cmbOdemeTipi.Enabled = true;
            btnMusteriEkle.Enabled = true;
            txtMusteriAdi.Visible = true;
            cmbOdemeTipi.SelectedIndex = -1;
            cmbOdemeTipi.Visible = true;
            label2.Visible = true;
            lblOdemeTipi.Visible = true;
        }

        private void btnMusteriEkle_Click(object sender, EventArgs e)
        {
            
            try
            {
                musteriler.Clear();
                string musteriAdi = txtMusteriAdi.Text;
                OdemeTipi odemeTipi = (OdemeTipi)cmbOdemeTipi.SelectedItem;
                Musteri musteri = new Musteri { Ad = musteriAdi, OdemeTipi = odemeTipi };
                kuyruk.Enqueue(musteri);
                musteriler.Add(musteri);
                lstMusteriKuyruk.DataSource = musteriler;
                _musteriSayaci++;
                lstMusteriKuyruk.Visible = true;
                txtMusteriAdi.Clear();
                cmbOdemeTipi.SelectedIndex = -1;
                btnMenuOlustur.Enabled = true;
                lstSiparisler.DataSource = null;
                lstSiparisler.Items.Clear();
                lblToplamTutar.Visible = false;
            }
            catch (Exception)
            {

                MessageBox.Show("Lütfen ödeme tipi seçiniz.");
            }




        }

        private void btnMenuOlustur_Click(object sender, EventArgs e)
        {
            flpEkstralar.Controls.Clear();
            cmbMenuler.DataSource = null;


            menuler = new List<Menu>() {
            new Menu { MenuAdi = "Big King Menü", MenuFiyati = 50.5M, HazirlanmaSuresi=5, BegenilmeOrani=BegenilmeOrani.Orta },
            new Menu { MenuAdi = "Double King Chicken Menü", MenuFiyati = 51.6M, HazirlanmaSuresi = 6, BegenilmeOrani = BegenilmeOrani.Iyi },
            new Menu { MenuAdi = "Steakhouse Menü", MenuFiyati = 52.7M ,HazirlanmaSuresi = 7, BegenilmeOrani = BegenilmeOrani.CokIyi },
            new Menu { MenuAdi = "Wooper Menü", MenuFiyati = 53.8M, HazirlanmaSuresi = 5, BegenilmeOrani = BegenilmeOrani.CokAz },
            new Menu { MenuAdi = "Wooper Jr. Menü", MenuFiyati = 54.9M, HazirlanmaSuresi = 8, BegenilmeOrani = BegenilmeOrani.Az },
            new Menu { MenuAdi = "Chicken Royal Menü", MenuFiyati = 55.99M, HazirlanmaSuresi = 6, BegenilmeOrani = BegenilmeOrani.CokIyi }};
            cmbMenuler.DataSource = menuler;

            icecekler = new List<Icecek>{
            new Icecek {IcecekAdi = "Kola", IcecekFiyati=6M, Boyut=Boyut.Buyuk },
            new Icecek {IcecekAdi = "Kola", IcecekFiyati=5M, Boyut=Boyut.Kucuk },
            new Icecek {IcecekAdi = "Fanta", IcecekFiyati=6M, Boyut=Boyut.Buyuk },
            new Icecek {IcecekAdi = "Fanta", IcecekFiyati=5M, Boyut=Boyut.Kucuk },
            new Icecek {IcecekAdi = "Gazoz", IcecekFiyati=6M, Boyut=Boyut.Buyuk },
            new Icecek {IcecekAdi = "Gazoz", IcecekFiyati=5M, Boyut=Boyut.Kucuk },
            new Icecek {IcecekAdi = "Ayran", IcecekFiyati=6M, Boyut=Boyut.Buyuk },
            new Icecek {IcecekAdi = "Ayran", IcecekFiyati=3M, Boyut=Boyut.Kucuk },
            new Icecek {IcecekAdi = "Su", IcecekFiyati=3M, Boyut=Boyut.Kucuk }};
            cmbIcecekler.DataSource = icecekler;

            ekstralar = new List<Ekstra> {
                new Ekstra {EkstraAdi="Ketçap" },
                new Ekstra {EkstraAdi="Mayonez" },
                new Ekstra {EkstraAdi="Hardal" },
                new Ekstra {EkstraAdi="Barbekü" },
                new Ekstra {EkstraAdi="Buffalo" },
                new Ekstra {EkstraAdi="Acý Sos" }};
            foreach (Ekstra item in ekstralar)
            {
                flpEkstralar.Controls.Add(new CheckBox()
                {
                    Text = item.EkstraAdi,
                    Tag = item
                });
            }

            cmbMenuler.SelectedIndex = -1;
            cmbIcecekler.SelectedIndex = -1;
            numMenuAdet.Value = 0;
            foreach (CheckBox chk in flpEkstralar.Controls)
            {
                chk.Checked = false;
            }
            cmbMenuler.Visible = true;
            cmbIcecekler.Visible = true;
            numMenuAdet.Visible = true;
            btnSiparisVer.Enabled = true;
        }
        private void btnSiparisVer_Click(object sender, EventArgs e)
        {
            try
            {
                siparis.Menu = (Menu)cmbMenuler.SelectedItem;
                siparis.Adet = (int)numMenuAdet.Value;
                siparis.Ekstralar = new List<Ekstra>();
                foreach (CheckBox item in flpEkstralar.Controls)
                {
                    if (item.Checked)
                    {
                        siparis.Ekstralar.Add((Ekstra)item.Tag);

                    }
                }
                siparis.Icecek = (Icecek)cmbIcecekler.SelectedItem;
                siparis.Hesapla();
                lstSiparisler.Items.Add(siparis);
                lblToplamTutar.Text = "Toplam Tutar = " + siparis.ToplamTutar.ToString("C2");
                _siparisSayaci++;
                _toplamSiparisTutari += siparis.ToplamTutar;
                lstMusteriKuyruk.DataSource = null;
                lstSiparisler.Visible = true;
                lblToplamTutar.Visible = true;
                btnMesaiBitir.Visible = true;
                btnMenuOlustur.Enabled = false;
                cmbMenuler.SelectedIndex = -1;
                cmbIcecekler.SelectedIndex = -1;
                numMenuAdet.Value = 0;
            foreach (CheckBox chk in flpEkstralar.Controls)
            {
                chk.Checked = false;
            }

            }
            catch (Exception)
            {

                MessageBox.Show("Lütfen menü, adet ve içecek seçimi yapýnýz");
            }



        }
        private void btnMesaiBitir_Click(object sender, EventArgs e)
        {
            sayac.MusteriSayisi = _musteriSayaci;
            sayac.SiparisSayisi = _siparisSayaci;
            sayac.ToplamKazanc = _toplamSiparisTutari;
            lblGunSonu.Text = sayac.ToString();
            label1.Visible = true;
            lblGunSonu.Visible = true;


            txtMusteriAdi.Visible = false;
            cmbOdemeTipi.Visible = false;
            cmbMenuler.Visible = false;
            cmbIcecekler.Visible = false;
            numMenuAdet.Visible = false;
            btnMusteriEkle.Enabled = false;
            btnMesaiBaslat.Enabled = false;
            btnMenuOlustur.Enabled = false;
            btnSiparisVer.Enabled = false;
            btnMesaiBitir.Visible = false;
            lstPersoneller.Visible = false;
            lstMusteriKuyruk.Visible = false;
            lstSiparisler.Visible = false;
            lblToplamTutar.Visible = false;
            lblPersoneller.Visible = false;
            flpEkstralar.Visible = false;
            label2.Visible = false;
            lblOdemeTipi.Visible = false;
            flpKasalar.Controls.Clear();

        }
    }
}