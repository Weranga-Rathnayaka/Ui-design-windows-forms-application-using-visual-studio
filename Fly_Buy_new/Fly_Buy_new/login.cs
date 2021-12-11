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
    public partial class login : MetroFramework.Forms.MetroForm
    {
        public login()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Opacity == 1)
            {
                timer1.Stop();
            }
            Opacity += .2;
        }

        private void gunaTransfarantPictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txt_bx_username_Click(object sender, EventArgs e)
        {
            txt_bx_username.Clear();
        }

        private void txt_bx_password_Click(object sender, EventArgs e)
        {
            txt_bx_password.Clear();
        }

        private void lbl_create_account_Click(object sender, EventArgs e)
        {
            
            Signup obj = new Signup();
            obj.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
