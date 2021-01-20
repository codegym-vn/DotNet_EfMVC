using ProductManagement.Entities;
using ProductManagement.Services.ProductService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductManagement.Repositories.RepositoryImpl
{
    public class ProductRepositoryImpl : GeneralRepositoryImpl<Product, DataContext>, IProductRepository
    {
        public ProductRepositoryImpl(DataContext context) : base(context)
        {

        }
    }
}
