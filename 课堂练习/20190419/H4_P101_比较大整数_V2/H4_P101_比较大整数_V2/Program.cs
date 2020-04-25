using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H4_P101_比较大整数_V2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num_1 = new int[101];
            int[] num_2 = new int[101];
            int[] answer = new int[101];
            int judge = 0;
            int add = 0;
            int minus = 0;
            int judgement = 1;
            int situation = 0;
            string answer_str = "0";

            // 输入          
            Console.WriteLine("请输入第一个整数：");
            Number big_num_str_1 = new Number(Console.ReadLine());
            if (big_num_str_1.Judgement == 0) Console.WriteLine("数字超出100位或不符合规范，将不进行后续运算！");

            Console.WriteLine("请选择运算方式（输入“+”或“-”，输入后不需要按回车）：");
            char symbol = Console.ReadKey().KeyChar;
            if (symbol != '-' && symbol != '+')
            {
                judgement = 0;
                Console.WriteLine("符号不符合规范，将不进行后续运算！");
            }

            Console.WriteLine("\n请输入第二个整数：");
            Number big_num_str_2 = new Number(Console.ReadLine());
            if (big_num_str_2.Judgement == 0) Console.WriteLine("数字超出100位或不符合规范，将不进行后续运算！");

            if (big_num_str_1.Judgement != 0 && big_num_str_2.Judgement != 0 && judgement != 0)             // 如果输入的数字和符号都符合规范，才运行下面的程序
            {
                // 比较大小
                num_1 = big_num_str_1.Num;
                num_2 = big_num_str_2.Num;
                for (int i = 0; i <= 100; i++)                                                              // 从高位数往低位数判断整数 AB 绝对值大小
                {
                    if (num_1[i] > num_2[i]) { judge = 1; break; }                                          // judge = 1：A 绝对值大于 B
                    else if (num_1[i] < num_2[i]) { judge = 2; break; }                                     // judge = 2：A 绝对值小于 B，如果保持原始值 judge = 0 不变，说明 AB 绝对值相等
                }
                if (big_num_str_1.Judgement > big_num_str_2.Judgement)
                    if (judge == 1) situation = 1;                                                          // 情况 1：A 正 B 负，A 绝对值大于 B
                    else if (judge == 2) situation = 2;                                                     // 情况 2：A 正 B 负，A 绝对值小于 B
                    else situation = 3;                                                                     // 情况 3：A 正 B 负，A 绝对值等于 B

                else if (big_num_str_1.Judgement < big_num_str_2.Judgement)
                    if (judge == 1) situation = 4;                                                          // 情况 4：A 负 B 正，A 绝对值大于 B
                    else if (judge == 2) situation = 5;                                                     // 情况 5：A 负 B 正，A 绝对值小于 B
                    else situation = 6;                                                                     // 情况 6：A 负 B 正，A 绝对值等于 B

                else if (big_num_str_1.Judgement == 1)
                    if (judge == 1) situation = 7;                                                          // 情况 7：AB 均为正，A 绝对值大于 B
                    else if (judge == 2) situation = 8;                                                     // 情况 8：AB 均为正，A 绝对值小于 B
                    else situation = 9;                                                                     // 情况 9：AB 均为正，A 绝对值等于 B

                else
                    if (judge == 1) situation = 10;                                                         // 情况 10：AB 均为负，A 绝对值大于 B
                    else if (judge == 2) situation = 11;                                                    // 情况 11：AB 均为负，A 绝对值小于 B
                    else situation = 12;                                                                    // 情况 12：AB 均为负，A 绝对值等于 B

                if (situation == 1 || situation == 2 || situation == 3 || situation == 7 || situation == 11) Console.WriteLine("\n比较结果：整数一大于整数二");
                else if (situation == 9 || situation == 12) Console.WriteLine("\n比较结果：整数一等于整数二");
                else Console.WriteLine("\n比较结果：整数一小于整数二");

                // 加法运算
                /* 下面列举需要运行绝对值加法运算及结果正负的所有情况：
                 * 输入“+”：情况 7/8/9——正数；
                 * 输入“+”：情况 10/11/12——负数；
                 * 输入“-”：情况 1/2/3——正数；
                 * 输入“-”：情况 4/5/6——负数。*/

                if ((symbol == '+' && situation >= 7 && situation <= 12) || (symbol == '-' && situation >= 1 && situation <= 6))
                {
                    for (int i = 100; i >= 0; i--)
                    {
                        answer[i] = add + num_1[i] + num_2[i];
                        add = 0;
                        if (answer[i] > 9)
                        {
                            answer[i] = answer[i] - 10;
                            add = 1;
                        }
                    }
                    for (int i = 0; i < 101; i++)
                        answer_str = answer_str + answer[i];
                    while (answer_str.IndexOf("0") == 0) answer_str = answer_str.TrimStart('0');
                    if ((situation >= 1 && situation <= 3) || (situation >= 7 && situation <= 9)) Console.WriteLine("运算结果：{0}", answer_str);
                    else Console.WriteLine("运算结果：-{0}", answer_str);
                }

                // 结果为零
                /* 下面列举结果为零的所有情况：
                 * 输入“+”：情况 3/6；
                 * 输入“-”：情况 9/12。*/

                else if ((symbol == '+' && (situation == 3 || situation == 6)) || (symbol == '-' && (situation == 9 || situation == 12)))
                    Console.WriteLine("运算结果：0");

                // 减法运算
                /* 下面列举需要运行绝对值加法运算及结果正负的所有情况：
                 * 输入“+”：情况 1：|A|-|B|，正数；
                 * 输入“+”：情况 2：|B|-|A|，负数；
                 * 输入“+”：情况 4：|A|-|B|，负数；
                 * 输入“+”：情况 5：|B|-|A|，正数；
                 * 输入“-”：情况 7：|A|-|B|，正数；
                 * 输入“-”：情况 8：|B|-|A|，负数；
                 * 输入“-”：情况 10：|A|-|B|，负数；
                 * 输入“-”：情况 11：|B|-|A|，正数。*/

                // |A|-|B| 的情况
                else if (symbol == '+' && (situation == 1 || situation == 4 || situation == 7 || situation == 10))
                {
                    for (int i = 100; i >= 0; i--)
                    {
                        answer[i] = num_1[i] - num_2[i] - minus;
                        minus = 0;
                        if (answer[i] < 0)
                        {
                            answer[i] = answer[i] + 10;
                            minus = 1;
                        }
                    }
                    for (int i = 0; i < 101; i++)
                        answer_str = answer_str + answer[i];
                    while (answer_str.IndexOf("0") == 0) answer_str = answer_str.TrimStart('0');
                    if (situation == 1 || situation == 7) Console.WriteLine("运算结果：{0}", answer_str);
                    else Console.WriteLine("运算结果：-{0}", answer_str);
                }

                // |B|-|A| 的情况
                else
                {
                    for (int i = 100; i >= 0; i--)
                    {
                        answer[i] = num_2[i] - num_1[i] - minus;
                        minus = 0;
                        if (answer[i] < 0)
                        {
                            answer[i] = answer[i] + 10;
                            minus = 1;
                        }
                    }
                    for (int i = 0; i < 101; i++)
                        answer_str = answer_str + answer[i];
                    while (answer_str.IndexOf("0") == 0) answer_str = answer_str.TrimStart('0');
                    if (situation == 5 || situation == 11) Console.WriteLine("运算结果：{0}", answer_str);
                    else Console.WriteLine("运算结果：-{0}", answer_str);
                }
            }
            Console.ReadLine();
        }
    }
}
