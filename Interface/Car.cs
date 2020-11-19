using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class Car:ICar
    {
        public double Sped { get; set; }
        public string Name { get; set; }

        public new string ToString()
        {
            return $"Имя {Name}, скорость {Sped}";
        }
    }
}
