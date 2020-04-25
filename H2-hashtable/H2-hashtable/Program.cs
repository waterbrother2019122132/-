using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace H2_hashtable
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable ht=new Hashtable();
            ht.Add("春", "兰花");
            ht.Add("夏", "荷花");
            ht.Add("秋", "菊花");
            ht.Add("冬", "梅花");
            Console.WriteLine ("Before:");
            Console.WriteLine("春天的代表花卉是" + ht["春"]);
            Console.WriteLine("夏天的代表花卉是" + ht["夏"]);
            Console.WriteLine("秋天的代表花卉是" + ht["秋"]);
            Console.WriteLine("冬天的代表花卉是" + ht["冬"]);
            ht.Remove("春");
            ht["夏"]="莲花";
            Console.WriteLine("After:");
            Console.WriteLine("春天的代表花卉是" + ht["春"]);
            Console.WriteLine("夏天的代表花卉是" + ht["夏"]);
            Console.WriteLine("秋天的代表花卉是" + ht["秋"]);
            Console.WriteLine("冬天的代表花卉是" + ht["冬"]);
        }
    }
}
