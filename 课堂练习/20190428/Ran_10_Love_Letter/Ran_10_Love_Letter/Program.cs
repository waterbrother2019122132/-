using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ran_10_Love_Letter
{
    class Program
    {
        static void Main(string[] args)
        {
            You you = new You(3, 10);
            Me me = new Me();

            you.energyEvent += me.makinglove;
            you.moodEvent += me.kissing;
            you.run();
            Console.ReadLine();
        }
    }
}
