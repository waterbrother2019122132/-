using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ran_9
{
    class Program
    {
        static void Main(string[] args)
        {
            float c, f;
            string s;
            s = Console.ReadLine();
            f = float.Parse(s);
            c = 5 * (f - 32) / 9;
            Console.WriteLine("华氏{0}度=摄氏{1}度", s, c.ToString());
            Console.ReadLine();
        }
    }
}
