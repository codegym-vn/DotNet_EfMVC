using ProductManagement.Entities; 
using ProductManagement.Repositories; 

namespace ProductManagement.Services.CategoryService
{
    public class CategoryService : GeneralServiceImpl<Category, ICategoryRepository>, ICategoryService
    {
        public CategoryService(ICategoryRepository repository) : base(repository)
        {

        }
    }
}
