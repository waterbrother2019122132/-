using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_27_第五章入门
{
    class Program
    {
        static void Main(string[] args)
        {
            try   // 为了避免用户输入的数据无法完成程序运行而出现异常，将可能出现异常的内容使用 try 框起来
            {
                string str = Console.ReadLine();
                int n = int.Parse(str);
                double m = Math.Pow(n, 2);
                Console.WriteLine("n = {0}\t m = {1}", n, m);
            }
            catch (Exception e)   // try 和 catch 是一套组合语句，当 try 中出现异常，执行 catch
            {
                Console.WriteLine("出错！");
            }
 
            Console.Read();
        }
    }
}
