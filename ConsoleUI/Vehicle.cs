using System;
namespace ConsoleUI
{
    public abstract class Vehicle
    {
        /*
             * Create an abstract class called Vehicle - DONE
             * The vehicle class shall have three string properties Year, Make, and Model - DONE
             * Set the defaults to something generic in the Vehicle class - DONE
             * Vehicle shall have an abstract method called DriveAbstract with no implementation - DONE
             * Vehicle shall have a virtual method called DriveVirtual with a base implementation. - DONE
             */

        public Vehicle()
        {
            
        }

        public int Year { get; set; } = 2000;
        public string Make { get; set; } = "Default make";
        public string Model { get; set; } = "Default model";

        public abstract void DriveAbstract();

        public virtual void DriveVirtual()
        {
            Console.WriteLine($"Driving along in a {Make} {Model}");
        }
    }
}
