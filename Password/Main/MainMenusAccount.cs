using Password.Main.HelpMe;
using Password.Main.PassWordForm;
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

namespace Password.Main
{
    public partial class MainMenusAccount : Form
    {
       
        public string numCount;//总和
        public string pathy;//文件路径
        public int times; //次数
        
        public MainMenusAccount(string alloooy)
        {
            pathy = alloooy;
            InitializeComponent();
            ListViewGetData();
        }

        //添加按钮
        private void Add_Account_btn_Click(object sender, EventArgs e)
        {
            AddAccountForm ADD = new AddAccountForm(numCount, pathy);
            ADD.ShowDialog();
            //InitializeComponent(); 
            ListViewGetData();//重新加载页面

        }
        //删除按钮
        private void Deleted_Account_btn_Click(object sender, EventArgs e)
        {
            //TelphoneModel tel = new TelphoneModel();
            //List<TelphoneModel> _tellist = new List<TelphoneModel>();
            int k = 0;
            int m = Body_Account_Listview.CheckedItems.Count;
            string[] a = new string[m];
            int[] c = new int[m];

            Queue<string> Q = new Queue<string>();

            for (int i = 0; i < m; i++)
                if (Body_Account_Listview.CheckedItems[i].Checked)
                    Q.Enqueue(Body_Account_Listview.CheckedItems[i].SubItems[5].Text);
            while (Q.Count > 0)
            {
                a[k] = Q.Dequeue();
                k++;
            }
            if (k > 0)
            {
            }
            else
            {
                MessageBox.Show("没有选中下列信息");
                return;
            }
            try
            {

                for (int yy = 0; yy < k; yy++)
                {
                    XmlDocument xmlDoc = new XmlDocument();
                    xmlDoc.Load(pathy);
                    //XElement rootNode = XElement.Load(pathy);
                    XmlNode _body = xmlDoc.SelectSingleNode("body");
                    XmlNode _Account = _body.SelectSingleNode("Account");
                    XmlNodeList _AllNodes = _body.ChildNodes;
                    string sc = a[yy];
                    XmlNode xn = xmlDoc.DocumentElement.SelectSingleNode("//Account[AccID=" + sc + "]");
                    xmlDoc.DocumentElement.RemoveChild(xn);
                    xmlDoc.Save(pathy);
                }
                //target.Attribute("TelID").Value.Equals(a[k])
                MessageBox.Show("删除成功");
                ListViewGetData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("删除失败原因" + ex.ToString());

            }
        }
        //查询按钮
        private void Check_Account_btn_Click(object sender, EventArgs e)
        {
            initializecomponenttwo();
            string lookName = Check_Acc_Name_Input.Text;
            string lookRetion = Check_Acc_Retion_Input.Text;
            XmlDocument doc = new XmlDocument();
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
            List<PassWordModel> _accountlist = new List<PassWordModel>();

            //doc.Load(@pathys);
            // 得到根节点body
            XmlNode _body = doc.SelectSingleNode("body");
            // 得到二级根节点Tel
            XmlNode _Acc = _body.SelectSingleNode("Account");
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
                    PassWordModel _AccModel = new PassWordModel();
                    // 将节点转换为元素，便于得到节点的属性值
                    XmlElement Ne = (XmlElement)_oneNode;//Ne指的元素类型节点
                    XmlNodeList NeChild = Ne.ChildNodes;


                    _AccModel.Account_Retion = NeChild.Item(2).InnerText;
                    _AccModel.Account_Name = NeChild.Item(1).InnerText;

                    bool check1 = (_AccModel.Account_Name).Contains(lookName);
                    bool check2 = (_AccModel.Account_Retion).Contains(lookRetion);
                    if (check1 && check2)
                    {
                        _AccModel.Account_IDnumber = NeChild.Item(0).InnerText;
                        _AccModel.Account_Name = NeChild.Item(1).InnerText;
                        _AccModel.Account_Retion = NeChild.Item(2).InnerText;
                        _AccModel.Account_userName = NeChild.Item(3).InnerText;
                        _AccModel.Account_password = NeChild.Item(4).InnerText;
                        _AccModel.Account_Remark = NeChild.Item(5).InnerText;

                        //将对象转换成list表类型
                        _accountlist.Add(_AccModel);
                        numCount = NeChild.Item(0).InnerText;
                    }
                    else
                    { }
                }
            }
            //清空列表是
            Body_Account_Listview.Items.Clear();
            //把list列表类型转换成对象表示出来
            int bll = 1;
            foreach (PassWordModel _one in _accountlist)
            {
                ListViewItem lv = new ListViewItem();
                lv.Text = Convert.ToString(bll);
                lv.SubItems.Add(_one.Account_Name);
                lv.SubItems.Add(_one.Account_Retion);
                lv.SubItems.Add(_one.Account_userName);
                lv.SubItems.Add(_one.Account_password);
                lv.SubItems.Add(_one.Account_IDnumber);
                bll++;
                //一定记得行数据创建完毕后添加到列表中
                Body_Account_Listview.Items.Add(lv);
            }
        }
        //初始化右侧
        public void initializecomponenttwo()
        {
            SEE_Account_Name.Text = "";
            SEE_Account_Retion.Text = "";
            SEE_Account_UserName.Text = "";
            SEE_Account_PassWord.Text = "";
            SEE_Account_Remark.Text = "";
        }
        //初始化页面
        public void ListViewGetData()
        {
            XmlDocument doc = new XmlDocument();
            //string path = Environment.CurrentDirectory + "\\Data\\abc2885171.xml";
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
            List<PassWordModel> _accountlist = new List<PassWordModel>();

            //doc.Load(@pathys);
            // 得到根节点body
            XmlNode _body = doc.SelectSingleNode("body");
            // 得到二级根节点Tel
            XmlNode _Account = _body.SelectSingleNode("Account");
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
                    PassWordModel _accountlistModel = new PassWordModel();
                    // 将节点转换为元素，便于得到节点的属性值
                    XmlElement Ne = (XmlElement)_oneNode;//Ne指的元素类型节点
                    XmlNodeList NeChild = Ne.ChildNodes;

                    _accountlistModel.Account_IDnumber = NeChild.Item(0).InnerText;
                    _accountlistModel.Account_Name = NeChild.Item(1).InnerText;
                    _accountlistModel.Account_Retion = NeChild.Item(2).InnerText;
                    _accountlistModel.Account_userName = NeChild.Item(3).InnerText;
                    _accountlistModel.Account_password = NeChild.Item(4).InnerText;
                    _accountlistModel.Account_Remark = NeChild.Item(5).InnerText;
                    //将对象转换成list表类型
                    _accountlist.Add(_accountlistModel);
                    numCount = NeChild.Item(0).InnerText;
                }
            }
            //清空列表是
            Body_Account_Listview.Items.Clear();
            //把list列表类型转换成对象表示出来
            int bll = 1;
            foreach (PassWordModel _one in _accountlist)
            {
                ListViewItem lv = new ListViewItem();
                lv.Text = Convert.ToString(bll);
                lv.SubItems.Add(_one.Account_Name);
                lv.SubItems.Add(_one.Account_Retion);
                lv.SubItems.Add(_one.Account_userName);
                lv.SubItems.Add(_one.Account_password);
                lv.SubItems.Add(_one.Account_IDnumber);
                bll++;
                //一定记得行数据创建完毕后添加到列表中
                Body_Account_Listview.Items.Add(lv);
            }
        }
        //编辑按钮点击
        private void Ediot_Account_btn_Click(object sender, EventArgs e)
        {

           
            int kkk = 0;
            int mmmm = Body_Account_Listview.CheckedItems.Count;
            string[] aaaa = new string[mmmm];
            int[] ccc = new int[mmmm];

            Queue<string> Q = new Queue<string>();

            for (int iii = 0; iii < mmmm; iii++)
                if (Body_Account_Listview.CheckedItems[iii].Checked)
                    Q.Enqueue(Body_Account_Listview.CheckedItems[iii].SubItems[5].Text);
            while (Q.Count > 0)
            {
                aaaa[kkk] = Q.Dequeue();
                kkk++;
            }
            if (kkk > 1)
            {
                MessageBox.Show("您选中的多个信息，无法编辑请选择一个；");
                return;
            }
            else if (kkk == 0)
            {
                MessageBox.Show("没有选中下列信息");
                return;
            }
            else if (kkk == 1)
            {
                string sck = aaaa[0];
                EdiotAccountForm Ediot = new EdiotAccountForm(sck, pathy);
                Ediot.ShowDialog();
                //InitializeComponent(); 
                ListViewGetData();//重新加载页面
            }
        }
        private void Body_Acc_Listview_ItemActivate(object sender, EventArgs e)
        {
            _ItemActivate();
        }
        //调用方法
        public void _ItemActivate()
        {
            int kkk = 0;
            int mmmm = Body_Account_Listview.CheckedItems.Count;
            string[] aaaa = new string[mmmm];
            int[] ccc = new int[mmmm];

            Queue<string> Q = new Queue<string>();
            bool cctv = false;
            for (int iii = 0; iii < mmmm; iii++)
                if (Body_Account_Listview.CheckedItems[iii].Checked)
                    Q.Enqueue(Body_Account_Listview.CheckedItems[iii].SubItems[5].Text);
            while (Q.Count > 0)
            {
                cctv = true;
                aaaa[kkk] = Q.Dequeue();
                kkk++;
            }
            if (!cctv)
            {
                //MessageBox.Show("没有选中下列信息");
                return;
            }
            else if (cctv)
            {
                string sck = aaaa[0];
                initializecomponenttwo();

                XmlDocument doc = new XmlDocument();
                //string path = Environment.CurrentDirectory + "\\Data\\abc2885171.xml";
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
                List<PassWordModel> _acclist = new List<PassWordModel>();

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

                        if (sck == idcv)
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
                SEE_Account_Name.Text = _AccModel.Account_Name;
                SEE_Account_Retion.Text = _AccModel.Account_Retion;
                SEE_Account_UserName.Text = _AccModel.Account_userName;
                SEE_Account_PassWord.Text = _AccModel.Account_password;
                SEE_Account_Remark.Text = _AccModel.Account_Remark;
              
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

        //菜单栏转到通讯录
        private void Select_Tel_Form_btn_Click(object sender, EventArgs e)
        {
            Hide();
            PasswordMunes ps = new PasswordMunes();
            ps.Show();
        }
        //菜单栏关闭
        private void Close_Account_Program_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void Munes_HelperCenter_Click(object sender, EventArgs e)
        {
            HelpCenterForm help = new HelpCenterForm();
            help.Show();
        }
        //菜单栏选项--关于我
        private void Muens_AboutMe_Click(object sender, EventArgs e)
        {
            AboutMeForm Am = new AboutMeForm();
            Am.Show();
        }
    }
}
