using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo02
{
    class Program
    {
        static void Main(string[] args)
        {
            string gunName = "AK";
            string str1 = string.Format("枪的名字是:{0}", gunName);//用占位符接收,或者string str1 = ("枪的名字是"+gunName);
            Console.WriteLine(str1);
            Console.WriteLine("cost money:{0:c}RMB",100);//数字字符串格式化
 
            Console.WriteLine("i like\"unity\"");//转义符
            char c1 = '\'';
            
            Console.WriteLine("测试换行\n这是下一行");

            //字符串转换其他类型
            string str2 = "1";
            int num1 = int.Parse(str2);
            string str3 = "true";
            bool b1 = bool.Parse(str3);
            Console.WriteLine(num1+"\t"+b1);

            //其他类型转字符串
            int num3 = 100;
            string str4 = num3.ToString();
            Console.WriteLine(str4);



            #region
            //折叠代码
            //折叠代码
            //折叠代码
            //折叠代码
            //折叠代码
            #endregion





            //类型自动上升
            byte b5 = 255;
            b5+=1;
            Console.WriteLine(b5);



           //接受输入(字符串)
 
            //Console.WriteLine("请输入性别");                    //字符串直接接收
            //string str5 = Console.ReadLine();
            // Console.WriteLine("请输入数字");//                  将输入的字符串转换成其他类型
           // int num4 = int.Parse(Console.ReadLine());
           
            
            
            
            
            
            
            
            
          
            
            
            
            
            
            
            Console.ReadLine();
        }
    }
}
