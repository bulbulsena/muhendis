using System.Security.Cryptography.X509Certificates;

namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            personel prs42 = new personel(adTxt.Text, adresTxt.Text, Convert.ToInt32(yasTxt.Text), Convert.ToInt32(mesaiTxt.Text), comboBox1.Text);
            if (comboBox1.Text == "Ýþçi")


            {
                MessageBox.Show(prs42.ucretHesapla().ToString());

            }
            else
            {
                prs42.ucretHesapla(1000);
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void adresTxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}