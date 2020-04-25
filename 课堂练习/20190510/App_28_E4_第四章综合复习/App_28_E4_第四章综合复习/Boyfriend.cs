using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_28_E4_第四章综合复习
{
    class Boyfriend
    {
        string name;
        DateTime date;
        int day;
        public Boyfriend(string name, DateTime date, int day)
        {
            this.name = name;
            this.date = date;
            this.day = day;
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }
        public int Day
        {
            get { return day; }
            set { day = value; }
        }
    }
}
