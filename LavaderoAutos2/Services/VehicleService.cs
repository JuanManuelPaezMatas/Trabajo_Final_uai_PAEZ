using LavaderoAutos2.BusinessLogicalLayer;
using LavaderoAutos2.DataAccessLayer;
using LavaderoAutos2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LavaderoAutos2.Services
{
    public class VehicleService
    {
		
        public void createVecicle(Vehicle vehicle)
        {
			try
			{
				BLLVehicle bllVehicle = new BLLVehicle();

				if (!bllVehicle.verifyObject(vehicle))
				{
					throw new Exception("error en el vehiculo");

				}
				DALVehicle.Instance.insert(vehicle);

			}
			catch (Exception)
			{

				throw;
			}

        }

    }
}
