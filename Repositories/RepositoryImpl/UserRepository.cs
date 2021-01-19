using ProductManagement.Entities;
using ProductManagement.Services.UserService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductManagement.Repositories.RepositoryImpl
{
    public class UserRepository : GeneralRepositoryImpl<User, DataContext>, IUserService
    {
        public UserRepository(DataContext context) : base(context)
        {

        }
    }
}