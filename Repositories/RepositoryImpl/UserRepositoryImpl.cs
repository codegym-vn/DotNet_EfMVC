using ProductManagement.Entities; 

namespace ProductManagement.Repositories.RepositoryImpl
{
    public class UserRepositoryImpl : GeneralRepositoryImpl<User, DataContext>, IUserRepository
    {
        public UserRepositoryImpl(DataContext context) : base(context)
        { 
        }
    }
}