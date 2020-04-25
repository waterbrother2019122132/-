using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H4_Event
{
    public delegate void catEventHandler(object sender, CatEventArgs c);
    public delegate void mouseEventHandler(object sender, MouseEventArgs m);

    public class CatEventArgs : EventArgs
    {
        string name;
        public CatEventArgs(string name)
        {
            this.name = name;
        }
        public string Name
        {
            get { return name; }
        }
    }

    class Cat
    {
        string name;
        public event catEventHandler catEvent;
        
        public Cat(string name)
        {
            this.name = name;
        }

        public void cry()
        {
            Console.WriteLine("{0}：“喵！”", name);
            CatEventArgs c = new CatEventArgs(name);
            catEvent(this, c);
        }

        public string Name
        {
            get { return name; }
        }
    }
}
