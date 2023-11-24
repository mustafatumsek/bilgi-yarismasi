namespace C____Bilgi_Yarışması
{
    partial class tarih1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tarih1));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            sorusıra = new Label();
            panel1 = new Panel();
            soru = new Label();
            asik = new Button();
            bsik = new Button();
            csik = new Button();
            dsik = new Button();
            anamenu = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(243, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(162, 108);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Montserrat", 26.2499962F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(428, 12);
            label1.Name = "label1";
            label1.Size = new Size(133, 48);
            label1.TabIndex = 1;
            label1.Text = "TARİH";
            // 
            // sorusıra
            // 
            sorusıra.AutoSize = true;
            sorusıra.Font = new Font("Montserrat Medium", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            sorusıra.Location = new Point(451, 60);
            sorusıra.Name = "sorusıra";
            sorusıra.Size = new Size(88, 29);
            sorusıra.TabIndex = 2;
            sorusıra.Text = "1. Soru";
            // 
            // panel1
            // 
            panel1.BackColor = Color.PapayaWhip;
            panel1.Controls.Add(soru);
            panel1.Location = new Point(-145, 115);
            panel1.Name = "panel1";
            panel1.Size = new Size(972, 155);
            panel1.TabIndex = 3;
            // 
            // soru
            // 
            soru.Font = new Font("Montserrat Light", 21.7499962F, FontStyle.Regular, GraphicsUnit.Point);
            soru.Location = new Point(145, 0);
            soru.Name = "soru";
            soru.Size = new Size(800, 155);
            soru.TabIndex = 0;
            soru.Text = "Harf devrimi hangi tarihte yapılmışır?";
            soru.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // asik
            // 
            asik.BackColor = Color.PapayaWhip;
            asik.Location = new Point(26, 297);
            asik.Name = "asik";
            asik.Size = new Size(152, 141);
            asik.TabIndex = 4;
            asik.Text = "29 Ekim 1923";
            asik.UseVisualStyleBackColor = false;
            asik.Click += asik_Click;
            // 
            // bsik
            // 
            bsik.BackColor = Color.PapayaWhip;
            bsik.Location = new Point(223, 297);
            bsik.Name = "bsik";
            bsik.Size = new Size(152, 141);
            bsik.TabIndex = 5;
            bsik.Text = "28 Şubat 1936";
            bsik.UseVisualStyleBackColor = false;
            bsik.Click += bsik_Click;
            // 
            // csik
            // 
            csik.BackColor = Color.PapayaWhip;
            csik.Location = new Point(421, 297);
            csik.Name = "csik";
            csik.Size = new Size(152, 141);
            csik.TabIndex = 7;
            csik.Text = "1 Kasım 1928";
            csik.UseVisualStyleBackColor = false;
            csik.Click += csik_Click;
            // 
            // dsik
            // 
            dsik.BackColor = Color.PapayaWhip;
            dsik.Location = new Point(618, 297);
            dsik.Name = "dsik";
            dsik.Size = new Size(152, 141);
            dsik.TabIndex = 9;
            dsik.Text = "14 Nisan 1930";
            dsik.UseVisualStyleBackColor = false;
            dsik.Click += dsik_Click;
            // 
            // anamenu
            // 
            anamenu.Location = new Point(223, 327);
            anamenu.Name = "anamenu";
            anamenu.Size = new Size(350, 89);
            anamenu.TabIndex = 10;
            anamenu.Text = "Ana Menüye Dön";
            anamenu.UseVisualStyleBackColor = true;
            anamenu.Visible = false;
            anamenu.Click += anamenu_Click;
            // 
            // tarih1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PeachPuff;
            ClientSize = new Size(800, 450);
            Controls.Add(anamenu);
            Controls.Add(dsik);
            Controls.Add(csik);
            Controls.Add(bsik);
            Controls.Add(asik);
            Controls.Add(panel1);
            Controls.Add(sorusıra);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "tarih1";
            Text = "Tarih Bilgi Yarışması";
            FormClosing += tarih1_FormClosing;
            Load += tarih1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label sorusıra;
        private Panel panel1;
        private Label soru;
        private Button asik;
        private Button bsik;
        private Button csik;
        private Button dsik;
        private Button anamenu;
    }
}