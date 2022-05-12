using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphyism_Bro_Code
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            Cycle cycle = new Cycle();
            Boat boat = new Boat();

            Vehicle[] vehicles = { car, cycle, boat };

            foreach (Vehicle vehicle in vehicles)
            {
                vehicle.Start();
            }

            Console.ReadKey();
        }
    }
    class Vehicle
    {
        public virtual void Start()
        {
            Console.WriteLine("Start");
        }
    }
    class Car : Vehicle
    {
        public override void Start()
        {
            Console.WriteLine("Start the car");
        }
    }
    class Cycle : Vehicle
    {
        public override void Start()
        {
            Console.WriteLine("Start the Cycle");
        }
    }
    class Boat : Vehicle
    {
        public override void Start()
        {
            Console.WriteLine("Start the Boat");
        }
    }
}



    

