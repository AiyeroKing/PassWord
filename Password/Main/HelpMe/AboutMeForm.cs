using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Password.Main.HelpMe
{
    public partial class AboutMeForm : Form
    {
        public AboutMeForm()
        {
            InitializeComponent();
        }

        #region --绑定事件
        //点击X退出程序
        private void ApplicationExit(object sender, FormClosingEventArgs e)
        {
            Hide();
        }
        #endregion

        //关闭按钮
        private void Cell_btn_AboutMe_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }

}
