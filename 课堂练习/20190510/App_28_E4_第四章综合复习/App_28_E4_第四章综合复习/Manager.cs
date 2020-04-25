using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_28_E4_第四章综合复习
{
    class Manager
    {
        Boyfriend[] bfs;
        int number;
        public Manager()
        {
            bfs = new Boyfriend[101];
            number = 0;
        }
        
        // 增删改操作通常返回类型为布尔，表明是否成功运行
        public bool addBoyfriend(string name, DateTime date, int day)
        {
            Boyfriend bf = new Boyfriend(name, date, day);
            number++;
            if (number >= 100) return false;
            bfs[number] = bf;
            return true;
        }

        public bool deleteBoyfriend(string name)
        {
            number--;
            if (number < 0) return false;
            return true;
        }

        public Boyfriend[] Bfs
        {
            get { return bfs; }
            set { }
        }

        public int Number
        {
            get { return number; }
            set { }
        }

        public bool i { get; set; }
    }
}
