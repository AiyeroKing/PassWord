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
            //string ex="";
            if(username == "" || password == "")
            {
                MessageBox.Show("用户名或密码为空！请重新输入");
                username_input.Text = "";
                password_input.Text = "";
                return;
            }
            XmlDocument doc = new XmlDocument();
            string path = Environment.CurrentDirectory + "\\Data\\" + username + "\\" + username + "Telphone.xml";//定义通讯录路径
            string ThePathtwo = Environment.CurrentDirectory + "\\Data\\" + username + "\\" + username + "Account.xml";//定义账号密码路径
            try
            {
                doc.Load(path);
            }
            catch (Exception ex)
            {
                string ExceptionTosting = Convert.ToString(ex);
                MessageBox.Show("不存在数据文件！");
                username_input.Text = "";
                password_input.Text = "";
                return;
            }
            XmlNode root = doc.DocumentElement;
            XmlNode node= root.SelectSingleNode("Adminiuser");
            XmlNodeList nodelist = root.SelectNodes("Adminiuser");
            
         //  string  a =  nodelist[0].SelectSingleNode("name").Value;
            //XmlNode newn = null;
            foreach (XmlNode n in nodelist)
            {
               XmlNode user= n.SelectSingleNode("UserAccount");
              string name=  user.FirstChild.Value; //获取到标题中第一个元素的值
                XmlNode passwords = n.ChildNodes[1];
                string passwor = passwords.FirstChild.Value;
                //newn = n;
                //break;
                if(name == username && password == passwor)
                {
                    SelectChoose s = new SelectChoose(path, ThePathtwo);
                    //s.pathone = path;
                    Hide();
                    s.Show();
                }
                else
                {
                    MessageBox.Show("您的密码有误，请重新输入！");
                    username_input.Text = "";
                    password_input.Text = "";
                    return;
                }
            }
            //this.Controls.Clear();  将空间清除掉的方法，其中this 可替换成容器的名字
        }

      

        private void sign_up_Click(object sender, EventArgs e)
        {
            Hide();
            SignUpPassWord For = new SignUpPassWord();
            For.Show();

        }
        private void look_back_Click(object sender, EventArgs e)
        {
            Hide();
            ForgotPassword For = new ForgotPassword();
            For.Show();

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
