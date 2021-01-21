using ProductManagement.Entities; 
namespace ProductManagement.Services
{
    public interface IUserService : IGeneralService<User>
    {
        User Login(string username, string password);
    }
}
