using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_14_E4_object_Girlfriend类
{
    class Program
    {
        static void Main(string[] args)
        {
            Girlfriend gf = new Girlfriend();   // 声明一个基于“Girlfriend”类的“gf”的对象实例

            gf.setName("贝贝");
            gf.setDate(20171224);
            gf.setLength(30);

            Console.Write("我的女朋友是{0}，", gf.getName());
            Console.Write("我们是{0}相识的，", gf.getDate());
            Console.Write("我们恋爱了{0}天。\n", gf.getLength());

            Console.ReadLine();
        }
    }
}
