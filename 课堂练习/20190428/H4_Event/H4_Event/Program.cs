using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H4_Event
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat("汤姆");
            Mouse mouse = new Mouse("杰瑞");
            Master master = new Master("房东");

            cat.catEvent += mouse.escape;
            mouse.mouseEvent += master.wakeup;
            cat.cry();

            Console.ReadLine();
        }
    }
}
