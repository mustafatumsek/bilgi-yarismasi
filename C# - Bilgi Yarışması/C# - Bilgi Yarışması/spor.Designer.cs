namespace C____Bilgi_Yarışması
{
    partial class spor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(spor));
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
            anamenu.Location = new Point(221, 333);
            anamenu.Name = "anamenu";
            anamenu.Size = new Size(350, 89);
            anamenu.TabIndex = 19;
            anamenu.Text = "Ana Menüye Dön";
            anamenu.UseVisualStyleBackColor = true;
            anamenu.Visible = false;
            anamenu.Click += anamenu_Click;
            // 
            // dsik
            // 
            dsik.BackColor = Color.RosyBrown;
            dsik.Location = new Point(616, 303);
            dsik.Name = "dsik";
            dsik.Size = new Size(152, 141);
            dsik.TabIndex = 18;
            dsik.Text = "Aston Villa";
            dsik.UseVisualStyleBackColor = false;
            dsik.Click += dsik_Click;
            // 
            // csik
            // 
            csik.BackColor = Color.RosyBrown;
            csik.Location = new Point(419, 303);
            csik.Name = "csik";
            csik.Size = new Size(152, 141);
            csik.TabIndex = 17;
            csik.Text = "Roma";
            csik.UseVisualStyleBackColor = false;
            csik.Click += csik_Click;
            // 
            // bsik
            // 
            bsik.BackColor = Color.RosyBrown;
            bsik.Location = new Point(221, 303);
            bsik.Name = "bsik";
            bsik.Size = new Size(152, 141);
            bsik.TabIndex = 16;
            bsik.Text = "Reims";
            bsik.UseVisualStyleBackColor = false;
            bsik.Click += bsik_Click;
            // 
            // asik
            // 
            asik.BackColor = Color.RosyBrown;
            asik.Location = new Point(24, 303);
            asik.Name = "asik";
            asik.Size = new Size(152, 141);
            asik.TabIndex = 15;
            asik.Text = "Glasgow Rangers";
            asik.UseVisualStyleBackColor = false;
            asik.Click += asik_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.RosyBrown;
            panel1.Controls.Add(soru);
            panel1.Location = new Point(-147, 121);
            panel1.Name = "panel1";
            panel1.Size = new Size(972, 155);
            panel1.TabIndex = 14;
            // 
            // soru
            // 
            soru.Font = new Font("Montserrat Light", 21.7499962F, FontStyle.Regular, GraphicsUnit.Point);
            soru.Location = new Point(147, 0);
            soru.Name = "soru";
            soru.Size = new Size(801, 155);
            soru.TabIndex = 0;
            soru.Text = "Hangi takım şampiyonlar ligi kazanmıştır?";
            soru.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // sorusıra
            // 
            sorusıra.AutoSize = true;
            sorusıra.Font = new Font("Montserrat Medium", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            sorusıra.Location = new Point(449, 66);
            sorusıra.Name = "sorusıra";
            sorusıra.Size = new Size(88, 29);
            sorusıra.TabIndex = 13;
            sorusıra.Text = "1. Soru";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Montserrat", 26.2499962F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(431, 18);
            label1.Name = "label1";
            label1.Size = new Size(124, 48);
            label1.TabIndex = 12;
            label1.Text = "SPOR";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(241, 7);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(162, 108);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // spor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.IndianRed;
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
            Name = "spor";
            Text = "Spor Bilgi Yarışması";
            FormClosing += spor_FormClosing;
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