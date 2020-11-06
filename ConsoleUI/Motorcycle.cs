using System;
namespace ConsoleUI
{
    public class Motorcycle : Vehicle
    {
        /* 
             * Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle
             * Add a distict property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
             * Provide the implementations for the abstract methods
             * Only in the Motorcycle class will you override the virtual drive method
            */

        public Motorcycle()
        {
        }

        public bool HasSideCar { get; set; } = false;

        public override void DriveAbstract()
        {
            Console.WriteLine("In gear.");
        }

        public override void DriveVirtual()
        {
            Console.WriteLine($"Biking with a {Make} {Model} in a virtual way");
        }
    }
}
