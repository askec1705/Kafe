using MetroFramework;
using MetroFramework.Controls;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kafe
{
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void Temizle(Control control)
        {
            foreach (Control item in control.Controls)
            {
                if (item is MetroTextBox)
                {
                    item.Text = "";
                }
                else if (item is TextBox)
                {
                    item.Text = "";
                }
            }
        }
        //public void HataMetodu(Control control)
        //{
        //    foreach (Form1 item in control.Controls)
        //    {
        //        if (item is MetroTextBox)
        //        {
        //            if (mtxtYemekisim.Text is null)
        //            {
        //                MessageBox.Show("Lütfen bilgileri eksiksiz giriniz");
        //            }
        //            else if (mtxtKategori.Text is null)
        //            {
        //                MessageBox.Show("Lütfen bilgileri eksiksiz giriniz");
        //            }
        //            else if (mtxtPorsFiyat.Text is null)
        //            {
        //                MessageBox.Show("Lütfen bilgileri eksiksiz giriniz");
        //            }
        //        }
        //    }
        //}

        public static List<Food> Foods = new List<Food>();

        FoodsService foodsService = new FoodsService();

        public void BtnSave_Click(object sender, EventArgs e)
        {
            Food food = new Food();

            food.FoodName = mtxtYemekisim.Text;
            food.FoodMetarials = mtxtMalzemeler.Text;
            food.FoodPrice = mtxtPorsFiyat.Text;
            food.FoodCategory = mtxtKategori.Text;
            food.FoodSpecification = txtSpecification.Text;

            //HataMetodu(groupBox1);
            Temizle(groupBox1);
            Foods.Add(food);
            bool result = foodsService.Add(food);
            Foods.Add(food);
            MetroMessageBox.Show(this, result ? "Kayıt başarıyla eklendi" : "Kayıt ekleme hatası", "Kayıt Ekleme Bildirme", MessageBoxButtons.OK, result ? MessageBoxIcon.Hand : MessageBoxIcon.Error);
        }

        public void MetroLink1_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            this.Hide();
            frm.ShowDialog();
        }
    }
}
