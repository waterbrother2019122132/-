using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace H3_score
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            Console.Write("请输入学生姓名（姓名为空时结束）：");
            string name = Console.ReadLine();
            while (name != "")                                          // 当键入的值为空时，跳出循环
            {
                Console.Write("请输入学生分数：");
                double score = double.Parse(Console.ReadLine());        // 将键盘输入的内容（字符串类型）转换为双精度类型
                ht.Add(name, score);
                Console.Write("请输入学生姓名（姓名为空时结束）：");
                name = Console.ReadLine();
            }

            // 遍历：逐个输出
            Console.Write("\n及格的学生：\n");
            foreach (string nameOutPut in ht.Keys)
                if ((double)ht[nameOutPut] >= 60.0) Console.WriteLine("{0}的分数是{1}", nameOutPut, ht[nameOutPut]);
                //“ht[nameOutPut]”需要强制类型转换成双精度类型数才可以比较大小
            Console.Write("\n不及格的学生：\n");
            foreach (string nameOutPut in ht.Keys)
                if ((double)ht[nameOutPut] < 60.0) Console.WriteLine("{0}的分数是{1}", nameOutPut, ht[nameOutPut]);

            Console.ReadLine();
        }
    }
}
