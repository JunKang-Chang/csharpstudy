using System;

namespace TestXiuShiFu
{
    public class TestXiuShiFu
    {   //类的方法要加访问修饰符，不然默认是private，调用不到
        static void Main(string[] args)
        {
            Apple ap1 = new Apple();
            ap1.sayBye();
            ap1.sayHello();
        }
    }

    class Fruit
    {
        public void sayHello()
        {
            Console.WriteLine("Fruit:hello");
        }
    }
    

    class Apple : Fruit
    {
        public void sayBye()
        {
            Console.WriteLine("Apple:bye");
        }
    }



}
