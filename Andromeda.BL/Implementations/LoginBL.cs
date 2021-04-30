using Andromeda.BL.Contracts;
using Andromeda.Core.DTO;
using Andromeda.DAL.Contracts;
using Andromeda.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Andromeda.BL.Implementations
{
    public class LoginBL : ILoginBL
    {
        public ILoginDAL loginDAL { get; set; }

        public LoginBL(ILoginDAL loginDAL) 
        {
            this.loginDAL = loginDAL;
        }
        public bool Login(LoginDTO loginDTO)
        {
            var usuario = new Usuario
            {
                Username = loginDTO.Username,
                Password = loginDTO.Password
            };

            return loginDAL.Login(usuario);
        }
    }
}
