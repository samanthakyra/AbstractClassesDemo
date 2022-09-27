﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Todo follow all comments!! 
             */

            #region Vehicles

            /*
             * Create an abstract class called Vehicle
             * The vehicle class shall have three string properties Year, Make, and Model
             * Set the defaults to something generic in the Vehicle class
             * Vehicle shall have an abstract method called DriveAbstract with no implementation
             * Vehicle shall have a virtual method called DriveVirtual with a base implementation.
             */
            // DONE

            /* 
             * Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle
             * Add a distict property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
             * Provide the implementations for the abstract methods
             * Only in the Motorcycle class will you override the virtual drive method
            */
            //DONE

            // Create a list of Vehicle called vehicles

            List<Vehicle> vehicles = new List<Vehicle>();

            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             * - set them up as one of each derived class
             * Set the properties with object initializer syntax
             */

            Vehicle car1 = new Car() { Year = "2017", Make = "Audi", Model = "A4", NumberOfTires = 4, NumberOfWindows = 5 };
            Car car2 = new Car() { Year = "2015", Make = "Toyota", Model = "Sequoia", NumberOfTires = 4, NumberOfWindows = 7 };
            Motorcycle motor1 = new Motorcycle() { Year = "2006", Make = "Kawasaki", Model = "Vulcan", EngineNoise = "Vrooom"};
            Vehicle motor2 = new Motorcycle();
            /*
             * Add the 4 vehicles to the list
             * Using a foreach loop iterate over each of the properties
             */
            vehicles.Add(car1);
            vehicles.Add(car2);
            vehicles.Add(motor1);
            vehicles.Add(motor2);

            foreach (var item in vehicles)
            {
                Console.WriteLine($"{item.Year} {item.Make} {item.Model}");
                Console.WriteLine();
            }


            // Call each of the drive methods for one car and one motorcycle
            car1.DriveAbstract();
            Console.WriteLine();

            car1.DriveVirtual();
            Console.WriteLine();

            motor1.DriveAbstract();
            Console.WriteLine();

            motor1.DriveVirtual();
            Console.WriteLine();

            #endregion
            Console.ReadLine();
        }
    }
}
