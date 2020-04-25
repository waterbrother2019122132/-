using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_13_对象的访问方法
{
    // 先定义类 B
    class B
    {
        public int x;
        public int f()
        {
            return x + 100;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // 利用类 B 来声明并创建对象 b
            B b = new B();

            // 访问 b 中的成员
            b.x = 100;
            int y = b.f();
            Console.WriteLine("y = {0}", y);

            Console.ReadLine();
        }
    }
}
