using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_25_E4_Interface
{
    interface IGirlfriend
    {
        void getPartingDate();
        int Day { get; set; }
    }

    class People
    {
        string name;
        public People(string name)
        {
            this.name = name;
        }
    }

    class Girlfriend : People, IGirlfriend
    {
        string name;
        int day, date;
        public Girlfriend(string name, int date)
            : base(name)
        {
            this.name = name;
            this.date = date;
        }
        public void getPartingDate()
        {
            Console.WriteLine("我和{0}的分手日期是{1}。", name, date);
        }
        public int Day
        {
            get { return day; }
            set { day = value; }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Girlfriend gf = new Girlfriend("贝贝", 20181111);
            gf.Day = 365;
            gf.getPartingDate();
            Console.WriteLine("我们的恋爱长度是{0}。", gf.Day);
            Console.ReadLine();
        }
    }
}
