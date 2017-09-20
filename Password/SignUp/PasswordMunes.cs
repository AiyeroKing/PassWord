using Password.SignUp;
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
            //if(username =="" && password == "")
            //{

            //}
            //else
            //{

            //}
            SelectChoose s = new SelectChoose();
            Hide();
            s.Show();
        }

        private void sign_up_Click(object sender, EventArgs e)
        {
            Hide();
            SignUpPassWord sign = new SignUpPassWord();
            sign.Show();

        }

        private void PasswordMunes_Load(object sender, EventArgs e)
        {
            mboxOne.Visible = true;
        }

        #region --绑定事件
        private void ApplicationExit(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("你确定要关闭吗！", "提示信息", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result == DialogResult.OK)
            {
                    e.Cancel = false;//强制关闭线程 
            }
            else
            {
                e.Cancel = true;    //取消关闭
            }
        }
        #endregion
    }
}
