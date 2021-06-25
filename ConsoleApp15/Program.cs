using ConsoleApp15;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Vehicles
            // Create a list of Vehicle called vehicles
            var vehicles = new List<Vehicle>();
            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             * - new it up as one of each derived class
             * Set the properties with object initializer syntax
             */
            var focus = new Car() { HasTrunk = true, Make = "ford", Model = "focus", Year = 2013 };

            var motorcycle = new Motorcycle() { HasSideCart = true, Make = "HD", Model = "Chopper", Year = 1978 };

            Vehicle vehicle1 = new Car() { HasTrunk = true, Make = "dodge", Model = "sedan", Year = 1988 };

            Vehicle vehicle2 = new Car() { HasTrunk = false, Make = "Panamera", Model = "porche", Year = 2080 };
            /*
             * Using a foreach loop iterate over each of the properties
             */
            vehicles.Add(vehicle1);
            vehicles.Add(vehicle2);
            vehicles.Add(focus);
            vehicles.Add(motorcycle);
           
            foreach (var vehicle in vehicles)
            {
                Console.WriteLine(".......");
                Console.WriteLine(vehicle.Make);
                Console.WriteLine(vehicle.Model);
                Console.WriteLine(vehicle.Year);

            }

            focus.DriveAbstract();
            focus.DriveVirtual();
            motorcycle.DriveVirtual();
            motorcycle.DriveAbstract();
            vehicle1.DriveAbstract();
            vehicle1.DriveVirtual();


            // Call each of the drive methods for one car and one motorcycle

            #endregion            
            Console.ReadLine();
        }
    }
}
