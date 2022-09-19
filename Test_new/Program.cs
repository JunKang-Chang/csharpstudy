using System;

namespace Test_new
{

    public class Test_new
    {
        static void Main(string[] args)
        {
            Parent p1 = new Child();
            p1.testPrint();
            Child p2 = new Child();
            p2.testPrint();


        }




        class Parent
        {
            public virtual void testPrint()//父类方法必须要用virtual，子类才能重写同名方法
            {
                Console.WriteLine("这是父类的方法");
            }
        }

        class Child : Parent
        {
            public override void testPrint()//子类要重写父类同名方法，父类方法要用virtual，子类要用override（父类的方法被替换成子类的了）
      {  // public (new)     void testPrint()如果子类没用override，则默认是new(规范起见最好写一下)（new=隐藏父类方法=>父类和子类的方法共存,即子类使用自己的方法，父类的方法依然存在）

                Console.WriteLine("这是子类的方法");
            }
        }
    }
}
