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
using XMLModel;

namespace Password.Main.PassWordForm
{
    public partial class AddAccountForm : Form
    {
        public string pathy;
        public string nuacount;
        public AddAccountForm(string a,string b)
        {
            pathy = b;
            nuacount = a;
            InitializeComponent();
            InitializeComponentTwo();
        }
        #region --绑定事件
        //点击X退出程序
        private void ApplicationExit(object sender, FormClosingEventArgs e)
        {
            Hide();
        }
        #endregion
        //初始化控件输入框内部的值
        public void InitializeComponentTwo()
        {
            ADD_Account_Name.Text = "";
            ADD_Account_Remark.Text = "未填";
            ADD_TEL_UserName.Text = "";
            ADD_TEL_PassWord.Text = "";
            ADD_Account_Remark.Text = "";
        }

        private void Cell_btn_ADD_Password_Click(object sender, EventArgs e)
        {
            this.Hide();    //隐藏当前窗口
            //MessageBox.Show("取消添加!");
            //this.Close();   //关闭当前窗口
        }
        //取消按钮
        private void OK_btn_ADD_Password_Click(object sender, EventArgs e)
        {
            //InitializeComponentThree();//设置为空的值未“  ”而非空

            PassWordModel _account = new PassWordModel();
            _account.Account_Name = ADD_Account_Name.Text;
            _account.Account_Retion = ADD_Account_Retion.Text;
            _account.Account_userName = ADD_TEL_UserName.Text;
            _account.Account_password = ADD_TEL_PassWord.Text;
            _account.Account_Remark = ADD_Account_Remark.Text;
            XmlDocument xml = new XmlDocument();//创建XML文件在内存中
            try
            {
                xml.Load(pathy);
            }
            catch (Exception ex)
            {
                string ExceptionTosting = Convert.ToString(ex);
                MessageBox.Show("不存在数据文件！");
                return;
            }
            //doc.Load(@pathys);
            // 得到根节点body
            XmlNode _body = xml.SelectSingleNode("body");
            // 得到二级根节点Acc
            // XmlNode _Acc = _body.SelectSingleNode("Acc");

            // 得到根节点的所有子节点
            XmlNodeList _AllNodes = _body.ChildNodes;
            int a = _AllNodes.Count;

            //将所有的元素放进_AccModel对象里面
            XmlElement Acc = xml.CreateElement("Account");//创建Acc标签节点
            //_body.ChildNodes[_AllNodes.Count + 1].AppendChild(Acc);//将Acc标签节点添加到body标签里面
            _body.AppendChild(Acc);
            XmlElement AccID = xml.CreateElement("AccID");//创建ID标签节点
            XmlElement AccName = xml.CreateElement("AccName");//创建AccName标签节点
            XmlElement AccRetion = xml.CreateElement("AccRetion");//创建AccSex标签节点
            XmlElement AccUserName = xml.CreateElement("AccUserName");//创建AccAccphone标签节点
            XmlElement AccPassWord = xml.CreateElement("AccPassWord");//创建AccPhone标签节点
            XmlElement AccRemark = xml.CreateElement("AccRemark");//创建AccBirthday标签节点


            if (a == 1 || a == 0)
            {
                AccID.InnerText = Convert.ToString(a);
            }
            else
            {
                AccID.InnerText = Convert.ToString(Convert.ToInt32(nuacount) + 1);
            }

            AccName.InnerText = _account.Account_Name;
            AccRetion.InnerText = _account.Account_Retion;
            AccUserName.InnerText = _account.Account_userName;
            AccPassWord.InnerText = _account.Account_password;
            AccRemark.InnerText = _account.Account_Remark;


            //_AllNodes[_AllNodes.Count + 1].AppendChild(TelName);//将tel标签节点添加到body标签里面
            // _body.ChildNodes[_AllNodes.Count + 1].AppendChild(Tel);//将tel标签节点添加到body标签里面
            Acc.AppendChild(AccID);

          
            Acc.AppendChild(AccName);//将AccName标签节点添加到Acc标签里面
            Acc.AppendChild(AccRetion);//将AccSex标签节点添加到Acc标签里面
            Acc.AppendChild(AccUserName);//将AccAccphone标签节点添加到Acc标签里面
            Acc.AppendChild(AccPassWord);//将AccPhone标签节点添加到Acc标签里面
            Acc.AppendChild(AccRemark);//将AccBirthday标签节点添加到Acc标签里面
            xml.Save(pathy);


            XmlDocument doc = new XmlDocument();//创建XML文件在内存中
            try
            {
                doc.Load(pathy);
            }
            catch (Exception ex)
            {
                string ExceptionTosting = Convert.ToString(ex);
                MessageBox.Show("不存在数据文件！");
                return;
            }

            XmlNode _ = doc.SelectSingleNode("body");
            // 得到二级根节点Tel
            // XmlNode _Tel = _body.SelectSingleNode("Tel");
            // 得到根节点的所有子节点
            XmlNodeList _xmlc = _body.ChildNodes;

            int b = _xmlc.Count;
            //int i = 0;
            if (a < b)
            {
                MessageBox.Show("添加成功!");
                this.Hide();    //隐藏当前窗口
                doc.Save(pathy);
                return;
            }
            else
            {
                MessageBox.Show("添加失败!");
                doc.Save(pathy);
                return;
            }
        }
    }
}
