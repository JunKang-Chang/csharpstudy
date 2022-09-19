using System;

namespace TestShuZu
{
    class TestShuZu
    {//注意!此项目用的是.net core框架,所以可以String xx=new String("xx");
     //而在.net framework框架下此语法会报错得用String xx=new String(new char[]{'x','x','x'});
        static void Main(string[] args)
        {   //不等价，没用new的引用存放在栈中,字符串存在常量池，用new的引用存放在栈中,生成的对象存在堆中然后指向常量池
            String s1 = "abc";
            String s2 = new String("abc");
            String s3 = new String("abc");

                       
            Console.WriteLine(s1.Equals(s2)); //判断值
            Console.WriteLine(s2.Equals(s3));
            
            Console.WriteLine(object.ReferenceEquals(s1,s2));//判断地址（是否同一对象）
            Console.WriteLine(object.ReferenceEquals(s2, s3));

            Console.WriteLine();

            
            //等价，用不用new都生成对象
            int[] arr1 = { 1, 2, 3 };
            int[] arr2 = new int[] { 1, 2, 3 };
            Console.WriteLine(object.ReferenceEquals(arr1,arr2));
  
        }
    }
}
