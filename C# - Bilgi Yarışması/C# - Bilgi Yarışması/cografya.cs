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
    public partial class cografya : Form
    {
        public cografya()
        {
            InitializeComponent();
        }
        public int s = 1;

        private void asik_Click(object sender, EventArgs e)
        {
            if (s == 1)
            {
                asik.BackColor = Color.Red;
                bsik.BackColor = Color.Green;
                csik.BackColor = Color.Red;
                dsik.BackColor = Color.Red;
                MessageBox.Show("Maalesef kaybettiniz.\nUlaştığınız soru: " + s + "\nKazandığınız ödül: 1000 TL");
                Application.Exit();
            }
            if (s == 2)
            {
                asik.BackColor = Color.Red;
                bsik.BackColor = Color.Red;
                csik.BackColor = Color.Green;
                dsik.BackColor = Color.Red;
                MessageBox.Show("Maalesef kaybettiniz.\nUlaştığınız soru: " + s + "\nKazandığınız ödül: 15000 TL");
                Application.Exit();
            }
            if (s == 3)
            {
                asik.BackColor = Color.Red;
                bsik.BackColor = Color.Red;
                csik.BackColor = Color.Red;
                dsik.BackColor = Color.Green;
                MessageBox.Show("Maalesef kaybettiniz.\nUlaştığınız soru: " + s + "\nKazandığınız ödül: 30000 TL");
                Application.Exit();
            }
            if (s == 4)
            {
                asik.BackColor = Color.Red;
                bsik.BackColor = Color.Red;
                csik.BackColor = Color.Red;
                dsik.BackColor = Color.Green;
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
                asik.BackColor = Color.Red;
                bsik.BackColor = Color.Green;
                csik.BackColor = Color.Red;
                dsik.BackColor = Color.Red;
                MessageBox.Show("Tebrikler. Doğru cevap!");
                asik.BackColor = Color.LightSkyBlue;
                bsik.BackColor = Color.LightSkyBlue;
                csik.BackColor = Color.LightSkyBlue;
                dsik.BackColor = Color.LightSkyBlue;
                sorusıra.Text = (s + 1) + ". Soru";
                soru.Text = "Allahüekber dağları Türkiye'nin hangi bölgesindedir?";
                asik.Text = "Akdeniz Bölgesi";
                bsik.Text = "İç Anadolu Bölgesi";
                csik.Text = "Doğu Anadolu Bölgesi";
                dsik.Text = "Karadeniz Bölgesi";
            }
            if (s == 2)
            {
                asik.BackColor = Color.Red;
                bsik.BackColor = Color.Red;
                csik.BackColor = Color.Red;
                dsik.BackColor = Color.Green;
                MessageBox.Show("Maalesef kaybettiniz.\nUlaştığınız soru: " + s + "\nKazandığınız ödül: 30000 TL");
                Application.Exit();
            }

            if (s == 3)
            {
                asik.BackColor = Color.Red;
                bsik.BackColor = Color.Red;
                csik.BackColor = Color.Red;
                dsik.BackColor = Color.Green;
                MessageBox.Show("Maalesef kaybettiniz.\nUlaştığınız soru: " + s + "\nKazandığınız ödül: 30000 TL");
                Application.Exit();
            }
            if (s == 4)
            {
                asik.BackColor = Color.Red;
                bsik.BackColor = Color.Red;
                csik.BackColor = Color.Red;
                dsik.BackColor = Color.Green;
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
                asik.BackColor = Color.LightSkyBlue;
                bsik.BackColor = Color.LightSkyBlue;
                csik.BackColor = Color.LightSkyBlue;
                dsik.BackColor = Color.LightSkyBlue;
                soru.Font = new Font("Helvetica", 23, FontStyle.Regular);
                soru.Text = "TEBRİKLER! COĞRAFYA YARIŞMASINI KAZANDINIZ!";
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
                asik.BackColor = Color.Red;
                bsik.BackColor = Color.Green;
                csik.BackColor = Color.Red;
                dsik.BackColor = Color.Red;
                MessageBox.Show("Maalesef kaybettiniz.\nUlaştığınız soru: " + s + "\nKazandığınız ödül: 1000 TL");
                Application.Exit();
            }
            if (s == 2)
            {
                asik.BackColor = Color.Red;
                bsik.BackColor = Color.Red;
                csik.BackColor = Color.Green;
                dsik.BackColor = Color.Red;
                MessageBox.Show("Tebrikler. Doğru cevap!");
                asik.BackColor = Color.LightSkyBlue;
                bsik.BackColor = Color.LightSkyBlue;
                csik.BackColor = Color.LightSkyBlue;
                dsik.BackColor = Color.LightSkyBlue;
                sorusıra.Text = (s + 1) + ". Soru";
                soru.Text = "Bogota hangi ülkenin başkentidir?";
                asik.Text = "Kenya";
                bsik.Text = "Nijerya";
                csik.Text = "Bolivya";
                dsik.Text = "Kolombiya";
            }
            if (s == 3)
            {
                asik.BackColor = Color.Red;
                bsik.BackColor = Color.Red;
                csik.BackColor = Color.Red;
                dsik.BackColor = Color.Green;
                MessageBox.Show("Maalesef kaybettiniz.\nUlaştığınız soru: " + s + "\nKazandığınız ödül: 30000 TL");
                Application.Exit();
            }
            if (s == 4)
            {
                asik.BackColor = Color.Red;
                bsik.BackColor = Color.Red;
                csik.BackColor = Color.Red;
                dsik.BackColor = Color.Green;
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

        private void dsik_Click(object sender, EventArgs e)
        {
            if (s == 1)
            {
                asik.BackColor = Color.Red;
                bsik.BackColor = Color.Green;
                csik.BackColor = Color.Red;
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
                MessageBox.Show("Maalesef kaybettiniz.\nUlaştığınız soru: " + s + "\nKazandığınız ödül: 30000 TL");
                Application.Exit();
            }
            if (s == 3)
            {
                asik.BackColor = Color.Red;
                bsik.BackColor = Color.Red;
                csik.BackColor = Color.Red;
                dsik.BackColor = Color.Green;
                MessageBox.Show("Tebrikler. Doğru cevap!");
                asik.BackColor = Color.LightSkyBlue;
                bsik.BackColor = Color.LightSkyBlue;
                csik.BackColor = Color.LightSkyBlue;
                dsik.BackColor = Color.LightSkyBlue;
                sorusıra.Text = (s + 1) + ". Soru";
                soru.Text = "Hangi ülke diğer üçünden daha kuzeydedir?";
                asik.Text = "Gana";
                bsik.Text = "Burkina Faso";
                csik.Text = "Nijerya";
                dsik.Text = "Mali";
            }
            if (s == 4)
            {
                asik.BackColor = Color.Red;
                bsik.BackColor = Color.Red;
                csik.BackColor = Color.Red;
                dsik.BackColor = Color.Green;
                MessageBox.Show("Tebrikler. Doğru cevap!");
                asik.BackColor = Color.LightSkyBlue;
                bsik.BackColor = Color.LightSkyBlue;
                csik.BackColor = Color.LightSkyBlue;
                dsik.BackColor = Color.LightSkyBlue;
                sorusıra.Text = (s + 1) + ". Soru";
                soru.Text = "Maveraünnehir, hangi iki nehrin arasında kalan bölgedir?";
                asik.Text = "Fırat - Dicle";
                bsik.Text = "Ceyhun - Seyhun";
                csik.Text = "Kızılırmak - Yeşilırmak";
                dsik.Text = "Büyükmenderes - Küçükmenderes";
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
        private void cografya_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void anamenu_Click_1(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
