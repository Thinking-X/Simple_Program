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
    public partial class Form_SC : Form
    {
        public Form_SC()
        {
            InitializeComponent();
        }
        private void Form_SC_Load(object sender, EventArgs e)
        {
            UpPage.Enabled = false;
            DownPage.Enabled = false;
        }
        int i;//表示第几页
        int count;//表示所查询的表一共几行
        SCDAO scDao = new SCDAO();

        private void View_SC_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
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
            View_SC.AutoGenerateColumns = true;
            View_SC.DataSource = scDao.DisplayTableSc();
            count = scDao.GainSumline();
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
                View_SC.AutoGenerateColumns = true;
                View_SC.DataSource = scDao.DisplayPage(num, i);
                UpPage.Enabled = false;
                DownPage.Enabled = true;
                count = scDao.GainSumline();
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
            View_SC.AutoGenerateColumns = true;
            View_SC.DataSource = scDao.DisplayPage(num, i);
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
            View_SC.AutoGenerateColumns = true;
            View_SC.DataSource = scDao.DisplayPage(num, i);
            UpPage.Enabled = true;
            return;
        }
        private void Insert_Click(object sender, EventArgs e)
        {
            SC sc = new SC();
            sc.Sid = Sid.Text;
            sc.Cid = Cid.Text;
            sc.Scores = Convert.ToDecimal(Scores.Text);
            if (Insert.Text.Equals("添加"))
            {
                scDao.Insert_SC(sc);
            }
            else
            {
                scDao.Updata_SC(sc);
                Sid.ReadOnly = false;
                Cid.ReadOnly = false;
                Insert.Text = "添加";
            }
            return;
        }
        private void Update_Click(object sender, EventArgs e)
        {
            if (View_SC.SelectedRows.Count == 1)
            {
                int index = View_SC.CurrentRow.Index;
            }
            else
            {
                MessageBox.Show("请点击索引，选择一行！");
                return;
            }
            Insert.Text = "确认更改";
            MessageBox.Show("请在右侧更改！");
            Sid.Text = View_SC.SelectedRows[0].Cells[0].Value.ToString();
            Cid.Text = View_SC.SelectedRows[0].Cells[1].Value.ToString();
            Scores.Text = View_SC.SelectedRows[0].Cells[2].Value.ToString();
            Sid.ReadOnly = true;
            Cid.ReadOnly = true;
            return;
        }       
        private void Prop_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> Dic = new Dictionary<string, string>();
            Dic.Add("学号", "No");
            Dic.Add("课程号", "Cid");
            Dic.Add("分数", "Scores");
            var t = Dic.Select(u => new { key = u.Key, value = u.Value });
            Prop.DataSource = t.ToList();
            Prop.DisplayMember = "key";
            Prop.ValueMember = "value";
            return;
        }
        private void Select_Click(object sender, EventArgs e)
        {
            View_SC.AutoGenerateColumns = true;
            View_SC.DataSource = scDao.Select_SC(Prop.SelectedValue.ToString(), Val.Text);
            return;
        }
        private void Delete_Click(object sender, EventArgs e)
        {
            if (View_SC.SelectedRows.Count == 1)
            {
                int index = View_SC.CurrentRow.Index;
            }
            else
            {
                MessageBox.Show("请点击索引，选择一行！");
                return;
            }
            scDao.Delete_SC(View_SC.SelectedRows[0].Cells[0].Value.ToString(), View_SC.SelectedRows[0].Cells[1].Value.ToString());
            return;
        }       
    }
}
