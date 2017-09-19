using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Password
{
    public partial class PasswordMunes : Form
    {
        public PasswordMunes()
        {
            InitializeComponent();
        }

        private void ESC_butto_login_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void OK_Login_button_Click(object sender, EventArgs e)
        {
            string username = username_input.Text;
            string password = password_input.Text;
            if(username =="abc2885171" && password == "2885171")
            {

            }
            else
            {

            }
        }
    }
}
