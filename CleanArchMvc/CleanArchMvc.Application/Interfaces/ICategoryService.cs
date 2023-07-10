using CleanArchMvc.Application.DTOs;

namespace CleanArchMvc.Application.Interfaces;

public interface ICategoryService
{
    Task<IEnumerable<CategoryDTO>> GetCategoriesDTOAsync();
    Task<CategoryDTO> GetCategorieDTOByIdAsync(int? id);
    Task CreateCategorieDTOAsync(CategoryDTO categoryDTO);
    Task UpdateCategorieDTOAsync(CategoryDTO categoryDTO);
    Task RomoveCategorieDTOAsync(int? id);

}
