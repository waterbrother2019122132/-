using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H4_Event
{
    public class MouseEventArgs : EventArgs
    {
        string name;
        public MouseEventArgs(string name)
        {
            this.name = name;
        }
        public string Name
        {
            get { return name; }
        }
    }
    
    class Mouse
    {
        string name;
        public event mouseEventHandler mouseEvent;

        public Mouse(string name)
        {
            this.name = name;
        }

        public void escape(object sender, CatEventArgs c)
        {
            Cat cat = (Cat)sender;
            Console.WriteLine("{0}被{1}吓得四处跑。", name, c.Name);
            MouseEventArgs m = new MouseEventArgs(name);
            mouseEvent(this, m);
            return;
        }

        public string Name
        {
            get { return name; }
        }
    }
}
