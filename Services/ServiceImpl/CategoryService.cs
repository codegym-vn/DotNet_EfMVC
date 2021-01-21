using ProductManagement.Entities; 
using ProductManagement.Repositories;
using ProductManagement.Services.Impl;

namespace ProductManagement.Services.ServiceImpl
{
    public class CategoryService : GeneralServiceImpl<Category, ICategoryRepository>, ICategoryService
    {
        public CategoryService(ICategoryRepository repository) : base(repository)
        {

        }
    }
}
