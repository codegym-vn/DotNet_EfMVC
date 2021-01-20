using ProductManagement.Entities;
using ProductManagement.Services.UserService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductManagement.Repositories.RepositoryImpl
{
    public class UserRepositoryImpl : GeneralRepositoryImpl<User, DataContext>, IUserRepository
    {
        public UserRepositoryImpl(DataContext context) : base(context)
        { 
        }
    }
}