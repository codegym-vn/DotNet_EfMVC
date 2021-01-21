using ProductManagement.Entities; 

namespace ProductManagement.Repositories
{
    public interface IUserRepository : IGeneralRepository<User>
    {
        User Login(string username,string password);
    }
}
