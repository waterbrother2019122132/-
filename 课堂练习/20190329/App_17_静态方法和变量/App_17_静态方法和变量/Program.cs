using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_17_静态方法和变量
{
    class Program
    {
        static void Main(string[] args)
        {
            Girlfriend gf1 = new Girlfriend("贝贝");        // 通过构造函数新建实例对象
            gf1.show();                                     // 通过“实例.方法”的格式，访问非静态方法 show()
            Girlfriend.showCount();                         // 通过“类.方法”的格式，访问静态方法 showCount()

            Girlfriend gf2 = new Girlfriend("晶晶");
            gf2.show();
            Girlfriend.showCount();

            Console.ReadLine();
        }
    }
}
