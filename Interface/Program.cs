using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car()
            {
                Name = "Tesla",
                Sped = 90
            };

            Console.WriteLine(car.ToString());

            Plane plane = new Plane()
            {
                Name = "Boeing 737",
                FlightAltitude = 9800,
                passengerCapacity = 110
            };

            Console.WriteLine(plane.ToString());

            Bicycle bicycle = new Bicycle()
            {
                Name = "БМХ",
                Sped = 30,
                Color = "Красный"
            };

            Console.WriteLine(bicycle.ToString());
        }
    }
}
