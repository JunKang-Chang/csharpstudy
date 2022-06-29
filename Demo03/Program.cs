using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo03
{
    class Program
    {
       
        
        static void Main(string[] args)
        {
            fun1();
            int a = fun2();
            Console.WriteLine("fun2的值是{0}",a);

            
           
            
            
            
            //插入字符串
            string str01 = "我叫";
            str01 = str01.Insert(2,"常");//此方法有返回值:"我叫常",调用完之后要重新赋给变量
            Console.WriteLine(str01);

            //定位字符位置
            int b = str01.IndexOf("叫");
            Console.WriteLine("叫 这个字在第{0}个位置",b);

            /*
            str01 =str01.Remove(1); //删除  "叫"
            str01 = str01.Replace("我","你");//替换      把前者替换成后者
            str01 = str01.StartsWith("我叫");//检查开头字符是否相同,字符数量随意,返回布尔类型
            str01 = str01.Contains();//检查是否包含字符
            */
            
         
                




            Console.ReadLine();
        }


       
        
        private static void fun1() {
           Console.WriteLine("fun1执行了");
        }

        private static int fun2() {
            Console.WriteLine("fun2执行了");
            return 100;
        }


    
    
    
    
    
    
    
    
    
    
    
    }









}
