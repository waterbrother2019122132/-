using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_23_E4_Love_Letter
{
    class Program
    {
        static void Main(string[] args)
        {
            You you = new You(3, 10);
            Me me1 = new Me("贝贝");
            Me me2 = new Me("晶晶");

            you.energyEvent += me1.cooking;
            you.moodEvent += me1.joking;
            you.energyEvent += me2.cooking;
            you.moodEvent += me2.joking;
            you.run();
            Console.ReadLine();
        }
    }
}
