using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
    委托相当于C++中的函数指针
    把一个方法赋值一个委托对象就实现了委托
 */
namespace _004委托
{
    class ProjectMain
    {
        // 声明一个委托（类）
        public delegate void printStrig(string str);
        public delegate void printColorString(string str, System.ConsoleColor color);
        public static void writeTostdout(string str) {
            Console.WriteLine(str);
        }

        public static void writeTostdoutRed(string str)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(str);
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        public static void writeTostdout_color(string str,System.ConsoleColor color) {
            for(int i = 0; i < 10; i++)
            {
                Console.ForegroundColor = color;
                Console.WriteLine(str+"---->{0}",i);
                Thread.Sleep(1000);
            }
        }
        static void Main(String[] Args)
        {
            printStrig p1 = new printStrig(writeTostdout);
            printStrig p2 = new printStrig(writeTostdoutRed);
            /*委托多播*/
            p1 += p2;
            p1.Invoke("hello invoke");
            //p1.Invoke("hello ");
            //p1("hello world");
            /*同步调用*/
            //printColorString p3 = new printColorString(writeTostdout_color);
            //p2.BeginInvoke("thread1", ConsoleColor.Red,null,null);
            //p2.BeginInvoke("thread2", ConsoleColor.Yellow, null, null);
            //p2.BeginInvoke("thread3", ConsoleColor.Green, null, null);
            //p2.BeginInvoke("thread4", ConsoleColor.Magenta, null, null);

            Console.ReadLine();
            return;
        }

    }
}
