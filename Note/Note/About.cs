using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Note
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
            textAbout.Text = "  notepad（记事本）是代码编辑器或WINDOWS中的" +
                "小程序，用于文本编辑，在文字编辑方面与Windows写字板" +
                "功能相当。是一款开源、小巧、免费的纯文本编辑器。" +
                "Notepad内置支持多达 27 种语法高亮度显示(囊括各种常见的" +
                "源代码、脚本，值得一提的是，完美支持.nfo 文件查看)，" +
                "也支持自定义语言。";
        }
    }
}
