using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LavaderoAutos2.Entities
{
    public class User:IEntity
    {   
        public User() {
            this.Name = string.Empty;
            this.Id = 0;
            this.UserCode = string.Empty;
            this.Password = string.Empty;

        }
        public User(string name,string usercode,string password)
        {
            this.Name = name;
            this.Id = 0;
            this.UserCode = usercode;
            this.Password = password;

        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string UserCode { get; set; }

        public string Password { get; set; }

        public string toString()
        {
            return "Nombre: " + this.Name; 

        }
        
    }
}
