using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_4_String数组
{
    class Program
    {
        static void Main(string[] args)
        {
            // 一维数组
            string[] a = new string[2] { "ii", "jj" };  // 定义并赋值数组
            a[0] = "kk";                                // 对 a[0] 重新赋值
            string[] b = a;                             // 将数组 a（的地址）赋给数组 b，此时数组 a、b 均指向同一个地址
            b[0] = "ll";                                // 实质上是更改 b 指向地址的第一个数，b[0] 和 a[0] 均指向同一个数
            for (int i = 0; i < a.Length; i++)          // Length 是一个方法，用以获取数组总共的元素个数
                Console.WriteLine(a[i]);                // 可以观察到：输出的 a[0] 是“ll”

            Console.WriteLine();                        // 空出一行
            
            // 二维数组
            string[,] c = new string[2, 3] {{"mm", "nn", "oo"}, {"pp", "qq", "rr"}};    // 定义并赋值二维数组，2 行 3 列
            for (int i = 0; i < c.GetLength(0); i++)                                    // GetLength 用于获取某一维上的元素个数
                                                                                        // 这里获取的是 0 维，即为“行”数
                for (int j = 0; j < c.GetLength(1); j++)                                // 这里获取的是 1 维，即为“列”数
                    Console.WriteLine(c[i, j]);

            Console.WriteLine();

            // 交错数组
            string[][] d = new string[2][];                 // 定义数组 d，指向两个数组的地址
            d[0] = new string[1] { "ss" };
            d[1] = new string[2] { "tt", "uu" };
            for (int i = 0; i < d.GetLength(0); i++)        // 获取 0 维，即数组个数
                for (int j = 0; j < d[i].Length; j++)       // 获取指向数组的元素个数
                    Console.WriteLine(d[i][j]); 

            Console.ReadLine();
        }
    }
}
