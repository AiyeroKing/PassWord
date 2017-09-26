using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using XMLModel;

namespace Password
{
  
    public partial class MainMenus : Form
    {
        
        public string pathy;
        public MainMenus()
        {
            InitializeComponent();
            ListViewGetData(); 
        }
        public void ListViewGetData()
        {
            XmlDocument doc = new XmlDocument();
            string path = Environment.CurrentDirectory + "\\Data\\abc2885171.xml";
            try
            {
                doc.Load(path);
            }
            catch (Exception ex)
            {
                MessageBox.Show("不存在数据文件！");
                return;
            }
            List<TelphoneModel> _tellist = new List<TelphoneModel>();

            //doc.Load(@pathys);
            // 得到根节点body
            XmlNode _body = doc.SelectSingleNode("body");
            // 得到二级根节点Tel
            XmlNode _Tel = _body.SelectSingleNode("Tel");
            int i = 1;
            // 得到根节点的所有子节点
            XmlNodeList _AllNodes = _body.ChildNodes;
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
                    TelphoneModel _telModel = new TelphoneModel();
                    // 将节点转换为元素，便于得到节点的属性值
                    XmlElement Ne = (XmlElement)_oneNode;//Ne指的元素类型节点
                    XmlNodeList NeChild = Ne.ChildNodes;
                    _telModel.IDnumber = i - 2;
                    _telModel.Name = NeChild.Item(0).InnerText;
                    _telModel.Sex = NeChild.Item(1).InnerText;
                    _telModel.Telphone = NeChild.Item(2).InnerText;
                    _telModel.Phone = NeChild.Item(3).InnerText;
                    _telModel.Birthday = NeChild.Item(4).InnerText;
                    _telModel.QQ = NeChild.Item(5).InnerText;
                    _telModel.Idcard = NeChild.Item(6).InnerText;
                    _telModel.Retion = NeChild.Item(7).InnerText;
                    _telModel.Company = NeChild.Item(8).InnerText;
                    _telModel.Email = NeChild.Item(9).InnerText;
                    _telModel.Address = NeChild.Item(10).InnerText;
                    _telModel.Remark = NeChild.Item(11).InnerText;

                    //将对象转换成list表类型
                    _tellist.Add(_telModel);
                }
            }
            //清空列表是
            Body_Tel_Listview.Items.Clear();
            //把list列表类型转换成对象表示出来
            foreach(TelphoneModel _one in _tellist)
            {
                ListViewItem lv = new ListViewItem();
                lv.Text =  Convert.ToString(_one.IDnumber);
                lv.SubItems.Add(_one.Name);
                lv.SubItems.Add(_one.Sex);
                lv.SubItems.Add(_one.Phone);
                lv.SubItems.Add(_one.Retion);
                lv.SubItems.Add(_one.Email);
                lv.SubItems.Add(_one.Company);
                //一定记得行数据创建完毕后添加到列表中
                Body_Tel_Listview.Items.Add(lv);
            }
          

        }
        


        #region --绑定事件

        //点击X退出程序
        private void ApplicationExit(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.ApplicationExitCall)
            {
                return;
            }
            DialogResult result = MessageBox.Show("你确定要关闭吗！", "提示信息", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result == DialogResult.OK)
            {
                Application.Exit();
            }
            else
            {
                e.Cancel = true;    //取消关闭
            }
        }



        #endregion


    }
}
