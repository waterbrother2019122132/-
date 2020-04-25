using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_3_华氏度转摄氏度
{
    class Program
    {
        static void Main(string[] args)
        {
            float c, f; // 数据类型（float, string），变量（c, f, s）
            string s;
            s = Console.ReadLine(); // 从键盘输入。“ReadLine”是系统函数，从键盘读取数据。
            f = float.Parse(s); // 数据类型的转换。“Parse”是一个方法，实现数值类型转换。
            c = 5 * (f - 32) / 9;
            Console.WriteLine("华氏{0}度=摄氏{1}度", s, c.ToString()); //“c”要转成String类型以输出。
            Console.ReadLine();
        }
    }
}
