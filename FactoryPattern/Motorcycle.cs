using System;
namespace FactoryPattern
{
	public class Motorcycle : IVehicle
	{
		public Motorcycle()
		{
		}

        string IVehicle.Make { get; set; }
        string IVehicle.Model { get; set; }

        void IVehicle.Drive()
        {

            Console.WriteLine("A motorcycle drives on two wheels");
        }
    }
}

