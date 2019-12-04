namespace Kafe
{
    partial class Form4
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtSpecification = new System.Windows.Forms.TextBox();
            this.mtxtKategori = new MetroFramework.Controls.MetroTextBox();
            this.mtxtPorsFiyat = new MetroFramework.Controls.MetroTextBox();
            this.mtxtMalzemeler = new MetroFramework.Controls.MetroTextBox();
            this.mtxtYemekisim = new MetroFramework.Controls.MetroTextBox();
            this.mlblPicture = new MetroFramework.Controls.MetroLabel();
            this.mlblKategori = new MetroFramework.Controls.MetroLabel();
            this.mlblFiyat = new MetroFramework.Controls.MetroLabel();
            this.mlblMalzemeler = new MetroFramework.Controls.MetroLabel();
            this.mlblisim = new MetroFramework.Controls.MetroLabel();
            this.metroLink1 = new MetroFramework.Controls.MetroLink();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.txtSpecification);
            this.groupBox1.Controls.Add(this.mtxtKategori);
            this.groupBox1.Controls.Add(this.mtxtPorsFiyat);
            this.groupBox1.Controls.Add(this.mtxtMalzemeler);
            this.groupBox1.Controls.Add(this.mtxtYemekisim);
            this.groupBox1.Controls.Add(this.mlblPicture);
            this.groupBox1.Controls.Add(this.mlblKategori);
            this.groupBox1.Controls.Add(this.mlblFiyat);
            this.groupBox1.Controls.Add(this.mlblMalzemeler);
            this.groupBox1.Controls.Add(this.mlblisim);
            this.groupBox1.Font = new System.Drawing.Font("Mistral", 25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(-1, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(750, 358);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Yemek Güncelle";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Kafe.Properties.Resources.chef_cooking_clip_art_cooking;
            this.pictureBox1.Location = new System.Drawing.Point(523, 54);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(190, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Gray;
            this.btnUpdate.Font = new System.Drawing.Font("Mistral", 25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))));
            this.btnUpdate.Location = new System.Drawing.Point(522, 260);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(191, 94);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "GÜNCELLE";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click_1);
            // 
            // txtSpecification
            // 
            this.txtSpecification.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSpecification.Location = new System.Drawing.Point(183, 171);
            this.txtSpecification.Multiline = true;
            this.txtSpecification.Name = "txtSpecification";
            this.txtSpecification.Size = new System.Drawing.Size(333, 183);
            this.txtSpecification.TabIndex = 5;
            // 
            // mtxtKategori
            // 
            // 
            // 
            // 
            this.mtxtKategori.CustomButton.Image = null;
            this.mtxtKategori.CustomButton.Location = new System.Drawing.Point(311, 1);
            this.mtxtKategori.CustomButton.Name = "";
            this.mtxtKategori.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mtxtKategori.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtxtKategori.CustomButton.TabIndex = 1;
            this.mtxtKategori.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtxtKategori.CustomButton.UseSelectable = true;
            this.mtxtKategori.CustomButton.Visible = false;
            this.mtxtKategori.Lines = new string[0];
            this.mtxtKategori.Location = new System.Drawing.Point(183, 141);
            this.mtxtKategori.MaxLength = 32767;
            this.mtxtKategori.Name = "mtxtKategori";
            this.mtxtKategori.PasswordChar = '\0';
            this.mtxtKategori.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtKategori.SelectedText = "";
            this.mtxtKategori.SelectionLength = 0;
            this.mtxtKategori.SelectionStart = 0;
            this.mtxtKategori.ShortcutsEnabled = true;
            this.mtxtKategori.Size = new System.Drawing.Size(333, 23);
            this.mtxtKategori.TabIndex = 4;
            this.mtxtKategori.UseSelectable = true;
            this.mtxtKategori.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtxtKategori.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mtxtPorsFiyat
            // 
            // 
            // 
            // 
            this.mtxtPorsFiyat.CustomButton.Image = null;
            this.mtxtPorsFiyat.CustomButton.Location = new System.Drawing.Point(311, 1);
            this.mtxtPorsFiyat.CustomButton.Name = "";
            this.mtxtPorsFiyat.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mtxtPorsFiyat.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtxtPorsFiyat.CustomButton.TabIndex = 1;
            this.mtxtPorsFiyat.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtxtPorsFiyat.CustomButton.UseSelectable = true;
            this.mtxtPorsFiyat.CustomButton.Visible = false;
            this.mtxtPorsFiyat.Lines = new string[0];
            this.mtxtPorsFiyat.Location = new System.Drawing.Point(183, 112);
            this.mtxtPorsFiyat.MaxLength = 32767;
            this.mtxtPorsFiyat.Name = "mtxtPorsFiyat";
            this.mtxtPorsFiyat.PasswordChar = '\0';
            this.mtxtPorsFiyat.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtPorsFiyat.SelectedText = "";
            this.mtxtPorsFiyat.SelectionLength = 0;
            this.mtxtPorsFiyat.SelectionStart = 0;
            this.mtxtPorsFiyat.ShortcutsEnabled = true;
            this.mtxtPorsFiyat.Size = new System.Drawing.Size(333, 23);
            this.mtxtPorsFiyat.TabIndex = 3;
            this.mtxtPorsFiyat.UseSelectable = true;
            this.mtxtPorsFiyat.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtxtPorsFiyat.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mtxtMalzemeler
            // 
            // 
            // 
            // 
            this.mtxtMalzemeler.CustomButton.Image = null;
            this.mtxtMalzemeler.CustomButton.Location = new System.Drawing.Point(311, 1);
            this.mtxtMalzemeler.CustomButton.Name = "";
            this.mtxtMalzemeler.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mtxtMalzemeler.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtxtMalzemeler.CustomButton.TabIndex = 1;
            this.mtxtMalzemeler.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtxtMalzemeler.CustomButton.UseSelectable = true;
            this.mtxtMalzemeler.CustomButton.Visible = false;
            this.mtxtMalzemeler.Lines = new string[0];
            this.mtxtMalzemeler.Location = new System.Drawing.Point(183, 83);
            this.mtxtMalzemeler.MaxLength = 32767;
            this.mtxtMalzemeler.Name = "mtxtMalzemeler";
            this.mtxtMalzemeler.PasswordChar = '\0';
            this.mtxtMalzemeler.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtMalzemeler.SelectedText = "";
            this.mtxtMalzemeler.SelectionLength = 0;
            this.mtxtMalzemeler.SelectionStart = 0;
            this.mtxtMalzemeler.ShortcutsEnabled = true;
            this.mtxtMalzemeler.Size = new System.Drawing.Size(333, 23);
            this.mtxtMalzemeler.TabIndex = 2;
            this.mtxtMalzemeler.UseSelectable = true;
            this.mtxtMalzemeler.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtxtMalzemeler.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mtxtYemekisim
            // 
            // 
            // 
            // 
            this.mtxtYemekisim.CustomButton.Image = null;
            this.mtxtYemekisim.CustomButton.Location = new System.Drawing.Point(311, 1);
            this.mtxtYemekisim.CustomButton.Name = "";
            this.mtxtYemekisim.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mtxtYemekisim.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtxtYemekisim.CustomButton.TabIndex = 1;
            this.mtxtYemekisim.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtxtYemekisim.CustomButton.UseSelectable = true;
            this.mtxtYemekisim.CustomButton.Visible = false;
            this.mtxtYemekisim.Lines = new string[0];
            this.mtxtYemekisim.Location = new System.Drawing.Point(183, 54);
            this.mtxtYemekisim.MaxLength = 32767;
            this.mtxtYemekisim.Name = "mtxtYemekisim";
            this.mtxtYemekisim.PasswordChar = '\0';
            this.mtxtYemekisim.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtYemekisim.SelectedText = "";
            this.mtxtYemekisim.SelectionLength = 0;
            this.mtxtYemekisim.SelectionStart = 0;
            this.mtxtYemekisim.ShortcutsEnabled = true;
            this.mtxtYemekisim.Size = new System.Drawing.Size(333, 23);
            this.mtxtYemekisim.TabIndex = 1;
            this.mtxtYemekisim.UseSelectable = true;
            this.mtxtYemekisim.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtxtYemekisim.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mlblPicture
            // 
            this.mlblPicture.BackColor = System.Drawing.Color.Maroon;
            this.mlblPicture.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.mlblPicture.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.mlblPicture.Location = new System.Drawing.Point(78, 170);
            this.mlblPicture.Name = "mlblPicture";
            this.mlblPicture.Size = new System.Drawing.Size(99, 35);
            this.mlblPicture.TabIndex = 11;
            this.mlblPicture.Text = "Yemeğin Tarifi :";
            this.mlblPicture.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // mlblKategori
            // 
            this.mlblKategori.BackColor = System.Drawing.Color.Maroon;
            this.mlblKategori.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.mlblKategori.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.mlblKategori.Location = new System.Drawing.Point(42, 141);
            this.mlblKategori.Name = "mlblKategori";
            this.mlblKategori.Size = new System.Drawing.Size(135, 23);
            this.mlblKategori.TabIndex = 10;
            this.mlblKategori.Text = "Yemeğin Kategorisi :";
            this.mlblKategori.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // mlblFiyat
            // 
            this.mlblFiyat.BackColor = System.Drawing.Color.Maroon;
            this.mlblFiyat.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.mlblFiyat.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.mlblFiyat.Location = new System.Drawing.Point(15, 112);
            this.mlblFiyat.Name = "mlblFiyat";
            this.mlblFiyat.Size = new System.Drawing.Size(162, 23);
            this.mlblFiyat.TabIndex = 9;
            this.mlblFiyat.Text = "Yemeğin Porsiyon Fiyatı :";
            this.mlblFiyat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // mlblMalzemeler
            // 
            this.mlblMalzemeler.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.mlblMalzemeler.Location = new System.Drawing.Point(30, 83);
            this.mlblMalzemeler.Name = "mlblMalzemeler";
            this.mlblMalzemeler.Size = new System.Drawing.Size(147, 23);
            this.mlblMalzemeler.TabIndex = 8;
            this.mlblMalzemeler.Text = "Yemeğin Malzemeleri :";
            this.mlblMalzemeler.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // mlblisim
            // 
            this.mlblisim.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.mlblisim.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.mlblisim.Location = new System.Drawing.Point(78, 54);
            this.mlblisim.Name = "mlblisim";
            this.mlblisim.Size = new System.Drawing.Size(99, 23);
            this.mlblisim.TabIndex = 7;
            this.mlblisim.Text = "Yemeğin İsmi :";
            this.mlblisim.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // metroLink1
            // 
            this.metroLink1.Location = new System.Drawing.Point(14, 408);
            this.metroLink1.Name = "metroLink1";
            this.metroLink1.Size = new System.Drawing.Size(128, 23);
            this.metroLink1.TabIndex = 1;
            this.metroLink1.Text = "Yemek Listesi";
            this.metroLink1.UseSelectable = true;
            this.metroLink1.Click += new System.EventHandler(this.MetroLink1_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 443);
            this.Controls.Add(this.metroLink1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroLabel mlblPicture;
        private MetroFramework.Controls.MetroLabel mlblKategori;
        private MetroFramework.Controls.MetroLabel mlblFiyat;
        private MetroFramework.Controls.MetroLabel mlblMalzemeler;
        private MetroFramework.Controls.MetroLabel mlblisim;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtSpecification;
        private MetroFramework.Controls.MetroTextBox mtxtKategori;
        private MetroFramework.Controls.MetroTextBox mtxtPorsFiyat;
        private MetroFramework.Controls.MetroTextBox mtxtMalzemeler;
        private MetroFramework.Controls.MetroTextBox mtxtYemekisim;
        private MetroFramework.Controls.MetroLink metroLink1;
    }
}