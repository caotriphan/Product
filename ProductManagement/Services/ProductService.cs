using ProductManagement.Entities;
using ProductManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagement.Services
{
    interface IProductService
    {
        Task<List<ProductModel>> GetProductsAsync();
        Task<ProductModel> GetProductAsync(int id);
        Task<ProductModel> AddProductAsync();
        Task UpdateProductAsync(ProductModel product);
        Task DeleteProductAsync(int id);
    }

    public class ProductService : IProductService
    {
        private ApplicationDbContext db = new();

        public Task<ProductModel> AddProductAsync()
        {
            throw new NotImplementedException();
        }

        public Task DeleteProductAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ProductModel> GetProductAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<ProductModel>> GetProductsAsync()
        {
            throw new NotImplementedException();
        }

        public Task UpdateProductAsync(ProductModel product)
        {
            throw new NotImplementedException();
        }
    }
}
