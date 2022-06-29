using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo04
{
    
    
    
    
    
    
    
    class Program
    {
       
        static void Main(string[] args)
        {
            int[] arr1 = { 2, 1, 32, 45 }; // int[] arr1 = new int[4]{2,1,32,45};
            Array.Sort(arr1);
           
             //查找最大,最小值
            Console.WriteLine("最大值是:{0}",arr1.Max());
            Console.WriteLine("最小值是:{0}",arr1.Min());

            //定义二维数组
            int[,] arr2 ={ 
                                        { 1,4,5},
                                        { 2,3,3},
                                        { 3,2,1} 
                                                                            };
            // int[,] arr2 = new int[3, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };


            for (int i = 0; i < arr1.Length; i++)//遍历数组
                Console.WriteLine(arr1[i]);
                                                                 //增强for循环遍历数组
            foreach (int i in arr2) {
                Console.WriteLine(i);
            }



            int[] arr3 = { 3, 6, 9, 8, 5, };
            int c= Array.IndexOf(arr3, 8);//查找某个数在数组中的位置,查找成功返回下标,失败返回-1   判断是否存在: bool result= Array.IndexOf(arr3, 8)>=0
            Console.WriteLine(c);
            
            
            
            //推断类型,根据所赋数据推断出类型
            //适用性:数据类型名字较长的时候,用var更简洁
            var v1 = 1;
            var v2 = "1";
            var v3 = 1.3;
            var v4 = true;


            




           
            
           
            int i2 =AddTest(1, 2, 3, 4, 5);
            Console.WriteLine(i2);         
            
                      
            int a4 = 1;
            int a5 = 2;
            
            Fun2(ref a4, ref a5);
            Console.WriteLine("使用ref修饰之后返回的a4的值是:{0}\ta5的值是{1}",a4,a5);
            Fun3(out a4,out a5);
            Console.WriteLine("使用out修饰之后返回的a4的值是:{0}\ta5的值是{1}",a4,a5);


           
            
            #region       //TryParse用法
            Console.WriteLine("请输入字符:");
            String str3 =Console.ReadLine();
            int result1;
            bool b4 = int.TryParse(str3,out result1);//转换成功第二个参数返回转换后的值,转换失败则返回0(即false)
            if (b4 == false) 
                Console.WriteLine("字符串转换成数字:失败");
            else
                Console.WriteLine("字符串转换成数字:成功");
            #endregion







            #region//判断是否同一字符串
            //string(c#)=String(.net) ,小写string经过编译后会会转为String，所以用小写更加规范，大写更省资源
            //相同(存值,存在字符串池中(栈内),没有则开辟空间,有则指向同一数据(节省空间)
            String str5 = "Test";
            String str6 = "Test";
            
            //不同(存引用,左边存在栈内,右边new出来的存在堆内,栈内变量指向堆内不同地址)
            String str7 = new String(new char[] { 'T', 'e', 's' ,'t' });
            String str8 = new String(new char[] { 'T', 'e', 's', 't' });

            bool b5 = object.ReferenceEquals(str5, str6); //true
            bool b6 = object.ReferenceEquals(str7, str8); //false

            #endregion





            #region//可变字符串
            StringBuilder sb1 = new StringBuilder("");
            for (int i = 0; i < 5; i++)
            {
                sb1.Append(i);
            }
            String result2 = sb1.ToString();//因为sb1是对象,所以需要调用tostring方法返回string值
            Console.WriteLine("可变字符串输出的结果是:{0}",result2);

            #endregion



            Console.ReadLine();      
        }

     
        
        
        
        #region //值参数   引用参数    输出参数
        static int AddTest(params int[] arr) {          //参数数组,调用填实参时可以不用写数组,更方便
            int sum = 0;
            foreach (var i in arr)
            {
                sum += i;
            }

            return sum;
        }


         //ref和out修饰形参(修饰值类型，引用类型本身就是传递地址没有必要用其修饰) 当函数需要有多个返回值时使用(因为函数只能return一个返回值)
        private static void Fun2(ref int a,ref int b) { //ref修饰形参,形参传递的是实参地址,可以对实参直接赋值(不改也可以))
            a = 123;
            b = 456;//b不赋值也可以,改几个参数没有要求
        } //作用:改变数据

        private static void Fun3(out int a, out int b) {//与ref唯一不同的是:使用out,方法内必须对传递进来的(全部)参数赋值(必须修改实参的值)
            a = 12345;
            b = 67890;//b必须赋值,必须为所有传进来的参数赋值
        } //作用:返回结果


        #endregion


    }


}
