using System;

namespace FactoryPatternExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many tires will your vehicle have?");
            Console.WriteLine();
            string tires = Console.ReadLine();
            IVehicle vehicle = VehicleFactory.GetVehicle(tires);
            vehicle.Drive();
        }
    }
}
