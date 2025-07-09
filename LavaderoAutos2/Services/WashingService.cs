using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LavaderoAutos2.Services
{
    public class WashingService : IWashingService
    {
        public double Precio { get ; set ; }
        public string Detalles { get ; set; }

        public WashingService(double precio, string detalles) {
        
        this.Detalles=detalles ;
        this.Precio = precio ;  
        
        }
    }
}
