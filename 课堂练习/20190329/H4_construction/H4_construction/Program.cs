using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;                                           // 添加使用声明

namespace H4_construction
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();                         // 新增 Hashtable 容器 ht

            Girlfriend gf_1 = new Girlfriend("贝贝");               // 以“Girlfriend”类实例三个对象
            Girlfriend gf_2 = new Girlfriend("晶晶");
            Girlfriend gf_3 = new Girlfriend("欢欢");

            gf_1.Date = 20150520; gf_1.Day = 40;
            gf_2.Date = 20160214; gf_2.Day = 20;
            gf_3.Date = 20170909; gf_3.Day = 60;

            ht.Add("贝贝", gf_1);
            ht.Add("晶晶", gf_2);
            ht.Add("欢欢", gf_3);

            Console.WriteLine("恋爱时长超过30天的女友信息：");
            foreach (string name in ht.Keys)
            {
                Girlfriend gf_0 = (Girlfriend)ht[name];             /* 哈希表中的 value 和 key 都是 object 类型，用的时候需要装箱、拆箱。
                                                                     * 新增“Girlfriend”类实例“gf_0”，用于临时存放哈希表的值。
                                                                     * 可以将哈希表的 value 强制转换成“Girlfriend”类。*/
                if ( gf_0.Day > 30 )
                    Console.WriteLine("我和{0}于{1}认识，恋爱时长是{2}天。", name, gf_0.Date, gf_0.Day);
            }

            Console.ReadLine();
        }
    }
}
