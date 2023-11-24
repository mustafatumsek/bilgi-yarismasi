using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C____Bilgi_Yarışması
{
    public partial class tarih1 : Form
    {
        public tarih1()
        {
            InitializeComponent();
        }
        public int s = 1;

        private void tarih1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void tarih1_Load(object sender, EventArgs e)
        {
        }

        private void asik_Click(object sender, EventArgs e)
        {
            if (s == 1)
            {
                asik.BackColor = Color.Red;
                bsik.BackColor = Color.Red;
                csik.BackColor = Color.Green;
                dsik.BackColor = Color.Red;
                MessageBox.Show("Maalesef kaybettiniz.\nUlaştığınız soru: " + s + "\nKazandığınız ödül: 1000 TL");
                Application.Exit();
            }
            if (s == 2)
            {
                asik.BackColor = Color.Red;
                bsik.BackColor = Color.Red;
                csik.BackColor = Color.Red;
                dsik.BackColor = Color.Green;
                MessageBox.Show("Maalesef kaybettiniz.\nUlaştığınız soru: " + s + "\nKazandığınız ödül: 15000 TL");
                Application.Exit();
            }
            if (s == 3)
            {
                asik.BackColor = Color.Green;
                bsik.BackColor = Color.Red;
                csik.BackColor = Color.Red;
                dsik.BackColor = Color.Red;
                MessageBox.Show("Tebrikler. Doğru cevap!");
                asik.BackColor = Color.PapayaWhip;
                bsik.BackColor = Color.PapayaWhip;
                csik.BackColor = Color.PapayaWhip;
                dsik.BackColor = Color.PapayaWhip;
                sorusıra.Text = (s + 1) + ". Soru";
                soru.Text = "İslamiyeti kabul eden ilk Türk boyu hangisidir?";
                asik.Text = "Kayılar";
                bsik.Text = "Peçenekler";
                csik.Text = "Karluklar";
                dsik.Text = "Karahıtaylar";
            }
            if (s == 4)
            {
                asik.BackColor = Color.Red;
                bsik.BackColor = Color.Red;
                csik.BackColor = Color.Green;
                dsik.BackColor = Color.Red;
                MessageBox.Show("Maalesef kaybettiniz.\nUlaştığınız soru: " + s + "\nKazandığınız ödül: 50000 TL");
                Application.Exit();
            }
            if (s == 5)
            {
                asik.BackColor = Color.Red;
                bsik.BackColor = Color.Red;
                csik.BackColor = Color.Red;
                dsik.BackColor = Color.Green;
                MessageBox.Show("Maalesef kaybettiniz.\nUlaştığınız soru: " + s + "\nKazandığınız ödül: 100000 TL");
                Application.Exit();
            }
            s++;
        }

        private void bsik_Click(object sender, EventArgs e)
        {
            if (s == 1)
            {
                asik.BackColor = Color.Red;
                bsik.BackColor = Color.Red;
                csik.BackColor = Color.Green;
                dsik.BackColor = Color.Red;
                MessageBox.Show("Maalesef kaybettiniz.\nUlaştığınız soru: " + s + "\nKazandığınız ödül: 1000 TL");
                Application.Exit();
            }
            if (s == 2)
            {
                asik.BackColor = Color.Red;
                bsik.BackColor = Color.Red;
                csik.BackColor = Color.Red;
                dsik.BackColor = Color.Green;
                MessageBox.Show("Maalesef kaybettiniz.\nUlaştığınız soru: " + s + "\nKazandığınız ödül: 15000 TL");
                Application.Exit();
            }
            if (s == 3)
            {
                asik.BackColor = Color.Green;
                bsik.BackColor = Color.Red;
                csik.BackColor = Color.Red;
                dsik.BackColor = Color.Red;
                MessageBox.Show("Maalesef kaybettiniz.\nUlaştığınız soru: " + s + "\nKazandığınız ödül: 30000 TL");
                Application.Exit();
            }
            if (s == 4)
            {
                asik.BackColor = Color.Red;
                bsik.BackColor = Color.Red;
                csik.BackColor = Color.Green;
                dsik.BackColor = Color.Red;
                MessageBox.Show("Maalesef kaybettiniz.\nUlaştığınız soru: " + s + "\nKazandığınız ödül: 50000 TL");
                Application.Exit();
            }
            if (s == 5)
            {
                asik.BackColor = Color.Red;
                bsik.BackColor = Color.Red;
                csik.BackColor = Color.Red;
                dsik.BackColor = Color.Green;
                MessageBox.Show("Maalesef kaybettiniz.\nUlaştığınız soru: " + s + "\nKazandığınız ödül: 100000 TL");
                Application.Exit();
            }
            s++;
        }

        private void csik_Click(object sender, EventArgs e)
        {
            if (s == 1)
            {
                asik.BackColor = Color.Red;
                bsik.BackColor = Color.Red;
                csik.BackColor = Color.Green;
                dsik.BackColor = Color.Red;
                MessageBox.Show("Tebrikler. Doğru cevap!");
                asik.BackColor = Color.PapayaWhip;
                bsik.BackColor = Color.PapayaWhip;
                csik.BackColor = Color.PapayaWhip;
                dsik.BackColor = Color.PapayaWhip;
                sorusıra.Text = (s + 1) + ". Soru";
                soru.Text = "Timur hangi ülke ile savaşmamıştır?";
                asik.Text = "Osmanlı İmparatorluğu";
                bsik.Text = "Altınorda Devleti";
                csik.Text = "Hindistan";
                dsik.Text = "Çungar Hanlığı";
            }
            if (s == 2)
            {
                asik.BackColor = Color.Red;
                bsik.BackColor = Color.Red;
                csik.BackColor = Color.Red;
                dsik.BackColor = Color.Green;
                MessageBox.Show("Maalesef kaybettiniz.\nUlaştığınız soru: " + s + "\nKazandığınız ödül: 15000 TL");
                Application.Exit();
            }
            if (s == 3)
            {
                asik.BackColor = Color.Green;
                bsik.BackColor = Color.Red;
                csik.BackColor = Color.Red;
                dsik.BackColor = Color.Red;
                MessageBox.Show("Maalesef kaybettiniz.\nUlaştığınız soru: " + s + "\nKazandığınız ödül: 30000 TL");
                Application.Exit();
            }
            if (s == 4)
            {
                asik.BackColor = Color.Red;
                bsik.BackColor = Color.Red;
                csik.BackColor = Color.Green;
                dsik.BackColor = Color.Red;
                MessageBox.Show("Tebrikler. Doğru cevap!");
                asik.BackColor = Color.PapayaWhip;
                bsik.BackColor = Color.PapayaWhip;
                csik.BackColor = Color.PapayaWhip;
                dsik.BackColor = Color.PapayaWhip;
                sorusıra.Text = (s + 1) + ". Soru";
                soru.Text = "Napolyon'un 1802'de Birleşik Krallık ile imzaladığı ve Devrim Savaşları'nı sonlandırdığı antlaşmanın adı nedir?";
                asik.Text = "Korsika Antlaşması";
                bsik.Text = "Longwood Antlaşması";
                csik.Text = "Pasarofça Antlaşması";
                dsik.Text = "Amiens Antlaşması";
            }
            if (s == 5)
            {
                asik.BackColor = Color.Red;
                bsik.BackColor = Color.Red;
                csik.BackColor = Color.Red;
                dsik.BackColor = Color.Green;
                MessageBox.Show("Maalesef kaybettiniz.\nUlaştığınız soru: " + s + "\nKazandığınız ödül: 100000 TL");
                Application.Exit();
            }
            s++;
        }

        private void dsik_Click(object sender, EventArgs e)
        {
            if (s == 1)
            {
                asik.BackColor = Color.Red;
                bsik.BackColor = Color.Red;
                csik.BackColor = Color.Green;
                dsik.BackColor = Color.Red;
                MessageBox.Show("Maalesef kaybettiniz.\nUlaştığınız soru: " + s + "\nKazandığınız ödül: 1000 TL");
                Application.Exit();
            }
            if (s == 2)
            {
                asik.BackColor = Color.Red;
                bsik.BackColor = Color.Red;
                csik.BackColor = Color.Red;
                dsik.BackColor = Color.Green;
                MessageBox.Show("Tebrikler. Doğru cevap!");
                asik.BackColor = Color.PapayaWhip;
                bsik.BackColor = Color.PapayaWhip;
                csik.BackColor = Color.PapayaWhip;
                dsik.BackColor = Color.PapayaWhip;
                sorusıra.Text = (s + 1) + ". Soru";
                soru.Text = "Alp Er Tunga kimdir?";
                asik.Text = "Saka Hanı";
                bsik.Text = "Hun İmparatoru";
                csik.Text = "Karahanlı Hükümdarı";
                dsik.Text = "Göktürk Kağanı";
            }
            if (s == 3)
            {
                asik.BackColor = Color.Green;
                bsik.BackColor = Color.Red;
                csik.BackColor = Color.Red;
                dsik.BackColor = Color.Red;
                MessageBox.Show("Maalesef kaybettiniz.\nUlaştığınız soru: " + s + "\nKazandığınız ödül: 30000 TL");
                Application.Exit();
            }
            if (s == 4)
            {
                asik.BackColor = Color.Red;
                bsik.BackColor = Color.Red;
                csik.BackColor = Color.Green;
                dsik.BackColor = Color.Red;
                MessageBox.Show("Maalesef kaybettiniz.\nUlaştığınız soru: " + s + "\nKazandığınız ödül: 50000 TL");
                Application.Exit();
            }
            if (s == 5)
            {
                asik.BackColor = Color.Red;
                bsik.BackColor = Color.Red;
                csik.BackColor = Color.Red;
                dsik.BackColor = Color.Green;
                MessageBox.Show("TEBRİKLER!\nTüm tarih sorularını doğru yanıtlayarak büyük ödülü kazandınız!\nÖDÜLÜNÜZ:500000 TL");
                asik.BackColor = Color.PapayaWhip;
                bsik.BackColor = Color.PapayaWhip;
                csik.BackColor = Color.PapayaWhip;
                dsik.BackColor = Color.PapayaWhip;
                soru.Font = new Font("Helvetica", 23, FontStyle.Regular);
                soru.Text = "TEBRİKLER! TARİH YARIŞMASINI KAZANDINIZ!";
                asik.Visible = false;
                bsik.Visible = false;
                csik.Visible = false;
                dsik.Visible = false;
                anamenu.Visible = true;
            }
            s++;
        }

        private void anamenu_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
