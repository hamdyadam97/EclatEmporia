using App.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Application.Services
{
    public interface IUserService
    {
        public User AddUser(string userName, string email, string password, string confirmPassword, string phoneNumber, string selectedRole);
        public void Add (User user);
        public IEnumerable<User> GetUsers();
        void UpdateUser(User user);
        public User GetUser(int id);

    }
    
}
