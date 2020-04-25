using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankManagement
{
    class VIPPerson
    {
        int idnum;
        string name;
        double money;
        DateTime date;
        static int num = 0;

        public VIPPerson(int idnum, string name, double money, DateTime date)
        {
            this.idnum = idnum;
            this.name = name;
            this.money = money;
            this.date = date;
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

        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }

        public static int Num
        {
            get { return num; }
            set { }
        }
    }
}
