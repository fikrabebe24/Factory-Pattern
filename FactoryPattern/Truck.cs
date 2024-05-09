using System;
namespace FactoryPattern
{
	public class Truck : IVehicle
	{
		public Truck()
		{
		}

        public string Make { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Model { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Drive()
        {
            Console.WriteLine("The Truck drives on 16 wheels!");

            
        }
    }
}

