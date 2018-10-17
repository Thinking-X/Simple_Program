using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using WindowsFormsApp2.Properties;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button5.Enabled = false;
            button6.Enabled = false;
        }
        List<VIP> list = new List<VIP>();
        int index;
        private void Form1_Load(object sender, EventArgs e)
        {
            FileStream fs_ = new FileStream(@"G:/a.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr_ = new StreamReader(fs_);
            string[] users;
            while (sr_.Peek() > -1)//
            {
                users = sr_.ReadLine().Split(',');
                VIP vip = new VIP();
                vip.Name = users[0];
                vip.Password = users[1];
                vip.Password_ = users[2];
                vip.TextTel = users[3];
                vip.Birthday = users[4];
                vip.Gender = users[5];
                list.Add(vip);
            }
            sr_.Dispose();
            fs_.Dispose();
            index = list.Count - 1;
            dataGridView1.DataSource = list;

            var com = list.Select(u => new { ID = u.Name, Sex = u.Gender });
            comboList.DataSource = com.ToList();
            comboList.DisplayMember = "ID";//显式的文本
            comboList.ValueMember = "Sex";//实际的值
            //if(comboBox1.SelectedValue.ToString()== "1_456")
            //{
            //    MessageBox.Show("!@#$");
            //}
        }
        private void button1_Click(object sender, EventArgs e)//注册并写入文本
        {
            VIP user = new VIP();
            user.Name = textID.Text;
            user.Password = textpassword.Text;
            user.Password_ = textpassword_.Text;
            user.TextTel = textTel.Text;
            user.Birthday = dTP_birthday.Text;
            //user.Birthday = dTP_birthday.Value.ToString();//日期带时间
            foreach (VIP item in list)
            {
                if (item.Name == user.Name)
                {
                    MessageBox.Show("该用户名已存在！\n   请重新输入");
                    return;
                }
            }
            bool flag = false;
            foreach (Control item in groupBox1.Controls)
            {
                if (item is RadioButton)
                {
                    RadioButton rdoCtl = item as RadioButton;
                    if (rdoCtl.Checked)
                    {
                        user.Gender = rdoCtl.Text;//
                        flag = true;
                        break;
                    }                   
                }               
            }
            if (!flag)
            {
                MessageBox.Show("请选择性别");
                return;
            }
            if(!user.Judgment())
            {
                MessageBox.Show("两次密码不一致！");
                return;
            }
            list.Add(user);
            index = list.Count - 1;
            dataGridView1.DataSource = null;//先清空
            dataGridView1.DataSource = list;//再绑定

            comboList.DataSource = null;
            var com = list.Select(u => new { ID = u.Name, Sex = u.Gender });
            comboList.DataSource = com.ToList();
            comboList.DisplayMember = "ID";
            comboList.ValueMember = "Sex";

            FileStream fs = new FileStream(@"G:/a.txt", FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            sw.Write("{0},{1},{2},{3},{4},{5}\r\n", 
                user.Name,user.Password,user.Password_,user.TextTel,user.Birthday,user.Gender);
            sw.Dispose();
            sw.Dispose();
            MessageBox.Show("新用户注册成功！");            
        }
        
        private void button2_Click(object sender, EventArgs e)//显示所有文本
        {
            FileStream fs = new FileStream(@"G:/a.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            textDisplay.Text = sr.ReadToEnd();//
            sr.Dispose();
            fs.Dispose();
        }
        private void button4_Click(object sender, EventArgs e)//打开文件
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "文本文件|*.txt|配置文件|*.ini|网页文件|*.html;*.css;*.js|所有文件|*.*";
            ofd.ShowDialog();

            FileStream fs = new FileStream(ofd.FileName, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs, Encoding.UTF8);
            textDisplay.Text = sr.ReadToEnd();
            sr.Dispose();
            fs.Dispose();
        }

        private void button3_Click(object sender, EventArgs e)//显示最新用户
        {
            index = list.Count - 1;
            int n = index;
            textID.Text = list[n].Name;
            textpassword.Text = list[n].Password;
            textpassword_.Text = list[n].Password_;
            textTel.Text = list[n].TextTel;
            dTP_birthday.Text = list[n].Birthday;
            if(list[n].Gender == "男")
            {
                radio_Y.Checked = true;
            }
            if (list[n].Gender == "女")
            {
                radio_X.Checked = true;
            }
            button5.Enabled = true;
            button6.Enabled = false;
        }       

        private void button5_Click(object sender, EventArgs e)//显示上一用户
        {
            index--;
            if (index < list.Count && index > -1)
            {               
                textID.Text = list[index].Name;
                textpassword.Text = list[index].Password;
                textpassword_.Text = list[index].Password_;
                textTel.Text = list[index].TextTel;
                dTP_birthday.Text = list[index].Birthday;
                if (list[index].Gender == "男")
                {
                    radio_Y.Checked = true;
                }
                if (list[index].Gender == "女")
                {
                    radio_X.Checked = true;
                }                              
            }
            else
            {
                if(index == -1 && index != list.Count)
                {
                    index = 0;
                }
                MessageBox.Show("往上已经没有了！");
            }
            button6.Enabled = true;
        }

        private void button6_Click(object sender, EventArgs e)//显示下一用户
        {
            index++;
            if (index < list.Count && index > -1)
            {
                textID.Text = list[index].Name;
                textpassword.Text = list[index].Password;
                textpassword_.Text = list[index].Password_;
                textTel.Text = list[index].TextTel;
                dTP_birthday.Text = list[index].Birthday;
                if (list[index].Gender == "男")
                {
                    radio_Y.Checked = true;
                }
                if (list[index].Gender == "女")
                {
                    radio_X.Checked = true;
                }                             
            }
            else
            {
                if (index == list.Count && index != -1)
                {
                    index = list.Count - 1;
                }
                MessageBox.Show("往下已经没有了！");
            }
        }

        private void button7_Click(object sender, EventArgs e)//显示性别
        {
            var s = list.Select(u => new { u.Name, u.Gender });
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = s.ToList();
        }
        private void comboList_Click(object sender, EventArgs e)//绑定数据源
        {
            
        }
        private void comboList_TextChanged(object sender, EventArgs e)//在控件上更该Text属性时引发的事件
        {
            for(int i = 0; i < list.Count; i++)
            {
                if(comboList.Text == list[i].Name)
                {
                    textID.Text = list[i].Name;
                    textpassword.Text = list[i].Password;
                    textpassword_.Text = list[i].Password_;
                    textTel.Text = list[i].TextTel;
                    dTP_birthday.Text = list[i].Birthday;
                    if (list[i].Gender == "男")
                    {
                        radio_Y.Checked = true;
                    }
                    if (list[i].Gender == "女")
                    {
                        radio_X.Checked = true;
                    }
                    return;
                }               
            }
        }
        //listBox1.Items.RemoveAt
        //listBox1.Items.Remove
        //Remove方法则是真正的从DataRow中删除一行
        //RemoveAt方法是根据本行的索引来删除
        private void move_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                listBox2.Items.Add(listBox1.Text);
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
            else
                MessageBox.Show("没有选中项！");
        }

        private void moveAll_Click(object sender, EventArgs e)
        {
            listBox2.Items.AddRange(listBox1.Items);
            listBox1.Items.Clear();
        }

        private void clear_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
        }

        private void clearAll_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }


        //private void radio_X_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (sender is RadioButton)
        //    {
        //        RadioButton radio_X = sender as RadioButton;
        //        if (radio_X.Checked)
        //        {
        //            //MessageBox.Show(rdoCtl.Text + "被选择！");
        //        }
        //    }
        //}
        //private void radio_Y_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (sender is RadioButton)
        //    {
        //        RadioButton radio_Y = sender as RadioButton;
        //        if (radio_Y.Checked)
        //        {
        //            //MessageBox.Show(rdoCtl.Text + "被选择！");
        //        }
        //    }
        //}
    }     
}
