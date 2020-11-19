using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class Plane: IPlane
    {
        public string Name{ get; set;}
        public double FlightAltitude { get; set; }
        public int passengerCapacity { get; set; }

        public override string ToString()
        {
            return $"Имя {Name}, Высота {FlightAltitude}, Вместимость самолета {passengerCapacity}";
        }
    }
}
