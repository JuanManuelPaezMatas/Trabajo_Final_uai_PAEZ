using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LavaderoAutos2.Entities;
using LavaderoAutos2.BusinessLogicalLayer;
using LavaderoAutos2.DataAccessLayer;
namespace LavaderoAutos2.Services
{
    internal class UserService
    {
        public int createUser(User user)
        {

            DALUser dAL;
		    BLLUser bLLUser = new BLLUser();
            try
            {
                dAL = DALUser.Instance;
                string passwordHasheada;
                passwordHasheada = bLLUser.hashPassword(user.Password);
                user.Password = passwordHasheada;
                return dAL.insert(user);

            }
            catch (Exception)
            {

                throw;
            }


        }
        public User login (string user,string password)
        {
			User usuario;
			BLLUser bll;
			DALUser dal;
			List<User> users;
			try
			{
				dal = DALUser.Instance;
				users=dal.getUsers(user);
				
				if (users.Count < 1)
                {
					throw new Exception("El usuario no existe");
				}
				else
				{
					usuario=users[0];
				}
				bll= new BLLUser();

				if (!bll.checkUser(usuario, password)) {

					throw new Exception("La contraseña no existe");
				
				}
				return usuario;

			}
			catch (Exception)
			{

				throw;
			}

        }
    }
}
