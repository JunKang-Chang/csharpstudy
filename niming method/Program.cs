using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace niming_method
{
    delegate void mydel(int x);
    delegate void mydel2();
    delegate int mydel3(int y);

    class Program
    {

        static void Main(string[] args)
        {
            mydel del = delegate (int x)
            {
                Console.WriteLine($"有参无返回值匿名方法输出:{x}");
            };

            mydel del4 = (int x) =>
              {
                  Console.WriteLine($"lambda表达式输出:{x}");
              };


            mydel2 del2 = delegate ()
            {
                Console.WriteLine("这是无参匿名方法");
            };

            mydel3 del3 = delegate (int y)
            {
                Console.WriteLine($"有参有返回值匿名方法输出:{y}");
                return (y + 1);
            };

            Action<int> ac1 = delegate (int z)
              {
                  Console.WriteLine($"系统自带的action委托生成的匿名方法返回值:{z}");
              };

            Func<int,int,int> func1=(int x,int y) =>
                {
                return x - y;
            };
            
            
           
            
            del.Invoke(10);
            del4.Invoke(20);
            del2.Invoke();
            int a = del3.Invoke(5);
            Console.WriteLine($"有返回值的匿名方法的返回值是:{a}");
            ac1.Invoke(30);
            Console.WriteLine($"系统自带的Function委托使用lambda表达式的返回值:{func1.Invoke(100, 10)}"); 



            Console.Read();
        }
    }
}