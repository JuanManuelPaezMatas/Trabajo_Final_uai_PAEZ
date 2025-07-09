using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LavaderoAutos2.Services
{
    public class WashingServiceCombo : IWashingService
    { 

        private List<IWashingService> _items;
        public double Precio { get{
                double total=0;
                foreach(IWashingService service in _items)
                {
                    total+= service.Precio;
                }
                return total;
            }  }
        public string Detalles { get {
            
                string total="";
                foreach(IWashingService service in _items)
                {
                    total +=" / "+ service.Detalles;
                }
                return total;
            
            }  
        }

        public WashingServiceCombo()
        {
            this._items = new List<IWashingService>();


        }
        public void addWashingService(IWashingService washingService)
        {
            _items.Add(washingService);


        }
    }
}
