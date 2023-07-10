using AutoMapper;
using CleanArchMvc.Application.DTOs;
using CleanArchMvc.Application.Interfaces;
using CleanArchMvc.Domain.Entities;
using CleanArchMvc.Domain.Interfaces;

namespace CleanArchMvc.Application.Services;

public class CategoryService : ICategoryService
{
    private readonly ICategoryRepository _categoryService;
    private readonly IMapper _mapper;
    public CategoryService(ICategoryRepository categoryService, IMapper mapper)
    {
        _mapper = mapper;
        _categoryService = categoryService;
    }
    public async Task CreateCategorieDTOAsync(CategoryDTO categoryDTO)
    {
        var categoryEntity = _mapper.Map<Category>(categoryDTO);
        await _categoryService.CreateCategorytAsync(categoryEntity);
    }

    public async Task<CategoryDTO> GetCategorieDTOByIdAsync(int? id)
    {
        var categoryEntity = await _categoryService.GetByCategoryIdAsync(id);
        return _mapper.Map<CategoryDTO>(categoryEntity);
    }

    public async Task<IEnumerable<CategoryDTO>> GetCategoriesDTOAsync()
    {
        var categoriesEntity = await _categoryService.GetCategoriesAsync();
        return _mapper.Map<IEnumerable<CategoryDTO>>(categoriesEntity);
    }

    public async Task UpdateCategorieDTOAsync(CategoryDTO categoryDTO)
    {
        var categoryEntity = _mapper.Map<Category>(categoryDTO);
        await _categoryService.UpdateCategoryAsync(categoryEntity);
    }

    public async Task RomoveCategorieDTOAsync(int? id)
    {
        var categoryEntity = _categoryService.GetByCategoryIdAsync(id).Result;
        await _categoryService.RemoveCategoryAsync(categoryEntity);
    }
}
