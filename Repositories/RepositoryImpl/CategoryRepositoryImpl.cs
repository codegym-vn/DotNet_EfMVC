using ProductManagement.Entities;
namespace ProductManagement.Repositories.RepositoryImpl
{
    public class CategoryRepositoryImpl : GeneralRepositoryImpl<Category, DataContext>, ICategoryRepository
    {
        public CategoryRepositoryImpl(DataContext context) : base(context)
        {

        }
    }
}