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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        Food _food;

        FoodsService foodsService = new FoodsService();

        ProjectContext db = new ProjectContext();

        public Form2(Food food)
        {
            this._food = food;
        }

        public void Liste()
        {
            dgvFoods.DataSource = db.Foods.Select(yb => new
            {
                yb.FoodName,
                yb.FoodPrice
            }).ToList();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            Liste();
        }
        public static List<Food> Employees = new List<Food>();

        private void TsmSil_Click(object sender, EventArgs e)
        {
            Guid Id = (Guid)dgvFoods.SelectedRows[0].Cells[0].Value;
            Food food = db.Foods.FirstOrDefault(x => x.FoodId == Id);
            foodsService.Delete(food);
            Liste();
        }

        private void TsmDuzenle_Click(object sender, EventArgs e)
        {
            Guid Id = (Guid)dgvFoods.SelectedRows[0].Cells[0].Value;
            Food food = db.Foods.FirstOrDefault(x => x.FoodId == Id);
            Form4 frm4 = new Form4();
            this.Hide();
            frm4.ShowDialog();
        }

        private void TsmDetay_Click(object sender, EventArgs e)
        {
            Guid Id = (Guid)dgvFoods.SelectedRows[0].Cells[0].Value;
            Food food = db.Foods.FirstOrDefault(x => x.FoodId == Id);
            Form3 frm3 = new Form3();
            this.Hide();
            frm3.ShowDialog();
        }

        private void TsmYeni_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            this.Hide();
            frm1.ShowDialog();
        }
    }
}
