using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_FileStream
{       //按字节进行文件传输
    class Test_FileStream
    {
        static void Main(string[] args)
        {
            string str1 = Path.GetFileName(@"C:\Users\Administrator\Desktop\1.txt");
            string str2 = "测试";
            byte[] bt1 = Encoding.Default.GetBytes(str2);
            FileStream fs1 = new FileStream(str1, FileMode.Append, FileAccess.Write);
            fs1.Write(bt1, 0, bt1.Length); ;

            fs1.Close();
            fs1.Dispose();

            Console.ReadKey();
        }
    }
}
