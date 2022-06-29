using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo05
{

    public class TestMeiJu
    {
        public static void Main(String[] args)
        {
            int i  =int.Parse( Console.ReadLine());
            Test((Sex)i);
        }



        //枚举类型,本质上是一个整数,做文本替换 默认第一个元素对应整数0，以后每个元素都对应的整数都递增1
        //意义:一一列举出某种数据所有取值,增强可读性,限定取值
        [Flags]//表示可以多选,不加也可以,没有实际作用,只是做标识,方便阅读
        enum Sex
        {
            Man,          //0
            Women,     //1(也可以主动赋值,默认从0开始递增)
            M = 10,
            W,               //11,如果部分赋值,则根据上一个值递增
            
            //需要多选时这样赋值,判断时用按位运算符:|
            a=1,
            b=2,
            c=4,
            d=8   


        }

        private static void Test(Sex s) {
            if (s == Sex.Man) Console.WriteLine("男");//0
            if (s == Sex.Women) Console.WriteLine("女");//1
            if (s == (Sex.c|Sex.d)) Console.WriteLine("女+男");//12(8+4)
            Console.ReadLine();
        }



 }
    



}



