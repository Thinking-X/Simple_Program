using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp.PublicClass
{
    class Course
    {
        private int no;
        private string cid;
        private string cname;
        private decimal credit;

        public int No { get => no; set => no = value; }
        public string Cid { get => cid; set => cid = value; }
        public string Cname { get => cname; set => cname = value; }
        public decimal Credit { get => credit; set => credit = value; }
    }
}
