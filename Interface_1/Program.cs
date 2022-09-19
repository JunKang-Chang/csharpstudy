using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var dr = new Driver(new LightTank());//类的接口实现(派生类有2种实现方式:继承实现和接口实现)
            dr.Drive();
            Console.ReadKey();
        }
    }

    class Driver
    {
        public iVehicle Veh { get; set; }
        public Driver(iVehicle Veh)
        {
            this.Veh = Veh;
        }

        public void Drive()
        {
            Veh.Run();
        }
        

    }

    interface iVehicle
    {
        void Run();
    }
    interface iWeapon
    {
        void Fire();
    }
    interface ITank : iVehicle, iWeapon//接口可以多继承
    {

    }

    class Car : iVehicle
    {
        public void Run()
        {
            Console.WriteLine("Car is running");
        }
    }

    class LightTank : ITank
    {
        public void Fire()
        {
            Console.WriteLine("LightTank  fire");
        }

        public void Run()
        {
            Console.WriteLine("LightTank run");
        }
    }

}
