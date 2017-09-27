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
    public partial class EdiotAccountForm : Form
    {
        public string pathy;
        public string IDnum;
        public EdiotAccountForm(string sck, string path)
        {
            IDnum = sck;
            pathy = path;
            InitializeComponent();
            string nuNumberID = sck;
            InitializeComponentTwo(nuNumberID);
        }

        #region --绑定事件
        //点击X退出程序
        private void ApplicationExit(object sender, FormClosingEventArgs e)
        {
            Hide();
        }
        #endregion

        //初始化界面
        private void InitializeComponentTwo(string nuID)
        {
            string xcID = nuID;

            XmlDocument doc = new XmlDocument();
            //string path = Environment.CurrentDirectory + "\\Data\\abc2885171.xml";
            try
            {
                doc.Load(pathy);
            }
            catch (Exception ex)
            {
                MessageBox.Show("不存在数据文件！");
                return;
            }
            List<PassWordModel> _Acclist = new List<PassWordModel>();

            //doc.Load(@pathys);
            // 得到根节点body
            XmlNode _body = doc.SelectSingleNode("body");
            // 得到二级根节点Tel
            XmlNode _Acc = _body.SelectSingleNode("Account");
            int i = 1;
            // 得到根节点的所有子节点
            XmlNodeList _AllNodes = _body.ChildNodes;
            PassWordModel _AccModel = new PassWordModel();
            //将所有的元素放进_telModel对象里面
            foreach (XmlNode _oneNode in _AllNodes)
            {
                if (i == 1)
                {
                    i++;
                }
                else
                {
                    i++;
                    // 将节点转换为元素，便于得到节点的属性值
                    XmlElement Ne = (XmlElement)_oneNode;//Ne指的元素类型节点
                    XmlNodeList NeChild = Ne.ChildNodes;
                    string idcv = NeChild.Item(0).InnerText;

                    if (xcID == idcv)
                    {
                        _AccModel.Account_IDnumber = NeChild.Item(0).InnerText;
                        _AccModel.Account_Name = NeChild.Item(1).InnerText;
                        _AccModel.Account_Retion = NeChild.Item(2).InnerText;
                        _AccModel.Account_userName = NeChild.Item(3).InnerText;
                        _AccModel.Account_password = NeChild.Item(4).InnerText;
                        _AccModel.Account_Remark = NeChild.Item(5).InnerText;
                    }
                }
            }
            //赋值初始化

            Ediot_Account_Name.Text = _AccModel.Account_Name;
            Ediot_Account_Retion.Text = _AccModel.Account_Retion;
            Ediot_TEL_UserName.Text = _AccModel.Account_userName;
            Ediot_TEL_PassWord.Text = _AccModel.Account_password;
            Ediot_Account_Remark.Text = _AccModel.Account_Remark;
        }
        //取消按钮
        private void Cell_btn_Ediot_Password_Click(object sender, EventArgs e)
        {
            Hide();
        }
        //确定编辑按钮
        private void OK_btn_Ediot_Password_Click(object sender, EventArgs e)
        {
            string HID = IDnum;
            XmlDocument xmldoc = new XmlDocument();
            //string path = Environment.CurrentDirectory + "\\Data\\abc2885171.xml";
            try
            {
                xmldoc.Load(pathy);
            }
            catch (Exception ex)
            {
                MessageBox.Show("不存在数据文件！");
                return;
            }
            List<PassWordModel> _Acclist = new List<PassWordModel>();
            //doc.Load(@pathys);
            // 得到根节点body
            XmlNode _body = xmldoc.SelectSingleNode("body");
            // 得到二级根节点Tel
            XmlNode _Acc = _body.SelectSingleNode("Account");
            int i = 1;
            // 得到根节点的所有子节点
            XmlNodeList _AllNodes = _body.ChildNodes;
            PassWordModel _AccModel = new PassWordModel();
            //将所有的元素放进_telModel对象里面
            foreach (XmlNode _oneNode in _AllNodes)
            {
                if (i == 1)
                {
                    i++;
                }
                else
                {
                    i++;
                    // 将节点转换为元素，便于得到节点的属性值
                    XmlElement Ne = (XmlElement)_oneNode;//Ne指的元素类型节点
                    XmlNodeList NeChild = Ne.ChildNodes;
                    string idcv = NeChild.Item(0).InnerText;

                    if (HID == idcv)
                    {
                        NeChild.Item(0).InnerText = HID;
                        NeChild.Item(1).InnerText = Ediot_Account_Name.Text;
                        NeChild.Item(2).InnerText = Ediot_Account_Retion.Text;
                        NeChild.Item(3).InnerText = Ediot_TEL_UserName.Text;
                        NeChild.Item(4).InnerText = Ediot_TEL_PassWord.Text;
                        NeChild.Item(5).InnerText = Ediot_Account_Remark.Text;

                        xmldoc.Save(pathy);
                    }
                }
            }

            Hide();
        
        }
    }
}
