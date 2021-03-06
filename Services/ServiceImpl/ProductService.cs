﻿using ProductManagement.Entities;
using ProductManagement.Repositories;
using ProductManagement.Services.Impl;

namespace ProductManagement.Services.ServiceImpl
{
    public class ProductService : GeneralServiceImpl<Product, IProductRepository>, IProductService
    {
        public ProductService(IProductRepository repository) : base(repository)
        {

        }
    }
}
