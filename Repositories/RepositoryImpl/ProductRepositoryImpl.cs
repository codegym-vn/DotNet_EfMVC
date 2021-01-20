using ProductManagement.Entities; 

namespace ProductManagement.Repositories.RepositoryImpl
{
    public class ProductRepositoryImpl : GeneralRepositoryImpl<Product, DataContext>, IProductRepository
    {
        public ProductRepositoryImpl(DataContext context) : base(context)
        {

        }
    }
}
