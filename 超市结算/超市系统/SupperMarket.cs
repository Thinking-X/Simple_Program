using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 超市系统
{
    class SupperMarket
    {
        Changku ck = new Changku();
        public SupperMarket()
        {
            ck.JinHuo("Acer",1000);
            ck.JinHuo("Samsung",1000);
            ck.JinHuo("banana",1000);
            ck.JinHuo("Jiangyou",1000);
            ck.Show();
        }
        public void AskBuying()
        {
            List<string> g = new List<string>();
            ProductFather[] pros;
            double amount = 0;
            int i = 0;
            while(true)
            {
                int count;
                string choose;
                Console.WriteLine("输入要买的商品：");
                string strType = Console.ReadLine();
                Console.WriteLine("购买数量：");
                bool x = int.TryParse(Console.ReadLine(), out count);
                if (x == false)
                {
                    Console.WriteLine("输入格式不正确");
                    continue;
                }               
                pros = ck.QvHuo(strType, count);               
                amount += Total(pros);               
                    g.Add("商品名：" + pros[i].Name + "商品编号：" + pros[i].ID);                              
                i++;
                f1: Console.WriteLine("是否需要继续购买：\n按1 - 继续\n按2 - 结束");
                choose = Console.ReadLine();
                if (choose == "1")
                {
                    continue;
                }
                else if (choose == "2")
                {
                    break;
                } 
                else if (choose == null || (choose.Trim(' ')) == "")
                {
                    Console.WriteLine("输入不可为空，请重新输入");
                    goto f1;
                }
                else
                {
                    Console.WriteLine("请输入正确指令");
                    goto f1;
                }               
            }           
            Console.WriteLine("你应付{0}元钱", discount(amount));
            receipt(g,i);
            Console.WriteLine();
        }
        public void receipt(List<string> g,int n)
        {
            Console.WriteLine("收据：");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(g[i]);
            }
        }
        public double Total(ProductFather [] pros)
        {
            double money = 0;
            for(int i = 0; i < pros.Length; i++)
            {
                money += pros[i].Price;
            }
            return money;
        }
        public double discount(double money)
        {
            while(true)
            {
                Console.WriteLine("输入选择的折扣方式：\n按‘1’ - 打折95折\n" +
                "按‘2’ - 满200减50\n按‘3’ - 满500减150\n按其他键不打折");
                string choose = Console.ReadLine();
                if (choose == null || choose.Trim(' ') == "")
                {
                    Console.WriteLine("输入不可为空,请重新输入");
                    continue;
                }
                switch (choose)
                {
                    case "1": money = money * 0.95;
                        break;
                    case "2":
                        if (money > 200)
                        {
                            money = money - (money / 200) * 50;
                        }
                        else
                        {
                            Console.WriteLine("您购物未满200元");
                        }
                        break;
                    case "3":
                        if (money > 500)
                        {
                            money = money - (money / 500) * 150;
                        }
                        else
                        {
                            Console.WriteLine("您购物未满500元");
                        }
                        break;
                    default:
                        Console.WriteLine("您选择不打折");
                        break;                   
                }
                break;
            }           
            return money;
        }
    }
}
