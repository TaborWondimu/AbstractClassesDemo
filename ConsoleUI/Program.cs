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

            /* 
             * Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle
             * Add a distict property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
             * Provide the implementations for the abstract methods
             * Only in the Motorcycle class will you override the virtual drive method
            */

            // Create a list of Vehicle called vehicles

            var vehicles = new List<Vehicle>();

            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             * - new it up as one of each derived class
             * Set the properties with object initializer syntax
             */
            Car car = new Car()
            {
                Make = "Honda",
                Year = "2020",
                Model = "Accord",
                HasTrunk = true,
                
            };
            
            Motorcycle motor = new Motorcycle()
            {
                Make = "ScoutBike",
                Year = "1456",
                Model = "Yamio",
                HasSideCart = true
            };
            Vehicle vehicle = new Car()
            {
                Make = "Honda",
                Year = "1989",
                Model = "Pilot",
            };
            Vehicle vehicle1 = new Motorcycle()
            {
                Make = "Totota",
                Model = "Matrix",
                Year = "2021",
                HasSideCart = true,
            };


            /*
             * Add the 4 vehicles to the list
             * Using a foreach loop iterate over each of the properties
             */
            vehicles.Add(car);
            vehicles.Add(motor);
            vehicles.Add(vehicle);
            vehicles.Add(vehicle1);

            foreach(var items in vehicles)
            {
                Console.WriteLine($"Make {items.Make},Model {items.Model}, Year {items.Year},");
                Console.WriteLine($"====================================================");
                
            }


            // Call each of the drive methods for one car and one motorcycle
            car.DriveVirtual();
            car.DriveAbstract();
            motor.DriveVirtual();
            motor.DriveAbstract();
            #endregion            
            Console.ReadLine();
        }
    }
}
