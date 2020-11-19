using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    interface ICar
    {
        double Sped { get; set; }
        string Name { get; set; }

        string ToString(); 
    }
}
