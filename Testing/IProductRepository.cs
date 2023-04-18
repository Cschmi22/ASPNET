using Microsoft.AspNetCore.Cors.Infrastructure;
using System.Collections;
using Testing.Models;
using System;
using System.Collections.Generic;

namespace Testing
{
    public interface IProductRepository
    {
        public IEnumerable<Product> GetAllProducts();
        public Product GetProduct(int id);
    }
}
