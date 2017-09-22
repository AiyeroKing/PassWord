﻿using Password.SignUp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;


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
            XmlDocument doc = new XmlDocument();
            string path = Environment.CurrentDirectory +"\\"+ username+".xml";
            doc.Load(path);
            XmlNode root = doc.DocumentElement;
            XmlNode node= root.SelectSingleNode("user");
            XmlNodeList nodelist = root.SelectNodes("user");
            
         //  string  a =  nodelist[0].SelectSingleNode("name").Value;
            //XmlNode newn = null;
            foreach (XmlNode n in nodelist)
            {
               XmlNode user= n.SelectSingleNode("name");
              string name=  user.FirstChild.Value;
                XmlNode passwords = n.ChildNodes[1];
                string passwor = passwords.FirstChild.Value;
                //newn = n;
                //break;
                if(name == username && password == passwor)
                {
                    SelectChoose s = new SelectChoose();
                    Hide();
                    s.Show();
                }
            }

            for(int i=0;i<nodelist.Count;i++)
            {
                XmlNode n = nodelist[i];
            }
            //if(username =="" && password == "")
            //{

            //}
            //else
            //{

            //}
           // SelectChoose s = new SelectChoose();
           // Hide();
           // s.Show();
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
