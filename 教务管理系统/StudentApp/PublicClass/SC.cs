using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp.PublicClass
{
    class SC
    {
        private string sid;
        private string cid;
        private decimal scores;

        public string Sid { get => sid; set => sid = value; }
        public string Cid { get => cid; set => cid = value; }
        public decimal Scores { get => scores; set => scores = value; }
    }
}
