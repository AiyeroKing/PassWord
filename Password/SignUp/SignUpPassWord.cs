using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Password.SignUp
{
    public partial class SignUpPassWord : Form
    {
        public SignUpPassWord()
        {
            InitializeComponent();
        }

        private void ESC_butto_Sign_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Comeback_index_SignIn_Click(object sender, EventArgs e)
        {
            Hide();
            PasswordMunes ps = new PasswordMunes();
            ps.Show();
        }

        #region --绑定事件
        private void ApplicationExit(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("你确定要关闭吗！", "提示信息", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result == DialogResult.OK)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;    //取消关闭
            }
        }
        #endregion
    }
}
