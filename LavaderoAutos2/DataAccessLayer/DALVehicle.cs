using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LavaderoAutos2.Entities;
using System.Data.SqlClient;
using System.Data;
using System.Runtime.InteropServices;
using LavaderoAutos2.BusinessLogicalLayer;


namespace LavaderoAutos2.DataAccessLayer
{
    public class DALVehicle : BaseDataAccessLayer
    {
        //copiar el singleton  de daluser
        private static DALVehicle dalVehicle;
        //Esto es commit 5
        public static DALVehicle Instance
        {
            get
            {
                if (dalVehicle == null)
                    dalVehicle = new DALVehicle();
                return dalVehicle;
            }
        }


        public override int delete(int id)
        {
            string textoConsulta;
            int registrosInsertados;
            
            try
            {
                
                textoConsulta = "DELETE vehicles WHERE  ";
                textoConsulta += " id=@id";
                //textoConsulta += "NULL,";
                             
                this._command.Parameters.Add(new SqlParameter("@id" , id));
               
                registrosInsertados = this.ExecuteNonQuery(textoConsulta);
                return registrosInsertados;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public override List<IEntity> getEntities(IEntity entity)
        {
            throw new NotImplementedException();
        }

        public override int insert(IEntity entity)
        {
            string textoConsulta;
            int registrosInsertados;
            Vehicle obj;
            try
            {
                obj = (Vehicle)entity;
                textoConsulta = "INSERT INTO vehicles(name,brand,year,vehicle_type) ";
                textoConsulta += "VALUES (";
                //textoConsulta += "NULL,";
                textoConsulta += "'" + obj.Name + "',";
                textoConsulta += "'" + obj.Brand + "',";
                textoConsulta += "'" + obj.Year + "',";
                textoConsulta += "'" + (int)obj.VehicleType + "')";
                registrosInsertados = this.ExecuteNonQuery(textoConsulta);
                return registrosInsertados;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public override int update(IEntity entity)
        {
            string textoConsulta;
            int registrosInsertados;
            Vehicle obj;
            try
            {
                obj = (Vehicle)entity;
                textoConsulta = "UPDATE  vehicles";
                textoConsulta+="set name=@name,";
                textoConsulta += "brand=@brand,";
                textoConsulta += "year=@year";
                textoConsulta += "vehicleType=@vehicleType";
                this._command.Parameters.Add(new SqlParameter("@name", obj.Name));
                this._command.Parameters.Add(new SqlParameter("@brand", obj.Brand));
                this._command.Parameters.Add(new SqlParameter("@year", obj.Year));
                this._command.Parameters.Add(new SqlParameter("@vehicletype", (int)obj.VehicleType));
                registrosInsertados = this.ExecuteNonQuery(textoConsulta);

                return registrosInsertados;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
