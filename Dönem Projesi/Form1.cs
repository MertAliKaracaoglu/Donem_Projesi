using Microsoft.VisualBasic.ApplicationServices;
using siniflar;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Dönem_Projesi
{
    public partial class Form1 : Form
    {
        public List<kullanici> kullanicilar = new List<kullanici>();
        public Form1()
        {
            InitializeComponent();
        }


        private void button3_Click(object sender, EventArgs e)
        {
            kullanici yeniKullanici = new kullanici();
            yeniKullanici.MailAdresi = textBox9.Text;
            yeniKullanici.Ad = textBox6.Text;
            yeniKullanici.Soyad = textBox5.Text;
            yeniKullanici.KullaniciAdi = textBox8.Text;
            yeniKullanici.Sifre = textBox7.Text;


            if (string.IsNullOrEmpty(yeniKullanici.KullaniciAdi) || string.IsNullOrEmpty(yeniKullanici.Sifre))
            {
                MessageBox.Show("Lütfen tüm seçenekleri doldurunuz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                kullanicilar.Add(yeniKullanici);
                MessageBox.Show("Kayıt başarıyla tamamlandı.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = textBox1.Text;
            string sifre = textBox2.Text;

            kullanici girisYapan = kullanicilar.Find(k => k.KullaniciAdi == kullaniciAdi && k.Sifre == sifre);

            if (girisYapan != null)
            {
                Form2 f2 = new Form2();
                f2.Show();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == "18811905" && textBox4.Text == "admin01")
            {
                Form3 f3 = new Form3();
                f3.Show();
            }
            else if (textBox3.Text == "01012003" && textBox4.Text == "admin02")
            {
                Form3 f3 = new Form3();
                f3.Show();
            }
            else
            {
                MessageBox.Show("ID No veya şifre hatalı.");
            }
        }
    }



}
