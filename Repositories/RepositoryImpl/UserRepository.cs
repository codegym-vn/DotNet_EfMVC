using ProductManagement.Entities; 

namespace ProductManagement.Repositories.RepositoryImpl
{
    public class UserRepository : GeneralRepositoryImpl<User, DataContext>, IUserRepository
    {
        public UserRepository(DataContext context) : base(context)
        {

        }
    }
}