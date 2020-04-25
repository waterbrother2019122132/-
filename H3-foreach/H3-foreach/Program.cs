using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace H3_foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable ht=new Hashtable ();
            ht.Add("张三", "92");
            ht.Add("李四", "98");
            ht.Add("王五", "60");
            ht.Add("孙六", "71");

            foreach (String index in ht.Keys) 
            Console.WriteLine(index + "的成绩是" + ht[index]);
        }
    }
}
