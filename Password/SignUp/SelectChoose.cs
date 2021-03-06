﻿using Password.Main;
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
        public string pathone1;
        public string pathine2;
        public SelectChoose(string pa1,string pa2)
        {
            pathone1 = pa1;
            pathine2 = pa2;
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
            string path = pathone1;//全局变量 从登录窗体窗体获取
            MainMenus pathcy = new MainMenus(path);
            Hide();
            // MainMenus m = new MainMenus();
            pathcy.Show();
        }

        private void Select_Acc_ok_Click(object sender, EventArgs e)
        {
            string path = pathine2;
            MainMenusAccount pathcy = new MainMenusAccount(path);
            Hide();
            //MainMenusAccount acc = new MainMenusAccount();
            pathcy.Show();
        }

  
    }
}
