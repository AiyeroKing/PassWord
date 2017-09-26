using Password.Main;
using Password.SignUp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Password
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new PassMenusOne());   
            //Application.Run(new SignUpPassWord()); //注册主界面
            //Application.Run(new PasswordMunes());  //登录主界面
            Application.Run(new MainMenus());   //通讯录主界面
             //Application.Run(new MainMenusAccount());   //通讯录主界面
        }
    }
}
