using System;
using System.Collections;
using System.Collections.Generic;

namespace Test_HashTable_Dictionary
{   //HashTable不支持泛型，而Dictionary支持泛型
    //都用foreach遍历，如果key里存的不是int类型，普通for循环无法遍历
    class Test_HashTable_Dictionary
    {
        static void Main(string[] args)
        {

            Dictionary<string,int> d1 = new Dictionary<string,int>();
            d1.Add("a", 10);
            d1.Add("b", 12);

            Console.WriteLine(d1["a"]);

            foreach (var item in d1.Keys)//用item作为d1.Keys的下标
            {
                Console.WriteLine("key is:{0},value is:{1}",item,d1[item]);
            }


            Console.WriteLine();


            Hashtable h1 = new Hashtable();
            h1.Add("abc", "def");
            h1.Add(12345, 67890);
            h1.Add(true, false);
            h1.Add(1, "zzz");

            foreach (var item in h1.Keys)
            {
                Console.WriteLine("key is:{0},value is:{1}",item,h1[item]);
            }



        }

       

    }
}
