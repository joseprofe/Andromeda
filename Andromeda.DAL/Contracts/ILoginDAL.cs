using Andromeda.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Andromeda.DAL.Contracts
{
    public interface ILoginDAL
    {
        bool Login(Usuario usuario);
    }
}
