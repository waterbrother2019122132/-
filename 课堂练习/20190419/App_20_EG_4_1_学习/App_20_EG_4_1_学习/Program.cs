using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_20_EG_4_1_学习
{
    class Program
    {
        static void Main(string[] args)
        {
            Complex a = new Complex(1, 2);
            Complex b = (" -3 -4* i ");
            Complex c, d, e;
            c = a + b;
            d = a - b;
            e = -a;

            Console.WriteLine("a+b = " + c.ToString());
            Console.WriteLine("a-b = " + d.ToString());
            Console.WriteLine("-a = " + e.ToString());

            Console.ReadLine();
        }
    }
}
