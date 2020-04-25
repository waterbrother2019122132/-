using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_7_EG_3_7_无穷级数求和
{
    class Program
    {
        static void Main(string[] args)
        {
            double t = 2;
            int i = 1;
            double sum = 0;
            while(t>0.000001)
            {
                t = 1.0/i;
                sum = sum + t;
                i++;
            }
            Console.Write("1+1/2+1/3+1/4+...+1/{0}={1}", i-1, sum);
            Console.ReadLine();
        }
    }
}
