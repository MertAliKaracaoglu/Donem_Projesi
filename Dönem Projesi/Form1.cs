namespace Dönem_Projesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "mertkaraca@gmail.com" && textBox2.Text == "ata81")
            {
                Form2 f2 = new Form2();
                f2.Show();
            }
            else
                MessageBox.Show("Hatalı mail adresi veya şifre!");





        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == "18811905" && textBox4.Text == "memo2003")
            {
                Form3 f3 = new Form3();
                f3.Show();
            }
            else
                MessageBox.Show("Hatalı ID veya şifre!");
        }
    }
}