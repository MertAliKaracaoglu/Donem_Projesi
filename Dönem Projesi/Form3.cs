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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Dönem_Projesi
{
    public partial class Form3 : Form
    {

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int barinakID = Convert.ToInt32(textBox4.Text);
            string barinakad = textBox1.Text;
            string barinakadres = textBox2.Text;
            int barinakbuyukluk = Convert.ToInt32(textBox3.Text);
            barinak.barinakEkle(barinakad, barinakadres, barinakbuyukluk, barinakID);

            MessageBox.Show("Yeni barınak başarıyla eklendi.");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            foreach (var item in barinak.barinaklar)
            {
                comboBox1.Items.Add(item.barinakad);
            }

            label6.Text = "Güncellendi.";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var aranan = comboBox1.SelectedItem;
            if(aranan != null) 
            {
                foreach(var item in barinak.barinaklar) 
                {
                    if(item.barinakad == aranan.ToString()) 
                    {
                        MessageBox.Show("Barinak Silindi");
                        barinak.barinaklar.Remove(item);
                        break;
                    }
                }
            }
        }
    }
}
