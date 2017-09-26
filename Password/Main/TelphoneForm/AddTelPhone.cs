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

namespace Password.Main.TelphoneForm
{
    public partial class AddTelPhone : Form
    {

        public string pathy;

        public AddTelPhone()
        {
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
            ADD_TEL_Name.Text = "  ";
            ADD_TEL_Sex.Text = "未填";
            ADD_TEL_Telphone.Text = "  ";
            ADD_TEL_Phone.Text = "  ";
            ADD_TEL_Birthday.Text = "2010/10/10";
            ADD_TEL_Idcard.Text = "  ";
            ADD_TEL_Retion.Text = "普通朋友";
            ADD_TEL_QQ.Text = "  ";
            ADD_TEL_Email.Text = "  ";
            ADD_TEL_Company.Text = "  ";
            ADD_TEL_Address.Text = "  ";
            ADD_TEL_Remark.Text = "  ";
        }

        //取消添加按钮
        private void Cell_btn_ADD_Telphone_Click(object sender, EventArgs e)
        {
            this.Hide();    //隐藏当前窗口
            //MessageBox.Show("取消添加!");
            //this.Close();   //关闭当前窗口
        }

        //点击添加按钮
        private void OK_btn_ADD_Telphone_Click(object sender, EventArgs e)
        {
            //InitializeComponentThree();//设置为空的值未“  ”而非空

            TelphoneModel _tel = new TelphoneModel();
            _tel.Name = ADD_TEL_Name.Text;
            _tel.Sex = ADD_TEL_Sex.Text;
            _tel.Telphone = ADD_TEL_Telphone.Text;
            _tel.Phone = ADD_TEL_Phone.Text;
            _tel.Birthday = ADD_TEL_Birthday.Text;
            _tel.Idcard = ADD_TEL_Idcard.Text;
            _tel.Remark = ADD_TEL_Retion.Text;
            _tel.QQ = ADD_TEL_QQ.Text;
            _tel.Email = ADD_TEL_Email.Text;
            _tel.Company = ADD_TEL_Company.Text;
            _tel.Address = ADD_TEL_Address.Text;
            _tel.Remark = ADD_TEL_Remark.Text;


            XmlDocument xml = new XmlDocument();//创建XML文件在内存中
            try
            {
                xml.Load(pathy);
            }
            catch (Exception ex)
            {
                MessageBox.Show("不存在数据文件！");
                return;
            }
            //doc.Load(@pathys);
            // 得到根节点body
            XmlNode _body = xml.SelectSingleNode("body");
            // 得到二级根节点Tel
           // XmlNode _Tel = _body.SelectSingleNode("Tel");
           
            // 得到根节点的所有子节点
            XmlNodeList _AllNodes = _body.ChildNodes;

            int a = _AllNodes.Count;
            //将所有的元素放进_telModel对象里面
            XmlElement Tel = xml.CreateElement("Tel");//创建Tel标签节点
            //_body.ChildNodes[_AllNodes.Count + 1].AppendChild(Tel);//将tel标签节点添加到body标签里面
            _body.AppendChild(Tel);
            XmlElement TelName = xml.CreateElement("TelName");//创建TelName标签节点
            XmlElement TelSex = xml.CreateElement("TelSex");//创建TelSex标签节点
            XmlElement TelTelphone = xml.CreateElement("TelTelphone");//创建TelTelphone标签节点
            XmlElement TelPhone = xml.CreateElement("TelPhone");//创建TelPhone标签节点
            XmlElement TelBirthday = xml.CreateElement("TelBirthday");//创建TelBirthday标签节点
            XmlElement TelQQ = xml.CreateElement("TelQQ");//创建TelQQ标签节点
            XmlElement TelIdcard = xml.CreateElement("TelIdcard");//创建TelIdcard标签节点
            XmlElement TelRetion = xml.CreateElement("TelRetion");//创建TelRetion标签节点
            XmlElement TelCompany = xml.CreateElement("TelCompany");//创建TelCompany标签节点
            XmlElement TelEmai = xml.CreateElement("TelEmai");//创建TelEmai标签节点
            XmlElement TelAddress = xml.CreateElement("TelAddress");//创建TelAddress标签节点
            XmlElement TelRemark = xml.CreateElement("TelRemark");//创建TelRemark标签节点

            TelName.InnerText = _tel.Name;
            TelSex.InnerText = _tel.Sex;
            TelTelphone.InnerText = _tel.Telphone;
            TelPhone.InnerText = _tel.Phone;
            TelBirthday.InnerText = _tel.Birthday;
            TelQQ.InnerText = _tel.QQ;
            TelIdcard.InnerText = _tel.Idcard;
            TelRetion.InnerText = _tel.Retion;
            TelCompany.InnerText = _tel.Company;
            TelEmai.InnerText = _tel.Email;
            TelAddress.InnerText = _tel.Address;
            TelRemark.InnerText = _tel.Remark;
            //_AllNodes[_AllNodes.Count + 1].AppendChild(TelName);//将tel标签节点添加到body标签里面
            // _body.ChildNodes[_AllNodes.Count + 1].AppendChild(Tel);//将tel标签节点添加到body标签里面
            Tel.AppendChild(TelName);//将TelName标签节点添加到Tel标签里面
            Tel.AppendChild(TelSex);//将TelSex标签节点添加到Tel标签里面
            Tel.AppendChild(TelTelphone);//将TelTelphone标签节点添加到Tel标签里面
            Tel.AppendChild(TelPhone);//将TelPhone标签节点添加到Tel标签里面
            Tel.AppendChild(TelBirthday);//将TelBirthday标签节点添加到Tel标签里面
            Tel.AppendChild(TelQQ);//将TelQQ标签节点添加到Tel标签里面
            Tel.AppendChild(TelIdcard);//将TelIdcard标签节点添加到Tel标签里面
            Tel.AppendChild(TelRetion);//将TelRetion标签节点添加到Tel标签里面
            Tel.AppendChild(TelCompany);//将TelCompany标签节点添加到Tel标签里面
            Tel.AppendChild(TelEmai);//将TelEmai标签节点添加到Tel标签里面
            Tel.AppendChild(TelAddress);//将TelAddress标签节点添加到Tel标签里面
            Tel.AppendChild(TelRemark);//将TelRemark标签节点添加到Tel标签里面
            xml.Save(pathy);

            XmlDocument doc = new XmlDocument();//创建XML文件在内存中
            try
            {
                doc.Load(pathy);
            }
            catch (Exception ex)
            {
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
            if (a<b)
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
