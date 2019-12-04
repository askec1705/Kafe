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
    public partial class Form3 : MetroForm
    {
        public Form3()
        {
            InitializeComponent();
        }
        Food food;

        FoodsService foodsService = new FoodsService();

        ProjectContext db = new ProjectContext();

        public Form3(Food food) : this()
        {
            this.food = food;
        }

        public void Form3_Load(object sender, EventArgs e)
        {
            mlblYemekisim.Text = food.FoodName;
            mlblMalzemeler.Text = food.FoodSpecification;
            mlblFiyat.Text = food.FoodPrice;
            mlblKategori.Text = food.FoodCategory;
            mlblTarif.Text = food.FoodSpecification;
        }

        public void MetroLink1_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            this.Hide();
            frm.ShowDialog();
        }
    }
}
