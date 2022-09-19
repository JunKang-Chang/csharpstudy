using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestBuFenLei
{
    class TestBuFenLei
    {
        static void Main(string[] args)
        {
            Person p1 = new Person(15);
            p1.sayAge();
            Console.ReadKey();
        }
    }

    partial class Person
    {
        private int age;

        public Person(int age)
        {
            this.age = age;
        }

        public int Age
        {
            get {
                return age;
            }

            set {
                age = value;
            }
        }
    }



    partial class Person
    {
        public void sayAge()
        {
            Console.WriteLine("Age is:{0}",this.Age);
        }
    }
}


