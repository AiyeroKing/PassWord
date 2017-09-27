using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Password.SignUp
{
    public partial class SignUpPassWord : Form
    {
        //
        //初始化界面
        //
        public SignUpPassWord()
        {
            InitializeComponent();
        }

        //
        //点击退出按钮触发事件
        //
        private void ESC_butto_Sign_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //
        //点击返回登录按钮触发事件
        //
        private void Comeback_index_SignIn_Click(object sender, EventArgs e)
        {
            Hide();
            PasswordMunes ps = new PasswordMunes();
            ps.Show();
        }
        //
        //点击注册按钮触发事件
        //
        private void OK_Sign_button_Click(object sender, EventArgs e)
        {
            string username1 = Sign_username.Text; //用户名-输入框的值
            string password1 = Sign_password.Text; //密码-输入框的值
            string name1 = Sign_name.Text;//真实姓名-输入框的值
            string miyao1 = Sign_Miyao_input.Text; //秘钥-输入框的值

            if(username1 == "" || password1 == "" || name1 =="")
            {
                MessageBox.Show("用户名、密码、真实姓名 三者其中为空，请重新输入！");
                Sign_username.Text = ""; //用户名-输入框的值
                Sign_password.Text = ""; //密码-输入框的值
                Sign_name.Text = "";//真实姓名-输入框的值
                Sign_Miyao_input.Text = ""; //秘钥-输入框的值
                return;
            }

            if (miyao1 != "supperadmin" && miyao1 != "209014")        //    ---- 验证秘钥
            {
                MessageBox.Show("您输入的密钥不正确！请重新输入");
                Sign_username.Text = ""; //用户名-输入框的值
                Sign_password.Text = ""; //密码-输入框的值
                Sign_name.Text = "";//真实姓名-输入框的值
                Sign_Miyao_input.Text = ""; //秘钥-输入框的值

                return;
                //Hide();
                //MessageBox.Show("登陆成功
            }
            XmlDocument xml = new XmlDocument();//创建XML文件在内存中
            XmlDeclaration xmldecl;//定义对象头文件标准
            xmldecl = xml.CreateXmlDeclaration("1.0", "utf-8", "");//将其头文件标准给予确定值
            xml.PreserveWhitespace = false;  //元素内容是否保留空白  

            XmlElement root = xml.DocumentElement;//root是数据文档 
            xml.InsertBefore(xmldecl, root);//设置xmldecl 在 root之前
            //以下都是root内容
            XmlElement body = xml.CreateElement("body");//创建body标签节点
            xml.AppendChild(body);//添加body标签在root里
            //----------------------------------------------------------------------------------//
            XmlElement Adminiuser = xml.CreateElement("Adminiuser");//创建adminiuser标签节点
            body.AppendChild(Adminiuser);//将adminiuser标签节点添加到body标签里面
            //----------------------------------------------------------------------------------//
            XmlElement UserAccount = xml.CreateElement("UserAccount");//创建user标签节点   --账号
            UserAccount.InnerText = username1;//username
            Adminiuser.AppendChild(UserAccount);//将user标签节点添加到body标签里面

            XmlElement Password = xml.CreateElement("Password");//创建password标签节点   --账号
            Password.InnerText = password1;//username
            Adminiuser.AppendChild(Password);//将user标签节点添加到body标签里面

            XmlElement Name = xml.CreateElement("Name");//创建Name标签节点   --姓名
            Name.InnerText = name1;//username
            Adminiuser.AppendChild(Name);//将user标签节点添加到body标签里面

            string Path = Environment.CurrentDirectory + "\\Data\\" + username1;//定义路径
            string ThePath = Environment.CurrentDirectory + "\\Data\\" + username1 +"\\"+ username1 + "Telphone.xml";//定义路径
            string ThePathtwo = Environment.CurrentDirectory + "\\Data\\" + username1 + "\\" + username1 + "Account.xml";//定义路径
            if (File.Exists(ThePath))
            {
                MessageBox.Show("该用户名已存在，无法注册！");
                Sign_username.Text = ""; //用户名-输入框的值
                Sign_password.Text = ""; //密码-输入框的值
                Sign_name.Text = "";//真实姓名-输入框的值
                Sign_Miyao_input.Text = ""; //秘钥-输入框的值
                return;
            }
            else
            {
                if (!Directory.Exists(Path))
                {
                    Directory.CreateDirectory(Path);
                }
                xml.Save(ThePath);//保存该第一个xml文件
                xml.Save(ThePathtwo);//保存该第二个xml文件
                Sign_username.Text = ""; //用户名-输入框的值
                Sign_password.Text = ""; //密码-输入框的值
                Sign_name.Text = "";//真实姓名-输入框的值
                Sign_Miyao_input.Text = ""; //秘钥-输入框的值
                MessageBox.Show("保存成功");
                Hide();
                PasswordMunes pa = new PasswordMunes();
                pa.Show();
            }

        }
        //
        //绑定控件触发事件
        //
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
