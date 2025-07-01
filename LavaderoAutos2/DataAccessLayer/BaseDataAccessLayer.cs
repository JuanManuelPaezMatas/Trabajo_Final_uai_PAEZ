using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Security.Cryptography.X509Certificates;
using LavaderoAutos2.Entities;
namespace LavaderoAutos2.DataAccessLayer

{
    public abstract class BaseDataAccessLayer
    {
        public string ConnectionString { get; set; }
        protected SqlConnection _connection;
        protected SqlCommand _command;

        public BaseDataAccessLayer() {
            this.ConnectionString = Properties.Settings.Default.ConnectionString;
        }
        public void TryConnection() {
            //this.ConnectionString =  "server=DESKTOP-DJBOD43\\SQLEXPRESS07;database=lavadero_autos;integrated security=SSPI";
            this._connection= new SqlConnection(this.ConnectionString);
            this._connection.Open();
        }
        protected int ExecuteNonQuery(string query) {
            try
            {
                this.ConnectionString = "server=DESKTOP-DJBOD43\\SQLEXPRESS07;database=lavadero_autos;integrated security=SSPI";
                this._connection = new SqlConnection(this.ConnectionString);
                this._command = new SqlCommand();
                this._command.CommandText = query;
                this._command.Connection = this._connection;
                int totalFilasAfectadas;  // variable para guardar el resultado de la ejecucion
                this._connection.Open() ;
                totalFilasAfectadas = this._command.ExecuteNonQuery();
                return totalFilasAfectadas;
            }
            catch (Exception)
            {

                throw;
            }
             }

        protected DataTable getTable(string query)
        {
            try
            {
                _connection = new SqlConnection(ConnectionString);
                _command = new SqlCommand();
               // _command= _connection.CreateCommand(); Esta es otra alternativa
               _command.Connection = this._connection;
                _command.CommandText = query;
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = _command;
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                return ds.Tables[0];
            }
            catch (Exception)
            {

                throw;
            }

                        
        }

        public abstract int insert(IEntity entity);
        public abstract int update(IEntity entity);
        public abstract int delete(int id);

        public abstract  List<IEntity> getEntities(IEntity entity);


    }
}
