using static siniflar.kullanici;
using siniflar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dönem_Projesi
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            comboBox1.SelectedIndex = 0;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int alinacakkilo))
            {
                if (comboBox1.SelectedItem == "Yavru")
                {
                    int kilofiyati = 150;

                    int toplamücret = alinacakkilo * kilofiyati;

                    label13.Text = $"Tutar: {toplamücret}";
                }
                else if (comboBox1.SelectedItem == "Yetişkin")
                {
                    int kilofiyati = 100;

                    int toplamücret = alinacakkilo * kilofiyati;

                    label13.Text = $"Tutar: {toplamücret}";
                }
                else
                {
                    MessageBox.Show("Lütfen iki seçenekten birini seçin.");
                }
            }
            else
            {
                MessageBox.Show("Lütfen bağışlamak istediğiniz mamanın ağırlığını giriniz.");
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox2.Text, out int alinacakkilo))
            {
                if (comboBox2.SelectedItem == "Yavru")
                {
                    int kilofiyati = 100;

                    int toplamücret = alinacakkilo * kilofiyati;

                    label15.Text = $"Tutar: {toplamücret}";
                }
                else if (comboBox2.SelectedItem == "Yetişkin")
                {
                    int kilofiyati = 80;

                    int toplamücret = alinacakkilo * kilofiyati;

                    label15.Text = $"Tutar: {toplamücret}";
                }
                else
                {
                    MessageBox.Show("Lütfen iki seçenekten birini seçin.");
                }
            }
            else
            {
                MessageBox.Show("Lütfen bağışlamak istediğiniz mamanın ağırlığını giriniz.");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            kedimamasi satinalinankedimamasi = new kedimamasi();
            satinalinankedimamasi.durum = comboBox1.ValueMember;
            satinalinankedimamasi.kilo = int.Parse(textBox1.Text);
            satinalinankedimamasi.tanebuyuklugu = comboBox3.ValueMember;
            satinalinankedimamasi.aroma = comboBox4.ValueMember;

            label17.Text = $"{comboBox1.SelectedItem} kediler için {textBox1.Text} kilo,{comboBox3.SelectedItem},{comboBox4.SelectedItem}\nkedi maması satın aldınız.";
            
            

            bool a = kedimamasi.Temizle();
            if (a)
            {
                textBox1.Text = "";
            }

        }
        private void button6_Click(object sender, EventArgs e)
        {
            kopekmamasi satinalinankopekmamasi = new kopekmamasi();
            satinalinankopekmamasi.durum = comboBox2.ValueMember;
            satinalinankopekmamasi.kilo = int.Parse(textBox2.Text);
            satinalinankopekmamasi.tanebuyuklugu = comboBox5.ValueMember;
            satinalinankopekmamasi.aroma = comboBox6.ValueMember;

            label18.Text = $"{comboBox2.SelectedItem} köpekler için {textBox2.Text} kilo,{comboBox5.SelectedItem},{comboBox6.SelectedItem}\nköpek maması satın aldınız.";

            bool a = kopekmamasi.Temizle();
            if (a)
            {
                textBox2.Text = "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBox7.Items.Clear();
            foreach (var item in barinak.barinaklar)
            {
                comboBox7.Items.Add(item.barinakad);
            }

            label4.Text = "Liste başarıyla güncellendi.";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox7.SelectedItem == null) 
            {
                MessageBox.Show("Lütfen barınak seçiniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);                
            }
            else if (string.IsNullOrWhiteSpace(label17.Text))
            {
                MessageBox.Show("Bağış yapmak için öncelikle mama satın almalısınız!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Bağışınızı başarılı bir şekilde gerçekleştirdiniz.\nBağış dekontunuz kısa bir süre sonra kayıtlı mail adresinize gönderilecektir.\nİşleminiz için teşekkürler.");
                label17.Text = string.Empty;
                label18.Text = string.Empty;
            }







        }
    }
}
