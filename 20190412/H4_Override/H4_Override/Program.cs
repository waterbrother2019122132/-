using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H4_Override
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal[] animal = new Animal[5];

            animal[0] = new Cat("大猫", "黑");
            animal[1] = new Cat("小猫", "白");
            animal[2] = new Mouse("硕鼠", 3.5);
            animal[3] = new Mouse("大鼠", 2.5);
            animal[4] = new Mouse("小鼠", 1.5);

            for (int i = 0; i < animal.Length; i++)
            {
                animal[i].printSelf();
            }

            Console.ReadLine();
        }
    }
}
