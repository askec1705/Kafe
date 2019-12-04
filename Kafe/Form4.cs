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
    public partial class Form4 : MetroForm
    {
        public Form4()
        {
            InitializeComponent();
        }
        Food _food;

        FoodsService foodsService = new FoodsService();

        ProjectContext db = new ProjectContext();

        public Form4(Food food) : this()
        {
            this._food = food;
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

        public void Form4_Load(object sender, EventArgs e)
        {
            mtxtYemekisim.Text    = _food.FoodName;
            mtxtMalzemeler.Text   = _food.FoodMetarials;
            mtxtPorsFiyat.Text    = _food.FoodPrice;
            mtxtKategori.Text     = _food.FoodCategory;
            txtSpecification.Text = _food.FoodSpecification;
        }

        public void MetroLink1_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            this.Hide();
            frm.ShowDialog();
        }

        public void BtnUpdate_Click_1(object sender, EventArgs e)
        {
            _food.FoodName = mtxtYemekisim.Text;
            _food.FoodMetarials = mtxtMalzemeler.Text;
            _food.FoodPrice = mtxtPorsFiyat.Text;
            _food.FoodCategory = mtxtKategori.Text;
            _food.FoodSpecification = txtSpecification.Text;


            Temizle(groupBox1);

            MessageBox.Show("İşleminiz başarıyla gerçekleşti.");

            bool result = foodsService.Update(_food);

            foodsService.Update(_food);
        }
    }
}
