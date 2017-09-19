using System;
using System.Windows.Forms;

namespace Password
{
    public partial class PassMenusOne : Form
    {
        public PassMenusOne()
        {
            InitializeComponent();
        }

        #region --功能操作
        //按钮退出点击
        private void Esc_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //按钮确定点击
        private void Ok_button_Click(object sender, EventArgs e)
        {

            PasswordMunes plogin = new PasswordMunes();//登录界面PasswordMunes
            plogin.Hide();
            string password = MiYao_input.Text;
            if (password == "2885171")
            {

                Hide();
                MessageBox.Show("登陆成功");
                plogin.Show();

            }
            else
            {
                MessageBox.Show("登陆失败");
                Application.Exit();
            }

        }
        #endregion
    }
}
