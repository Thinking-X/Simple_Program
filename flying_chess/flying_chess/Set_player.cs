using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace flying_chess
{
    class Set_player
    {
        public string player1;
        public string player2;
        public void Input1()
        {
            Console.WriteLine("请输入玩家1的名字");
            for (; ; )
            {
                player1 = Console.ReadLine();
                if (player1 == null || (player1.Trim(' ')) == "")
                {
                    Console.WriteLine("输入不能为空，请重新输入玩家1名字");
                    continue;
                }
                else
                {
                    break;
                }
            }
        }
        public void Input2()
        {
            Console.WriteLine("请输入玩家2的名字");
            for (; ; )
            {
                player2 = Console.ReadLine();
                if(player1 == player2)
                {
                    Console.WriteLine("不能与玩家1名字相同，请重新输入");
                    continue;
                }
                if (player2 == null || (player2.Trim(' ')) == "")
                {
                    Console.WriteLine("输入不能为空，请重新输入玩家1名字");
                    continue;
                }
                else
                {
                    break;
                }
            }
        }
        public void Show()
        {
            Console.WriteLine("玩家{0}的棋子用Ａ表示", player1);
            Console.WriteLine("玩家{0}的棋子用Ｂ表示", player2);
        }
    }
}
