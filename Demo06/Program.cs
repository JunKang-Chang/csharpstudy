using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo06
{//private修饰符只允许在类的内部使用。static修饰的静态变量和静态方法属于类，使用类直接调用，static修饰的类不能被实例化(静态类中只能有静态变量。非静态类中可以存在静态变量),static修饰的在数据区，只有一份拷贝，程序结束才会释放内存
    class Wife
    {//不写默认就是private,为了规范起见而写,字段首字母小写,字段用private,起保护作用,通过属性实现只读只写
        private string name;//字段
        private int age;
        private string sex;

        public Wife(string name, int age, string sex)//构造方法,用于初始对象化赋值，如果不希望在类的外部创建对象，则用private修饰，将构造函数私有化
        {
            this.name = name;
            this.age = age;
            this.sex = sex;
        }

        public Wife() {
            Console.WriteLine("调用了无参构造方法");
        }


        public Wife(string name):this()//同时调用无参构造方法,括号里写参数的话就是同时调用有参数的构造方法
        {
            this.name = name;
        }

        
        #region 
        //属性(首字母大写),本质上就是两个方法(set和get方法,底层实现参考java),目的:保护字段(封装思想),实现只读、只写
        //属性只是外壳,实际上操作私有字段
        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }
        public int Age
        {
            get
            {
                return age;//age是字段名
            }

            set
            {   if (value !=20) throw new Exception("error!!!!!");
                age = value;//age是字段名,value相当于传递进来的形参
            }
        }

        public string Sex
        {
            get
            {
                return sex;
            }

            set
            {
                sex = value;
            }
        }

        #endregion




        static void Main() {
            Wife w1 = new Wife("cjk",20,"man");
            Console.WriteLine(w1.Name);//输出

           
            Console.WriteLine("输入年龄:");
            w1.Age= int.Parse(Console.ReadLine());//,输入
            Console.WriteLine("年龄是{0}",w1.Age);


            Wife w2 = new Wife("CJK");
            


           
            Console.ReadLine();
        }
    }
 

}
