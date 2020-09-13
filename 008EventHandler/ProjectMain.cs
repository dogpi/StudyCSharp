using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _007自定义事件_简略_
{
    class ProjectMain
    {
        public static void Main(String[] Args)
        {
            Publisher p = new Publisher();
            Subscriber s = new Subscriber();
            p.action += s.process;

            p.Action_event();

            Console.ReadLine();
            return;
        }
    }

    public class ActionEventArgs : EventArgs
    {
        public string name { set; get; }
        public int pram { set; get; }
    }


    public class Publisher
    {
        public event EventHandler action;

        public void Action_event()
        {
            if (action != null)
            {
                ActionEventArgs e = new ActionEventArgs();
                e.name = "third";
                e.pram = 4096;
                action.Invoke(this, e);
            }
            else
                Console.WriteLine("no callback");
        }

    }

    public class Subscriber
    {
        public void process(object s, EventArgs e)
        {
            // 多态
            Publisher s1 = s as Publisher;  
            ActionEventArgs e1 = e as ActionEventArgs;
            Console.WriteLine("process");
            Console.WriteLine(e1.name);
            Console.WriteLine(e1.pram);
        }
    }

}
