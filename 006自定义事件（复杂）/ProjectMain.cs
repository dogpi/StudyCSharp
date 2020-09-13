using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
 事件的完整声明方式
 该例子中涉及到：
    事件发出者
    事件
    事件接收者
    事件处理
     
     */
namespace _006自定义事件_复杂_
{
    class ProjectMain
    {
        static void Main(String[] Args)
        {
            Publisher p = new Publisher();
            Subscriber s = new Subscriber();

            p.action += s.process;

            p.action_event();

            Console.ReadLine();
            return;
        }
    }

    // 事件传输参数
    public class ActionEventArgs:EventArgs
    {
        public string name { set; get; }
        public int param { set; get; }
    }

    // 声明一个委托类型
    public delegate void ActionEventHandler(Publisher s, ActionEventArgs args);

    public class Publisher
    {
        // 事件发出者：发出事件
        
        // 用于存储事件处理函数
        private ActionEventHandler actionEventhandler;

        // 事件（订阅后会存储事件处理函数）
        public event ActionEventHandler action
        {
            add
            {
                this.actionEventhandler += value;
            }
            remove
            {
                this.actionEventhandler -= value;
            }
        }

        public void action_event()
        {
            if (this.actionEventhandler != null)
            {
                ActionEventArgs e = new ActionEventArgs();
                e.name = "first action";
                e.param = 1024;
                Console.WriteLine("action_event");
                // 触发事件
                this.actionEventhandler.Invoke(this, e);
            }
            
        }
        

    }

    public class Subscriber
    {
        // 事件响应者：处理事件
        public void process(Publisher s, ActionEventArgs args)
        {
            Console.WriteLine("Process action");
            Console.WriteLine(args.name);
            Console.WriteLine(args.param);
        }
    }

}
