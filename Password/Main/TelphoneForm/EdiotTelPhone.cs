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
    public partial class EdiotTelPhone : Form
    {
        public string pathy;
        public string IDnum;
     
        public EdiotTelPhone(string scking, string path)
        {
            pathy = path;
            IDnum = scking;
            string nuNumberID = scking;
            InitializeComponent();
            InitializeComponentTwo(nuNumberID);
        }
        //查询
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
            List<TelphoneModel> _tellist = new List<TelphoneModel>();

            //doc.Load(@pathys);
            // 得到根节点body
            XmlNode _body = doc.SelectSingleNode("body");
            // 得到二级根节点Tel
            XmlNode _Tel = _body.SelectSingleNode("Tel");
            int i = 1;
            // 得到根节点的所有子节点
            XmlNodeList _AllNodes = _body.ChildNodes;
            TelphoneModel _telModel = new TelphoneModel();
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

                    if(xcID == idcv )
                    {
                        _telModel.IDnumber = NeChild.Item(0).InnerText;
                        _telModel.Name = NeChild.Item(1).InnerText;
                        _telModel.Sex = NeChild.Item(2).InnerText;
                        _telModel.Telphone = NeChild.Item(3).InnerText;
                        _telModel.Phone = NeChild.Item(4).InnerText;
                        _telModel.Birthday = NeChild.Item(5).InnerText;
                        _telModel.QQ = NeChild.Item(6).InnerText;
                        _telModel.Idcard = NeChild.Item(7).InnerText;
                        _telModel.Retion = NeChild.Item(8).InnerText;
                        _telModel.Company = NeChild.Item(9).InnerText;
                        _telModel.Email = NeChild.Item(10).InnerText;
                        _telModel.Address = NeChild.Item(11).InnerText;
                        _telModel.Remark = NeChild.Item(12).InnerText;
                    }
                }
            }
            //赋值初始化
            Ediot_TEL_Name.Text = _telModel.Name;
            Ediot_TEL_Sex.Text = _telModel.Sex;
            Ediot_TEL_Telphone.Text = _telModel.Telphone;
            Ediot_TEL_Phone.Text = _telModel.Phone;
            Ediot_TEL_Birthday.Text = _telModel.Birthday;
            Ediot_TEL_Idcard.Text = _telModel.Idcard;
            Ediot_TEL_Retion.Text = _telModel.Retion;
            Ediot_TEL_QQ.Text = _telModel.QQ;
            Ediot_TEL_Email.Text = _telModel.Email;
            Ediot_TEL_Company.Text = _telModel.Company;
            Ediot_TEL_Address.Text = _telModel.Address;
            Ediot_TEL_Remark.Text = _telModel.Remark;
        }

        //取消编辑按钮
        private void Cell_btn_Ediot_Telphone_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void OK_btn_Ediot_Telphone_Click(object sender, EventArgs e)
        {
            string HID  = IDnum;
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
            List<TelphoneModel> _tellist = new List<TelphoneModel>();
            //doc.Load(@pathys);
            // 得到根节点body
            XmlNode _body = xmldoc.SelectSingleNode("body");
            // 得到二级根节点Tel
            XmlNode _Tel = _body.SelectSingleNode("Tel");
            int i = 1;
            // 得到根节点的所有子节点
            XmlNodeList _AllNodes = _body.ChildNodes;
            TelphoneModel _telModel = new TelphoneModel();
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
                        NeChild.Item(0).InnerText = HID ;
                        NeChild.Item(1).InnerText = Ediot_TEL_Name.Text;
                        NeChild.Item(2).InnerText = Ediot_TEL_Sex.Text;
                        NeChild.Item(3).InnerText = Ediot_TEL_Telphone.Text;
                        NeChild.Item(4).InnerText =Ediot_TEL_Phone.Text;
                        NeChild.Item(5).InnerText =Ediot_TEL_Birthday.Text;
                        NeChild.Item(6).InnerText = Ediot_TEL_QQ.Text;
                        NeChild.Item(7).InnerText = Ediot_TEL_Idcard.Text;
                        NeChild.Item(8).InnerText = Ediot_TEL_Retion.Text;
                        NeChild.Item(9).InnerText = Ediot_TEL_Company.Text;
                        NeChild.Item(10).InnerText = Ediot_TEL_Email.Text;
                        NeChild.Item(11).InnerText = Ediot_TEL_Address.Text;
                        NeChild.Item(12).InnerText = Ediot_TEL_Remark.Text;

                        xmldoc.Save(pathy);
                    }
                }
            }

            Hide();
        }
    }
}
