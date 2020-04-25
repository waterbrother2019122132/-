using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H4_Event
{
    class Master
    {
        string name;

        public Master(string name)
        {
            this.name = name;
        }

        public void wakeup(object sender, MouseEventArgs m)
        {
            Mouse mouse = (Mouse)sender;
            Console.WriteLine("{0}被{1}吵醒。", name, m.Name);
            return;
        }

        public string Name
        {
            get { return name; }
        }
    }
}
