using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
   public abstract class Vehicle
    {
    public  string Make { get; set; } = "Default";

    public string Year { get; set; } = "Deafult";

    public  string Model { get; set; } = "Default";

    public abstract void DriveAbstract(); // stubbed out method
      
    public virtual void DriveVirtual()
        {
            // this is a base implementatoin
            Console.WriteLine("Vehicle is VIRTUAL!!");
        }
    }
}
