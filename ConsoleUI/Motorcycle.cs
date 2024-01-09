using System;
namespace ConsoleUI
{
	public class Motorcycle : Vehicle
	{
		public Motorcycle()
		{
		}

        public override void DriveAbstract()
        {
            Console.WriteLine($"The motorcycle goes Vrooom!");
        }

        public override void DriveVirtual()
        {
            Console.WriteLine($"The {GetType().Name} drives off!");
        }

        public bool hasSideCar = true;
	}
}

