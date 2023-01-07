using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_class_as_prop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student(new Person("小王",23));
            s1.Score = 80;
            Console.WriteLine($"姓名:{s1.Person1.Name},年龄:{s1.Person1.Age},分数:{s1.Score}");
            s1.Person1.Say();

            Console.Read();
        }
    }

    public class Person
    {
        public Person()
        {

        }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
        

        public string Name { get; set; }
        public int Age { get; set; }
        public string Sex { get; set; }

        public void Say()
        {
            Console.WriteLine("do nothing");
        }

       
    }

    public class Student
    {
        public Student(Person person1)
        {
            this.Person1 = person1;

        }

        private Person person1;

        public int Score { get; set; }

        public Person Person1//封装时候的字段是什么类型,setget赋值取值也必须和它类型一致.封装了类的对象,setget的也必须是这个类的对象
        {
            get {
                return person1;
            }

            set {
                person1 = value;
                if (value.Age < 30)
                {
                    throw new Exception("年龄需要大于30");
                }
            }
        }
    }


}