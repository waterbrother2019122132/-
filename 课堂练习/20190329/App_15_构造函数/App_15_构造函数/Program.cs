using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_15_构造函数
{
    class Program
    {
        static void Main(string[] args)
        {
            // 新建对象
            Girlfriend gf1 = new Girlfriend("贝贝");              // 根据参数的数量和类型可知，这里会自动调用构造函数 ①
            Girlfriend gf2 = new Girlfriend("晶晶", 20180520);    // 自动调用构造函数 ②

            // 设置属性值
            gf1.Length = 365;
            gf2.Length = 200;

            // 输出
            Console.WriteLine("我前女友的名字是{0}，恋爱时长是{1}天；", gf1.Name, gf1.Length);
            Console.WriteLine("我现女友的名字是{0}，我们认识的时间是{1}，到现在已经{2}天了！", gf2.Name, gf2.Date, gf2.Length);

            Console.ReadLine();
        }
    }
}
