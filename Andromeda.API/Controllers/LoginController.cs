using Andromeda.BL.Contracts;
using Andromeda.Core.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Andromeda.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        public ILoginBL loginBL { get; set; }

        public LoginController(ILoginBL loginBL) 
        {
            this.loginBL = loginBL;
        }

        [HttpPost]
        public bool Login(LoginDTO loginDTO)
        {
            return loginBL.Login(loginDTO);
        }

        
    }
}
