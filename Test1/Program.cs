using System;

namespace Test1
{
    class Program
    {
        static void Main(string[] args)
        {//字符串是引用类型,s1和s2的aaa是同一个内存地址,s3和s4不是
            string s1 ="aaa";//引用s1存在堆,aaa存在常量池
            string s2 ="aaa";//引用s2存在堆,aaa存在常量池
            string s3 =new string( "aaa");//引用s3存在堆,aaa也存在堆
            string s4 = new string("aaa");//引用s4存在堆,aaa也存在堆
            Console.WriteLine(s1.Equals(s2));
            Console.WriteLine(object.ReferenceEquals(s1,s2));
            Console.WriteLine(s3.Equals(s4));
            Console.WriteLine(object.ReferenceEquals(s3, s4));


            int? a1 =null;
           // if (a1 == null) a1 = 20;
            Console.WriteLine(a1??20);

            student stu1 = new student(1, 100);
            student stu2 = new student(1, 100);

            Console.WriteLine(stu1 == stu2);
            Console.WriteLine(stu1.Num.Equals(stu2.Num));


        }
    }

    class student
    {
        private int num;
        private int score;

        public student(int num, int score)
        {
            this.num = num;
            this.score = score;
        }

        public int Num
        {
            get {
                return num;
            }

            set {
                num = value;
            }
        }

        public int Score
        {
            get {
                return score;
            }

            set {
                score = value;
            }
        }
    }
}
