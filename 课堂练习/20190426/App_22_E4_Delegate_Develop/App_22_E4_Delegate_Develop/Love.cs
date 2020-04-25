using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_22_E4_Delegate_Develop
{
    /* public delegate void sayDelegate(string name); */   // 该声明也可放在这里，注意一定要放在 class Love 外面，否则 class Program 访问不到。

    class Love
    {
        public event sayDelegate say3;                     /* 加上关键字“event”，前面的访问控制符只对“+=”“-=”有效 (public)，其余修饰符均无效 (private)。
                                                            * 事件是一种特殊的委托，实现的是委托的封装。*/

        public void showLove(string name)                  // 此时可以把“static”去掉，在主函数中声明对象。
        {
            if(say3 != null) say3(name);
        }
    }
}
