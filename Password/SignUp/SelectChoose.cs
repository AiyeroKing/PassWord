using Password.Main;
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
    public partial class SelectChoose : Form
    {
        public SelectChoose()
        {
            InitializeComponent();
        }

        #region --封装
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

        private void Select_tel_ok_Click(object sender, EventArgs e)
        {
            Hide();
            MainMenus m = new MainMenus();
            m.Show();
        }

        private void Select_Acc_ok_Click(object sender, EventArgs e)
        {
            Hide();
            MainMenusAccount acc = new MainMenusAccount();
            acc.Show();
        }
    }
}
