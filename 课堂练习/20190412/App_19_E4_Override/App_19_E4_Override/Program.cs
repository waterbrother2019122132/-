using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_19_E4_Override
{
    class Program
    {
        static void Main(string[] args)
        {
            Boyfriend bf = new Boyfriend("贝贝", 20160512);
            Father father = new Father("老晶", 19800101);

            bf.printInfo();
            father.printInfo();

            People p = new People("欢欢");
            p.printInfo();

            Console.WriteLine("");

            p = bf;                 // 可以兼容特殊化的 People 类——Boyfriend 类
            p.printInfo();          // 运行时多态

            p = father;
            p.printInfo();          // 运行时多态

            Console.WriteLine("");

            People.show(bf);
            People.show(father);

            Console.ReadLine();
        }
    }
}
