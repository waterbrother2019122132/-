using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H4_Inherit
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat("猫", "鱼");
            Tree tree = new Tree("树", 8);

            cat.show();
            tree.show();

            Console.ReadLine();
        }
    }
}
