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
        }
    }

    public class ActionEventArgs : EventArgs
    {
        public string name { set; get; }
        public int pram { set; get; }
    }

    public delegate void ActionEbentHandler(Publisher s, ActionEventArgs Args);

    public class Publisher
    {
        public event ActionEbentHandler action;

        public void Action_event()
        {
            if (action != null)
            {
                ActionEventArgs e = new ActionEventArgs();
                e.name = "sencon";
                e.pram = 2048;
                action.Invoke(this,e);
            }
        }

    }
       
    public class Subscriber
    {
        public void process(Publisher s,ActionEventArgs e)
        {
            Console.WriteLine("process");
            Console.WriteLine(e.name);
            Console.WriteLine(e.pram);
        }
    }

}
