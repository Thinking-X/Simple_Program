using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace booksystem
{
    class reader
    {
        public string Name;
        public string Sid;
        private static int Max=3;
        public int Count = 0;
        public void Information()
        {
            Console.WriteLine("注:一位读者限借3本");
            Console.WriteLine();
        }
        public int Remain()
        {
            Max = Max - Count;
            Console.WriteLine("您还能借{0}本",Max);
            Console.WriteLine();
            return Max;
        }
        public int Remain1()
        {
            Max = Max + Count;
            Console.WriteLine("您还能借{0}本", Max);
            Console.WriteLine();
            return Max;
        }
    }
}
