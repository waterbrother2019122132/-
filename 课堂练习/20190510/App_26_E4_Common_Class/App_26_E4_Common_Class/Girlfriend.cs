using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_26_E4_Common_Class
{
    class Girlfriend
    {
        string name;
        int day;
        DateTime date;

        public Girlfriend(string name, int day, DateTime date)
        {
            this.name = name;
            this.day = day;
            this.date = date;
        }

        public void show()
        {
            Console.WriteLine("Name: {0}\t Day: {1}\t Date: {2}年{3}月{4}日",
                name, day, date.Year, date.Month, date.Day);
        }

        public void addYear(int n)
        {
            date = date.AddYears(n);    // 年份增加
        }
    }
}
