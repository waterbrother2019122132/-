using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 英制长度的加法与减法
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入你要进行运算的长度格式(请不要输错格式)如：1英尺9英寸");
            Console.WriteLine("\n第一个英制长度b1：");
            BLength B1 = Console.ReadLine();
            Console.WriteLine("\n第二个英制长度b2：");
            BLength B2 = Console.ReadLine();
            BLength B3 = B1 + B2;
            Console.WriteLine("\n进行加法运算：b1 + b2");
            Console.WriteLine("{0}英尺{1}英寸 + {2}英尺{3}英寸 = {4}英尺{5}英寸",B1.feet,B1.inches,B2.feet,B2.inches,B3.feet,B3.inches);
            BLength B4 = B1 - B2;
            Console.WriteLine("\n进行减法运算：b1 - b2");
            if (B4.inches >= 0)
                Console.WriteLine("{0}英尺{1}英寸 - {2}英尺{3}英寸 = {4}英尺{5}英寸", B1.feet, B1.inches, B2.feet, B2.inches, B4.feet, B4.inches);
            else
                Console.WriteLine("{0}英尺{1}英寸 - {2}英尺{3}英寸 = - {4}英尺{5}英寸", B1.feet, B1.inches, B2.feet, B2.inches, B4.feet, -B4.inches);
            Console.ReadLine();
        }
    }
}
