using StudentApp.PublicClass;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentApp.DAL
{
    class SCDAO
    {
        public List<SC> Deliver(SqlDataReader reader)
        {
            List<SC> list = new List<SC>();
            while (reader.Read())
            {
                SC sc = new SC();
                sc.Sid = reader["Sid"].ToString();
                sc.Cid = reader["Cid"].ToString();
                if(!(reader["Scores"] is DBNull))
                {
                    sc.Scores = Convert.ToDecimal(reader["Scores"]);
                }               
                list.Add(sc);
            }
            return list;
        }
        public List<SC> DisplayTableSc()
        {
            SqlConnection con = DBHelper.Connect();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from sc";
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            List<SC> list = Deliver(reader);
            con.Close();
            return list;
        }
        public int GainSumline()//获取表的总行数
        {
            SqlConnection con = DBHelper.Connect();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();
            cmd.CommandText = "select count(*) from sc";
            int sum = (int)cmd.ExecuteScalar();
            con.Close();
            return sum;
        }
        public List<SC> DisplayPage(int LineNum, int i)
        {
            SqlConnection con = DBHelper.Connect();
            SqlCommand cmd = new SqlCommand();
            string Sentence = String.Format("select * from (select ROW_NUMBER() over(order by sid) as RowNo, * from sc) as part where RowNo between ({0}*({1}-1)+1) and ({2}*{3})", LineNum, i, LineNum, i);
            cmd.CommandText = Sentence;
            cmd.Connection = con;
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            List<SC> list = Deliver(reader);
            con.Close();
            return list;
        }
        public void Insert_SC(SC sc)
        {
            string insert = string.Format("insert into SC values ({0}, '{1}', {2})", sc.Sid, sc.Cid, sc.Scores);
            SqlConnection con = DBHelper.Connect();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = insert;
            con.Open();
            try
            {
                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("成功插入一行记录！");
                }
                else
                {
                    MessageBox.Show("插入失败！");
                }
            }
            catch
            {
                MessageBox.Show("执行出错，插入失败！");
            }
            con.Close();
            return;
        }
        public void Delete_SC(string sid,string cid)
        {
            string delete = String.Format("delete sc where sid = '{0}' and  cid='{1}'", sid, cid);
            SqlConnection con = DBHelper.Connect();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = delete;
            con.Open();
            try
            {
                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("成功删除一行记录！");
                }
                else
                {
                    MessageBox.Show("删除失败！");
                }
            }
            catch
            {
                MessageBox.Show("执行出错，删除失败！");
            }
            con.Close();
            return;
        }
        public void Updata_SC(SC sc)
        {
            string update = string.Format("update sc set scores = '{0}'  where sid = '{1}' and cid = '{2}'", sc.Scores, sc.Sid, sc.Cid);
            SqlConnection con = DBHelper.Connect();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = update;
            con.Open();
            try
            {
                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("成功更改一行记录！");
                }
                else
                {
                    MessageBox.Show("未做更改！");
                }
            }
            catch
            {
                MessageBox.Show("执行出错，更改失败！");
            }
            con.Close();
            return;
        }
        public List<SC> Select_SC(string Prop, string Val)
        {
            string select = "select * from sc where " + Prop + " like " + "'%" + Val + "%'";
            SqlConnection con = DBHelper.Connect();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = select;
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            List<SC> list = Deliver(reader);
            con.Close();
            return list;
        }
    }
}
