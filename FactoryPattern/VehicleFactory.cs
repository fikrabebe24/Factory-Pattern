using System;
namespace FactoryPattern
{
	public class VehicleFactory
	{
        public static IVehicle GetVehicle(int tires)
        {


            if (tires == 2)
            {
                Console.WriteLine("Motorcycle");
                return new Motorcycle();
               
            }
            if (tires == 16)
            {
                Console.WriteLine("Truck");
                return new Truck();
            }
            else 
            {
                Console.WriteLine("Car");
                return new Car();
            }
        }

    }
}

