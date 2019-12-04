namespace Kafe
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            this.metroContextMenu1 = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.TsmDuzenle = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmSil = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmYeni = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmDetay = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvFoods = new System.Windows.Forms.DataGridView();
            this.metroContextMenu1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFoods)).BeginInit();
            this.SuspendLayout();
            // 
            // metroContextMenu1
            // 
            this.metroContextMenu1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsmDuzenle,
            this.TsmSil,
            this.TsmYeni,
            this.TsmDetay});
            this.metroContextMenu1.Name = "metroContextMenu1";
            this.metroContextMenu1.Size = new System.Drawing.Size(126, 92);
            // 
            // TsmDuzenle
            // 
            this.TsmDuzenle.Name = "TsmDuzenle";
            this.TsmDuzenle.Size = new System.Drawing.Size(125, 22);
            this.TsmDuzenle.Text = "Düzenle";
            this.TsmDuzenle.Click += new System.EventHandler(this.TsmDuzenle_Click);
            // 
            // TsmSil
            // 
            this.TsmSil.Name = "TsmSil";
            this.TsmSil.Size = new System.Drawing.Size(125, 22);
            this.TsmSil.Text = "Sil";
            this.TsmSil.Click += new System.EventHandler(this.TsmSil_Click);
            // 
            // TsmYeni
            // 
            this.TsmYeni.Name = "TsmYeni";
            this.TsmYeni.Size = new System.Drawing.Size(125, 22);
            this.TsmYeni.Text = "Yeni Kayıt";
            this.TsmYeni.Click += new System.EventHandler(this.TsmYeni_Click);
            // 
            // TsmDetay
            // 
            this.TsmDetay.Name = "TsmDetay";
            this.TsmDetay.Size = new System.Drawing.Size(125, 22);
            this.TsmDetay.Text = "Detay";
            this.TsmDetay.Click += new System.EventHandler(this.TsmDetay_Click);
            // 
            // dgvFoods
            // 
            this.dgvFoods.BackgroundColor = System.Drawing.Color.White;
            this.dgvFoods.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFoods.ContextMenuStrip = this.metroContextMenu1;
            this.dgvFoods.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvFoods.Location = new System.Drawing.Point(20, 60);
            this.dgvFoods.Name = "dgvFoods";
            this.dgvFoods.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFoods.Size = new System.Drawing.Size(760, 370);
            this.dgvFoods.TabIndex = 0;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvFoods);
            this.Name = "Form2";
            this.Text = "YEMEK LİSTESİ";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.metroContextMenu1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFoods)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroContextMenu metroContextMenu1;
        private System.Windows.Forms.ToolStripMenuItem TsmDuzenle;
        private System.Windows.Forms.ToolStripMenuItem TsmSil;
        private System.Windows.Forms.ToolStripMenuItem TsmYeni;
        private System.Windows.Forms.ToolStripMenuItem TsmDetay;
        private System.Windows.Forms.DataGridView dgvFoods;
    }
}