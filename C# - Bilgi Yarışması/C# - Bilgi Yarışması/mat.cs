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
    public partial class mat : Form
    {
        public mat()
        {
            InitializeComponent();
        }
        public int s = 1;

        private void asik_Click(object sender, EventArgs e)
        {
            if (s == 1)
            {
                asik.BackColor = Color.Green;
                bsik.BackColor = Color.Red;
                csik.BackColor = Color.Red;
                dsik.BackColor = Color.Red;
                MessageBox.Show("Tebrikler. Doğru cevap!");
                asik.BackColor = Color.MediumSlateBlue;
                bsik.BackColor = Color.MediumSlateBlue;
                csik.BackColor = Color.MediumSlateBlue;
                dsik.BackColor = Color.MediumSlateBlue;
                sorusıra.Text = (s + 1) + ". Soru";
                soru.Text = "5 makinenin 5 cihaz üretmesi 5 dakika sürüyorsa 100 makinenin 100 cihaz üretmesi ne kadar sürer?";
                asik.Text = "5 dakika";
                bsik.Text = "1 saat";
                csik.Text = "1 saat 40 dakika";
                dsik.Text = "1 dakika";
            }
            if (s == 2)
            {
                asik.BackColor = Color.Green;
                bsik.BackColor = Color.Red;
                csik.BackColor = Color.Red;
                dsik.BackColor = Color.Red;
                MessageBox.Show("Tebrikler. Doğru cevap!");
                asik.BackColor = Color.MediumSlateBlue;
                bsik.BackColor = Color.MediumSlateBlue;
                csik.BackColor = Color.MediumSlateBlue;
                dsik.BackColor = Color.MediumSlateBlue;
                sorusıra.Text = (s + 1) + ". Soru";
                soru.Text = "5 katının 5'e bölümü 5'e eşit olan sayının 5 fazlasının 5 eksiği kaça eşittir?";
                asik.Text = "0";
                bsik.Text = "5";
                csik.Text = "15";
                dsik.Text = "50";
            }
            if (s == 3)
            {
                asik.BackColor = Color.Red;
                bsik.BackColor = Color.Green;
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
                bsik.BackColor = Color.Green;
                csik.BackColor = Color.Red;
                dsik.BackColor = Color.Red;
                MessageBox.Show("Maalesef kaybettiniz.\nUlaştığınız soru: " + s + "\nKazandığınız ödül: 100000 TL");
                Application.Exit();
            }
            s++;
        }

        private void bsik_Click(object sender, EventArgs e)
        {
            if (s == 1)
            {
                asik.BackColor = Color.Green;
                bsik.BackColor = Color.Red;
                csik.BackColor = Color.Red;
                dsik.BackColor = Color.Red;
                MessageBox.Show("Maalesef kaybettiniz.\nUlaştığınız soru: " + s + "\nKazandığınız ödül: 1000 TL");
                Application.Exit();
            }
            if (s == 2)
            {
                asik.BackColor = Color.Green;
                bsik.BackColor = Color.Red;
                csik.BackColor = Color.Red;
                dsik.BackColor = Color.Red;
                MessageBox.Show("Maalesef kaybettiniz.\nUlaştığınız soru: " + s + "\nKazandığınız ödül: 30000 TL");
                Application.Exit();
            }

            if (s == 3)
            {
                asik.BackColor = Color.Red;
                bsik.BackColor = Color.Green;
                csik.BackColor = Color.Red;
                dsik.BackColor = Color.Red;
                MessageBox.Show("Tebrikler. Doğru cevap!");
                asik.BackColor = Color.MediumSlateBlue;
                bsik.BackColor = Color.MediumSlateBlue;
                csik.BackColor = Color.MediumSlateBlue;
                dsik.BackColor = Color.MediumSlateBlue;
                sorusıra.Text = (s + 1) + ". Soru";
                soru.Text = "Türkiye'deki illerin plaka kodlarının toplamı kaçtır?";
                asik.Text = "5543";
                bsik.Text = "6431";
                csik.Text = "3321";
                dsik.Text = "5210";
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
                bsik.BackColor = Color.Green;
                csik.BackColor = Color.Red;
                dsik.BackColor = Color.Red;
                MessageBox.Show("TEBRİKLER!\nTüm spor sorularını doğru yanıtlayarak büyük ödülü kazandınız!\nÖDÜLÜNÜZ:500000 TL");
                asik.BackColor = Color.MediumSlateBlue;
                bsik.BackColor = Color.MediumSlateBlue;
                csik.BackColor = Color.MediumSlateBlue;
                dsik.BackColor = Color.MediumSlateBlue;
                soru.Font = new Font("Helvetica", 23, FontStyle.Regular);
                soru.Text = "TEBRİKLER! MATEMATİK YARIŞMASINI KAZANDINIZ!";
                asik.Visible = false;
                bsik.Visible = false;
                csik.Visible = false;
                dsik.Visible = false;
                anamenu.Visible = true;
            }
            s++;
        }

        private void csik_Click(object sender, EventArgs e)
        {
            if (s == 1)
            {
                asik.BackColor = Color.Green;
                bsik.BackColor = Color.Red;
                csik.BackColor = Color.Red;
                dsik.BackColor = Color.Red;
                MessageBox.Show("Maalesef kaybettiniz.\nUlaştığınız soru: " + s + "\nKazandığınız ödül: 1000 TL");
                Application.Exit();
            }
            if (s == 2)
            {
                asik.BackColor = Color.Green;
                bsik.BackColor = Color.Red;
                csik.BackColor = Color.Red;
                dsik.BackColor = Color.Red;
                MessageBox.Show("Maalesef kaybettiniz.\nUlaştığınız soru: " + s + "\nKazandığınız ödül: 30000 TL");
                Application.Exit();
            }
            if (s == 3)
            {
                asik.BackColor = Color.Red;
                bsik.BackColor = Color.Green;
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
                asik.BackColor = Color.MediumSlateBlue;
                bsik.BackColor = Color.MediumSlateBlue;
                csik.BackColor = Color.MediumSlateBlue;
                dsik.BackColor = Color.MediumSlateBlue;
                sorusıra.Text = (s + 1) + ". Soru";
                soru.Text = "Bir milyon kere on milyon kaç eder?";
                asik.Text = "100 milyon";
                bsik.Text = "10 trilyon";
                csik.Text = "1 trilyon";
                dsik.Text = "10 milyar";
            }
            if (s == 5)
            {
                asik.BackColor = Color.Red;
                bsik.BackColor = Color.Green;
                csik.BackColor = Color.Red;
                dsik.BackColor = Color.Red;
                MessageBox.Show("Maalesef kaybettiniz.\nUlaştığınız soru: " + s + "\nKazandığınız ödül: 100000 TL");
                Application.Exit();
            }
            s++;
        }

        private void dsik_Click(object sender, EventArgs e)
        {
            if (s == 1)
            {
                asik.BackColor = Color.Green;
                bsik.BackColor = Color.Red;
                csik.BackColor = Color.Red;
                dsik.BackColor = Color.Red;
                MessageBox.Show("Maalesef kaybettiniz.\nUlaştığınız soru: " + s + "\nKazandığınız ödül: 1000 TL");
                Application.Exit();
            }
            if (s == 2)
            {
                asik.BackColor = Color.Green;
                bsik.BackColor = Color.Red;
                csik.BackColor = Color.Red;
                dsik.BackColor = Color.Red;
                MessageBox.Show("Maalesef kaybettiniz.\nUlaştığınız soru: " + s + "\nKazandığınız ödül: 30000 TL");
                Application.Exit();
            }
            if (s == 3)
            {
                asik.BackColor = Color.Red;
                bsik.BackColor = Color.Green;
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
                bsik.BackColor = Color.Green;
                csik.BackColor = Color.Red;
                dsik.BackColor = Color.Red;
                MessageBox.Show("Maalesef kaybettiniz.\nUlaştığınız soru: " + s + "\nKazandığınız ödül: 100000 TL");
                Application.Exit();
            }
            s++;
        }
        private void mat_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void anamenu_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
