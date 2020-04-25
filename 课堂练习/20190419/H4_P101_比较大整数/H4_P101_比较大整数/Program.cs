using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H4_P101_比较大整数
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num_1, num_2, answer; num_1 = num_2 = answer = new int[101];
            int judge, add, minus, situation; judge = add = minus = situation = 0;
            int judgement = 1; string answer_str = "0";       
            Console.WriteLine("请输入第一个整数："); Number big_num_str_1 = new Number(Console.ReadLine());
            if (big_num_str_1.Judgement == 0) Console.WriteLine("数字超出100位或不符合规范，将不进行后续运算！");
            Console.WriteLine("请选择运算方式（输入“+”或“-”，输入后不需要按回车）："); char symbol = Console.ReadKey().KeyChar;
            if (symbol != '-' && symbol != '+') { judgement = 0; Console.WriteLine("符号不符合规范，将不进行后续运算！"); }
            Console.WriteLine("\n请输入第二个整数：");
            Number big_num_str_2 = new Number(Console.ReadLine());
            if (big_num_str_2.Judgement == 0) Console.WriteLine("数字超出100位或不符合规范，将不进行后续运算！");
            if (big_num_str_1.Judgement != 0 && big_num_str_2.Judgement != 0 && judgement != 0)
            {   num_1 = big_num_str_1.Num; num_2 = big_num_str_2.Num;
                for (int i = 0; i <= 100; i++)
                {   if (num_1[i] > num_2[i]) { judge = 1; break; }
                    else if (num_1[i] < num_2[i]) { judge = 2; break; } }
                if (big_num_str_1.Judgement > big_num_str_2.Judgement)
                    if (judge == 1) situation = 1; else if (judge == 2) situation = 2; else situation = 3;
                else if (big_num_str_1.Judgement < big_num_str_2.Judgement)
                    if (judge == 1) situation = 4; else if (judge == 2) situation = 5; else situation = 6;
                else if (big_num_str_1.Judgement == 1)
                    if (judge == 1) situation = 7; else if (judge == 2) situation = 8; else situation = 9;
                else
                    if (judge == 1) situation = 10; else if (judge == 2) situation = 11; else situation = 12;
                if (situation == 1 || situation == 2 || situation == 3 || situation == 7 || situation == 11) Console.WriteLine("\n比较结果：整数一大于整数二");
                else if (situation == 9 || situation == 12) Console.WriteLine("\n比较结果：整数一等于整数二");
                else Console.WriteLine("\n比较结果：整数一小于整数二");
                if ((symbol == '+' && situation >= 7 && situation <= 12) || (symbol == '-' && situation >= 1 && situation <= 6))
                {   for (int i = 100; i >= 0; i--)
                    {   answer[i] = add + num_1[i] + num_2[i]; add = 0;
                        if(answer[i] > 9) { answer[i] = answer[i] - 10; add = 1; } }
                    for (int i = 0; i < 101; i++) answer_str = answer_str + answer[i];
                    while (answer_str.IndexOf("0") == 0) answer_str = answer_str.TrimStart('0');
                    if ((situation >= 1 && situation <= 3) || (situation >= 7 && situation <= 9)) Console.WriteLine("运算结果：{0}", answer_str);
                    else Console.WriteLine("运算结果：-{0}", answer_str); }
                else if ((symbol == '+' && (situation == 3 || situation == 6)) || (symbol == '-' && (situation == 9 || situation == 12))) Console.WriteLine("运算结果：0");
                else if(symbol == '+' && (situation == 1 || situation == 4 || situation == 7 || situation == 10))
                {   for (int i = 100; i >= 0; i--)
                    {   answer[i] = num_1[i] - num_2[i] - minus; minus = 0;
                        if (answer[i] < 0) { answer[i] = answer[i] + 10; minus = 1; } }
                    for (int i = 0; i < 101; i++) answer_str = answer_str + answer[i];
                    while (answer_str.IndexOf("0") == 0) answer_str = answer_str.TrimStart('0');
                    if (situation == 1 || situation == 7) Console.WriteLine("运算结果：{0}", answer_str);
                    else Console.WriteLine("运算结果：-{0}", answer_str); }
                else
                {   for (int i = 100; i >= 0; i--)
                    {   answer[i] = num_2[i] - num_1[i] - minus; minus = 0;
                        if (answer[i] < 0) { answer[i] = answer[i] + 10; minus = 1; } }
                    for (int i = 0; i < 101; i++) answer_str = answer_str + answer[i];
                    while (answer_str.IndexOf("0") == 0) answer_str = answer_str.TrimStart('0');
                    if (situation == 5 || situation == 11) Console.WriteLine("运算结果：{0}", answer_str);
                    else Console.WriteLine("运算结果：-{0}", answer_str); } }
            Console.ReadLine();
        }
    }
}
