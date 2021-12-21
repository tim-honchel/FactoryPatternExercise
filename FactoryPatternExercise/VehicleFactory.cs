using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise
{
    public static class VehicleFactory
    {
        public static IVehicle GetVehicle(string tires)
        {
            switch (tires)
            {
                case "1":
                case "one":
                    return new Unicycle();
                case "2":
                case "two":
                    return new Motorcycle();
                case "3":
                case "three":
                    return new Tricycle();
                case "4":
                case "four":
                    return new Car();
                default:
                    return new UFO();


            }

        }
    }
}
