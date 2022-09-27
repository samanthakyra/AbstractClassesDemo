using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleUI
{
    class Car : Vehicle
    {
        public int NumberOfWindows { get; set; }

        public override void DriveAbstract()
        {
            Console.WriteLine("I drive a {GetType().Name} in an abstract method. It is a {GetType().BaseType.Name}");
        }
        public override void DriveVirtual()
        {
            Console.WriteLine("I drive a {GetType().Name} in a virtual method. It is {GetType().BaseType.Name}");
        }
    }
}

