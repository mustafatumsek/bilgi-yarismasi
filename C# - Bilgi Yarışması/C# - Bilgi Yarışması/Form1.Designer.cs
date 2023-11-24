namespace C____Bilgi_Yarışması
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            label2 = new Label();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Montserrat", 26.2499962F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(130, 159);
            label1.Name = "label1";
            label1.Size = new Size(545, 48);
            label1.TabIndex = 0;
            label1.Text = "TRİLYONER BİLGİ YARIŞMASI";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(225, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(333, 194);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Font = new Font("Montserrat SemiBold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(295, 295);
            button1.Name = "button1";
            button1.Size = new Size(192, 69);
            button1.TabIndex = 2;
            button1.Text = "BAŞLA";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Montserrat Medium", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(261, 234);
            label2.Name = "label2";
            label2.Size = new Size(254, 22);
            label2.TabIndex = 3;
            label2.Text = "Lütfen bir kategori seçiniz.";
            label2.Visible = false;
            // 
            // button2
            // 
            button2.BackColor = Color.DarkSeaGreen;
            button2.Font = new Font("Montserrat Medium", 21.7499962F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(12, 283);
            button2.Name = "button2";
            button2.Size = new Size(174, 155);
            button2.TabIndex = 4;
            button2.Text = "Tarih";
            button2.UseVisualStyleBackColor = false;
            button2.Visible = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.DarkSeaGreen;
            button3.Font = new Font("Montserrat Medium", 21.7499962F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(212, 283);
            button3.Name = "button3";
            button3.Size = new Size(174, 155);
            button3.TabIndex = 5;
            button3.Text = "Spor";
            button3.UseVisualStyleBackColor = false;
            button3.Visible = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.DarkSeaGreen;
            button4.Font = new Font("Montserrat Medium", 21.7499962F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Location = new Point(413, 283);
            button4.Name = "button4";
            button4.Size = new Size(174, 155);
            button4.TabIndex = 7;
            button4.Text = "Coğrafya";
            button4.UseVisualStyleBackColor = false;
            button4.Visible = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.DarkSeaGreen;
            button5.Font = new Font("Montserrat Medium", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            button5.Location = new Point(614, 283);
            button5.Name = "button5";
            button5.Size = new Size(174, 155);
            button5.TabIndex = 9;
            button5.Text = "Matematik";
            button5.UseVisualStyleBackColor = false;
            button5.Visible = false;
            button5.Click += button5_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.ForestGreen;
            ClientSize = new Size(800, 450);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Trilyoner Bilgi Yarışması";
            FormClosing += Form1_FormClosing;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private Button button1;
        private Label label2;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
    }
}