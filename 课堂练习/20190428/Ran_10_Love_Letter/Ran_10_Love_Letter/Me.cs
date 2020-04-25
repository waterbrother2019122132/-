using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ran_10_Love_Letter
{
    class Me
    {
        const int MaxValue = 10;

        public void kissing(object sender, MoodEventArgs m)
        {
            You you = (You)sender;
            if (m.Mood < 8)
            {
                Console.WriteLine("            Mua! ヾﾉ≧^≦)っ❥(^_-)");
                you.MoodValue = MaxValue;
            }
            return;
        }

        public void makinglove(object sender, EnergyEventArgs e)
        {
            You you = (You)sender;
            if (e.Energy < 5)
            {
                Console.WriteLine("            3┤ Ah♂! ~~~");
                you.EnergyValue = MaxValue;
            }
            return;
        }
    }
}
