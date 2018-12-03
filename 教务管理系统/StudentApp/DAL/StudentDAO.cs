using StudentApp.PublicClass;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentApp.DAL
{
    class StudentDAO
    {
        public List<Student> Deliver(SqlDataReader reader)
        {
            List<Student> list = new List<Student>();
            while (reader.Read())
            {
                Student stu = new Student();
                stu.Sid = reader["Sid"].ToString();
                if (!(reader["Sname"] is DBNull))
                {
                    stu.Sname = reader["Sname"].ToString();
                }
                if (!(reader["Sex"] is DBNull))
                {
                    stu.Sex = reader["Sex"].ToString();
                }
                if(!(reader["Brithdate"] is DBNull))
                {
                    stu.Brithdate = Convert.ToDateTime(reader["Brithdate"]);
                }
                if(!(reader["Specialty"] is DBNull))
                {
                    stu.Specialty = reader["Specialty"].ToString();
                }
                if(!(reader["AScores"] is DBNull))
                {
                    stu.AScores = Convert.ToDecimal(reader["AScores"]);
                }               
                list.Add(stu);
            }
            return list;
        }
        public List<Student> DisplayTableStu()
        {
            SqlConnection con = DBHelper.Connect();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from student";
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            List<Student> list = Deliver(reader);
            con.Close();
            return list;          
        }
        public int GainSumline()//获取表的总行数
        {
            SqlConnection con = DBHelper.Connect();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();
            cmd.CommandText = "select count(*) from student";
            int sum = (int)cmd.ExecuteScalar();
            con.Close();
            return sum;
        }
        public List<Student> DisplayPage(int LineNum, int i)
        {
            SqlConnection con = DBHelper.Connect();
            SqlCommand cmd = new SqlCommand();
            string Sentence = String.Format("select * from (select ROW_NUMBER() over(order by sid) as RowNo, * from student) as part where RowNo between ({0}*({1}-1)+1) and ({2}*{3})", LineNum, i, LineNum, i);
            cmd.CommandText = Sentence;
            cmd.Connection = con;
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            List<Student> list = Deliver(reader);           
            con.Close();
            return list;
        }
        public void Insert_Stu(Student stu)
        {
            string insert = string.Format("insert into student values('{0}', '{1}', '{2}', '{3}', '{4}', {5})", stu.Sid, stu.Sname, stu.Sex, stu.Brithdate, stu.Specialty, stu.AScores);
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
        public void Delete_Stu(string Id)
        {
            string delete = String.Format("delete student where sid = '{0}'", Id);
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
        public void Updata_Stu(Student stu)
        {
            string update = string.Format("update student set sname = '{0}', sex = '{1}', brithdate = '{2}', specialty = '{3}', ascores = {4} where sid = '{5}'", stu.Sname, stu.Sex, stu.Brithdate, stu.Specialty, stu.AScores, stu.Sid);
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
        public List<Student> Select_Stu(string Prop, string Val)
        {
            string select = "select * from student where " + Prop + " like " + "'%" + Val + "%'";
            SqlConnection con = DBHelper.Connect();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = select;
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            List<Student> list = Deliver(reader);
            con.Close();
            return list;
        }
    }
}

