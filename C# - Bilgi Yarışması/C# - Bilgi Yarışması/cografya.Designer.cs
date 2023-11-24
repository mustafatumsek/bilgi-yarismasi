namespace C____Bilgi_Yarışması
{
    partial class cografya
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cografya));
            anamenu = new Button();
            dsik = new Button();
            csik = new Button();
            bsik = new Button();
            asik = new Button();
            panel1 = new Panel();
            soru = new Label();
            sorusıra = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // anamenu
            // 
            anamenu.Location = new Point(225, 333);
            anamenu.Name = "anamenu";
            anamenu.Size = new Size(350, 89);
            anamenu.TabIndex = 28;
            anamenu.Text = "Ana Menüye Dön";
            anamenu.UseVisualStyleBackColor = true;
            anamenu.Visible = false;
            anamenu.Click += anamenu_Click_1;
            // 
            // dsik
            // 
            dsik.BackColor = Color.LightSkyBlue;
            dsik.Location = new Point(620, 303);
            dsik.Name = "dsik";
            dsik.Size = new Size(152, 141);
            dsik.TabIndex = 27;
            dsik.Text = "Aras Nehri";
            dsik.UseVisualStyleBackColor = false;
            dsik.Click += dsik_Click;
            // 
            // csik
            // 
            csik.BackColor = Color.LightSkyBlue;
            csik.Location = new Point(423, 303);
            csik.Name = "csik";
            csik.Size = new Size(152, 141);
            csik.TabIndex = 26;
            csik.Text = "Kızılırmak Nehri";
            csik.UseVisualStyleBackColor = false;
            csik.Click += csik_Click;
            // 
            // bsik
            // 
            bsik.BackColor = Color.LightSkyBlue;
            bsik.Location = new Point(225, 303);
            bsik.Name = "bsik";
            bsik.Size = new Size(152, 141);
            bsik.TabIndex = 25;
            bsik.Text = "Fırat Nehri";
            bsik.UseVisualStyleBackColor = false;
            bsik.Click += bsik_Click;
            // 
            // asik
            // 
            asik.BackColor = Color.LightSkyBlue;
            asik.Location = new Point(28, 303);
            asik.Name = "asik";
            asik.Size = new Size(152, 141);
            asik.TabIndex = 24;
            asik.Text = "Dicle Nehri";
            asik.UseVisualStyleBackColor = false;
            asik.Click += asik_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightSkyBlue;
            panel1.Controls.Add(soru);
            panel1.Location = new Point(-143, 121);
            panel1.Name = "panel1";
            panel1.Size = new Size(972, 155);
            panel1.TabIndex = 23;
            // 
            // soru
            // 
            soru.Font = new Font("Montserrat Light", 21.7499962F, FontStyle.Regular, GraphicsUnit.Point);
            soru.Location = new Point(139, 0);
            soru.Name = "soru";
            soru.Size = new Size(806, 155);
            soru.TabIndex = 0;
            soru.Text = "Hangisi Türkiye'nin en uzun nehridir?";
            soru.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // sorusıra
            // 
            sorusıra.AutoSize = true;
            sorusıra.Font = new Font("Montserrat Medium", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            sorusıra.Location = new Point(453, 66);
            sorusıra.Name = "sorusıra";
            sorusıra.Size = new Size(88, 29);
            sorusıra.TabIndex = 22;
            sorusıra.Text = "1. Soru";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Montserrat", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(410, 25);
            label1.Name = "label1";
            label1.Size = new Size(177, 37);
            label1.TabIndex = 21;
            label1.Text = "COĞRAFYA";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(245, 7);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(162, 108);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            // 
            // cografya
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
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
            Name = "cografya";
            Text = "Coğrafya Bilgi Yarışması";
            FormClosing += cografya_FormClosing;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button anamenu;
        private Button dsik;
        private Button csik;
        private Button bsik;
        private Button asik;
        private Panel panel1;
        private Label soru;
        private Label sorusıra;
        private Label label1;
        private PictureBox pictureBox1;
    }
}