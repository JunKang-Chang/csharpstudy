using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestException
{
    public class TestException
    {
        
        static void Main(string[] args)
        {

#region 测试系统异常
            Console.WriteLine("输入一个数字：");
            int? i = null;

            try
            {
                i = int.Parse(Console.ReadLine());
                {
                    Console.WriteLine("输入的值是：{0}", i);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("输入错误:{0}",e.Message);

            }

            finally
            {
                Console.WriteLine("测试系统异常运行结束");
            }
            #endregion




            #region 自定义异常

            Console.WriteLine("输入一个1-5的数字：");
            int? j = null;
            //有多种异常情况，则由细到粗，exception类兜底
            try
            {
                j = int.Parse(Console.ReadLine());
                if (j < 1 || j > 5)
                {
                    throw new TestOneToFiveException("错误！输入的数字并非1-5");

                }
            }
            catch (TestOneToFiveException e1)
            {
                Console.WriteLine("错误原因：{0}", e1.Message);

            }
            catch (Exception e2)
            {
                Console.WriteLine("错误原因：{0}",e2.Message);
            }

            #endregion

            Console.ReadKey();
        }
   
    
    
    
    
    
    
    
    }


    class TestOneToFiveException : Exception//自定义异常要继承异常类
    {
      

        public TestOneToFiveException(string message) : base(message)
        {
           
        }
    }

}
