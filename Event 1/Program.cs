using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Event_1
{
    class Program
    {
        static void Main(string[] args)
        {//事件由5个部分组成
            Timer t1 = new Timer();//1.事件的拥有者:t1
            t1.Interval = 1000;
            Boy b = new Boy();//3.事件的响应者:Boy对象b
            Girl g = new Girl();
            t1.Elapsed += b.MyAction;//2.事件:Elapsed      5.事件的订阅:MyAction,用+=符号用来订阅委托
            t1.Elapsed += new ElapsedEventHandler(g.MyAction2);//g.MyAction2;

            //总结:对象b用它的MyAction方法响应t1的Elapsed事件

            Console.ReadKey();
        }
    }

    class Boy
    {
        internal void MyAction(object sender, ElapsedEventArgs e)//4.事件的处理器:MyAction方法
        {
            Console.WriteLine("jump");
        }
    }

    class Girl
    {
        internal void MyAction2(object sender, ElapsedEventArgs e)
        {
            Console.WriteLine("sing a song");
        }
    }
}
