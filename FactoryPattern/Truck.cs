using System;
namespace FactoryPattern
{
	public class Truck : IVehicle
	{
		public Truck()
		{
		}

        public string Make { get; set; }
        public string Model { get; set; }

        public void Drive()
        {
            Console.WriteLine("The Truck drives on 16 wheels!");

            
        }
    }
}

