using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @delegate
{

    //3.自己声明委托,委托是一种类,声明在namespace
    public delegate int Calc(int x, int y);//返回类型是目标方法返回值类型,参数是目标方法参数类型


    class Program
    {
        static void Main(string[] args)
        {

            Calculator cal = new Calculator();

            //1.系统自带的委托Action,不具有返回值和参数
            Action ac = new Action(cal.Report);//参数写的是方法名不要加括号

            //直接调用
            cal.Report();
            //间接调用
            ac.Invoke();//ac();


            //2.系统自带的委托Func
            //前面2个int代表方法的参数类型,第3个代表方法返回类型
            Func<int, int, int> func1 = new Func<int, int, int>(cal.Add);
            Func<int, int, int> func2 = new Func<int, int, int>(cal.Sub);
            int x = 100, y = 200,z=0;
            z = func1.Invoke(x, y); Console.WriteLine(z);//.invoke可以省略
            z = func2.Invoke(x, y); Console.WriteLine(z);


            //3.测试自己声明委托
            Calc c1 = new Calc(cal.Add);
            Calc c2 = new Calc(cal.Sub);
            z = c1.Invoke(x, y); Console.WriteLine(z);
            z = c2.Invoke(x, y); Console.WriteLine(z);


            Console.ReadKey();
        }


    }

    class Calculator
    {

        public void Report()
        {
            Console.WriteLine("i have 3 methonds");
        }
        public int Add(int a, int b)
        {
            int result = a + b;
            return result;
        }
        public int Sub(int a, int b)
        {
            int result = a - b;
            return result;
        }
    }

}
