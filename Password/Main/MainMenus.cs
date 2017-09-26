using Password.Main.TelphoneForm;
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

        //public string pathy = Environment.CurrentDirectory + "\\Data\\abc2885171.xml";
        public string numCount;
        public string pathy;
        public int times;
        public MainMenus(string path)
        {
            InitializeComponent();
            pathy = path;
            ListViewGetData();

        }

        //数据从后台到窗口Listview显示
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
                    _telModel.Remark = NeChild.Item(11).InnerText;
                    //将对象转换成list表类型
                    _tellist.Add(_telModel);
                    numCount = NeChild.Item(0).InnerText;
                }
            }
            //清空列表是
            Body_Tel_Listview.Items.Clear();
            //把list列表类型转换成对象表示出来
            int bll = 1;
            foreach (TelphoneModel _one in _tellist)
            {
                ListViewItem lv = new ListViewItem();
                lv.Text = Convert.ToString(bll);
                lv.SubItems.Add(_one.Name);
                lv.SubItems.Add(_one.Sex);
                lv.SubItems.Add(_one.Phone);
                lv.SubItems.Add(_one.Retion);
                lv.SubItems.Add(_one.Email);
                lv.SubItems.Add(_one.IDnumber);
                bll++;
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

        private void Add_Tel_btn_Click(object sender, EventArgs e)
        {
            AddTelPhone ADD = new AddTelPhone(numCount, pathy);

            ADD.ShowDialog();
            //InitializeComponent(); 
            ListViewGetData();//重新加载页面

        }
        //删除
        private void Deleted_Tel_btn_Click(object sender, EventArgs e)
        {
            //TelphoneModel tel = new TelphoneModel();
            //List<TelphoneModel> _tellist = new List<TelphoneModel>();
            int k = 0;
            int m = Body_Tel_Listview.CheckedItems.Count;
            string[] a = new string[m];
            int[] c = new int[m];

            Queue<string> Q = new Queue<string>();

            for (int i = 0; i < m; i++)
                if (Body_Tel_Listview.CheckedItems[i].Checked)
                    Q.Enqueue(Body_Tel_Listview.CheckedItems[i].SubItems[6].Text);
            while (Q.Count > 0)
            {
                a[k] = Q.Dequeue();
                k++;
            }
            try
            {
               
                for (int yy =0;yy<k;yy++)
                {
                    XmlDocument xmlDoc = new XmlDocument();
                    xmlDoc.Load(pathy);
                    //XElement rootNode = XElement.Load(pathy);
                    XmlNode _body = xmlDoc.SelectSingleNode("body");
                    XmlNode _Tel = _body.SelectSingleNode("Tel");
                    XmlNodeList _AllNodes = _body.ChildNodes;
                    string sc = a[yy];
                    XmlNode xn = xmlDoc.DocumentElement.SelectSingleNode("//Tel[TelID="+sc+"]");
                    xmlDoc.DocumentElement.RemoveChild(xn);
                    xmlDoc.Save(pathy);
                }
                //target.Attribute("TelID").Value.Equals(a[k])
                MessageBox.Show("删除成功");
                ListViewGetData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("删除失败原因"+ ex.ToString());

            }
        }

 
        




        ////复选框的值
        //private void Body_Tel_Listview_ItemChecked(object sender, ItemCheckedEventArgs e)
        //{
        //    //e.Item.Selected = e.Item.Checked;
        //    //int m = Body_Tel_Listview.CheckedItems.Count;
        //    //label1.Text = "当前选中数：" + m.ToString();
        //    int k = 0;
        //    int m = Body_Tel_Listview.CheckedItems.Count;
        //    string[] a = new string[m];
        //    Queue<string> Q = new Queue<string>();

        //    for (int i = 0; i < m; i++)
        //        if (Body_Tel_Listview.CheckedItems[i].Checked)
        //            Q.Enqueue(Body_Tel_Listview.CheckedItems[i].SubItems[1].Text);
        //    while (Q.Count > 0)
        //    {
        //        a[k] = Q.Dequeue();
        //        k++;
        //    }
        //}
        #region --单选复选框
        //选中复选框
        //private void Body_Tel_Listview_ItemCheck(object sender, ItemCheckEventArgs e)
        //{
        //    if (!Body_Tel_Listview.Items[e.Index].Checked)//如果点击的CheckBoxes没有选中  
        //    {
        //        foreach (ListViewItem lv in Body_Tel_Listview.Items)
        //        {
        //            if (lv.Checked)//取消所有已选中的CheckBoxes  
        //            {
        //                lv.Checked = false;
        //                lv.Selected = false;
        //                // lv.BackColor = Color.White;  
        //            }
        //        }
        //        Body_Tel_Listview.Items[e.Index].Selected = true;
        //        // lv.Checked = false;  
        //    }
        //}
        //private void Body_Tel_Listview_SelectedIndexChanged(object sender, EventArgs e)
        //{

        //    foreach (ListViewItem lv in Body_Tel_Listview.Items)
        //    {

        //        if (lv.Selected)
        //        {
        //            //if (lv.Checked)  
        //            //{  
        //            //    //lv.Checked = false;  
        //            //}  
        //            //else  
        //            //{  
        //            lv.Checked = true;
        //            //}  
        //        }
        //        else
        //        {
        //            if (Body_Tel_Listview.SelectedIndices.Count >)
        //            {
        //                if (lv.Checked)
        //                {
        //                    lv.Checked = false;
        //                }
        //            }

        //        }
        //    }

        //}
        #endregion
    }
}

