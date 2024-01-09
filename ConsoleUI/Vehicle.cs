using System;
namespace ConsoleUI
{
	public abstract class Vehicle
	{
		public Vehicle()
		{
		}

        public string Year { get; set; } = "2023";
        public string Make { get; set; } = "BMW";
        public string Model { get; set; } = "X5";

        public abstract void DriveAbstract();

        public virtual void DriveVirtual()
		{
			Console.WriteLine($"Vroom! The {GetType().Name} drives off.");
		}
	}
}
