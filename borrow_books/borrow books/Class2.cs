using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace booksystem
{
    class book
    {
        private string Number="0001";
        private string Name="红楼梦";
        private string Author="曹雪芹";
        private static int Amount = 10;
        public  int Count=0;
        public void Information()
        {
            Console.WriteLine("图书信息");
            Console.WriteLine("图书编号："+Number);
            Console.WriteLine("图书名："+Name);
            Console.WriteLine("作者："+Author);
            Console.WriteLine("原有数量：" + Amount);
            Console.WriteLine();
        }
        public void Borrow()
        {
            Amount = Amount - Count;
            Console.WriteLine("借书成功，该图书现在还有{0}本", Amount);
        }
        public void Back()
        {
            Amount = Amount + Count;
            Console.WriteLine("还书成功，该图书现在还有{0}本", Amount);
        }
    }
}
