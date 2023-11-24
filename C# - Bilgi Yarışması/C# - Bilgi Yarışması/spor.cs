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
    public partial class spor : Form
    {
        public spor()
        {
            InitializeComponent();
        }
        public int s = 1;

        private void asik_Click(object sender, EventArgs e)
        {
            if (s == 1)
            {
                asik.BackColor = Color.Red;
                bsik.BackColor = Color.Red;
                csik.BackColor = Color.Red;
                dsik.BackColor = Color.Green;
                MessageBox.Show("Maalesef kaybettiniz.\nUlaştığınız soru: " + s + "\nKazandığınız ödül: 1000 TL");
                Application.Exit();
            }
            if (s == 2)
            {
                asik.BackColor = Color.Red;
                bsik.BackColor = Color.Green;
                csik.BackColor = Color.Red;
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
                asik.BackColor = Color.Green;
                bsik.BackColor = Color.Red;
                csik.BackColor = Color.Red;
                dsik.BackColor = Color.Red;
                MessageBox.Show("Tebrikler. Doğru cevap!");
                asik.BackColor = Color.RosyBrown;
                bsik.BackColor = Color.RosyBrown;
                csik.BackColor = Color.RosyBrown;
                dsik.BackColor = Color.RosyBrown;
                sorusıra.Text = (s + 1) + ". Soru";
                soru.Text = "Hangi futbolcu kariyeri boyunca daha çok gol atmıştır?";
                asik.Text = "Fernando Torres";
                bsik.Text = "Andriy Shevchenko";
                csik.Text = "Wayne Rooney";
                dsik.Text = "Didier Drogba";
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
                bsik.BackColor = Color.Red;
                csik.BackColor = Color.Red;
                dsik.BackColor = Color.Green;
                MessageBox.Show("Maalesef kaybettiniz.\nUlaştığınız soru: " + s + "\nKazandığınız ödül: 1000 TL");
                Application.Exit();
            }
            if (s == 2)
            {
                asik.BackColor = Color.Red;
                bsik.BackColor = Color.Green;
                csik.BackColor = Color.Red;
                dsik.BackColor = Color.Red;
                MessageBox.Show("Tebrikler. Doğru cevap!");
                asik.BackColor = Color.RosyBrown;
                bsik.BackColor = Color.RosyBrown;
                csik.BackColor = Color.RosyBrown;
                dsik.BackColor = Color.RosyBrown;
                sorusıra.Text = (s + 1) + ". Soru";
                soru.Text = "Hangi F1 pilotunun 1'den fazla pilotlar şampiyonluğu yoktur?";
                asik.Text = "Fernando Alonso";
                bsik.Text = "Alberto Ascari";
                csik.Text = "Niki Lauda";
                dsik.Text = "Kimi Räikkönen";
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
                asik.BackColor = Color.Green;
                bsik.BackColor = Color.Red;
                csik.BackColor = Color.Red;
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
                asik.BackColor = Color.RosyBrown;
                bsik.BackColor = Color.RosyBrown;
                csik.BackColor = Color.RosyBrown;
                dsik.BackColor = Color.RosyBrown;
                soru.Font = new Font("Helvetica", 23, FontStyle.Regular);
                soru.Text = "TEBRİKLER! SPOR YARIŞMASINI KAZANDINIZ!";
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
                bsik.BackColor = Color.Red;
                csik.BackColor = Color.Red;
                dsik.BackColor = Color.Green;
                MessageBox.Show("Maalesef kaybettiniz.\nUlaştığınız soru: " + s + "\nKazandığınız ödül: 1000 TL");
                Application.Exit();
            }
            if (s == 2)
            {
                asik.BackColor = Color.Red;
                bsik.BackColor = Color.Green;
                csik.BackColor = Color.Red;
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
                asik.BackColor = Color.Green;
                bsik.BackColor = Color.Red;
                csik.BackColor = Color.Red;
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

        private void dsik_Click(object sender, EventArgs e)
        {
            if (s == 1)
            {
                asik.BackColor = Color.Red;
                bsik.BackColor = Color.Red;
                csik.BackColor = Color.Red;
                dsik.BackColor = Color.Green;
                MessageBox.Show("Tebrikler. Doğru cevap!");
                asik.BackColor = Color.RosyBrown;
                bsik.BackColor = Color.RosyBrown;
                csik.BackColor = Color.RosyBrown;
                dsik.BackColor = Color.RosyBrown;
                sorusıra.Text = (s + 1) + ". Soru";
                soru.Text = "Rajon Rondo hangi kulüpte forma giymemiştir?";
                asik.Text = "Chicago Bulls";
                bsik.Text = "Utah Jazz";
                csik.Text = "Dallas Mavericks";
                dsik.Text = "New Orleands Pelicans";
            }
            if (s == 2)
            {
                asik.BackColor = Color.Red;
                bsik.BackColor = Color.Green;
                csik.BackColor = Color.Red;
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
                MessageBox.Show("Tebrikler. Doğru cevap!");
                asik.BackColor = Color.RosyBrown;
                bsik.BackColor = Color.RosyBrown;
                csik.BackColor = Color.RosyBrown;
                dsik.BackColor = Color.RosyBrown;
                sorusıra.Text = (s + 1) + ". Soru";
                soru.Text = "Hangi şehir son 4 yaz olimpiyatlarından birine ev sahipliği yapmamıştır?";
                asik.Text = "Atlanta";
                bsik.Text = "Tokyo";
                csik.Text = "Pekin";
                dsik.Text = "Rio de Janiero";
            }
            if (s == 4)
            {
                asik.BackColor = Color.Green;
                bsik.BackColor = Color.Red;
                csik.BackColor = Color.Red;
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

        private void anamenu_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
        private void spor_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
