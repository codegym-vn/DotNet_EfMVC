using ProductManagement.Entities;
using ProductManagement.Repositories;
using ProductManagement.Services.Impl;

namespace ProductManagement.Services.ServiceImpl
{
    public class UserService : GeneralServiceImpl<User, IUserRepository>, IUserService
    {
        IUserRepository _repository;
        public UserService(IUserRepository repository) : base(repository)
        {
            _repository = repository;
        }
        public User Login(string username, string password)
        {
            var user = _repository.Login(username,password);
            return user;
        }
    }
}
