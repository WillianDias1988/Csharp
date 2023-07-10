using CleanArchMvc.Domain.Entities;

namespace CleanArchMvc.Domain.Interfaces;

public interface ICategoryRepository
{
    Task<IEnumerable<Category>> GetCategoriesAsync();
    Task<Category> GetByCategoryIdAsync(int? id);
    Task<Category> CreateCategorytAsync(Category category);
    Task<Category> UpdateCategoryAsync(Category category);
    Task<Category> RemoveCategoryAsync(Category category);
}
