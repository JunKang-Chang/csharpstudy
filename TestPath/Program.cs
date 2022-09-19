using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPath
{
    class Program
    {
        static void Main(string[] args)
        {
            //在字符串前用@屏蔽转义字符

            //获取文件名含拓展名
            Console.WriteLine(Path.GetFileName(@"E:\myCode\Solution1\TestPath\prgoram.cs"));
            //获取文件名不含拓展名
            Console.WriteLine(Path.GetFileNameWithoutExtension(@"E:\myCode\Solution1\TestPath\prgoram.cs"));
            //获取文件所在文件夹名
            Console.WriteLine(Path.GetDirectoryName(@"E:\myCode\Solution1\TestPath\prgoram.cs"));
            //获取文件的拓展名
            Console.WriteLine(Path.GetExtension(@"E:\myCode\Solution1\TestPath\prgoram.cs"));
            //获取文件的绝对路径
            Console.WriteLine(Path.GetFullPath(@"E:\myCode\Solution1\TestPath\prgoram.cs"));



            Console.ReadKey();
        }
    }
}
