using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_2//委托的使用方式:1.模板方法(委托有返回值),2.回调方法(委托无返回值)
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductFactory pf = new ProductFactory();
            WrapFactory wf = new WrapFactory();
            Func<Product> func1 = new Func<Product>(pf.MakePizza);
            Func<Product> func2 = new Func<Product>(pf.MakeToyCar);
            Logger log1 = new Logger();
            Action < Product > ac1= new Action<Product>(log1.log);


            Box b1 = wf.wrap(func1,ac1);
            Box b2 = wf.wrap(func2,ac1);

            Console.WriteLine(b1.Pro.Name);
            Console.WriteLine(b2.Pro.Name);

            Console.ReadLine();
        }
    }


    class Logger
    {
        public void log(Product p)
        {
            Console.WriteLine($"Product:{p.Name} created at {DateTime.UtcNow},price is {p.Price}");
        }
    }


    class Product
    {
        private string name;
        private double price;

        public string Name
        {
            get {
                return name;
            }

            set {
                name = value;
            }
        }

        public double Price
        {
            get {
                return price;
            }

            set {
                price = value;
            }
        }
    }

     


    class Box
    {
        private Product pro;

        internal Product Pro
        {
            get {
                return pro;
            }

            set {
                pro = value;
            }
        }
    }

    class WrapFactory
    {
        public Box wrap(Func<Product> getPro,Action<Product> logCallback)
        {
            Box b = new Box();
            Product p = getPro.Invoke();
            if (p.Price > 50) logCallback.Invoke(p);//回调方法,价格大于50则调用
            b.Pro = p;
            return b;
        }
    }

    class ProductFactory
    {
        public Product MakePizza()
        {
            Product p1 = new Product();
            p1.Name = "pizza";
            p1.Price = 12;
            return p1;
        }

        public Product MakeToyCar()
        {
            Product p2 = new Product();
            p2.Name = "ToyCar";
            p2.Price = 100;
            return p2;
        }

    }
}
