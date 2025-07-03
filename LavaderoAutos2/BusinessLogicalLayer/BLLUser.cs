using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LavaderoAutos2.Entities;
using LavaderoAutos2.DataAccessLayer;
using System.Data;
using System.Security.Cryptography;
namespace LavaderoAutos2.BusinessLogicalLayer
{
    internal class BLLUser
    { 
       
        
        public string hashPassword (string password)
        {
            string passwordHasheado;
            try
            {
                byte[] arrayPassword;
                arrayPassword= Encoding.UTF8.GetBytes(password);  
                SHA256 hash = SHA256.Create();                   
                byte[] hashBytes = hash.ComputeHash(arrayPassword); 
                passwordHasheado = BitConverter.ToString(hashBytes);
                return passwordHasheado ;
            }
            catch (Exception)
            {

                throw;
            }

        }
                       

        public bool checkUser(User user,string password)
        {
            string passwordHasheado;

            try
            {
                passwordHasheado= this.hashPassword(password);

                return passwordHasheado == user.Password;
            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}
