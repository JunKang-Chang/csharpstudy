using System;

namespace TestInterface
{
    class TestInterface
    {
        static void Main(string[] args)
        {
            Dog d1 = new Dog();
            d1.name();
            d1.bark();

            Bird b1 = new Bird();
            b1.name();
            b1.bark();


            //多态    父类引用指向子类对象
            IAnimal d2 = new Dog();
            d2.name();
            d2.bark();

            IAnimal b2 = new Bird();    
            b2.name();
            b2.bark();
        }
    }


    public interface IAnimal    //接口命名通常加一个大写的i
        //不能加访问修饰符
        //接口含有的方法没有方法体
        //只能含有属性,不能含有字段,即字段要封装成属性
        //子类实现父类接口时要实现所有内容
    {
        void bark();
       void name();

        int Age { get; set; }

    }

    public class Dog : IAnimal
    {
        public void name()//隐式实现接口,加访问修饰符
        {
            Console.WriteLine("name is dog");
        }

        public void bark()
        {
            Console.WriteLine("旺旺");
        }

         int IAnimal. Age { get; set; }////显式实现接口,在属性或方法前加接口名前缀
    }



    public class Bird : IAnimal
    {
        public void bark()
        {
            Console.WriteLine("叽叽");

        }

        public void name()
        {
            Console.WriteLine("name is Bird");
        }
        public int Age { get; set; }
    }
}

