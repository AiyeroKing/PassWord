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

namespace Password.SignUp
{
    public partial class ForgotPassword : Form
    {
        public ForgotPassword()
        {
            InitializeComponent();
        }
        //返回登录页面
        private void Forgot_Esc_button_Click(object sender, EventArgs e)
        {
            Hide();
            PasswordMunes ps = new PasswordMunes();
            ps.Show();
        }
        //修改密码
        private void Eidt_Progot_Ok_button_Click(object sender, EventArgs e)
        {

            Eidt_Progot_save_one();
            Eidt_Progot_save_two();
        }

        public void Eidt_Progot_save_one()
        {
            string username = Forgot_username_input.Text;
            string name = Forgot_name_input.Text;
            string newprossword = Forgot_new_password.Text;
            if (username == "" || name == "" || newprossword == "")
            {
                MessageBox.Show("用户名或真实姓名、新密码为空！请重新输入");
                Forgot_username_input.Text = "";
                Forgot_name_input.Text = "";
                Forgot_new_password.Text = "";
                return;
            }
            XmlDocument doc = new XmlDocument();
            string path = Environment.CurrentDirectory + "\\Data\\" + username + "\\" + username + "Password.xml";//定义路径
            //string ThePathtwo = Environment.CurrentDirectory + "\\Data\\" + username1 + "\\" + username1 + "Account.xml";//定义路径
            try
            {
                doc.Load(path);
            }
            catch (Exception ex)
            {
                MessageBox.Show("该用户名无效！");
                Forgot_username_input.Text = "";
                Forgot_name_input.Text = "";
                Forgot_new_password.Text = "";
                return;
            }
            XmlNode root = doc.DocumentElement;
            XmlNode node = root.SelectSingleNode("Adminiuser");
            XmlNodeList nodelist = root.SelectNodes("Adminiuser");
            foreach (XmlNode n in nodelist)
            {
                XmlNode user = n.SelectSingleNode("UserAccount");
                string name1 = user.FirstChild.Value; //获取到标题中第一个元素的值
                XmlNode name1s = n.ChildNodes[2];
                string nam = name1s.FirstChild.Value;
                //newn = n;
                //break;
                if (name1 == username && name == nam)
                {
                    XmlNode oldprass = n.ChildNodes[1];//0坐标是用户名  1坐标是密码   2坐标是密码
                    //oldprass.InnerText = newprossword;
                    n.ChildNodes[1].FirstChild.Value = newprossword;
                    doc.Save(path);
                    MessageBox.Show("修改成功，点击确定后放回登录页面");
                    PasswordMunes p = new PasswordMunes();
                    Hide();
                    p.Show();
                }
                else
                {
                    MessageBox.Show("您的密码有误，请重新输入！");
                    Forgot_username_input.Text = "";
                    Forgot_name_input.Text = "";
                    Forgot_new_password.Text = "";
                    return;
                }
            }
        }
        public void Eidt_Progot_save_two()
        {
            string username = Forgot_username_input.Text;
            string name = Forgot_name_input.Text;
            string newprossword = Forgot_new_password.Text;
            if (username == "" || name == "" || newprossword == "")
            {
                //MessageBox.Show("用户名或真实姓名、新密码为空！请重新输入");
                Forgot_username_input.Text = "";
                Forgot_name_input.Text = "";
                Forgot_new_password.Text = "";
                return;
            }
            XmlDocument doc = new XmlDocument();
            //string path = Environment.CurrentDirectory + "\\Data\\" + username + "\\" + username + "Password.xml";//定义路径
            string ThePathtwo = Environment.CurrentDirectory + "\\Data\\" + username + "\\" + username + "Account.xml";//定义路径
            try
            {
                doc.Load(ThePathtwo);
            }
            catch (Exception ex)
            {
                //MessageBox.Show("该用户名无效！");
                Forgot_username_input.Text = "";
                Forgot_name_input.Text = "";
                Forgot_new_password.Text = "";
                return;
            }
            XmlNode root = doc.DocumentElement;
            XmlNode node = root.SelectSingleNode("Adminiuser");
            XmlNodeList nodelist = root.SelectNodes("Adminiuser");
            foreach (XmlNode n in nodelist)
            {
                XmlNode user = n.SelectSingleNode("UserAccount");
                string name1 = user.FirstChild.Value; //获取到标题中第一个元素的值
                XmlNode name1s = n.ChildNodes[2];
                string nam = name1s.FirstChild.Value;
                //newn = n;
                //break;
                if (name1 == username && name == nam)
                {
                    XmlNode oldprass = n.ChildNodes[1];//0坐标是用户名  1坐标是密码   2坐标是密码
                    //oldprass.InnerText = newprossword;
                    n.ChildNodes[1].FirstChild.Value = newprossword;
                    doc.Save(ThePathtwo);
                    //MessageBox.Show("修改成功，点击确定后放回登录页面");
                    PasswordMunes p = new PasswordMunes();
                    Hide();
                    //p.Show();
                }
                else
                {
                    //MessageBox.Show("您的密码有误，请重新输入！");
                    Forgot_username_input.Text = "";
                    Forgot_name_input.Text = "";
                    Forgot_new_password.Text = "";
                    return;
                }
            }
        }
        //绑定关闭菜单
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
