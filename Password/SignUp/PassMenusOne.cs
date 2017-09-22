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
            if (password == "")
            {

                Hide();
                //MessageBox.Show("登陆成功");
                plogin.Show();

            }
            else
            {
                MessageBox.Show("登陆失败");
            }

        }
        #endregion

        #region --绑定事件

        //点击X退出程序
        private void ApplicationExit(object sender, FormClosingEventArgs e)
        {
            //第一次e.CloseReasonw为UserClosing
            if (e.CloseReason == CloseReason.ApplicationExitCall)//判断关闭请求
            {
                return;//如果请求为应用退出请求，那么直接退出；
            }
            else
            {
                DialogResult result = MessageBox.Show("你确定要关闭吗！", "提示信息", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (result == DialogResult.OK)
                {
                    Application.Exit();//执行了此函数；即：e.CloseReason == CloseReason.ApplicationExitCall 原因变为：ApplicationExitCall
                }
                else
                {
                    e.Cancel = true;    //取消关闭
                }
            }
          
        }

        #endregion


    }
}
