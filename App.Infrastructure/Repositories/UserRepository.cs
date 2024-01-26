using App.Application.Contracts;
using App.Context;
using App.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Infrastructure.Repositories
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        StoreContext context;

        public UserRepository(StoreContext storeContext) : base(storeContext) { }
           
        public User Addusers(User entity)
        {
            var addedUser = context.Users.Add(entity).Entity;
            return addedUser;
        }

    }
}
