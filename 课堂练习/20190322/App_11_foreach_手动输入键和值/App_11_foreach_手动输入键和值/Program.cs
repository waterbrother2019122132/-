using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace App_11_foreach_手动输入键和值
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            Console.Write("请输入 Key（Key 为空时结束）：");
            string key = Console.ReadLine();
            while (key != "")
            {
                Console.Write("请输入 Value：");
                string value = Console.ReadLine();
                ht.Add(key, value);
                Console.Write("请输入 Key（Key 为空时结束）：");
                key = Console.ReadLine();
            }

            // 遍历：逐个输出
            foreach (string name in ht.Keys)
                Console.WriteLine("{0}的爱好是{1}", name, ht[name]);

            Console.ReadLine();
        }
    }
}
