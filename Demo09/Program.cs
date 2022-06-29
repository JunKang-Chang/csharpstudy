using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo09
{

    //结构体属于值类型,可以包含字段和方法        直接存储数据,因此在一个对象的主要成员为数据且数据量不大的情况下，使用结构体比使用类效率更高
    struct Books
    {   //字段不能直接赋值,但是const和static修饰的可以
        public string name;
        public int num;
        public int money;
       
        public  const int c1= 12345;//不能更改数值,通过结构体名调用
        public  static int s1 = 678;//可以更改数值,通过结构体名调用



        /*结构体自带无参构造方法,不能写,有参数的可以写
        public Book() 
        {     
        
            }
    */
        public Books(string name, int num, int money)
        {
            this.name = name;
            this.num = num;
            this.money = money;

        }
    
    
    };
    



    class Test
    {
        public static void Main(string[] args)
        {
            //不用new也可以,直接对象名.字段名
            Books book1 = new Books("book no.1", 1, 50);
          
            
            Console.WriteLine("书名:{0}\t编号{1}\t价格{2}",book1.name,book1.num,book1.money);
            Console.WriteLine("测试const:{0}",Books.c1);
            Console.WriteLine("测试static:{0}",Books.s1);
            Books.s1 = Books.s1 + 100;
            Console.WriteLine("测试修改后的static:{0}",Books.s1);

            Console.ReadLine();
        }
    }

}
