using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo07
{
    class User
    {

        private string name;
        private int age;

        public User(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

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
                return age;
            }

            set
            {
                age = value;
            }
        }

        static void Main(string[] args)
        {
            //动态数组

            User u1 = new User("1号", 15);
            List<User> l1 = new List<User>();//相当于java的容器
            l1.Add(u1);
            l1.Add(new User("2号", 20));






            //字典(键值对)
            Dictionary<string, User> d1 = new Dictionary<string, User>();
            d1.Add("1", u1);
            Console.WriteLine("输入号码:");
            String s1 = Console.ReadLine();
            Console.WriteLine("{0}号的年龄为:{1}",s1,d1[s1].Age);



            Console.ReadLine();

        
        
        }
    }
}
