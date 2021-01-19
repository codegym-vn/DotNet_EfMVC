using ProductManagement.Entities;
using ProductManagement.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductManagement.Services.UserService
{
    public class UserService : GeneralServiceImpl<User, IUserRepository>, IUserService
    {
        public UserService(IUserRepository repository) : base(repository)
        {

        }
    }
}
