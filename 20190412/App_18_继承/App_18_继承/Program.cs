using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_18_继承 // 
{
    class Program
    {
        static void Main(string[] args)
        {
            Boyfriend bf_1 = new Boyfriend("贝贝", 365);
            Boyfriend bf_2 = new Boyfriend("晶晶", 180, "小晶晶");

            bf_1.showName();
            bf_2.showName();

            Console.WriteLine("");
            bf_1.show();
            bf_2.show();

            Console.ReadLine();
        }
    }
}
