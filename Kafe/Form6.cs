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
    public partial class Form6 : MetroForm
    {
        public Form6()
        {
            InitializeComponent();
        }
        string admin = "Menu Kafe";
        string password = "2417";
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
        private void BtnGirisYap_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == admin && txtPassword.Text == password)
            {
                Form1 frm = new Form1();
                this.Hide();
                frm.ShowDialog();
            }
            else if (txtUser.Text == admin && txtPassword.Text != password)
            {
                MessageBox.Show("Kullanıcı adınız doğru fakat şifreniz yanlış!");
                Temizle(groupBox1);
            }
            else if (txtUser.Text != admin && txtPassword.Text == password)
            {
                MessageBox.Show("Şifreniz doğru fakat kullanıcı adınız yanlış!");
                Temizle(groupBox1);
            }
            else
            {
                MessageBox.Show("Lütfen bilgilerinizi kontrol ediniz!");
                Temizle(groupBox1);
            }
        }
    }
}
