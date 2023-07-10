using Azure.Core;
using CleanArchMvc.Domain.Entities;
using CleanArchMvc.Domain.Interfaces;
using CleanArchMvc.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace CleanArchMvc.Infra.Data.Repositories;

public class ProductRepository : IProductRepository { 
    private readonly ApplicationDBContext _ProductRepository;
    public ProductRepository(ApplicationDBContext Context)
    {
        _ProductRepository = Context;
    }

    public async Task<Product> CreateProductAsync(Product product)
    {
        _ProductRepository.Add(product);
        await _ProductRepository.SaveChangesAsync();
        return product;
    }

    public async Task<Product> GetByProductIdAsync(int? id)
    {
        return await _ProductRepository.Products.FindAsync(id);
    }

    public Task<Product> GetProductCategoryAsync(int? id)
    {
       return _ProductRepository.Products.Include(c => c.Category)
            .SingleOrDefaultAsync(p => p.Id == id);
    }

    public async Task<IEnumerable<Product>> GetProductsAsync()
    {
        return await _ProductRepository.Products.ToListAsync();
    }

    public async Task<Product> RemoveProductAsync(Product product)
    {
        _ProductRepository.Remove(product);
        await _ProductRepository.SaveChangesAsync();
        return product;
    }

    public async Task<Product> UpdateProductAsync(Product product)
    {
        _ProductRepository.Update(product);
        await _ProductRepository.SaveChangesAsync();
        return product;
    }

}
