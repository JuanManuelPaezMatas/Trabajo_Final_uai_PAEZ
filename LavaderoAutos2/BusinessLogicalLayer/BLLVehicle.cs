using LavaderoAutos2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LavaderoAutos2.BusinessLogicalLayer
{
    public class BLLVehicle
    {
        public bool verifyObject(Vehicle vehicle)
        {
			try
			{
				if (vehicle == null)
				{
					return false;
				}
				if ( vehicle.Year > 2026 || vehicle.Year <1886)
				{

					return false;
				}

				return true;
			}
			catch (Exception)
			{

				throw;
			}

        }
    }
}
