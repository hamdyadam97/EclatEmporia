using App.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Application.Contracts
{
    public interface IUserRepository:IRepository<User>
    {
        
    }
}
