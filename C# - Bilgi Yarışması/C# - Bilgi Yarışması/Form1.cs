using System.Security.Cryptography;

namespace C____Bilgi_Yarışması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            label2.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            button4.Visible = true;
            button5.Visible = true;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            tarih1 tarih1 = new tarih1();
            tarih1.Show();
            this.Hide();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            spor spor = new spor();
            spor.Show();
            this.Hide();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            cografya cografya = new cografya();
            cografya.Show();
            this.Hide();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            mat mat = new mat();
            mat.Show();
            this.Hide();
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e) {Application.Exit();}
    }
}