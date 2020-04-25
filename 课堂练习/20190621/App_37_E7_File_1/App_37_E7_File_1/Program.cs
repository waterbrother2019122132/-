using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;   // 导入命名空间

namespace App_37_E7_File_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // 读取文件并存入 text

            string path = @"D:\in.txt";
            Console.WriteLine("已成功加载文件：D:\\in.txt");
            StreamReader reader;
            reader = new StreamReader(path, System.Text.Encoding.Default);
            int ascii = reader.Read();   // 获得字符的 ASCII 码
            char ch = (char)ascii;   // 转换为字符
            string text = "";
            while (ascii != -1)
            {
                text += ch.ToString();
                ascii = reader.Read();
                ch = (char)ascii;
            }
            reader.Close();
            Console.WriteLine("\n源文件的内容是：\n" + text);

            Console.WriteLine("\n每行整数的最小公倍数计算结果：");
            string numstr = "0";
            int[] num = new int[1000];
            int m = -1;
            int a;
            string outputstr = "";

            foreach (char strch in text)
            {
                if (strch >= '0' && strch <= '9')
                {
                    numstr += strch;
                }
                else if (strch == ' ')
                {
                    m++;
                    num[m] = int.Parse(numstr);
                    numstr = "0";
                }
                else if (strch == '\n')
                {
                    m++;
                    num[m] = int.Parse(numstr);
                    a = 1;
                    for (int i = 0; i < num.Length; i++)
                    {
                        if (num[i] == 0) continue;
                        int t, s, c;
                        if (a < num[i])
                        { t = a; a = num[i]; num[i] = t; }
                        s = a * num[i];
                        c = a % num[i];
                        while (c != 0)
                        { a = num[i]; num[i] = c; c = a % num[i]; }
                        a = s / num[i];
                    }
                    outputstr += a.ToString();
                    outputstr += "\n";

                    // 末尾处理
                    Array.Clear(num, 0, num.Length);   // 清空数组
                    m = -1;
                    numstr = "0";
                }
            }

            m++;
            num[m] = int.Parse(numstr);
            a = 1;
            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] == 0) continue;
                int t, s, c;
                if (a < num[i])
                { t = a; a = num[i]; num[i] = t; }
                s = a * num[i];
                c = a % num[i];
                while (c != 0)
                { a = num[i]; num[i] = c; c = a % num[i]; }
                a = s / num[i];
            }
            outputstr += a.ToString();
            outputstr += "\n";
            Console.WriteLine(outputstr);

            path = @"D:\out.txt";
            StreamWriter writer = new StreamWriter(path, false, System.Text.Encoding.Default);
            writer.Write(outputstr);
            writer.Close();

            Console.WriteLine("程序已执行完成，已将结果导出至：D:\\out.txt\n\n请按任意键退出");
            Console.Read();
        }
    }
}
