namespace Kafe
{
    partial class Form3
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mlblTarifi = new MetroFramework.Controls.MetroLabel();
            this.mlblKategorisi = new MetroFramework.Controls.MetroLabel();
            this.mlblFiyati = new MetroFramework.Controls.MetroLabel();
            this.mlblMalzemeleri = new MetroFramework.Controls.MetroLabel();
            this.mlblisim = new MetroFramework.Controls.MetroLabel();
            this.mlblYemekisim = new MetroFramework.Controls.MetroLabel();
            this.mlblMalzemeler = new MetroFramework.Controls.MetroLabel();
            this.mlblFiyat = new MetroFramework.Controls.MetroLabel();
            this.mlblKategori = new MetroFramework.Controls.MetroLabel();
            this.mlblTarif = new MetroFramework.Controls.MetroLabel();
            this.metroLink1 = new MetroFramework.Controls.MetroLink();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.mlblTarif);
            this.groupBox1.Controls.Add(this.mlblKategori);
            this.groupBox1.Controls.Add(this.mlblFiyat);
            this.groupBox1.Controls.Add(this.mlblMalzemeler);
            this.groupBox1.Controls.Add(this.mlblYemekisim);
            this.groupBox1.Controls.Add(this.mlblTarifi);
            this.groupBox1.Controls.Add(this.mlblKategorisi);
            this.groupBox1.Controls.Add(this.mlblFiyati);
            this.groupBox1.Controls.Add(this.mlblMalzemeleri);
            this.groupBox1.Controls.Add(this.mlblisim);
            this.groupBox1.Font = new System.Drawing.Font("Mistral", 25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(1, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(479, 319);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Yemek Detayı";
            // 
            // mlblTarifi
            // 
            this.mlblTarifi.BackColor = System.Drawing.Color.Maroon;
            this.mlblTarifi.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.mlblTarifi.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.mlblTarifi.Location = new System.Drawing.Point(70, 176);
            this.mlblTarifi.Name = "mlblTarifi";
            this.mlblTarifi.Size = new System.Drawing.Size(99, 35);
            this.mlblTarifi.TabIndex = 6;
            this.mlblTarifi.Text = "Yemeğin Tarifi :";
            this.mlblTarifi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // mlblKategorisi
            // 
            this.mlblKategorisi.BackColor = System.Drawing.Color.Maroon;
            this.mlblKategorisi.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.mlblKategorisi.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.mlblKategorisi.Location = new System.Drawing.Point(34, 147);
            this.mlblKategorisi.Name = "mlblKategorisi";
            this.mlblKategorisi.Size = new System.Drawing.Size(135, 23);
            this.mlblKategorisi.TabIndex = 7;
            this.mlblKategorisi.Text = "Yemeğin Kategorisi :";
            this.mlblKategorisi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // mlblFiyati
            // 
            this.mlblFiyati.BackColor = System.Drawing.Color.Maroon;
            this.mlblFiyati.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.mlblFiyati.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.mlblFiyati.Location = new System.Drawing.Point(7, 118);
            this.mlblFiyati.Name = "mlblFiyati";
            this.mlblFiyati.Size = new System.Drawing.Size(162, 23);
            this.mlblFiyati.TabIndex = 8;
            this.mlblFiyati.Text = "Yemeğin Porsiyon Fiyatı :";
            this.mlblFiyati.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // mlblMalzemeleri
            // 
            this.mlblMalzemeleri.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.mlblMalzemeleri.Location = new System.Drawing.Point(22, 89);
            this.mlblMalzemeleri.Name = "mlblMalzemeleri";
            this.mlblMalzemeleri.Size = new System.Drawing.Size(147, 23);
            this.mlblMalzemeleri.TabIndex = 9;
            this.mlblMalzemeleri.Text = "Yemeğin Malzemeleri :";
            this.mlblMalzemeleri.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // mlblisim
            // 
            this.mlblisim.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.mlblisim.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.mlblisim.Location = new System.Drawing.Point(70, 60);
            this.mlblisim.Name = "mlblisim";
            this.mlblisim.Size = new System.Drawing.Size(99, 23);
            this.mlblisim.TabIndex = 10;
            this.mlblisim.Text = "Yemeğin İsmi :";
            this.mlblisim.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // mlblYemekisim
            // 
            this.mlblYemekisim.Location = new System.Drawing.Point(176, 60);
            this.mlblYemekisim.Name = "mlblYemekisim";
            this.mlblYemekisim.Size = new System.Drawing.Size(279, 23);
            this.mlblYemekisim.TabIndex = 11;
            // 
            // mlblMalzemeler
            // 
            this.mlblMalzemeler.Location = new System.Drawing.Point(175, 89);
            this.mlblMalzemeler.Name = "mlblMalzemeler";
            this.mlblMalzemeler.Size = new System.Drawing.Size(279, 23);
            this.mlblMalzemeler.TabIndex = 11;
            // 
            // mlblFiyat
            // 
            this.mlblFiyat.Location = new System.Drawing.Point(175, 118);
            this.mlblFiyat.Name = "mlblFiyat";
            this.mlblFiyat.Size = new System.Drawing.Size(279, 23);
            this.mlblFiyat.TabIndex = 11;
            // 
            // mlblKategori
            // 
            this.mlblKategori.Location = new System.Drawing.Point(175, 147);
            this.mlblKategori.Name = "mlblKategori";
            this.mlblKategori.Size = new System.Drawing.Size(279, 23);
            this.mlblKategori.TabIndex = 11;
            // 
            // mlblTarif
            // 
            this.mlblTarif.Location = new System.Drawing.Point(175, 176);
            this.mlblTarif.Name = "mlblTarif";
            this.mlblTarif.Size = new System.Drawing.Size(279, 138);
            this.mlblTarif.TabIndex = 11;
            // 
            // metroLink1
            // 
            this.metroLink1.Location = new System.Drawing.Point(23, 353);
            this.metroLink1.Name = "metroLink1";
            this.metroLink1.Size = new System.Drawing.Size(104, 23);
            this.metroLink1.TabIndex = 1;
            this.metroLink1.Text = "Yemek Listesi";
            this.metroLink1.UseSelectable = true;
            this.metroLink1.Click += new System.EventHandler(this.MetroLink1_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 383);
            this.Controls.Add(this.metroLink1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroLabel mlblTarifi;
        private MetroFramework.Controls.MetroLabel mlblKategorisi;
        private MetroFramework.Controls.MetroLabel mlblFiyati;
        private MetroFramework.Controls.MetroLabel mlblMalzemeleri;
        private MetroFramework.Controls.MetroLabel mlblisim;
        private MetroFramework.Controls.MetroLabel mlblYemekisim;
        private MetroFramework.Controls.MetroLabel mlblTarif;
        private MetroFramework.Controls.MetroLabel mlblKategori;
        private MetroFramework.Controls.MetroLabel mlblFiyat;
        private MetroFramework.Controls.MetroLabel mlblMalzemeler;
        private MetroFramework.Controls.MetroLink metroLink1;
    }
}