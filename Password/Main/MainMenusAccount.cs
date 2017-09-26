using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Password.Main
{
    public partial class MainMenusAccount : Form
    {
        public string pathy;
        public string pathys = "C:\\Users\\Aiyero\\Desktop\\Password\\Password\\bin\\Debug\\Data\\2885171.xml";
        public MainMenusAccount()
        {
            InitializeComponent();
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

        private void 通讯录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainMenus mm = new MainMenus();
            mm.Show();
        }
    }
}
