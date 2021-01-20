using ProductManagement.Entities;
using ProductManagement.Repositories; 

namespace ProductManagement.Services.ServiceImpl
{
    public class UserService : GeneralServiceImpl<User, IUserRepository>, IUserService
    {
        public UserService(IUserRepository repository) : base(repository)
        {

        }
    }
}
