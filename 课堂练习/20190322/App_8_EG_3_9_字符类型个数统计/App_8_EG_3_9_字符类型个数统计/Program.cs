using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_8_EG_3_9_字符类型个数统计
{
    class Program
    {
        static void Main(string[] args)
        {
            // 声明个数累加器变量
            int nUpper, nLower, nNumber, nOther;
            nUpper = nLower = nNumber = nOther = 0;
            
            // 输入字符串
            Console.WriteLine("请输入一行字符，以统计字符类型数目：");
            string line = Console.ReadLine();

            // 将“line”字符串转换为名称为“chars”的字符数组 
            char[] chars = line.ToCharArray();

            /* 对数组进行遍历，写法一：
            for (int i = 0; i < chars.Length; i++)
            {
                if (chars[i] >= 'A' && chars[i] <= 'Z') nUpper++;
                else if (chars[i] >= 'a' && chars[i] <= 'z') nLower++;
                else if (chars[i] >= '0' && chars[i] <= '9') nNumber++;
                else nOther++;
            } */

            // 对数组进行遍历，写法二：
            for (int i = 0; i < chars.Length; i++)
            {
                if (chars[i] >= 'A' && chars[i] <= 'Z') { nUpper++; continue; }
                if (chars[i] >= 'a' && chars[i] <= 'z') { nLower++; continue; }
                if (chars[i] >= '0' && chars[i] <= '9') { nNumber++; continue; }
                nOther++;
            }

            // 输出结果
            Console.WriteLine("上面的字符中有大写字母{0}个，小写字母{1}个，数字字符{2}个，其他字符{3}个。", nUpper, nLower, nNumber, nOther);

            Console.ReadLine();
        }
    }
}
