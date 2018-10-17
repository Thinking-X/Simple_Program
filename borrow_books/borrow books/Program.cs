using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace booksystem
{
    class Program
    {
        static void Main(string[] args)
        {
            int Count1 = 0;//读者借书数量
            int Count2 = 3;//读者剩余借书数量
            int Count3 = 0;//读者还书数量
            int Count = 0;//累加借书量
            string Choice ;
            reader R = new reader();
            book B = new book();
            B.Information();
            R.Information();          
            for ( ; ; )
            { 
                Console.WriteLine("按‘1’借书，按‘2’还书，按‘3’退出，之后按‘Enter’确定");
                Choice = Console.ReadLine();
                Console.WriteLine();              
                if (Choice == "1")
                {
                    if(Count2 > 0)
                    {               
                        Console.Write("输入要借数量，按‘Enter’确定：");
                        //Count1 = Convert.ToInt32(Console.ReadLine());
                        bool x = int.TryParse(Console.ReadLine(), out Count1);
                        if (x == false)
                        {
                            Console.WriteLine("输入格式不正确");
                            Console.WriteLine();
                            continue;
                        }
                        if (Count1 > 0 && Count1 < 4 && Count1 <= Count2)
                        {
                            B.Count = R.Count = Count1;
                            Count = Count + Count1;
                            B.Borrow();                   
                            Count2 = R.Remain();                      
                        }
                        else
                        {
                            Console.WriteLine("输入不符合要求,请重新输入");
                            Console.WriteLine();
                        }
                    }
                    else
                    {
                        Console.WriteLine("输入不符合要求,请重新输入");
                        Console.WriteLine();
                    }
                }
            
                else if (Choice=="2")
                {
                    if (Count2 >= 3)
                    {
                        Console.WriteLine("您没有需要还的书");
                        Console.WriteLine();
                        continue;
                    }
                    else
                    {                       
                        Console.Write("输入要还数量，按‘Enter’确定：");
                        //Count3 = Convert.ToInt32(Console.ReadLine());
                        bool x = int.TryParse(Console.ReadLine(), out Count3);
                        if (x == false)
                        {
                            Console.WriteLine("输入格式不正确");
                            Console.WriteLine();
                            continue;
                        }
                        if (Count3 > 0 && Count3 < 4 && Count3 <= Count)
                        {
                            R.Count = B.Count = Count3;
                            B.Back();
                            Count2 = R.Remain1();
                        }
                        else
                        {
                            Console.WriteLine("输入不符合要求,请重新输入");
                            Console.WriteLine();
                        }                      
                    }
                }

                else if(Choice=="3")
                {
                   return ;
                }

                else
                {
                    Console.WriteLine("输入命令有误,请重新输入");
                    Console.WriteLine();
                }
            }           
        }
    }
}
