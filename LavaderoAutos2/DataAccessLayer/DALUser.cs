using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LavaderoAutos2.Entities;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
namespace LavaderoAutos2.DataAccessLayer
{
    public class DALUser:BaseDataAccessLayer
    {
        private static  DALUser dalUser;
        public static DALUser Instance { get 
            { 
                if (dalUser == null)
                    dalUser = new DALUser();
                return dalUser; 
            } }
        private DALUser()
        {

        }
       
        /// <summary>
        /// Devuelve todoslos usuarios de la base de datos. Permite obtener un unico usuario.
        /// </summary>
        /// <param name="user">opcional.pasarlo cuando se quiera obtener un unico usuario</param>
        /// <returns>Devuelve una lista de usuarios.Una lista de objetos usuarios.si se paso el parametro user devolvera solo ese usuario.</returns>
        public List<User> getUsers(string user=null)
        {
            try
            {
                //this.ConnectionString = "server=DESKTOP-DJBOD43\\SQLEXPRESS07;database=lavadero_autos;integrated security=SSPI";
                
                this._connection = new SqlConnection(this.ConnectionString);
                this._command = new SqlCommand();
                this._command.CommandText = "Select * from users";
                if (user != null)
                {
                    this._command.CommandText += " where user_code = @usuario";
                    SqlParameter miSqlParametro=this._command.CreateParameter();
                    miSqlParametro.ParameterName = "@usuario";
                    miSqlParametro.Value = user;

                    this._command.Parameters.Add(miSqlParametro);
                }
                this._command.Connection = this._connection;

                if (this._connection.State != System.Data.ConnectionState.Open)
                {
                    this._connection.Open();

                }
                SqlDataReader dr = this._command.ExecuteReader();
                List<User> lstUser = new List<User>();
                while (dr.Read())
                {
                    
                    User u = new User();  // instanciacion de variable.Reserva espacio en memoria.
                    // Asignamos valores de la base de datos a los modelos de los entities de mi programa
                    u.Name = dr.GetString(1);      
                    u.UserCode= dr.GetString(2);
                    u.Password= dr.GetString(3);
                    u.Id= dr.GetInt32(0);
                    // sin la linea 64, todo lo que lei y capture en los pasos anteriores lo perdere.
                    lstUser.Add(u);
                    
                }
                return lstUser;
                    

            }
            catch
            {
                throw;

            }
        }

        public DataTable getUserTable()
        {
            try
            {
                DataTable dt;
                dt = this.getTable("select * from users");
                return dt;
                           


            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool validate(string user,string password)
        {
            try
            {
                _connection = new SqlConnection(ConnectionString);
                this._command = new SqlCommand();
                this._command.Connection= this._connection;
                int total;
                _command.CommandText = "select count(*) from users where user_code='"+user+"' and password='"+password+"'";
                this._connection.Open();
                total=(int)_command.ExecuteScalar();
                this._connection.Close();
                return total > 0;
            }
            catch (Exception)
            {

                throw;
            }


        }

        public override int insert(IEntity entity)
        {
            string textoConsulta;
            int usuariosInsertados;
            User user_usuario;
            try
            {
                user_usuario = (User)entity;
                textoConsulta = "INSERT INTO users(name,user_code,password) ";
                textoConsulta += "VALUES (";
                //textoConsulta += "NULL,";
                textoConsulta += "'" + user_usuario.Name + "',";
                textoConsulta += "'" + user_usuario.UserCode + "',";
                textoConsulta += "'" + user_usuario.Password + "')";
                usuariosInsertados = this.ExecuteNonQuery(textoConsulta);
                return usuariosInsertados;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public override int update(IEntity entity)
        {
            throw new NotImplementedException();
        }

        public override int delete(IEntity entity)
        {
            throw new NotImplementedException();
        }

        public override List<IEntity> getEntities(IEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
