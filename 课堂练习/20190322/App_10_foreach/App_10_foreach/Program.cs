using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace App_10_foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            // 新建 Hashtable 实例并在哈希表实例中添加女生名字和爱好
            Hashtable ht = new Hashtable();
            ht.Add("贝贝", "弹琴");
            ht.Add("晶晶", "下棋");
            ht.Add("欢欢", "书法");
            ht.Add("莺莺", "画画");
            ht.Add("妮妮", "唱KTV");

            // 遍历：逐个输出
            foreach (string name in ht.Keys)
                Console.WriteLine("{0}的爱好是{1}", name, ht[name]);

            Console.ReadLine();
        }
    }
}
