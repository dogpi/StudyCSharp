using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002变量
{
    class ProjectMain
    {
        static void Main(String[] Args)
        {
            bool b0;    // 无法作为右值使用 ERROR 未初始化的局部变量
            // bool b00 = b0;
            bool b1 = true;
            bool b2 = false;

            Console.WriteLine("b1 = {0}, b2 = {1}", b1, b2);

            var i = 100;
            // 判断 i 是不是 int 类型
            Console.WriteLine(i is int);
            Console.WriteLine(i is bool);

            Type iType = i.GetType();
            Console.WriteLine("i 的类型是 " + iType.ToString());


            Console.ReadLine();
            return;
        }
    }
}
