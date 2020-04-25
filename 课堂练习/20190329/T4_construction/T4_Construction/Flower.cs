using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T4_Construction
{
    class Flower
    {
        string name;
        string place;
        double score;
        static int num;

        public static void praise() {
            num++;
            Console.WriteLine("共获得了{0}次点赞。", num); }

        public Flower(string name)
        { this.name = name; }
        public Flower(string name, string place)
        { this.name = name; this.place = place; }

        public double Score {
            get { return score; }
            set { score = value; } }
        public string Name
        {
            get { return name; }
            set { }
        }
        public string Place
        {
            get { return place; }
            set { }
        }
    }
}
