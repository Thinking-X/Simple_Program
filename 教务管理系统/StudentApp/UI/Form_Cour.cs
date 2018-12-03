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

namespace StudentApp.UI
{
    public partial class Form_Cour : Form
    {
        public Form_Cour()
        {
            InitializeComponent();
        }
        int i;//表示第几页
        int count;//表示所查询的表一共几行
        private void Form_Cour_Load(object sender, EventArgs e)
        {
            UpPage.Enabled = false;
            DownPage.Enabled = false;
        }
        CourseDAO CourDao = new CourseDAO();
        private void View_Cour_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
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
            View_Cour.AutoGenerateColumns = true;
            View_Cour.DataSource = CourDao.DisplayTableCour();
            count = CourDao.GainSumline();
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
                View_Cour.AutoGenerateColumns = true;
                View_Cour.DataSource = CourDao.DisplayPage(num, i);
                UpPage.Enabled = false;
                DownPage.Enabled = true;
                count = CourDao.GainSumline();
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
            View_Cour.AutoGenerateColumns = true;
            View_Cour.DataSource = CourDao.DisplayPage(num, i);
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
            View_Cour.AutoGenerateColumns = true;
            View_Cour.DataSource = CourDao.DisplayPage(num, i);
            UpPage.Enabled = true;
            return;
        }
        private void Insert_Click(object sender, EventArgs e)
        {
            Course cour = new Course();
            cour.No = Convert.ToInt32(No.Text);
            cour.Cid = Cid.Text;
            cour.Cname = Cname.Text;
            cour.Credit = Convert.ToDecimal(Credit.Text);
            if (Insert.Text.Equals("添加"))
            {
                CourDao.Insert_Cour(cour);

            }
            else
            {
                CourDao.Updata_Cour(cour);
                Cid.ReadOnly = false;
                Insert.Text = "添加";
            }
            return;
        }
        private void Update_Click(object sender, EventArgs e)
        {
            if (View_Cour.SelectedRows.Count == 1)
            {
                int index = View_Cour.CurrentRow.Index;
            }
            else
            {
                MessageBox.Show("请点击索引，选择一行！");
                return;
            }
            Insert.Text = "确认更改";
            MessageBox.Show("请在右侧更改！");
            No.Text = View_Cour.SelectedRows[0].Cells[0].Value.ToString();
            Cid.Text = View_Cour.SelectedRows[0].Cells[1].Value.ToString();
            Cname.Text = View_Cour.SelectedRows[0].Cells[2].Value.ToString();
            Credit.Text = View_Cour.SelectedRows[0].Cells[3].Value.ToString();
            Cid.ReadOnly = true;
            return;
        }
        private void Prop_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> Dic = new Dictionary<string, string>();
            Dic.Add("编号", "No");
            Dic.Add("课程号", "Cid");
            Dic.Add("课程名", "Cname");
            Dic.Add("学分", "Credit");
            var t = Dic.Select(u => new { key = u.Key, value = u.Value });
            Prop.DataSource = t.ToList();
            Prop.DisplayMember = "key";
            Prop.ValueMember = "value";
            return;
        }
        private void Select_Click(object sender, EventArgs e)
        {
            View_Cour.AutoGenerateColumns = true;
            View_Cour.DataSource = CourDao.Select_Cour(Prop.SelectedValue.ToString(), Val.Text);
            return;
        }
        private void Delete_Click(object sender, EventArgs e)
        {
            if (View_Cour.SelectedRows.Count == 1)
            {
                int index = View_Cour.CurrentRow.Index;
            }
            else
            {
                MessageBox.Show("请点击索引，选择一行！");
                return;
            }
            CourDao.Delete_Cour(View_Cour.SelectedRows[0].Cells[0].Value.ToString());
            return;
        }       
    }
}
