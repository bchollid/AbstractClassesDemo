using System;
namespace ConsoleUI
{
	public class Car : Vehicle
	{
		public Car()
		{
		}

		public override void DriveAbstract()
		{
			Console.WriteLine($"The car goes Vrooom!");
		}

		public bool hasTrunk = true;
	}
}

