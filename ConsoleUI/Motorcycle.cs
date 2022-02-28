using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    public class Motorcycle : Vehicle
    {
        public Motorcycle()
        {
            // default constructor
        }

        public bool HasSideCart { get; set; }
     
        public override void DriveAbstract()
        {
            Console.WriteLine("This is a motorcycle");
        }
        public override void DriveVirtual()
        {
            Console.WriteLine("I AM OVER RIDEN");
        }
    }
}
