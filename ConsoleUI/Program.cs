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
             *Done-Create an abstract class called Vehicle
             *Done- The vehicle class shall have one int property: Year, and two string properties: Make, and Model
             *Done- Set the defaults to something generic in the Vehicle class
             *Done- Vehicle shall have an abstract method called DriveAbstract with no implementation
             *Done- Vehicle shall have a virtual method called DriveVirtual with a base implementation.
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
             * - set them up as one of each derived class
             * Set the properties with object initializer syntax
             */
            var superCar = new Car() { HasTrunk = false, Make = "Porsche", Model = "911 GT3 RS", Year = 2023 };
            vehicles.Add(superCar);

            var superBike = new Motorcycle() {HasSideCart = false, Make =  "BMW", Model = "S1000RR", Year = 2022};
            vehicles.Add(superBike);

            Vehicle sedan = new Car() { HasTrunk = true, Make = "Honda", Model = "Accord", Year = 2019 };
            vehicles.Add(sedan);

            Vehicle cruiser = new Motorcycle() { HasSideCart = true, Make = "Indian", Model = "RoadMaster/Dark Horse/Elite", Year = 2020 };
            vehicles.Add(cruiser);
            /*
             * Add the 4 vehicles to the list
             * Using a foreach loop iterate over each of the properties
             */
            foreach(var vehicle in vehicles)
            {
                Console.WriteLine("-----------------------");
                Console.WriteLine($"Make {vehicle.Make} Model {vehicle.Model} Year {vehicle.Year}");
                
                vehicle.DriveAbstract();
               
                vehicle.DriveVirtual();

            }

            // Call each of the drive methods for one car and one motorcycle

            #endregion            
            Console.ReadLine();
        }
    }
}
