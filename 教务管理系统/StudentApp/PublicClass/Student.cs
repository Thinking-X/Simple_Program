using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp.PublicClass
{
    class Student
    {
        private string sid;
        private string sname;
        private string sex;
        private DateTime brithdate;
        private string specialty;
        private Decimal aScores;

        public string Sid { get => sid; set => sid = value; }
        public string Sname { get => sname; set => sname = value; }
        public string Sex { get => sex; set => sex = value; }
        public string Specialty { get => specialty; set => specialty = value; }
        public Decimal AScores { get => aScores; set => aScores = value; }
        public DateTime Brithdate { get => brithdate; set => brithdate = value; }
    }
}
