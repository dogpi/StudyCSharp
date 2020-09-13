using System;
using System.Timers;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    事件
    1、发布事件
    2、订阅事件
    3、事件处理 
*/

namespace _005事件
{
    class ProjectMain
    {
        public static void Main(String[] Args)
        {
            Timer t1 = new Timer();
            t1.Interval = 1000;     // 设置Timer.Elapsed事件的时间间隔

            /*
                1、t1触发事件
                2、lambda表达式通过+=订阅事件
                3、lambda为事件处理函数
             */
            t1.Elapsed += (object s,ElapsedEventArgs e) => { Console.WriteLine("Hello"); };
            t1.Start();
            
            Console.ReadLine();
            return;
        }
    }
}
