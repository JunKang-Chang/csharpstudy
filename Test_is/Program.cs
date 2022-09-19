using System;

namespace Test_is
{
    class Test_is //检查对象是否与给定的类型兼容(是本类或者子类)
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            Student s1 = new Student();

            Console.WriteLine(p1 is Person);
            Console.WriteLine(s1 is Student);
            
            Console.WriteLine(p1 is Student);
            Console.WriteLine(s1 is Person);

        
        }
    }


    class Person
    {

    }

    class Student : Person
    {

    }
}
