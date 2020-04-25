using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_23_E4_Love_Letter
{
    class Me
    {
        string name;
        const int MaxValue = 10;

        public Me(string name)
        {
            this.name = name;
        }

        public void joking(object sender, MoodEventArgs m)
        {
            You you = (You)sender;
            if (m.Mood < 5)
            {
                Console.WriteLine("{0} will tell you a joke!", name);
                you.MoodValue = MaxValue;
            }
            return;
        }

        public void cooking(object sender, EnergyEventArgs e)
        {
            You you = (You)sender;
            if (e.Energy < 5)
            {
                Console.WriteLine("{0} will cook a meal for you!", name);
                you.EnergyValue = MaxValue;
            }
            return;
        }
    }
}
