using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankManagement
{
    class Person
    {
        int idnum;
        string name;
        double money;
        static int num = 0;

        public Person(int idnum, string name, double money)
        {
            this.idnum = idnum;
            this.name = name;
            this.money = money;
        }

        public int Idnum
        {
            get { return idnum; }
            set { idnum = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public double Money
        {
            get { return money; }
            set { money = value; }
        }

        public static int Num
        {
            get { return num; }
            set { }
        }
    }
}
