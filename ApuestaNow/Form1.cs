using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApuestaNow
{
    
    
    public partial class frmLogin : Form
    {
        public static int userid;

        public frmLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        public void BtnLogin_Click(object sender, EventArgs e)
        {
            User login = new User(txtUser.Text, txtPassword.Text);
            if(login.UserName == txtUser.Text)
            {
                userid = login.Number;
                frmMenu menu = new frmMenu();
                this.Hide();
                menu.Show();             
            }
            else
            {
                MessageBox.Show("User incorrect and/or Password incorrect", "Login Incorrect", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
