using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003使用new创建对象
{
    class ProjectMain
    {
        static void Main(String[] Args)
        {

            Dog d1 = new Dog("黑豆","Black");
            Dog d2;
            d2 = d1;

            Console.WriteLine("d1 name {0} color {1} ", d1.Name, d1.Color);
            Console.WriteLine("d2 name {0} color {1} ", d2.Name, d2.Color);

            d1.Name = "臭豆腐";
            Console.WriteLine("只修改d1的name。");
            Console.WriteLine("d1 name {0} color {1} ", d1.Name, d1.Color);
            Console.WriteLine("d2 name {0} color {1} ", d2.Name, d2.Color);

            // 可以看出通过new创建出的对象赋值是引用操作。
            /*
                Dog d2 = d1;
                相当于C++中的
                Dog& d2 = d1;
             */

            Console.ReadLine();
            return;
        }
    }

    class Dog
    {
        public String Name { get; set; }
        public String Color { get; set; }

        public Dog(String name, String color) {
            Name = name;
            Color = color;
        }
        ~Dog() { }

    }
}
