using StudentApp.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentApp
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
            Form_Menu menu = new Form_Menu();
            Application.Run(menu);
            int result = menu.Result;
            while(result != 0)
            {
                switch (result)
                {
                    case 1:
                        Application.Run(new Form_Stu());
                        break;
                    case 2:
                        Application.Run(new Form_Cour());
                        break;
                    case 3:
                        Application.Run(new Form_SC());
                        break;
                }
                Form_Menu menu_ = new Form_Menu();
                Application.Run(menu_);
                result = menu_.Result;
            }
            return;
        }
    }
}
