using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fly_Buy_new
{
    public partial class learn_more : MetroFramework.Forms.MetroForm
    {
        public learn_more()
        {
            InitializeComponent();
        }

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {

        }

        private void btn_signup_Click(object sender, EventArgs e)
        {
            Signup obj = new Signup();
            obj.ShowDialog();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            login obj = new login();
            obj.ShowDialog();
        }

        private void learn_more_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Opacity == 1)
            {
                timer1.Stop();
            }
            Opacity += .2;
        }

        private void lbl_home_Click(object sender, EventArgs e)
        {
            this.Hide();
            welcome obj = new welcome();
            obj.ShowDialog();
        }

        private void lbl_help_Click(object sender, EventArgs e)
        {

            help obj = new help();
            obj.ShowDialog();
        }

        private void lbl_brand_name_Click(object sender, EventArgs e)
        {
            this.Hide();
            welcome obj = new welcome();
            obj.ShowDialog();
        }

        private void lbl_products_Click(object sender, EventArgs e)
        {
            this.Hide();
            products obj = new products();
            obj.ShowDialog();
        }
    }
}
