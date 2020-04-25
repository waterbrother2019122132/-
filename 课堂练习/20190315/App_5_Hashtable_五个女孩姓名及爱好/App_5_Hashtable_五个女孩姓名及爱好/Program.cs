using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;          // 添加使用文件

namespace App_5_Hashtable_五个女孩姓名及爱好
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();     // Hashtable 声明
            ht.Add("贝贝", "弹琴");
            ht.Add("晶晶", "下棋");
            Console.WriteLine("贝贝的爱好：{0}", ht["贝贝"]);

            /*“.Add”是 Hashtable 类型的一种方法，用于往该容器中添加元素。
             * 括号内分别为“键(key)(索引值)”和“值(value)(被索引值)”，即通过“贝贝”索引到“弹琴”。
             * 不同元素之间“键”一定不相同，但是“值”可以相同。*/

            /* 适用于 Hashtable 类型的其它方法：
             * ht.Remove("贝贝");         // 删除“贝贝”所对应的元素
             * ht.Clear();                // 移除所有元素
             * ht.Contains(“晶晶”);     // 是否包含“晶晶”对应的元素，返回值为布尔类型 */

            bool result = ht.Contains("晶晶");                              // 新建布尔类型的值“result”，判断是否有“晶晶”这个“键”
            if (result)                                                     // 如果“result”为真
            {
                Console.WriteLine("晶晶的爱好：{0}", ht["晶晶"]);
                ht.Remove("晶晶");                                          // 删除“晶晶”及其对应的“值”
                if (ht.Contains("晶晶")) Console.WriteLine("删除不成功！");  // 如果仍有“晶晶”这个值，则报错
                else Console.WriteLine("晶晶虽然存在，但已经被我删除了！");
            }
            else Console.WriteLine("不存在晶晶这个人！");

            ht.Clear();                                                     // 清除 ht 内的所有元素
            if (ht.Contains("贝贝")) Console.WriteLine("清除不成功！");
            else Console.WriteLine("成功清除！");
            
            Console.ReadLine();
        }
    }
}
