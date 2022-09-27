using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleUI
{
        abstract class Vehicle
        {
            public int NumberOfTires { get; set; } = 1;
            public string Make { get; set; } = "Generic Manufacturer";
            public string Model { get; set; } = "Generic Model";
            public string Year { get; set; } = "No year";

        public abstract void DriveAbstract();

        public virtual void DriveVirtual()
        {
            Console.WriteLine("I am driving my car");

        }
    }
}