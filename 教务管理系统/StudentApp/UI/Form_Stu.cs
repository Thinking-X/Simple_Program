using StudentApp.DAL;
using StudentApp.PublicClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentApp
{
    public partial class Form_Stu : Form
    {
        public Form_Stu()
        {
            InitializeComponent();
        }
        int i;//表示第几页
        int count;//表示所查询的表一共几行
        private void Form_Stu_Load(object sender, EventArgs e)
        {
            UpPage.Enabled = false;
            DownPage.Enabled = false;
        }
        StudentDAO StuDao = new StudentDAO();
        private void View_Stu_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)//为dataGridView增加索引列
        {
            var grid = sender as DataGridView;
            var rowIdx = (e.RowIndex + 1).ToString();
            var centerFormat = new StringFormat()
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };
            var headerBounds = new Rectangle(e.RowBounds.Left, e.RowBounds.Top, grid.RowHeadersWidth, e.RowBounds.Height);
            e.Graphics.DrawString(rowIdx, this.Font, SystemBrushes.ControlText, headerBounds, centerFormat);
            return;
        }
        private void Display_Click(object sender, EventArgs e)
        {          
            View_Stu.AutoGenerateColumns = true;
            View_Stu.DataSource = StuDao.DisplayTableStu();
            count = StuDao.GainSumline();
            UpPage.Enabled = false;
            DownPage.Enabled = false;
            return;
        }
        private void FirstPage_Click(object sender, EventArgs e)
        {
            int num;//一页显示几行
            bool x = int.TryParse(LineNum.Text, out num);
            if (x && num > 0)
            {
                i = 1;                               
                View_Stu.AutoGenerateColumns = true;
                View_Stu.DataSource = StuDao.DisplayPage(num,i);
                UpPage.Enabled = false;
                DownPage.Enabled = true;
                count = StuDao.GainSumline();
            }
            else
            {
                MessageBox.Show("请输入合法的数！");
            }
            return;
        }
        private void UpPage_Click(object sender, EventArgs e)
        {
            i--;
            if (i == 0)
            {
                i++;
                UpPage.Enabled = false;
                MessageBox.Show("往上已经没有了！");
                return;
            }
            int num = Convert.ToInt32(LineNum.Text);           
            View_Stu.AutoGenerateColumns = true;
            View_Stu.DataSource = StuDao.DisplayPage(num, i);
            DownPage.Enabled = true;
            return;
        }
        private void DownPage_Click(object sender, EventArgs e)
        {
            i++;
            int num = Convert.ToInt32(LineNum.Text);//一页显示几行
            if (count % num == 0)
            {
                if ((i - 1) == (count / num))
                {
                    i--;
                    DownPage.Enabled = false;
                    MessageBox.Show("往下已经没有了！");
                    return;
                }
            }
            else
            {
                if ((i - 1) == (count / num + 1))
                {
                    i--;
                    DownPage.Enabled = false;
                    MessageBox.Show("往下已经没有了！");
                    return;
                }
            }            
            View_Stu.AutoGenerateColumns = true;
            View_Stu.DataSource = StuDao.DisplayPage(num, i);
            UpPage.Enabled = true;
            return;
        }
        private void Insert_Click(object sender, EventArgs e)
        {
            Student stu = new Student();
            stu.Sid = Sid.Text;
            stu.Sname = Sname.Text;
            stu.Brithdate = Convert.ToDateTime(Brithdate.Text.ToString());
            stu.Specialty = Specialty.Text;
            stu.AScores = Convert.ToDecimal(AScores.Text);
            bool flag = false;
            foreach (Control item in groupBox1.Controls)
            {
                if (item is RadioButton)
                {
                    RadioButton button = item as RadioButton;
                    if (button.Checked)
                    {
                        stu.Sex = button.Text;
                        flag = true;
                        break;
                    }
                }
            }
            if (!flag)
            {
                MessageBox.Show("请选择性别！");
                return;
            }
            if (Insert.Text.Equals("注册"))
            {
                StuDao.Insert_Stu(stu);
            }
            else
            {
                StuDao.Updata_Stu(stu);
                Sid.ReadOnly = false;
                Insert.Text = "注册";
            }
            return;
        }
        private void Update_Click(object sender, EventArgs e)
        {
            if (View_Stu.SelectedRows.Count == 1)
            {
                int index = View_Stu.CurrentRow.Index;
            }
            else
            {
                MessageBox.Show("请点击索引，选择一行！");
                return;
            }
            Insert.Text = "确认更改";
            MessageBox.Show("请在右侧更改！");
            Sid.Text = View_Stu.SelectedRows[0].Cells[0].Value.ToString();
            Sname.Text = View_Stu.SelectedRows[0].Cells[1].Value.ToString();
            string Gender = View_Stu.SelectedRows[0].Cells[2].Value.ToString();
            if (Gender.Trim() == "男")
            {
                radio_Y.Checked = true;
            }
            if (Gender.Trim() == "女")
            {
                radio_X.Checked = true;
            }
            Specialty.Text = View_Stu.SelectedRows[0].Cells[3].Value.ToString();
            AScores.Text = View_Stu.SelectedRows[0].Cells[4].Value.ToString();
            Brithdate.Text = View_Stu.SelectedRows[0].Cells[5].Value.ToString();
            Sid.ReadOnly = true;
            return;
        }
        private void Prop_Click(object sender, EventArgs e)
        {
            //选择查找方式时触发的事件
            Dictionary<string, string> Dic = new Dictionary<string, string>();
            Dic.Add("学号", "Sid");
            Dic.Add("姓名", "Sname");
            Dic.Add("性别", "Sex");
            Dic.Add("专业", "Specialty");
            Dic.Add("分数", "Ascores");
            Dic.Add("生日(用短线隔开)", "Brithdate");
            var t = Dic.Select(u => new { key = u.Key, value = u.Value });
            Prop.DataSource = t.ToList();
            Prop.DisplayMember = "key";
            Prop.ValueMember = "value";
            return;
        }
        private void Select_Click(object sender, EventArgs e)
        {
            View_Stu.AutoGenerateColumns = true;
            View_Stu.DataSource = StuDao.Select_Stu(Prop.SelectedValue.ToString(), Val.Text);                    
            return;
        }
        private void Delete_Click(object sender, EventArgs e)
        {
            if (View_Stu.SelectedRows.Count == 1)
            {
                int index = View_Stu.CurrentRow.Index;
            }
            else
            {
                MessageBox.Show("请点击索引，选择一行！");
                return;
            }
            StuDao.Delete_Stu(View_Stu.SelectedRows[0].Cells[0].Value.ToString());
            return;
        }       
    }
}
