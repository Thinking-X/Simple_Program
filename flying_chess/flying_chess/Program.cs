using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace flying_chess
{
    class Program
    {
        static void Main(string[] args)
        {
            Game_name G = new Game_name();
            G.Name();
            Set_player S = new Set_player();
            S.Input1();
            S.Input2();
            Console.Clear();
            G.Name();
            S.Show();
            Console.WriteLine("图例：幸运轮盘◎   地雷★   暂停▲   时空隧道 卍");
            int[] Map = new int[102];
            Chessboard(Map,100,'0',101,'0');
            Throw T = new Throw();
            int p1 = 0, p2 = 0, j, sign1 = 0, sign2 = 0 ;           
                                  
            while(p1 < 99 && p2 < 99)
            {               
                if (sign1 == 0)
                {
                    Console.WriteLine("玩家{0}按任意键开始掷骰子", S.player1);
                    Console.ReadKey(true);
                    j = T.Step();
                    Console.WriteLine("玩家{0}掷出了{1},玩家{0}走{1}步", S.player1, j, S.player1, j);
                    for (; ; )
                    {
                        p1 = p1 + j;
                        if (p1 > 99)
                        {
                            break;
                        }
                        if(p1 == p2)
                        {
                            Console.WriteLine("玩家{0}踩到了玩家{1}，玩家{2}退六步", S.player1, S.player2, S.player1);
                            if (p1 > 6)
                            {
                                p1 = p1 - 6;
                            }
                            else
                            {
                                p1 = 0;
                            }
                            break;
                        }
                        if (Map[p1] == '□')
                        {
                            break;
                        }
                        else if (Map[p1] == '◎')
                        {
                            Console.WriteLine("踩到幸运轮盘，按‘1’交换位置，按‘2’使对方后退六步,选择之后按两次‘Enter’确定");
                            int Choice;
                            for (; ; )
                            {
                                bool x = int.TryParse(Console.ReadLine(), out Choice);
                                if (x == false)
                                {
                                    Console.WriteLine("输入格式不正确,请重新输入");
                                    continue;
                                }                          
                                if (Choice == 1)
                                {
                                    p1 = p1 + p2;
                                    p2 = p1 - p2;
                                    p1 = p1 - p2;
                                    break;
                                }
                                else if (Choice == 2)
                                {
                                    if (p2 > 6)
                                    {
                                        p2 = p2 - 6;
                                    }                              
                                    else
                                    {
                                        p2 = 0;
                                    }
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("输入格式不正确,请重新输入");
                                    continue;
                                }
                            }
                        }
                        else if (Map[p1] == '★')
                        {
                            Console.WriteLine("踩到地雷，后退六步");
                            if (p1 > 6)
                            {
                                p1 = p1 - 6;
                            }
                            else
                            {
                                p1 = 0;
                            }
                            break;
                        }
                        else if (Map[p1] == '▲')
                        {
                            Console.WriteLine("踩到暂停，玩家{0}暂停一次",S.player1);
                            sign1 = -2;
                            break;
                        }
                        else if (Map[p1] == '卍')
                        {
                            Console.WriteLine("踩到时空隧道，前进十步");
                            p1 = p1 + 10;
                            continue;
                        }
                    }
                }

                if (sign2 == 0)
                {
                    Console.WriteLine("玩家{0}按任意键开始掷骰子", S.player2);
                    Console.ReadKey(true);
                    j = T.Step();
                    Console.WriteLine("玩家{0}掷出了{1},玩家{2}走{3}步", S.player2, j, S.player2, j);                   
                    for (; ; )
                    {
                        p2 = p2 + j;
                        if (p2 > 99)
                        {
                            break;
                        }
                        if (p1 == p2)
                        {
                            Console.WriteLine("玩家{0}踩到了玩家{1}，玩家{2}退六步",S.player2 ,S.player1 ,S.player2);
                            if (p2 > 6)
                            {
                                p2 = p2 - 6;
                            }
                            else
                            {
                                p2 = 0;
                            }
                            break;
                        }
                        if (Map[p2] == '□')
                        {
                            break;
                        }
                        else if (Map[p2] == '◎')
                        {
                            Console.WriteLine("踩到幸运轮盘，按‘1’交换位置，按‘2’使对方后退六步,选择之后按两次‘Enter’确定");
                            int Choice;
                            for (; ; )
                            {
                                bool x = int.TryParse(Console.ReadLine(), out Choice);
                                if (x == false)
                                {
                                    Console.WriteLine("输入格式不正确,请重新输入");
                                    continue;
                                }                         
                                if (Choice == 1)
                                {
                                    p2 = p2 + p1;
                                    p1 = p2 - p1;
                                    p2 = p2 - p1;
                                    break;
                                }
                                else if (Choice == 2)
                                {
                                    if (p1 > 6)
                                    {
                                        p1 = p1 - 6;
                                    }
                                    else
                                    {
                                        p1 = 0;
                                    }
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("输入格式不正确,请重新输入");
                                    continue;
                                }
                            }
                        }
                        else if (Map[p2] == '★')
                        {
                            Console.WriteLine("踩到地雷，后退六步");
                            if (p2 > 6)
                            {
                                p2 = p2 - 6;
                            }
                            else
                            {
                                p2 = 0;
                            }
                            break;
                        }
                        else if (Map[p2] == '▲')
                        {
                            Console.WriteLine("踩到暂停，玩家{0}暂停一次",S.player2);
                            sign2 = -2;
                            break;
                        }
                        else if (Map[p2] == '卍')
                        {
                            Console.WriteLine("踩到时空隧道，前进十步");
                            p2 = p2 + 10;
                            continue;
                        }
                    }                   
                }
                Console.ReadKey(true);
                if (p1 <= 99 && p2 <= 99)
                {                   
                    Console.Clear();
                    Console.WriteLine("图例：幸运轮盘◎   地雷★   暂停▲   时空隧道 卍");                   
                    Chessboard(Map, p1, 'Ａ', p2, 'Ｂ');
                    ChessboardInitialize(Map);
                }               

                if (sign1 != 0)
                {
                    sign1++;
                }
                if (sign2 != 0)
                {
                    sign2++;
                }
            }

            if(p1 > 99)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("玩家{0}获胜", S.player1);
                Console.ReadKey(true);
                return;
            }

            if (p2 > 99)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("玩家{0}获胜", S.player2);
                Console.ReadKey(true);
                return;
            }           
        }
        public static void Chessboard(int[] Map,int n1,char t1,int n2,char t2)
        {
            int[] luckyturn = { 6, 23, 40, 55, 69, 83 };
            int[] landmine = { 5, 13, 17, 33, 38, 50, 64, 80, 94 };
            int[] pause = { 9, 27, 60, 93 };
            int[] timeTunnel = { 20, 25, 45, 63, 72, 88, 90 };
            int i;
            for (i = 0; i < luckyturn.Length; i++)
            {
                Map[luckyturn[i]] = '◎';
            }
            for (i = 0; i < landmine.Length; i++)
            {
                Map[landmine[i]] = '★';
            }
            for (i = 0; i < pause.Length; i++)
            {
                Map[pause[i]] = '▲';
            }
            for (i = 0; i < timeTunnel.Length; i++)
            {
                Map[timeTunnel[i]] = '卍';
            }
            Map[0] = '→';
            for (i = 1; i < 100; i++)
            {
                if (Map[i] == 0)
                {
                    Map[i] = '□';
                }
            }
            Map[n1] = t1;
            Map[n2] = t2;

            for (i = 0; i < 30; i++)
            {
                Console.Write(Convert.ToChar(Map[i]));
            }
            Console.WriteLine();
            int j = 30;
            for (i = 0; i < 150; i++)
            {
                if (i == 29 || i == 59 || i == 89 || i == 119 || i == 149)
                {
                    Console.WriteLine(Convert.ToChar(Map[j]));
                    j++;
                }
                else
                {
                    Console.Write("  ");
                }
            }
            for (i = 64; i > 34; i--)
            {
                Console.Write(Convert.ToChar(Map[i]));
            }
            Console.WriteLine();
            for (i = 65; i < 70; i++)
            {
                Console.WriteLine(Convert.ToChar(Map[i]));
            }
            for (i = 70; i < 100; i++)
            {
                Console.Write(Convert.ToChar(Map[i]));
            }
            Console.WriteLine();
        }
        public static void ChessboardInitialize(int[] Map)
        {
            int[] luckyturn = { 6, 23, 40, 55, 69, 83 };
            int[] landmine = { 5, 13, 17, 33, 38, 50, 64, 80, 94 };
            int[] pause = { 9, 27, 60, 93 };
            int[] timeTunnel = { 20, 25, 45, 63, 72, 88, 90 };
            int i;
            for (i = 0; i < luckyturn.Length; i++)
            {
                Map[luckyturn[i]] = '◎';
            }
            for (i = 0; i < landmine.Length; i++)
            {
                Map[landmine[i]] = '★';
            }
            for (i = 0; i < pause.Length; i++)
            {
                Map[pause[i]] = '▲';
            }
            for (i = 0; i < timeTunnel.Length; i++)
            {
                Map[timeTunnel[i]] = '卍';
            }
            Map[0] = '→';
            for (i = 1; i < 100; i++)
            {
                char c = Convert.ToChar(Map[i]);
                if (( c != '◎' ) && ( c != '★' ) && ( c != '▲' ) && ( c != '卍'))
                {
                    Map[i] = '□';
                }
            }
        }
    }
}
