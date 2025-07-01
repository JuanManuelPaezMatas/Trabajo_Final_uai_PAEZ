using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LavaderoAutos2.Entities
{
    internal interface IServiceBase
    {
         string Name { get; set; }

        double DisplayPrice();
        

    }
}
