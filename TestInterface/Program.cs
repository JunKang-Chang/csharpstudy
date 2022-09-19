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
        }
    }


    public interface IAnimal    //接口命名通常加一个大写的i
    {
        public void bark();



        public void name();

    }

    public class Dog : IAnimal
    {
        public void name()
        {
            Console.WriteLine("name is dog");
        }

        public void bark()
        {
            Console.WriteLine("旺旺");
        }
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

    }
}
