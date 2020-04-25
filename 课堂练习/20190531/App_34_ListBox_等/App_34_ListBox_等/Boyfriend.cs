using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_34_ListBox_等
{
    public class Boyfriend
    {
        string name;
        DateTime dt;

        public Boyfriend(string name, DateTime dt)
        {
            this.name = name;
            this.dt = dt;
        }

        public string show()
        {
            return name + "：" + dt.Year + "/" + dt.Month + "/" + dt.Day;
        }
    }
}
