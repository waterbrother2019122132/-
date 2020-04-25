using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_9_EG_3_11_判断素数
{
    class Program
    {
        static void Main(string[] args)
        {
            // 声明变量
            string putOut;
            int i;

            // 输入整数
            Console.Write("请输入一个整数 n = ");
            int n = int.Parse(Console.ReadLine());
            
            // 判断素数，从“2”到“根号n”检查是否能整除
            for (i = (int)System.Math.Sqrt(n); i > 1; i--)  // 计算根号 n 的值
                if (n % i == 0) break;

            // 输出结果
            if (i == 1) putOut = "整数 " + n.ToString() + " 是素数！";
            else putOut = "整数 " + n.ToString() + " 不是素数！";
            Console.Write(putOut);

            Console.ReadLine();
        }
    }
}
