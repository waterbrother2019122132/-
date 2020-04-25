using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_35_男友管理系统
{
    public class Boyfriend
    {
        string name;
        DateTime dt;
        int day;

        public Boyfriend(string name, DateTime dt, int day)
        {
            this.name = name;
            this.dt = dt;
            this.day = day;
        }

        public string Name
        { get { return name; } }

        public DateTime DT
        { get { return dt; } }

        public int Day
        { get { return day; } }
    }
}
