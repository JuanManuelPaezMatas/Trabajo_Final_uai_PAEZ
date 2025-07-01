using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LavaderoAutos2.Entities
{
    public enum VehicleType
    {
        Car,Truck,Bike,Motorcycle

    }
    public class Vehicle:IEntity
    {
        public int Id { get; set; }
        public string Name {  get; set; }
        public string Brand { get; set; }
        public int Year { get; set; }
        public VehicleType VehicleType { get; set; }

        public string toString()
        {
            return Name+" "+Brand;
        }

    }
}
