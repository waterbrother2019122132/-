using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;                                               // 注意添加使用文件

namespace H2_hashtable
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();                             // 新建 Hashtable 容器“ht”
            ht.Add("春季", "桃花");                                     // 添加“季节”和“季节里的花”
            ht.Add("夏季", "兰花");
            ht.Add("秋季", "菊花");
            ht.Add("冬季", "梅花");

            Console.WriteLine("原始数据：");                            // 输出根据“季节”输出“季节里的花”
            Console.WriteLine("春天的花：{0}", ht["春季"]);
            Console.WriteLine("夏天的花：{0}", ht["夏季"]);
            Console.WriteLine("秋天的花：{0}", ht["秋季"]);
            Console.WriteLine("冬天的花：{0}", ht["冬季"]);

            Console.Write("\n处理后的数据：\n");
            ht.Remove("春季");                                          // 删除“春季”及其对应的花
            ht["夏季"] = "荷花";                                        // 更改“夏季”对应的花

            bool result = ht.Contains("春季");                          // 新建布尔值“result”，找寻“ht”中是否含有“春季”对应的花
            if (result) Console.WriteLine("春天的花：{0}", ht["春季"]); // 如果含有“春季”对应的花，那么输出花名
            else Console.WriteLine("找不到春季的花！");                 // 如果不含有“春季”对应的花，那么输出“找不到春季的花！”

            Console.WriteLine("夏天的花：{0}", ht["夏季"]);             // 继续输出更改后的花名
            Console.WriteLine("秋天的花：{0}", ht["秋季"]);
            Console.WriteLine("冬天的花：{0}", ht["冬季"]);

            Console.ReadLine();
        }
    }
}
