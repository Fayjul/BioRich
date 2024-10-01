using Core.Entities;
using Core.Interfaces;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly StoreContext _contex;
        public ProductRepository(StoreContext context)
        {
            _contex = context;
        }
        public async Task<Product> GetProductByIdAsync(int id)
        {
            var product = await _contex.Products.FindAsync(id);
            return product;
        }

        public async Task<IReadOnlyList<Product>> GetProductsAsync()
        {
            var products = await _contex.Products.ToListAsync();
            return products;
        }
    }
}