using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Note
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string filepath = "";
        bool txtchange = false;
        string temp = "";
        private void 新建NToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txtfile.Text.Trim() != "" && temp != txtfile.Text)
            {
                DialogResult dr = MessageBox.Show("内容改变，是否保存？", "提示", MessageBoxButtons.YesNoCancel);
                switch (dr)
                {
                    case DialogResult.Yes:
                        保存SToolStripMenuItem_Click(sender, e);
                        txtfile.Text = "";
                        filepath = "";
                        txtchange = false;
                        break;
                    case DialogResult.No:
                        txtfile.Text = "";
                        filepath = "";
                        txtchange = false;
                        break;
                    case DialogResult.Cancel:
                        break;
                }
            }
            if (txtfile.Text.Trim() == "")
            {
                MessageBox.Show("请新建文本！");
            }
        }
        private void 打开OToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "文本文件|*.txt|配置文件|*.ini|网页文件|*.html;*.css;*.js|所有文件|*.*";
            DialogResult dr = ofd.ShowDialog();
            
            if (dr == DialogResult.OK)
            {
                using (FileStream fs = new FileStream(ofd.FileName, FileMode.Open, FileAccess.Read))
                {
                    using (StreamReader sr = new StreamReader(fs, Encoding.Default))
                    {
                        temp = txtfile.Text = sr.ReadToEnd();
                        filepath = ofd.FileName;
                    }
                }
            }
            if(temp != txtfile.Text)
            {
                txtchange = true;               
            }
        }
        private void 另存为AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFile();
        }
        public void SaveFile()
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "文本文件|*.txt|所有文件|*.*";
            sfd.DefaultExt = "txt";//默认格式
            DialogResult dr = sfd.ShowDialog();
            if (dr == DialogResult.OK)
            {
                SavePreviousFile(sfd.FileName);
            }
        }
        public void SavePreviousFile(string path)
        {
            using (FileStream fs = new FileStream(path, FileMode.Create))
            {
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    sw.Write(txtfile.Text);
                }
            }
            filepath = path;
        }
        private void 保存SToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (filepath == "")
            {
                SaveFile();
            }
            else
            {
                SavePreviousFile(filepath);
            }
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (txtfile.Text.Trim() != "" && temp != txtfile.Text)
            {
                DialogResult dr = MessageBox.Show("内容已经改变，是否保存？", "提示", MessageBoxButtons.YesNoCancel);
                switch (dr)
                {
                    case DialogResult.Yes:
                        保存SToolStripMenuItem_Click(sender, e);
                        break;
                    case DialogResult.No:
                        break;
                    case DialogResult.Cancel:
                        e.Cancel = true;
                        break;
                }
            }
        }
        private void txtfile_TextChanged(object sender, EventArgs e)
        {
            txtchange = false;
        }
        private void 撤消UToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtfile.Undo();
        }
        private void 剪切TToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtfile.Cut();
        }
        private void 复制CToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtfile.Copy();
        }
        private void 粘贴PToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtfile.Paste();
        }
        private void 全选AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtfile.SelectAll();
        }
        private void 退出XToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void 字体ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            fd.Font = txtfile.Font;
            fd.ShowDialog();
            txtfile.Font = fd.Font;
        }
        private void 颜色ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            cd.Color = txtfile.ForeColor;
            cd.ShowDialog();
            txtfile.ForeColor = cd.Color;
        }
        private void txtfile_MouseUp(object sender, MouseEventArgs e)//松开鼠标时的操作
        {
            if(txtfile.SelectedText.Length > 0)
            {
                this.复制CToolStripMenuItem.Enabled = true;
            }
            else
            {
                this.复制CToolStripMenuItem.Enabled = false;
            }
        }
        private void 关于AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.ShowDialog();
        }
    }
}
