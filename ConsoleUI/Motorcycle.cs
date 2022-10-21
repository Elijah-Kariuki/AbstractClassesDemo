using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    public class Motorcycle : Vehicle
    {
        public override void DriveAbstract()
        {
            Console.WriteLine($"The {GetType().Name} is leaning gracefully into and out of the turns");
        }
        public bool HasSideCart { get; set; } = false;
        public override void DriveVirtual()
        {
            Console.WriteLine($"The {GetType().Name} is a top of the line bike and is cruising down the road!");
        }
    }
}
