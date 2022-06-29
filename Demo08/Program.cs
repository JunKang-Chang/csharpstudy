using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo08
{//private修饰的仅供本类访问,protected修饰的供本类和子类使用,public修饰的才可以在类的外部调用
    class Person{//只有public和protected可以被子类继承
        public string sex;
        protected int age;

        public Person(string sex, int age)
        {
            this.sex = sex;
            this.age = age;
        }


        public Person()
        {
            Console.WriteLine("这是一个父类的无参构造方法,测试是否被子类调用");
        }

       
        
        //静态构造方法,不能添加访问修饰符(静态属于类,不属于对象,添加没有意义),用来初始化静态数据成员
        static Person()
        { 
            
        }

    }



    class Student : Person//继承父类的所有字段和方法(不包括private修饰的和构造方法)(要使用父类的有参构造方法,子类要主动调用.无参的系统默认就指向父类)
    {
        private int score;//子类独有的字段

        public Student(string sex, int age,int score) : base(sex, age)//调用父类有参构造方法(相当于JAVA的super),独有字段要单独写
        {
            this.score = score;
        }

        public Student()//:base()
        {//子类在调用自身的无参构造方法之前还会调用父类的无参构造方法,因为系统默认指向了父类的无参构造方法,这里其实省略了base没有写出来(也不用写)
            Console.WriteLine("这是子类自己的无参构造方法");
        }

        static void Main() {
            
            Student s1 = new Student("男",20,100);
            Console.WriteLine("性别:{0}",s1.sex);
            Console.WriteLine("年龄:{0}", s1.age);
            Console.WriteLine("分数:{0}", s1.score);

            Student s2 = new Student();


         
            
            //父类引用指向子类对象
            //只能使用父类成员(但是包含了子类的成员)(只有public修饰的,protected不可以)
            Person s3 = new Student();
            //如果需要访问子类成员,需要强转,用as(如果转换失败不会抛出异常)
            Student s4 = s3 as Student;
            
          
            
            
            Console.ReadLine();

        }
    }


}
