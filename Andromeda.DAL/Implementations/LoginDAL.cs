using Andromeda.DAL.Contracts;
using Andromeda.DAL.Entities;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Andromeda.DAL.Implementations
{
    public class LoginDAL : ILoginDAL
    {
        public ConcesionarioContext context { get; set; }
        public LoginDAL(ConcesionarioContext context)
        {
            this.context = context;
        }
        public bool Login(Usuario usuario)
        {
            MySqlConnection conn = context.GetConnection();
            
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(String.Format("select * from usuarios " +
                                                "where username = '{0}' and" +
                                                " password = '{1}'", usuario.Username, usuario.Password), conn);

            var reader = cmd.ExecuteReader();                
            while (reader.Read())
            {
                return true;
            }        
            
            return false;
        }
    }
}
