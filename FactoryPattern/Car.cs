using System;
namespace FactoryPattern
{
	public class Car: IVehicle
	{
		public Car()
		{
		}

        public string Make { get; set; }
        public string Model { get; set; }

        public void Drive()
        {
      
        }
    }
}

