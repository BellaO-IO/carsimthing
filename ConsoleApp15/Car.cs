using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp15
{
    public class Car : Vehicle
    {
        public Car()
        {
        }
        public bool HasTrunk { get; set; } = true;
        public override void DriveAbstract()
        {
            Console.WriteLine("This car is in drive");
        }
        
    }
}
