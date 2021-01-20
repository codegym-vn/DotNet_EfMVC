using ProductManagement.Entities;
using ProductManagement.Repositories;

namespace ProductManagement.Services.ProductService
{
    public class ProductService : GeneralServiceImpl<Product, IProductRepository>, IProductService
    {
        public ProductService(IProductRepository repository) : base(repository)
        {

        }
    }
}
