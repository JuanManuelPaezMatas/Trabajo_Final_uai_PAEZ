using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LavaderoAutos2.Entities
{
    internal class Service : IServiceBase, IEntity
    {
        public string Name {  get; set; }
        public double Price { get; set; }

        public double DisplayPrice()
        {
            return this.Price;
        }
    }
}
