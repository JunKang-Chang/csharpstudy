using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("helloworld");
            Student s1 = new Student("tom", 1);
            Console.WriteLine("name:"+s1.Name);
            s1.Num=s1.Num + 1;
            Console.WriteLine("num:\t"+s1.Num);
        }
    }

    class Student
    {
        private string name;
        private int num;

        public Student(string name, int num)
        {
            this.Name = name;
            this.num = num;
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public int Num
        {
            get
            {
                return num;
            }

            set
            {
                num = value;
            }
        }
    }

}
