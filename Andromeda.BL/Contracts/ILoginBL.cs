using Andromeda.Core.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Andromeda.BL.Contracts
{
    public interface ILoginBL
    {
        bool Login(LoginDTO loginDTO);
    }
}
