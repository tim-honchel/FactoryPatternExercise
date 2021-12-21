using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise
{
    public class UFO : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine();
            Console.WriteLine("Building a new UFO!");
        }
    }
}
