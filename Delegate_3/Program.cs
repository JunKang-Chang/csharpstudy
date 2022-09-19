using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Delegate_3


    #region//委托的单,多播

{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student() { Id = 1, PenColor = ConsoleColor.Red };
            Student s2 = new Student() { Id = 2, PenColor = ConsoleColor.Green };
            Student s3 = new Student() { Id = 3, PenColor = ConsoleColor.Blue };
            Action ac1 = new Action(s1.DoHomeWork);
            Action ac2 = new Action(s2.DoHomeWork);
            Action ac3 = new Action(s3.DoHomeWork);
            //*****同步调用(单线程)*****
            //以下2种属于间接同步调用(直接同步调用用方法名)
            ////一个委托只封装1个方法--单播委托
            //ac1.Invoke();
            //ac2.Invoke();
            //ac3.Invoke();
            ////一个委托封装多个方法--多播委托
            //ac1 += ac2;
            //ac1 += ac3;
            //ac1.Invoke();

            //*****异步调用(多线程)*****
            //隐式异步调用
            //ac1.BeginInvoke(null, null);
            //ac2.BeginInvoke(null, null);
            //ac3.BeginInvoke(null, null);

           
            //显式异步调用(低级)
            //Thread t1 = new Thread(new ThreadStart(s1.DoHomeWork));
            //Thread t2 = new Thread(new ThreadStart(s2.DoHomeWork));
            //Thread t3 = new Thread(new ThreadStart(s3.DoHomeWork));
            //t1.Start();
            //t2.Start();
            //t3.Start();

            //(高级)
            Task task1 = new Task(new Action(s1.DoHomeWork));
            Task task2 = new Task(new Action(s2.DoHomeWork));
            Task task3 = new Task(new Action(s3.DoHomeWork));
            task1.Start();
            task2.Start();
            task3.Start();

            #endregion

            //********用接口取代委托********
            IProductFactory PizzaFactory = new PizzaFactory();
            IProductFactory ToyCarFactory = new ToyCarFactory();
            WrapFactory wf = new WrapFactory();
            Box b1 = wf.wrap(PizzaFactory);
            Box b2 = wf.wrap(ToyCarFactory);
            Console.WriteLine(b1.Pro.Name);
            Console.WriteLine(b2.Pro.Name);



            Console.Read();
        }
    }

    class Student
    {
        public int Id { get; set; }
        public ConsoleColor PenColor { get; set; }

        public void DoHomeWork()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.ForegroundColor = this.PenColor;
                Console.WriteLine($"Student{this.Id} doing homework {i} hours");
                Thread.Sleep(1000);
            }
        }

    }



 

   







    #region 用接口取代委托
    class Product
    {
        public string  Name { get; set; }
    }

    interface IProductFactory
    {
        Product Make();
    }

    class PizzaFactory : IProductFactory
    {
        public Product Make()
        {
            Product p = new Product();
            p.Name = "pizza!";
            return p;
        }
    }

    class ToyCarFactory : IProductFactory
    {
        public Product Make()
        {
            Product p = new Product();
            p.Name = "ToyCar!";
            return p;
        }
    }

    class Box
    {
        public Product Pro { get; set; }

    }
    
    class WrapFactory
    {
        public Box wrap(IProductFactory pro)
        {
            Box b = new Box();
            Product p = pro.Make();
            b.Pro = p;
            return b;
        }
    }
    #endregion



}
